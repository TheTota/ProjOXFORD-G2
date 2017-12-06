//-----------------------------------------------------------------------
// <copyright file="IdentificationVisuel.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Loïc DELAUNAY</author>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjOXFORD_G2;
using WebEye.Controls.WinForms.WebCameraControl;

namespace ProjOXFORD_G2WinForm
{
    /// <summary> An identification visuel. </summary>
    /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
    public partial class IdentificationVisuel : MetroFramework.Forms.MetroForm
    {
        /// <summary> / Chemin vers la racine du programme. </summary>
        private string cheminRacine = Environment.CurrentDirectory;

        /// <summary> The chemin vers dossier temporary. </summary>
        private string cheminVersDossierTemp;

        /// <summary> The face identifier reconnu. </summary>
        private string faceIdReconnu = string.Empty;

        /// <summary> Liste des caméras. </summary>
        private List<WebCameraId> listCams;

        /// <summary> Initializes a new instance of the <see cref="ProjOXFORD_G2WinForm.IdentificationVisuel"/>
        /// class. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        public IdentificationVisuel()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        /// <summary> Event handler. Called by IdentificationVisuel for load events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void identificationVisuel_Load(object sender, EventArgs e)
        {
            Load_identificationVisuel.Hide();
            Txt_chargementMetro.Hide();
            Lbl_infoutilisateur.Hide();
            Img_previewUserReconnu.Hide();
            Btn_continuerToMdp.Hide();
            Btn_continuerToMdp.Enabled = false;
            //// Chemin vers le dossier temporaire de l'application.
            cheminVersDossierTemp = cheminRacine + "\\temp";
            //// Liste les caméras.
            listCams = Cam_Visuel1.GetVideoCaptureDevices().ToList<WebCameraId>();

            foreach (WebCameraId camera in listCams)
            {
                List_Camera.Items.Add(camera.Name);
            }

            List_Camera.SelectedIndex = 0;
            try
            {
                Cam_Visuel1.StartCapture(listCams[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATTENTION !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Crée le dossier temporaire s'il n'existe pas.
            if (!System.IO.Directory.Exists(cheminVersDossierTemp))
            {
                Directory.CreateDirectory(cheminVersDossierTemp);
            }

            //// Supprime le cache.
            RemoveCache();
        }

        /// <summary> Event handler. Called by List_Camera for selected index changed events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void List_Camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cam_Visuel1.StartCapture(listCams[List_Camera.SelectedIndex]);
        }

        /// <summary> Event handler. Called by Btn_RetourVisuel for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Btn_RetourVisuel_Click(object sender, EventArgs e)
        {
            Form identificationVisuel = new Identification1();
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Close();
        }

        /// <summary> Event handler. Called by Btn_VérifierVisuel for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Btn_VérifierVisuel_Click(object sender, EventArgs e)
        {
            //// Vérifie si le dossier temp existe sinon on le crée.
            string cheminVersImageTemp = cheminVersDossierTemp + "\\capture" + DateTimeOffset.Now.ToUnixTimeSeconds() + ".jpeg";
            Cam_Visuel1.GetCurrentImage().Save(cheminVersImageTemp);
            //// Appel du test de l'image.
            TestImage(cheminVersImageTemp);
        }

        /// <summary> Tests image. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="cheminVersImageTemp"> The chemin vers image temporary. </param>
        private async void TestImage(string cheminVersImageTemp)
        {
            TraitementBdd.EventInfo(1337, "Un utilisateur est en train de s'identifier visuellement");
            Load_identificationVisuel.Show();
            Txt_chargementMetro.Show();
            Btn_RetourVisuel.Enabled = false;
            Btn_VérifierVisuel.Enabled = false;
            Cam_Visuel1.StopCapture();
            //// Affichage sur le coté gauche de l'image de l'utilisateur.
            string imgPrev = System.IO.Path.Combine(Application.StartupPath, cheminVersImageTemp);
            Bitmap bmp = new Bitmap(imgPrev);
            Img_identificationVisuelPreview.Image = bmp;
            Img_previewUserReconnu.Image = bmp;
            try
            {
                JObject resultatPhotoTemporaire = await ReconnaissanceFaciale.FaceRecCreateFaceIdTempAsync(cheminVersImageTemp);
                string faceId = Convert.ToString(resultatPhotoTemporaire.GetValue("faceId"));
                JObject compareFace = await ReconnaissanceFaciale.FaceRecCompareFaceAsync(faceId);
                ////ReloadPage();
                //// Comparaison du retour.
                //// Si le visage a été reconnu.
                if (compareFace != null && Convert.ToInt32(compareFace.GetValue("confidence")) >= 0.6)
                {
                    Cam_Visuel1.Hide();
                    Img_previewUserReconnu.Show();
                    Img_identificationVisuelPreview.Hide();

                    faceIdReconnu = Convert.ToString(compareFace.GetValue("persistedFaceId"));

                    if (TraitementBdd.RecupStatus(faceIdReconnu) == 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Utilisateur révoqué !", "REVOQUE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);

                        TraitementBdd.EventErreur(TraitementBdd.RecupIdUtilisateur(faceIdReconnu), "L'utilisateur révoqué a essayé de s'identifier.");

                        Form identificationVisuel = new Identification1();
                        identificationVisuel.Location = this.Location;
                        identificationVisuel.StartPosition = FormStartPosition.Manual;
                        identificationVisuel.Show();
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Vous avez bien été reconnu !", "RECONNU", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        AffichageInfoVisage(resultatPhotoTemporaire);

                        TraitementBdd.EventSucces(TraitementBdd.RecupIdUtilisateur(faceIdReconnu), "L'utilisateur a été reconnu visuellement.");

                        Load_identificationVisuel.Hide();
                        Txt_chargementMetro.Hide();

                        Btn_continuerToMdp.Show();
                        Btn_continuerToMdp.Enabled = true;
                    }
                }
                else
                {
                    //// Si le visage n'a pas été reconnu.
                    MetroFramework.MetroMessageBox.Show(this, "Aucun utilisateur reconnu !", "NON RECONNU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                    ReconnaissanceFaciale.MailErreur(imgPrev);
                    ReloadPage();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "ERREUR : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error & MessageBoxIcon.Stop);
                ReloadPage();
            }

            return;
        }

        /// <summary> Reload page. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        private void ReloadPage()
        {
            ////Load_identificationVisuel.Hide();
            ////Txt_chargementMetro.Hide();
            ////Btn_RetourVisuel.Enabled = true;
            ////Btn_VérifierVisuel.Enabled = true;
            ////Cam_Visuel1.StartCapture(listCams[List_Camera.SelectedIndex]);
            ////Cam_Visuel1.StopCapture();
            Form identificationVisuel = new IdentificationVisuel();
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Hide();
        }

        /// <summary> Removes the cache. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        private void RemoveCache()
        {
            DirectoryInfo di = new DirectoryInfo(cheminVersDossierTemp);

            foreach (FileInfo file in di.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch (Exception)
                {
                    return;
                }
            }

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        /// <summary> Affichage information visage. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="Infos"> The infos. </param>
        private void AffichageInfoVisage(JObject Infos)
        {
            Lbl_infoutilisateur.Show();
            float smile = (int)Infos["faceAttributes"]["smile"];
            string gender = (string)Infos["faceAttributes"]["gender"];
            string age = (string)Infos["faceAttributes"]["age"];
            float moustache = (float)Infos["faceAttributes"]["facialHair"]["moustache"];
            float beard = (float)Infos["faceAttributes"]["facialHair"]["beard"];
            float sideburns = (float)Infos["faceAttributes"]["facialHair"]["sideburns"];
            string glasses = (string)Infos["faceAttributes"]["glasses"];

            Lbl_infoutilisateur.Text = "% de Sourir : " + smile * 100 + "% \n";
            Lbl_infoutilisateur.Text += "Sexe : " + gender + "\n";
            Lbl_infoutilisateur.Text += "Age : " + age + "\n";
            Lbl_infoutilisateur.Text += "% de moustache : " + moustache * 100 + "%\n";
            Lbl_infoutilisateur.Text += "% de barbe : " + beard * 100 + "%\n";
            Lbl_infoutilisateur.Text += "% de rouflaquettes : " + sideburns * 100 + "%\n";
            if (glasses == "ReadingGlasses")
            {
                Lbl_infoutilisateur.Text += "Porte des lunettes de lecture";
            }
        }

        /// <summary> Event handler. Called by Btn_continuerToMdp for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Btn_continuerToMdp_Click(object sender, EventArgs e)
        {
            Form identificationVisuel = new IdentificationMDP(faceIdReconnu);
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Close();
        }

        /// <summary> Event handler. Called by Img_previewUserReconnu for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Img_previewUserReconnu_Click(object sender, EventArgs e)
        {
        }

        /// <summary> Event handler. Called by Cam_Visuel1 for load events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Cam_Visuel1_Load(object sender, EventArgs e)
        {
        }
    }
}
