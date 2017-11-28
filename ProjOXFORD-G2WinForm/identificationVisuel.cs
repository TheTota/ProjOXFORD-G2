using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebEye.Controls.WinForms.WebCameraControl;
using ProjOXFORD_G2;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ProjOXFORD_G2WinForm
{
    public partial class identificationVisuel : MetroFramework.Forms.MetroForm
    {
        //Chemin vers la racine du programme
        string cheminRacine = Environment.CurrentDirectory;
        string cheminVersDossierTemp;
        string faceIdReconnu = "";

        //Liste des caméras
        List<WebCameraId> listCams;

        public identificationVisuel()
        {
            InitializeComponent();
        }

        private void identificationVisuel_Load(object sender, EventArgs e)
        {
            Load_identificationVisuel.Hide();
            Txt_chargementMetro.Hide();
            Lbl_infoutilisateur.Hide();
            Img_previewUserReconnu.Hide();
            Btn_continuerToMdp.Hide();
            Btn_continuerToMdp.Enabled = false;

            //Chemin vers le dossier temporaire de l'application
            cheminVersDossierTemp = cheminRacine + "\\temp";

            //Liste les caméras
            listCams = Cam_Visuel1.GetVideoCaptureDevices().ToList<WebCameraId>();

            foreach (WebCameraId camera in listCams)
            {
                 List_Camera.Items.Add(camera.Name);
            }

            List_Camera.SelectedIndex = 0;

            try
            {
                Cam_Visuel1.StartCapture(listCams[0]);
            }catch(Exception)
            {
                MessageBox.Show("Aucune camera détécté !", "ATTENTION !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Créer le dossier temporaire si il n'existe
            if (!System.IO.Directory.Exists(cheminVersDossierTemp))
            {
                Directory.CreateDirectory(cheminVersDossierTemp);
            }

            //Supprime le cache
            removeCache();
        }

        private void List_Camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cam_Visuel1.StartCapture(listCams[List_Camera.SelectedIndex]);
        }

        private void Btn_RetourVisuel_Click(object sender, EventArgs e)
        {
            Form identificationVisuel = new identification1();
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Close();
        }

        private void Btn_VérifierVisuel_Click(object sender, EventArgs e)
        {
            //vérifie si le dossier temp existe sinon le créer 
            string cheminVersImageTemp = cheminVersDossierTemp + "\\capture" + DateTimeOffset.Now.ToUnixTimeSeconds() + ".jpeg";

            Cam_Visuel1.GetCurrentImage().Save(cheminVersImageTemp);

            //Appelle du test de l'image
            TestImage(cheminVersImageTemp);

        }

        private async void TestImage(string cheminVersImageTemp)
        {
            Load_identificationVisuel.Show();
            Txt_chargementMetro.Show();
            Btn_RetourVisuel.Enabled = false;
            Btn_VérifierVisuel.Enabled = false;
            Cam_Visuel1.StopCapture();

            //Affichage sur le coté gauche de l'image de l'utilisateur 
            string imgPrev = System.IO.Path.Combine(Application.StartupPath, cheminVersImageTemp);
            Bitmap bmp = new Bitmap(imgPrev);
            Img_identificationVisuelPreview.Image = bmp;
            Img_previewUserReconnu.Image = bmp;

            try
            {
                JObject resultatPhotoTemporaire = await ReconnaissanceFaciale.FaceRecCreateFaceIdTempAsync(cheminVersImageTemp);

                string faceId = Convert.ToString(resultatPhotoTemporaire.GetValue("faceId"));

                JObject compareFace = await ReconnaissanceFaciale.FaceRecCompareFaceAsync(faceId);

                //reloadPage();

                //Comparaison du retour

                //Si le visage à été reconnu
                if (compareFace != null && Convert.ToInt32(compareFace.GetValue("confidence")) >= 0.6)
                {
                    Cam_Visuel1.Hide();
                    Img_previewUserReconnu.Show();
                    Img_identificationVisuelPreview.Hide();

                    faceIdReconnu = Convert.ToString(compareFace.GetValue("persistedFaceId"));


                    MetroFramework.MetroMessageBox.Show(this, "Vous avez bien été reconnu !", "RECONNU",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    affichageInfoVisage(resultatPhotoTemporaire);

                    Btn_continuerToMdp.Show();
                    Btn_continuerToMdp.Enabled = true;
                }
                //Si le visage n'a pas été reconnu
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Aucun utilisateur reconnu !", "NON RECONNU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                    //ReconnaissanceFaciale.MailErreur(imgPrev);
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "ERREUR : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error & MessageBoxIcon.Stop);
                reloadPage();
            }

            return;
        }

        private void reloadPage()
        {
            Load_identificationVisuel.Hide();
            Txt_chargementMetro.Hide();
            Btn_RetourVisuel.Enabled = true;
            Btn_VérifierVisuel.Enabled = true;
            Cam_Visuel1.StartCapture(listCams[List_Camera.SelectedIndex]);
        }

        private void removeCache()
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

        private void affichageInfoVisage(JObject Infos)
        {
            Lbl_infoutilisateur.Show();

            float smile = (int)Infos["faceAttributes"]["smile"];
            string gender = (string)Infos["faceAttributes"]["gender"];
            string age = (string)Infos["faceAttributes"]["age"];
            float moustache = (int)Infos["faceAttributes"]["facialHair"]["moustache"];
            float beard = (int)Infos["faceAttributes"]["facialHair"]["beard"];
            float sideburns = (int)Infos["faceAttributes"]["facialHair"]["sideburns"];
            string glasses = (string)Infos["faceAttributes"]["glasses"];

            Lbl_infoutilisateur.Text = "% de Sourir : " + smile*100 + "% \n";
            Lbl_infoutilisateur.Text += "Sexe : " + gender + "\n";
            Lbl_infoutilisateur.Text += "Age : " + age + "\n";
            Lbl_infoutilisateur.Text += "% de moustache : " + moustache*100 + "%\n";
            Lbl_infoutilisateur.Text += "% de barbe : " + beard*100 + "%\n";
            Lbl_infoutilisateur.Text += "% de rouflaquettes : " + sideburns*100 + "%\n";

            if(glasses == "ReadingGlasses")
            {
                Lbl_infoutilisateur.Text += "Porte des lunettes de lecture";
            }

        }

        private void Btn_continuerToMdp_Click(object sender, EventArgs e)
        {
            Form identificationVisuel = new identificationMDP(faceIdReconnu);
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Close();
        }
    }
}
