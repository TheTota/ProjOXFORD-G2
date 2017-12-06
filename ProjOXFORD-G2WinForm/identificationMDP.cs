//-----------------------------------------------------------------------
// <copyright file="IdentificationMDP.cs" company="SIO">
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
using ProjOXFORD_G2;

namespace ProjOXFORD_G2WinForm
{
    /// <summary> An identification mdp. </summary>
    /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
    public partial class IdentificationMDP : MetroFramework.Forms.MetroForm
    {
        /// <summary> The face ida tester. </summary>
        private string _faceIdATester;

        /// <summary> Initializes a new instance of the <see cref="ProjOXFORD_G2WinForm.IdentificationMDP"/> class. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="faceId"> Face ID pour lequel le mot de passe ca être récupéré. </param>
        public IdentificationMDP(string faceId)
        {
            this._faceIdATester = faceId;
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Compare le mot de passe récupéré en BDD avec celui saisi par l'utilisateur dans le formulaire.
        /// </summary>
        /// <param name="mdpSaisi">Mot de passe saisi dans le formulaire.</param>
        /// <param name="faceId">Face ID pour lequel le mot de passe ca être récupéré.</param>
        /// <returns>True s'il y a correpondance, sinon retourne False.</returns>
        public static bool CompareMdp(IWin32Window owner, int mdpSaisi, string faceId)
        {
            if (TraitementBdd.RecupMdp(faceId) == mdpSaisi)
            {
                MetroFramework.MetroMessageBox.Show(owner, "Mot de passe valide !", "RECONNU", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TraitementBdd.EventSucces(TraitementBdd.RecupIdUtilisateur(faceId), "L'utilisateur a bien été authentifier.");
                return true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(owner, "Mot de passe non valide !", "NON RECONNU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                TraitementBdd.EventErreur(TraitementBdd.RecupIdUtilisateur(faceId), "L'utilisateur a entré le mauvais mot de passe.");
                return false;
            }
        }

        /// <summary> Event handler. Called by IdentificationMDP for load events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void IdentificationMDP_Load(object sender, EventArgs e)
        {
        }

        /// <summary> Enmpèche de saisir autre chose que des nombres et empèche le dépassement de 4
        /// chiffres. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      . </param>
        private void TxtBox_MotDePasse_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtBox_MotDePasse.Text, "[^0-9]"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Merci de n'entrer que des chiffres.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                TxtBox_MotDePasse.Text = TxtBox_MotDePasse.Text.Remove(TxtBox_MotDePasse.Text.Length - 1);
            }
        }

        /// <summary> Event handler. Called by TxtBox_MotDePasse for key press events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Key press event information. </param>
        private void TxtBox_MotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                if (TxtBox_MotDePasse.Text.Length != 4)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Le mot de passe doit faire 4 chiffres.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);

                }
                else
                {
                    VerifierMDP();
                }
            }
            else if (TxtBox_MotDePasse.Text.Length >= 4)
            {
                MetroFramework.MetroMessageBox.Show(this, "Le mot de passe ne peut pas dépasser 4 chiffres.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);

            }


        }

        /// <summary> Event handler. Called by Btn_NombreMDP0 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP0_Click(object sender, EventArgs e)
        {
            SaisieMdp(0);
        }

        /// <summary> Event handler. Called by Btn_NombreMDP1 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP1_Click(object sender, EventArgs e)
        {
            SaisieMdp(1);
        }

        /// <summary> Event handler. Called by Btn_NombreMDP2 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP2_Click(object sender, EventArgs e)
        {
            SaisieMdp(2);
        }

        /// <summary> Event handler. Called by Btn_NombreMDP3 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP3_Click(object sender, EventArgs e)
        {
            SaisieMdp(3);
        }

        /// <summary> Event handler. Called by Btn_NombreMDP4 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP4_Click(object sender, EventArgs e)
        {
            SaisieMdp(4);
        }

        /// <summary> Event handler. Called by Btn_NombreMDP5 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP5_Click(object sender, EventArgs e)
        {
            SaisieMdp(5);
        }

        /// <summary> Event handler. Called by Btn_NombreMDP6 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP6_Click(object sender, EventArgs e)
        {
            SaisieMdp(6);
        }

        /// <summary> Event handler. Called by Btn_NombreMDP7 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP7_Click(object sender, EventArgs e)
        {
            SaisieMdp(7);
        }

        /// <summary> Event handler. Called by Btn_NombreMDP8 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP8_Click(object sender, EventArgs e)
        {
            SaisieMdp(8);
        }

        /// <summary> Event handler. Called by Btn_NombreMDP9 for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDP9_Click(object sender, EventArgs e)
        {
            SaisieMdp(9);
        }

        /// <summary> Saisie mdp. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="valeur"> The valeur. </param>
        private void SaisieMdp(int valeur)
        {
            if (TxtBox_MotDePasse.Text.Length >= 4)
            {
                MetroFramework.MetroMessageBox.Show(this, "Le mot de passe ne peut pas dépasser 4 chiffres.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);

            }
            else
            {
                Btn_NombreMDPRetour.Enabled = true;
                TxtBox_MotDePasse.Text += valeur;
                if (TxtBox_MotDePasse.Text.Length == 4)
                {
                    Pnl_ChiffreMdp.Enabled = false;
                    Btn_NombreMDPRetour.Enabled = true;
                }
            }
        }

        /// <summary> Event handler. Called by Btn_NombreMDPRetour for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_NombreMDPRetour_Click(object sender, EventArgs e)
        {
            Pnl_ChiffreMdp.Enabled = true;
            if (TxtBox_MotDePasse.Text.Length >= 1)
            { 
                TxtBox_MotDePasse.Text = TxtBox_MotDePasse.Text.Remove(TxtBox_MotDePasse.Text.Length - 1);
            }
            else
            {
                Btn_NombreMDPRetour.Enabled = false;
            }
        }

        /// <summary> Event handler. Called by Btn_RetourMDP for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_RetourMDP_Click(object sender, EventArgs e)
        {
            Form identificationVisuel = new IdentificationVisuel();
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Close();
        }

        /// <summary> Event handler. Called by Btn_VerifierMDP for click events. </summary>
        /// <remarks> Thomas LAURE, 05/12/2017. </remarks>
        /// <param name="sender"> . </param>
        /// <param name="e">      Event information. </param>
        private void Btn_VerifierMDP_Click(object sender, EventArgs e)
        {
            VerifierMDP();
        }

        private void VerifierMDP()
        {
            Btn_VerifierMDP.Enabled = false;
            if (CompareMdp(this, Convert.ToInt16(TxtBox_MotDePasse.Text), _faceIdATester))
            {
                Form identificationVisuel = new IdentificationTermine(_faceIdATester);
                identificationVisuel.Location = this.Location;
                identificationVisuel.StartPosition = FormStartPosition.Manual;
                identificationVisuel.Show();
                this.Close();
            }
            else
            {
                Btn_VerifierMDP.Enabled = true;
            }
        }
    }
}
