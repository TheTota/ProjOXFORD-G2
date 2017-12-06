//-----------------------------------------------------------------------
// <copyright file="Identification1.cs" company="SIO">
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
using ProjOXFORD_G2WinForm;

namespace ProjOXFORD_G2WinForm
{
    /// <summary> An identification 1. </summary>
    /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
    public partial class Identification1 : MetroFramework.Forms.MetroForm
    {
        /// <summary> Initialises a new instance of the ProjOXFORD_G2WinForm.Identification1 class. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        public Identification1()
        {
            this.InitializeComponent();

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            //// Ajout de la transparence sur le lock
            imgTopper1.Controls.Add(imgUnlock);
            imgUnlock.BackColor = Color.Transparent;
            TxtAnimation();
        }

        /// <summary> Event handler. Called by Form1 for load events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary> Event handler. Called by txtTitre for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Txt_Titre_Click(object sender, EventArgs e)
        {
            GoToIdentificationVisuel();
        }

        /// <summary> Event handler. Called by label1 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Label1_Click(object sender, EventArgs e)
        {
            GoToIdentificationVisuel();
        }

        /// <summary> Event handler. Called by imgTopper1 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Img_Topper1_Click(object sender, EventArgs e)
        {
            GoToIdentificationVisuel();
        }

        /// <summary> Text animation. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        private async void TxtAnimation()
        {
            await Task.Delay(1000);
            if (txtSousTitre1.Visible)
            {
                txtSousTitre1.Visible = false;
            }
            else
            {
                txtSousTitre1.Visible = true;
            }

            TxtAnimation();
        }

        /// <summary> Event handler. Called by imgUnlock for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void Img_Unlock_Click(object sender, EventArgs e)
        {
            GoToIdentificationVisuel();
        }

        /// <summary> Go to identification visuel. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        private void GoToIdentificationVisuel()
        {
            string cheminVersDossierTemp = Environment.CurrentDirectory + "\\temp";
            //// Créer le dossier temporaire s'il n'existe pas.
            if (!System.IO.Directory.Exists(cheminVersDossierTemp))
            {
                Directory.CreateDirectory(cheminVersDossierTemp);
            }

            Form identificationVisuel = new IdentificationVisuel();
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Hide();
        }
    }
}
