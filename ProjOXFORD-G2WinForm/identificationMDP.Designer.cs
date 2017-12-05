//-----------------------------------------------------------------------
// <copyright file="identificationMDP.Designer.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Loïc DELAUNAY</author>
//-----------------------------------------------------------------------

namespace ProjOXFORD_G2WinForm
{
    /// <content> An identification mdp. </content>
    public partial class IdentificationMDP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> The picture box 1 control. </summary>
        private System.Windows.Forms.PictureBox pictureBox1;

        /// <summary> The text titre 3 control. </summary>
        private System.Windows.Forms.Label Txt_Titre3;

        /// <summary> The text box mot de passe. </summary>
        private MetroFramework.Controls.MetroTextBox TxtBox_MotDePasse;

        /// <summary> The button verifier mdp. </summary>
        private MetroFramework.Controls.MetroButton Btn_VerifierMDP;

        /// <summary> The button retour mdp. </summary>
        private MetroFramework.Controls.MetroButton Btn_RetourMDP;

        /// <summary> The pnl chiffre mdp. </summary>
        private MetroFramework.Controls.MetroPanel Pnl_ChiffreMdp;

        /// <summary> The fourth button nombre mdp. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP4;

        /// <summary> The third button nombre mdp. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP3;

        /// <summary> The second button nombre mdp. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP2;

        /// <summary> The first button nombre mdp. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP1;

        /// <summary> The button nombre mdp 7. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP7;

        /// <summary> The button nombre mdp 6. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP6;

        /// <summary> The fifth button nombre mdp. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP5;

        /// <summary> The button nombre mdp 0. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP0;

        /// <summary> The button nombre mdp 9. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP9;

        /// <summary> The button nombre mdp 8. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDP8;

