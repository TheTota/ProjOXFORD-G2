//-----------------------------------------------------------------------
// <copyright file="identificationVisuel.Designer.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Loïc DELAUNAY</author>
//-----------------------------------------------------------------------

using WebEye.Controls.WinForms.WebCameraControl;

namespace ProjOXFORD_G2WinForm
{
    /// <content> An identification visuel. </content>
    public partial class IdentificationVisuel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer _components = null;

        /// <summary> The image logo ox control. </summary>
        private System.Windows.Forms.PictureBox Img_LogoOX;

        /// <summary> The text titre 2 control. </summary>
        private System.Windows.Forms.Label txtTitre2;

        /// <summary> The webcam. </summary>
        private WebCameraControl webcam;

        /// <summary> The button retour visuel. </summary>
        private MetroFramework.Controls.MetroButton Btn_RetourVisuel;

        /// <summary> The button vérifier visuel. </summary>
        private MetroFramework.Controls.MetroButton Btn_VérifierVisuel;

        /// <summary> The first camera visuel. </summary>
        private WebCameraControl Cam_Visuel1;

        /// <summary> The list camera control. </summary>
        private System.Windows.Forms.ListBox List_Camera;

        /// <summary> The image identification visuel preview control. </summary>
        private System.Windows.Forms.PictureBox Img_identificationVisuelPreview;

        /// <summary> The load identification visuel. </summary>
        private MetroFramework.Controls.MetroProgressSpinner Load_identificationVisuel;

        /// <summary> The text chargement metro. </summary>
        private MetroFramework.Controls.MetroLabel Txt_chargementMetro;

        /// <summary> The label infoutilisateur control. </summary>
        private System.Windows.Forms.Label Lbl_infoutilisateur;

        /// <summary> The image preview user reconnu control. </summary>
        private System.Windows.Forms.PictureBox Img_previewUserReconnu;

