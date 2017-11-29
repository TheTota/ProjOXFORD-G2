using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjOXFORD_G2WinForm;
using System.IO;

namespace ProjOXFORD_G2WinForm
{
    public partial class identification1 : MetroFramework.Forms.MetroForm
    {
        public identification1()
        {
            InitializeComponent();

            ////Ajout de la transparence sur le lock.
            Img_Topper1.Controls.Add(Img_Unlock);
            Img_Unlock.BackColor = Color.Transparent;
            TxtAnimation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Txt_Titre_Click(object sender, EventArgs e)
        {
            GoToIdentificationVisuel();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GoToIdentificationVisuel();
        }

        private void Img_Topper1_Click(object sender, EventArgs e)
        {
            GoToIdentificationVisuel();
        }

        private async void TxtAnimation()
        {
            await Task.Delay(1000);
            if (Txt_SousTitre1.Visible)
            {
                Txt_SousTitre1.Visible = false;
            }
            else{

                Txt_SousTitre1.Visible = true;

            }
            TxtAnimation();
        }

        private void Img_Unlock_Click(object sender, EventArgs e)
        {
            GoToIdentificationVisuel();
        }

        private void GoToIdentificationVisuel()
        {
            string cheminVersDossierTemp = Environment.CurrentDirectory + "\\temp";
            //// Créer le dossier temporaire s'il n'existe pas.
            if (!System.IO.Directory.Exists(cheminVersDossierTemp))
            {
                Directory.CreateDirectory(cheminVersDossierTemp);
            }

            Form identificationVisuel = new identificationVisuel();
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Hide();
        }
    }
}
