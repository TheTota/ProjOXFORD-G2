using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ProjOXFORD_G2;

namespace ProjOXFORD_G2WinForm
{
    public partial class IdentificationTermine : MetroFramework.Forms.MetroForm
    {
        string faceId;

        public IdentificationTermine(string _faceId)
        {
            InitializeComponent();
            faceId = _faceId;

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void IdentificationTermine_Load(object sender, EventArgs e)
        {
            WaitAndReload();
            Txt_infos.Text = "Bienvenue M. " + TraitementBdd.RecupInfosUser(faceId);
        }

        private async void WaitAndReload()
        {
            await Task.Delay(5000);
            Form identificationVisuel = new identification1();
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Close();
        }

    }
}
