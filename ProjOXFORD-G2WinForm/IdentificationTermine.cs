//-----------------------------------------------------------------------
// <copyright file="IdentificationTermine.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Loïc DELAUNAY</author>
//-----------------------------------------------------------------------

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
    /// <summary> An identification termine. </summary>
    /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
    public partial class IdentificationTermine : MetroFramework.Forms.MetroForm
    {
        /// <summary> Identifier for the face. </summary>
        private string _faceId;

        /// <summary> 
        /// Initializes a new instance of the <see cref="ProjOXFORD_G2WinForm.IdentificationTermine"/> class.
        /// </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="faceId"> Identifier for the face. </param>
        public IdentificationTermine(string faceId)
        {
            InitializeComponent();
            this._faceId = faceId;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary> Event handler. Called by IdentificationTermine for load events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void IdentificationTermine_Load(object sender, EventArgs e)
        {
            WaitAndReload();
            txtInfos.Text = "Bienvenue M. " + TraitementBdd.RecupInfosUser(this._faceId);
        }

        /// <summary> Wait and reload. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        private async void WaitAndReload()
        {
            await Task.Delay(5000);
            Form identificationVisuel = new Identification1();
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Close();
        }
    }
}
