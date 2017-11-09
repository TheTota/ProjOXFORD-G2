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

namespace ProjOXFORD_G2WinForm
{
    public partial class identificationVisuel : MetroFramework.Forms.MetroForm
    {
        string cheminRacine = Environment.CurrentDirectory;
        List<WebCameraId> listCams;

        public identificationVisuel()
        {
            InitializeComponent();
        }

        private void identificationVisuel_Load(object sender, EventArgs e)
        {
            listCams = Cam_Visuel1.GetVideoCaptureDevices().ToList<WebCameraId>();

            foreach (WebCameraId camera in listCams)
            {
                 List_Camera.Items.Add(camera.Name);
            }
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
            this.Hide();
        }

        private void Btn_VérifierVisuel_Click(object sender, EventArgs e)
        {
            //vérifie si le dossier temp existe sinon le créer 
            string cheminVersDossierTemp = cheminRacine + "\\temp";
            string cheminVersImageTemp = cheminVersDossierTemp + "\\capture.jpeg";

            if (!System.IO.Directory.Exists(cheminVersDossierTemp))
            {
                System.IO.Directory.CreateDirectory(cheminVersDossierTemp);
            }

            Cam_Visuel1.GetCurrentImage().Save(cheminVersImageTemp);

            //Appelle du test de l'image
            TestImage(cheminVersImageTemp);

        }

        private async void TestImage(string cheminVersImageTemp)
        {
            MessageBox.Show("méthode atteinte");

            //Affichage sur le coté gauche de l'image de l'utilisateur 
            string myLogo = System.IO.Path.Combine(Application.StartupPath, cheminVersImageTemp);
            Bitmap bmp = new Bitmap(myLogo);
            Img_identificationVisuelPreview.Image = bmp;

            int compareFace = await ReconnaissanceFaciale.FaceRecCompareFaceAsync(cheminVersImageTemp);

            //Comparaison du retour
            if (compareFace >= 0.6)
            {
                MessageBox.Show("L'utilisateur à bien été reconnu !");
                Form identificationVisuel = new identificationMDP();
                identificationVisuel.Location = this.Location;
                identificationVisuel.StartPosition = FormStartPosition.Manual;
                identificationVisuel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Aucun utilisateur reconnu !");
            }

            return;
        }

        private void Cam_Visuel1_Load(object sender, EventArgs e)
        {

        }
    }
}