        /// <summary> The button nombre mdp retour. </summary>
        private MetroFramework.Controls.MetroButton Btn_NombreMDPRetour;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Titre3 = new System.Windows.Forms.Label();
            this.TxtBox_MotDePasse = new MetroFramework.Controls.MetroTextBox();
            this.Btn_VerifierMDP = new MetroFramework.Controls.MetroButton();
            this.Btn_RetourMDP = new MetroFramework.Controls.MetroButton();
            this.Pnl_ChiffreMdp = new MetroFramework.Controls.MetroPanel();
            this.Btn_NombreMDP0 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDP9 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDP8 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDP7 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDP6 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDP5 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDP4 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDP3 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDP2 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDP1 = new MetroFramework.Controls.MetroButton();
            this.Btn_NombreMDPRetour = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_ChiffreMdp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Titre3
            // 
            this.Txt_Titre3.AutoSize = true;
            this.Txt_Titre3.Font = new System.Drawing.Font("Roboto Th", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titre3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Txt_Titre3.Location = new System.Drawing.Point(555, 40);
            this.Txt_Titre3.Name = "Txt_Titre3";
            this.Txt_Titre3.Size = new System.Drawing.Size(810, 65);
            this.Txt_Titre3.TabIndex = 2;
            this.Txt_Titre3.Text = "Merci de saisir votre mot de passe";
            // 
            // TxtBox_MotDePasse
            // 
            this.TxtBox_MotDePasse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtBox_MotDePasse.CustomButton.Image = null;
            this.TxtBox_MotDePasse.CustomButton.Location = new System.Drawing.Point(373, 2);
            this.TxtBox_MotDePasse.CustomButton.Name = string.Empty;
            this.TxtBox_MotDePasse.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.TxtBox_MotDePasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBox_MotDePasse.CustomButton.TabIndex = 1;
            this.TxtBox_MotDePasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBox_MotDePasse.CustomButton.UseSelectable = true;
            this.TxtBox_MotDePasse.CustomButton.Visible = false;
            this.TxtBox_MotDePasse.DisplayIcon = true;
            this.TxtBox_MotDePasse.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBox_MotDePasse.Lines = new string[0];
            this.TxtBox_MotDePasse.Location = new System.Drawing.Point(207, 424);
            this.TxtBox_MotDePasse.MaxLength = 4;
            this.TxtBox_MotDePasse.Name = "TxtBox_MotDePasse";
            this.TxtBox_MotDePasse.PasswordChar = '●';
            this.TxtBox_MotDePasse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBox_MotDePasse.SelectedText = string.Empty;
            this.TxtBox_MotDePasse.SelectionLength = 0;
            this.TxtBox_MotDePasse.SelectionStart = 0;
            this.TxtBox_MotDePasse.ShortcutsEnabled = true;
            this.TxtBox_MotDePasse.ShowClearButton = true;
            this.TxtBox_MotDePasse.Size = new System.Drawing.Size(571, 200);
            this.TxtBox_MotDePasse.TabIndex = 3;
            this.TxtBox_MotDePasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBox_MotDePasse.UseCustomBackColor = true;
            this.TxtBox_MotDePasse.UseCustomForeColor = true;
            this.TxtBox_MotDePasse.UseSelectable = true;
            this.TxtBox_MotDePasse.UseStyleColors = true;
            this.TxtBox_MotDePasse.UseSystemPasswordChar = true;
            this.TxtBox_MotDePasse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBox_MotDePasse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_MotDePasse.TextChanged += new System.EventHandler(this.TxtBox_MotDePasse_TextChanged);
            this.TxtBox_MotDePasse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_MotDePasse_KeyPress);
            // 
            // Btn_VerifierMDP
            // 
            this.Btn_VerifierMDP.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_VerifierMDP.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Btn_VerifierMDP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_VerifierMDP.Highlight = true;
            this.Btn_VerifierMDP.Location = new System.Drawing.Point(207, 658);
            this.Btn_VerifierMDP.Name = "Btn_VerifierMDP";
            this.Btn_VerifierMDP.Size = new System.Drawing.Size(571, 89);
            this.Btn_VerifierMDP.TabIndex = 4;
            this.Btn_VerifierMDP.Text = "Vérifier";
            this.Btn_VerifierMDP.UseCustomForeColor = true;
            this.Btn_VerifierMDP.UseSelectable = true;
            this.Btn_VerifierMDP.Click += new System.EventHandler(this.Btn_VerifierMDP_Click);
            // 
            // Btn_RetourMDP
            // 
            this.Btn_RetourMDP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_RetourMDP.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_RetourMDP.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Btn_RetourMDP.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_RetourMDP.Location = new System.Drawing.Point(1485, 48);
            this.Btn_RetourMDP.Name = "Btn_RetourMDP";
            this.Btn_RetourMDP.Size = new System.Drawing.Size(442, 57);
            this.Btn_RetourMDP.TabIndex = 5;
            this.Btn_RetourMDP.Text = "Retour";
            this.Btn_RetourMDP.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Btn_RetourMDP.UseCustomBackColor = true;
            this.Btn_RetourMDP.UseCustomForeColor = true;
            this.Btn_RetourMDP.UseSelectable = true;
            this.Btn_RetourMDP.Click += new System.EventHandler(this.Btn_RetourMDP_Click);
            // 
            // Pnl_ChiffreMdp
            // 
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP0);
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP9);
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP8);
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP7);
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP6);
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP5);
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP4);
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP3);
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP2);
            this.Pnl_ChiffreMdp.Controls.Add(this.Btn_NombreMDP1);
            this.Pnl_ChiffreMdp.HorizontalScrollbarBarColor = true;
            this.Pnl_ChiffreMdp.HorizontalScrollbarHighlightOnWheel = false;
            this.Pnl_ChiffreMdp.HorizontalScrollbarSize = 10;
            this.Pnl_ChiffreMdp.Location = new System.Drawing.Point(863, 247);
            this.Pnl_ChiffreMdp.Name = "Pnl_ChiffreMdp";
            this.Pnl_ChiffreMdp.Size = new System.Drawing.Size(646, 751);
            this.Pnl_ChiffreMdp.TabIndex = 6;
            this.Pnl_ChiffreMdp.VerticalScrollbarBarColor = true;
            this.Pnl_ChiffreMdp.VerticalScrollbarHighlightOnWheel = false;
            this.Pnl_ChiffreMdp.VerticalScrollbarSize = 10;
            // 
            // Btn_NombreMDP0
            // 
            this.Btn_NombreMDP0.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP0.Highlight = true;
            this.Btn_NombreMDP0.Location = new System.Drawing.Point(129, 631);
            this.Btn_NombreMDP0.Name = "Btn_NombreMDP0";
            this.Btn_NombreMDP0.Size = new System.Drawing.Size(372, 113);
            this.Btn_NombreMDP0.TabIndex = 11;
            this.Btn_NombreMDP0.Text = "0";
            this.Btn_NombreMDP0.UseCustomBackColor = true;
            this.Btn_NombreMDP0.UseCustomForeColor = true;
            this.Btn_NombreMDP0.UseSelectable = true;
            this.Btn_NombreMDP0.UseStyleColors = true;
            this.Btn_NombreMDP0.Click += new System.EventHandler(this.Btn_NombreMDP0_Click);
            // 
            // Btn_NombreMDP9
            // 
            this.Btn_NombreMDP9.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP9.Highlight = true;
            this.Btn_NombreMDP9.Location = new System.Drawing.Point(455, 15);
            this.Btn_NombreMDP9.Name = "Btn_NombreMDP9";
            this.Btn_NombreMDP9.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDP9.TabIndex = 10;
            this.Btn_NombreMDP9.Text = "9";
            this.Btn_NombreMDP9.UseCustomBackColor = true;
            this.Btn_NombreMDP9.UseCustomForeColor = true;
            this.Btn_NombreMDP9.UseSelectable = true;
            this.Btn_NombreMDP9.UseStyleColors = true;
            this.Btn_NombreMDP9.Click += new System.EventHandler(this.Btn_NombreMDP9_Click);
            // 
            // Btn_NombreMDP8
            // 
            this.Btn_NombreMDP8.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP8.Highlight = true;
            this.Btn_NombreMDP8.Location = new System.Drawing.Point(234, 15);
            this.Btn_NombreMDP8.Name = "Btn_NombreMDP8";
            this.Btn_NombreMDP8.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDP8.TabIndex = 9;
            this.Btn_NombreMDP8.Text = "8";
            this.Btn_NombreMDP8.UseCustomBackColor = true;
            this.Btn_NombreMDP8.UseCustomForeColor = true;
            this.Btn_NombreMDP8.UseSelectable = true;
            this.Btn_NombreMDP8.UseStyleColors = true;
            this.Btn_NombreMDP8.Click += new System.EventHandler(this.Btn_NombreMDP8_Click);
            // 
            // Btn_NombreMDP7
            // 
            this.Btn_NombreMDP7.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP7.Highlight = true;
            this.Btn_NombreMDP7.Location = new System.Drawing.Point(20, 15);
            this.Btn_NombreMDP7.Name = "Btn_NombreMDP7";
            this.Btn_NombreMDP7.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDP7.TabIndex = 8;
            this.Btn_NombreMDP7.Text = "7";
            this.Btn_NombreMDP7.UseCustomBackColor = true;
            this.Btn_NombreMDP7.UseCustomForeColor = true;
            this.Btn_NombreMDP7.UseSelectable = true;
            this.Btn_NombreMDP7.UseStyleColors = true;
            this.Btn_NombreMDP7.Click += new System.EventHandler(this.Btn_NombreMDP7_Click);
            // 
            // Btn_NombreMDP6
            // 
            this.Btn_NombreMDP6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP6.Highlight = true;
            this.Btn_NombreMDP6.Location = new System.Drawing.Point(455, 234);
            this.Btn_NombreMDP6.Name = "Btn_NombreMDP6";
            this.Btn_NombreMDP6.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDP6.TabIndex = 7;
            this.Btn_NombreMDP6.Text = "6";
            this.Btn_NombreMDP6.UseCustomBackColor = true;
            this.Btn_NombreMDP6.UseCustomForeColor = true;
            this.Btn_NombreMDP6.UseSelectable = true;
            this.Btn_NombreMDP6.UseStyleColors = true;
            this.Btn_NombreMDP6.Click += new System.EventHandler(this.Btn_NombreMDP6_Click);
            // 
            // Btn_NombreMDP5
            // 
            this.Btn_NombreMDP5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP5.Highlight = true;
            this.Btn_NombreMDP5.Location = new System.Drawing.Point(234, 234);
            this.Btn_NombreMDP5.Name = "Btn_NombreMDP5";
            this.Btn_NombreMDP5.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDP5.TabIndex = 6;
            this.Btn_NombreMDP5.Text = "5";
            this.Btn_NombreMDP5.UseCustomBackColor = true;
            this.Btn_NombreMDP5.UseCustomForeColor = true;
            this.Btn_NombreMDP5.UseSelectable = true;
            this.Btn_NombreMDP5.UseStyleColors = true;
            this.Btn_NombreMDP5.Click += new System.EventHandler(this.Btn_NombreMDP5_Click);
            // 
            // Btn_NombreMDP4
            // 
            this.Btn_NombreMDP4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP4.Highlight = true;
            this.Btn_NombreMDP4.Location = new System.Drawing.Point(20, 234);
            this.Btn_NombreMDP4.Name = "Btn_NombreMDP4";
            this.Btn_NombreMDP4.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDP4.TabIndex = 5;
            this.Btn_NombreMDP4.Text = "4";
            this.Btn_NombreMDP4.UseCustomBackColor = true;
            this.Btn_NombreMDP4.UseCustomForeColor = true;
            this.Btn_NombreMDP4.UseSelectable = true;
            this.Btn_NombreMDP4.UseStyleColors = true;
            this.Btn_NombreMDP4.Click += new System.EventHandler(this.Btn_NombreMDP4_Click);
            // 
            // Btn_NombreMDP3
            // 
            this.Btn_NombreMDP3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP3.Highlight = true;
            this.Btn_NombreMDP3.Location = new System.Drawing.Point(455, 438);
            this.Btn_NombreMDP3.Name = "Btn_NombreMDP3";
            this.Btn_NombreMDP3.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDP3.TabIndex = 4;
            this.Btn_NombreMDP3.Text = "3";
            this.Btn_NombreMDP3.UseCustomBackColor = true;
            this.Btn_NombreMDP3.UseCustomForeColor = true;
            this.Btn_NombreMDP3.UseSelectable = true;
            this.Btn_NombreMDP3.UseStyleColors = true;
            this.Btn_NombreMDP3.Click += new System.EventHandler(this.Btn_NombreMDP3_Click);
            // 
            // Btn_NombreMDP2
            // 
            this.Btn_NombreMDP2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP2.Highlight = true;
            this.Btn_NombreMDP2.Location = new System.Drawing.Point(234, 438);
            this.Btn_NombreMDP2.Name = "Btn_NombreMDP2";
            this.Btn_NombreMDP2.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDP2.TabIndex = 3;
            this.Btn_NombreMDP2.Text = "2";
            this.Btn_NombreMDP2.UseCustomBackColor = true;
            this.Btn_NombreMDP2.UseCustomForeColor = true;
            this.Btn_NombreMDP2.UseSelectable = true;
            this.Btn_NombreMDP2.UseStyleColors = true;
            this.Btn_NombreMDP2.Click += new System.EventHandler(this.Btn_NombreMDP2_Click);
            // 
            // Btn_NombreMDP1
            // 
            this.Btn_NombreMDP1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDP1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDP1.Highlight = true;
            this.Btn_NombreMDP1.Location = new System.Drawing.Point(20, 438);
            this.Btn_NombreMDP1.Name = "Btn_NombreMDP1";
            this.Btn_NombreMDP1.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDP1.TabIndex = 2;
            this.Btn_NombreMDP1.Text = "1";
            this.Btn_NombreMDP1.UseCustomBackColor = true;
            this.Btn_NombreMDP1.UseCustomForeColor = true;
            this.Btn_NombreMDP1.UseSelectable = true;
            this.Btn_NombreMDP1.UseStyleColors = true;
            this.Btn_NombreMDP1.Click += new System.EventHandler(this.Btn_NombreMDP1_Click);
            // 
            // Btn_NombreMDPRetour
            // 
            this.Btn_NombreMDPRetour.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_NombreMDPRetour.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_NombreMDPRetour.Highlight = true;
            this.Btn_NombreMDPRetour.Location = new System.Drawing.Point(1544, 262);
            this.Btn_NombreMDPRetour.Name = "Btn_NombreMDPRetour";
            this.Btn_NombreMDPRetour.Size = new System.Drawing.Size(170, 170);
            this.Btn_NombreMDPRetour.TabIndex = 12;
            this.Btn_NombreMDPRetour.Text = "<-";
            this.Btn_NombreMDPRetour.UseCustomBackColor = true;
            this.Btn_NombreMDPRetour.UseCustomForeColor = true;
            this.Btn_NombreMDPRetour.UseSelectable = true;
            this.Btn_NombreMDPRetour.UseStyleColors = true;
            this.Btn_NombreMDPRetour.Click += new System.EventHandler(this.Btn_NombreMDPRetour_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjOXFORD_G2WinForm.Properties.Resources.LogoOxford;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IdentificationMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Pnl_ChiffreMdp);
            this.Controls.Add(this.Btn_RetourMDP);
            this.Controls.Add(this.Btn_NombreMDPRetour);
            this.Controls.Add(this.Btn_VerifierMDP);
            this.Controls.Add(this.TxtBox_MotDePasse);
            this.Controls.Add(this.Txt_Titre3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IdentificationMDP";
            this.Load += new System.EventHandler(this.IdentificationMDP_Load);
            this.Pnl_ChiffreMdp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}