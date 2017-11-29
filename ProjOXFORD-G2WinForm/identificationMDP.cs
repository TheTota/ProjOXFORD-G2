using ProjOXFORD_G2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjOXFORD_G2WinForm
{
    public partial class identificationMDP : MetroFramework.Forms.MetroForm
    {
        string faceIdaTester;

        public identificationMDP(string faceId)
        {
            faceIdaTester = faceId;
            InitializeComponent();

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        

        private void identificationMDP_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Enmpéche d'entrer autre chose que des nombres et empèche le dépassement de 4 chiffres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBox_MotDePasse_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtBox_MotDePasse.Text, "[^0-9]"))
            {
                MessageBox.Show("Merci de n'entrer que des chiffres.");
                TxtBox_MotDePasse.Text = TxtBox_MotDePasse.Text.Remove(TxtBox_MotDePasse.Text.Length - 1);
            }
        }

        private void TxtBox_MotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(TxtBox_MotDePasse.Text.Length >= 4)
            {
                MessageBox.Show("Le mot de passe ne peut pas dépasser 4 chiffres.");
            }
        }

        private void Btn_NombreMDP0_Click(object sender, EventArgs e)
        {
            SaisieMdp(0);
        }

        private void Btn_NombreMDP1_Click(object sender, EventArgs e)
        {
            SaisieMdp(1);
        }

        private void Btn_NombreMDP2_Click(object sender, EventArgs e)
        {
            SaisieMdp(2);
        }

        private void Btn_NombreMDP3_Click(object sender, EventArgs e)
        {
            SaisieMdp(3);
        }

        private void Btn_NombreMDP4_Click(object sender, EventArgs e)
        {
            SaisieMdp(4);
        }

        private void Btn_NombreMDP5_Click(object sender, EventArgs e)
        {
            SaisieMdp(5);
        }

        private void Btn_NombreMDP6_Click(object sender, EventArgs e)
        {
            SaisieMdp(6);
        }

        private void Btn_NombreMDP7_Click(object sender, EventArgs e)
        {
            SaisieMdp(7);
        }

        private void Btn_NombreMDP8_Click(object sender, EventArgs e)
        {
            SaisieMdp(8);
        }

        private void Btn_NombreMDP9_Click(object sender, EventArgs e)
        {
            SaisieMdp(9);
        }

        private void SaisieMdp(int valeur)
        {
            if (TxtBox_MotDePasse.Text.Length >= 4)
            {
                MessageBox.Show("Le mot de passe ne peut pas dépasser 4 chiffres.");
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

        private void Btn_RetourMDP_Click(object sender, EventArgs e)
        {
            Form identificationVisuel = new identificationVisuel();
            identificationVisuel.Location = this.Location;
            identificationVisuel.StartPosition = FormStartPosition.Manual;
            identificationVisuel.Show();
            this.Close();
        }

        /// <summary>
        /// Compare le mot de passe récupéré en BDD avec celui saisir par l'utilisateur dans le formulaire.
        /// </summary>
        /// <param name="mdpSaisi">Mot de passe saisi dans le formulaire.</param>
        /// <param name="faceId">Face ID pour lequel le mot de passe ca être récupéré.</param>
        /// <returns>True s'il y a correpondance, sinon retourne False.</returns>
        public static bool CompareMdp(IWin32Window owner,int mdpSaisi, string faceId)
        {
            if (TraitementBdd.RecupMdp(faceId) == mdpSaisi)
            {
                MetroFramework.MetroMessageBox.Show(owner,"Mot de passe valide !", "RECONNU", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(owner, "Mot de passe non valide !", "NON RECONNU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                return false;
            }
        }

        private void Btn_VerifierMDP_Click(object sender, EventArgs e)
        {
            if (CompareMdp(this, Convert.ToInt16(TxtBox_MotDePasse.Text), faceIdaTester))
            {
                CompareMdp(this, Convert.ToInt16(TxtBox_MotDePasse.Text), faceIdaTester);
                Form identificationVisuel = new IdentificationTermine(faceIdaTester);
                identificationVisuel.Location = this.Location;
                identificationVisuel.StartPosition = FormStartPosition.Manual;
                identificationVisuel.Show();
                this.Close();
            }
        }
    }
}
