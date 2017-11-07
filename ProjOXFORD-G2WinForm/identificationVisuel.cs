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

namespace ProjOXFORD_G2WinForm
{
    public partial class identificationVisuel : MetroFramework.Forms.MetroForm
    {

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
    }
}