        /// <summary> The button continuer to mdp. </summary>
        private MetroFramework.Controls.MetroButton Btn_continuerToMdp;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this._components != null))
            {
                this._components.Dispose();
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
            this.txtTitre2 = new System.Windows.Forms.Label();
            this.webcam = new WebEye.Controls.WinForms.WebCameraControl.WebCameraControl();
            this.Btn_RetourVisuel = new MetroFramework.Controls.MetroButton();
            this.Btn_VérifierVisuel = new MetroFramework.Controls.MetroButton();
            this.Cam_Visuel1 = new WebEye.Controls.WinForms.WebCameraControl.WebCameraControl();
            this.List_Camera = new System.Windows.Forms.ListBox();
            this.Load_identificationVisuel = new MetroFramework.Controls.MetroProgressSpinner();
            this.Txt_chargementMetro = new MetroFramework.Controls.MetroLabel();
            this.Lbl_infoutilisateur = new System.Windows.Forms.Label();
            this.Btn_continuerToMdp = new MetroFramework.Controls.MetroButton();
            this.Img_previewUserReconnu = new System.Windows.Forms.PictureBox();
            this.Img_identificationVisuelPreview = new System.Windows.Forms.PictureBox();
            this.Img_LogoOX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Img_previewUserReconnu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_identificationVisuelPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_LogoOX)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitre2
            // 
            this.txtTitre2.AutoSize = true;
            this.txtTitre2.Font = new System.Drawing.Font("Roboto Th", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTitre2.Location = new System.Drawing.Point(513, 41);
            this.txtTitre2.Name = "Txt_Titre2";
            this.txtTitre2.Size = new System.Drawing.Size(894, 65);
            this.txtTitre2.TabIndex = 1;
            this.txtTitre2.Text = "Merci de vous placer face à la camera";
            // 
            // webcam
            // 
            this.webcam.Location = new System.Drawing.Point(0, 0);
            this.webcam.Name = "webcam";
            this.webcam.Size = new System.Drawing.Size(150, 150);
            this.webcam.TabIndex = 0;
            // 
            // Btn_RetourVisuel
            // 
            this.Btn_RetourVisuel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_RetourVisuel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_RetourVisuel.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Btn_RetourVisuel.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_RetourVisuel.Location = new System.Drawing.Point(1559, 49);
            this.Btn_RetourVisuel.Name = "Btn_RetourVisuel";
            this.Btn_RetourVisuel.Size = new System.Drawing.Size(442, 57);
            this.Btn_RetourVisuel.Style = MetroFramework.MetroColorStyle.Silver;
            this.Btn_RetourVisuel.TabIndex = 2;
            this.Btn_RetourVisuel.Text = "Retour";
            this.Btn_RetourVisuel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Btn_RetourVisuel.UseCustomBackColor = true;
            this.Btn_RetourVisuel.UseCustomForeColor = true;
            this.Btn_RetourVisuel.UseSelectable = true;
            this.Btn_RetourVisuel.Click += new System.EventHandler(this.Btn_RetourVisuel_Click);
            // 
            // Btn_VérifierVisuel
            // 
            this.Btn_VérifierVisuel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_VérifierVisuel.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Btn_VérifierVisuel.Location = new System.Drawing.Point(1539, 499);
            this.Btn_VérifierVisuel.Name = "Btn_VérifierVisuel";
            this.Btn_VérifierVisuel.Size = new System.Drawing.Size(358, 116);
            this.Btn_VérifierVisuel.Style = MetroFramework.MetroColorStyle.Silver;
            this.Btn_VérifierVisuel.TabIndex = 3;
            this.Btn_VérifierVisuel.Text = "Vérifier";
            this.Btn_VérifierVisuel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Btn_VérifierVisuel.UseSelectable = true;
            this.Btn_VérifierVisuel.Click += new System.EventHandler(this.Btn_VérifierVisuel_Click);
            // 
            // Cam_Visuel1
            // 
            this.Cam_Visuel1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Cam_Visuel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cam_Visuel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cam_Visuel1.Location = new System.Drawing.Point(406, 235);
            this.Cam_Visuel1.MinimumSize = new System.Drawing.Size(830, 500);
            this.Cam_Visuel1.Name = "Cam_Visuel1";
            this.Cam_Visuel1.Size = new System.Drawing.Size(1109, 684);
            this.Cam_Visuel1.TabIndex = 8;
            this.Cam_Visuel1.Load += new System.EventHandler(this.Cam_Visuel1_Load);
            // 
            // List_Camera
            // 
            this.List_Camera.FormattingEnabled = true;
            this.List_Camera.Location = new System.Drawing.Point(349, 956);
            this.List_Camera.Name = "List_Camera";
            this.List_Camera.Size = new System.Drawing.Size(1222, 95);
            this.List_Camera.TabIndex = 5;
            this.List_Camera.SelectedIndexChanged += new System.EventHandler(this.List_Camera_SelectedIndexChanged);
            // 
            // Load_identificationVisuel
            // 
            this.Load_identificationVisuel.Location = new System.Drawing.Point(774, 403);
            this.Load_identificationVisuel.Maximum = 100;
            this.Load_identificationVisuel.Name = "Load_identificationVisuel";
            this.Load_identificationVisuel.Size = new System.Drawing.Size(368, 350);
            this.Load_identificationVisuel.Speed = 2F;
            this.Load_identificationVisuel.TabIndex = 7;
            this.Load_identificationVisuel.UseCustomBackColor = true;
            this.Load_identificationVisuel.UseCustomForeColor = true;
            this.Load_identificationVisuel.UseSelectable = true;
            this.Load_identificationVisuel.UseStyleColors = true;
            // 
            // Txt_chargementMetro
            // 
            this.Txt_chargementMetro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_chargementMetro.AutoSize = true;
            this.Txt_chargementMetro.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Txt_chargementMetro.Location = new System.Drawing.Point(754, 698);
            this.Txt_chargementMetro.Name = "Txt_chargementMetro";
            this.Txt_chargementMetro.Size = new System.Drawing.Size(413, 25);
            this.Txt_chargementMetro.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_chargementMetro.TabIndex = 8;
            this.Txt_chargementMetro.Text = "IDENTIFICATION DE LA PHOTO MERCI DE PATIENTER";
            this.Txt_chargementMetro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_chargementMetro.UseCustomBackColor = true;
            this.Txt_chargementMetro.UseCustomForeColor = true;
            this.Txt_chargementMetro.UseStyleColors = true;
            // 
            // Lbl_infoutilisateur
            // 
            this.Lbl_infoutilisateur.AutoSize = true;
            this.Lbl_infoutilisateur.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_infoutilisateur.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_infoutilisateur.Location = new System.Drawing.Point(20, 211);
            this.Lbl_infoutilisateur.Name = "Lbl_infoutilisateur";
            this.Lbl_infoutilisateur.Size = new System.Drawing.Size(63, 25);
            this.Lbl_infoutilisateur.TabIndex = 10;
            this.Lbl_infoutilisateur.Text = "label1";
            // 
            // Btn_continuerToMdp
            // 
            this.Btn_continuerToMdp.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_continuerToMdp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btn_continuerToMdp.Location = new System.Drawing.Point(1539, 499);
            this.Btn_continuerToMdp.Name = "Btn_continuerToMdp";
            this.Btn_continuerToMdp.Size = new System.Drawing.Size(358, 116);
            this.Btn_continuerToMdp.TabIndex = 12;
            this.Btn_continuerToMdp.Text = "Continuer";
            this.Btn_continuerToMdp.UseCustomForeColor = true;
            this.Btn_continuerToMdp.UseSelectable = true;
            this.Btn_continuerToMdp.Click += new System.EventHandler(this.Btn_continuerToMdp_Click);
            // 
            // Img_previewUserReconnu
            // 
            this.Img_previewUserReconnu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Img_previewUserReconnu.Location = new System.Drawing.Point(406, 250);
            this.Img_previewUserReconnu.Name = "Img_previewUserReconnu";
            this.Img_previewUserReconnu.Size = new System.Drawing.Size(1109, 669);
            this.Img_previewUserReconnu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_previewUserReconnu.TabIndex = 11;
            this.Img_previewUserReconnu.TabStop = false;
            this.Img_previewUserReconnu.Click += new System.EventHandler(this.Img_previewUserReconnu_Click);
            // 
            // Img_identificationVisuelPreview
            // 
            this.Img_identificationVisuelPreview.Location = new System.Drawing.Point(0, 615);
            this.Img_identificationVisuelPreview.Name = "Img_identificationVisuelPreview";
            this.Img_identificationVisuelPreview.Size = new System.Drawing.Size(390, 304);
            this.Img_identificationVisuelPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_identificationVisuelPreview.TabIndex = 6;
            this.Img_identificationVisuelPreview.TabStop = false;
            // 
            // Img_LogoOX
            // 
            this.Img_LogoOX.Image = global::ProjOXFORD_G2WinForm.Properties.Resources.LogoOxford;
            this.Img_LogoOX.Location = new System.Drawing.Point(0, -1);
            this.Img_LogoOX.Name = "Img_LogoOX";
            this.Img_LogoOX.Size = new System.Drawing.Size(193, 194);
            this.Img_LogoOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img_LogoOX.TabIndex = 0;
            this.Img_LogoOX.TabStop = false;
            // 
            // IdentificationVisuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Btn_continuerToMdp);
            this.Controls.Add(this.Lbl_infoutilisateur);
            this.Controls.Add(this.Txt_chargementMetro);
            this.Controls.Add(this.Load_identificationVisuel);
            this.Controls.Add(this.Img_identificationVisuelPreview);
            this.Controls.Add(this.List_Camera);
            this.Controls.Add(this.Cam_Visuel1);
            this.Controls.Add(this.Btn_VérifierVisuel);
            this.Controls.Add(this.Btn_RetourVisuel);
            this.Controls.Add(this.txtTitre2);
            this.Controls.Add(this.Img_LogoOX);
            this.Controls.Add(this.Img_previewUserReconnu);
            this.Name = "IdentificationVisuel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Load += new System.EventHandler(this.identificationVisuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_previewUserReconnu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_identificationVisuelPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_LogoOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}