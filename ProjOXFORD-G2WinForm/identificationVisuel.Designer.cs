using WebEye.Controls.WinForms.WebCameraControl;

namespace ProjOXFORD_G2WinForm

{
    partial class identificationVisuel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.Txt_Titre2 = new System.Windows.Forms.Label();
            this.Img_LogoOX = new System.Windows.Forms.PictureBox();
            this.Webcam = new WebEye.Controls.WinForms.WebCameraControl.WebCameraControl();
            this.Btn_RetourVisuel = new MetroFramework.Controls.MetroButton();
            this.Btn_VérifierVisuel = new MetroFramework.Controls.MetroButton();
            this.Cam_Visuel1 = new WebEye.Controls.WinForms.WebCameraControl.WebCameraControl();
            this.List_Camera = new System.Windows.Forms.ListBox();
            this.Img_identificationVisuelPreview = new System.Windows.Forms.PictureBox();
            this.Load_identificationVisuel = new MetroFramework.Controls.MetroProgressSpinner();
            this.Txt_chargementMetro = new MetroFramework.Controls.MetroLabel();
            this.Lbl_infoutilisateur = new System.Windows.Forms.Label();
            this.Img_previewUserReconnu = new System.Windows.Forms.PictureBox();
            this.Btn_continuerToMdp = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Img_LogoOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_identificationVisuelPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_previewUserReconnu)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Titre2
            // 
            this.Txt_Titre2.AutoSize = true;
            this.Txt_Titre2.Font = new System.Drawing.Font("Roboto Th", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titre2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Txt_Titre2.Location = new System.Drawing.Point(513, 41);
            this.Txt_Titre2.Name = "Txt_Titre2";
            this.Txt_Titre2.Size = new System.Drawing.Size(894, 65);
            this.Txt_Titre2.TabIndex = 1;
            this.Txt_Titre2.Text = "Merci de vous placer face à la camera";
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
            // Webcam
            // 
            this.Webcam.Location = new System.Drawing.Point(0, 0);
            this.Webcam.Name = "Webcam";
            this.Webcam.Size = new System.Drawing.Size(150, 150);
            this.Webcam.TabIndex = 0;
            // 
            // Btn_RetourVisuel
            // 
            this.Btn_RetourVisuel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_RetourVisuel.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Btn_RetourVisuel.Location = new System.Drawing.Point(25, 925);
            this.Btn_RetourVisuel.Name = "Btn_RetourVisuel";
            this.Btn_RetourVisuel.Size = new System.Drawing.Size(301, 113);
            this.Btn_RetourVisuel.Style = MetroFramework.MetroColorStyle.Silver;
            this.Btn_RetourVisuel.TabIndex = 2;
            this.Btn_RetourVisuel.Text = "Retour";
            this.Btn_RetourVisuel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Btn_RetourVisuel.UseSelectable = true;
            this.Btn_RetourVisuel.Click += new System.EventHandler(this.Btn_RetourVisuel_Click);
            // 
            // Btn_VérifierVisuel
            // 
            this.Btn_VérifierVisuel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_VérifierVisuel.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Btn_VérifierVisuel.Location = new System.Drawing.Point(23, 779);
            this.Btn_VérifierVisuel.Name = "Btn_VérifierVisuel";
            this.Btn_VérifierVisuel.Size = new System.Drawing.Size(301, 116);
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
            this.List_Camera.Location = new System.Drawing.Point(349, 969);
            this.List_Camera.Name = "List_Camera";
            this.List_Camera.Size = new System.Drawing.Size(1222, 69);
            this.List_Camera.TabIndex = 5;
            this.List_Camera.SelectedIndexChanged += new System.EventHandler(this.List_Camera_SelectedIndexChanged);
            // 
            // Img_identificationVisuelPreview
            // 
            this.Img_identificationVisuelPreview.Location = new System.Drawing.Point(0, 433);
            this.Img_identificationVisuelPreview.Name = "Img_identificationVisuelPreview";
            this.Img_identificationVisuelPreview.Size = new System.Drawing.Size(390, 304);
            this.Img_identificationVisuelPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_identificationVisuelPreview.TabIndex = 6;
            this.Img_identificationVisuelPreview.TabStop = false;
            // 
            // Load_identificationVisuel
            // 
            this.Load_identificationVisuel.Location = new System.Drawing.Point(774, 403);
            this.Load_identificationVisuel.Maximum = 100;
            this.Load_identificationVisuel.Name = "Load_identificationVisuel";
            this.Load_identificationVisuel.Size = new System.Drawing.Size(368, 350);
            this.Load_identificationVisuel.TabIndex = 7;
            this.Load_identificationVisuel.UseSelectable = true;
            // 
            // Txt_chargementMetro
            // 
            this.Txt_chargementMetro.AutoSize = true;
            this.Txt_chargementMetro.Location = new System.Drawing.Point(575, 548);
            this.Txt_chargementMetro.Name = "Txt_chargementMetro";
            this.Txt_chargementMetro.Size = new System.Drawing.Size(193, 19);
            this.Txt_chargementMetro.TabIndex = 8;
            this.Txt_chargementMetro.Text = "IDENTIFICATION DE LA PHOTO";
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
            // Img_previewUserReconnu
            // 
            this.Img_previewUserReconnu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Img_previewUserReconnu.Location = new System.Drawing.Point(545, 326);
            this.Img_previewUserReconnu.Name = "Img_previewUserReconnu";
            this.Img_previewUserReconnu.Size = new System.Drawing.Size(830, 484);
            this.Img_previewUserReconnu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img_previewUserReconnu.TabIndex = 11;
            this.Img_previewUserReconnu.TabStop = false;
            this.Img_previewUserReconnu.Click += new System.EventHandler(this.Img_previewUserReconnu_Click);
            // 
            // Btn_continuerToMdp
            // 
            this.Btn_continuerToMdp.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Btn_continuerToMdp.Location = new System.Drawing.Point(349, 969);
            this.Btn_continuerToMdp.Name = "Btn_continuerToMdp";
            this.Btn_continuerToMdp.Size = new System.Drawing.Size(1222, 69);
            this.Btn_continuerToMdp.TabIndex = 12;
            this.Btn_continuerToMdp.Text = "Continuer";
            this.Btn_continuerToMdp.UseSelectable = true;
            this.Btn_continuerToMdp.Click += new System.EventHandler(this.Btn_continuerToMdp_Click);
            // 
            // identificationVisuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Btn_continuerToMdp);
            this.Controls.Add(this.Img_previewUserReconnu);
            this.Controls.Add(this.Lbl_infoutilisateur);
            this.Controls.Add(this.Txt_chargementMetro);
            this.Controls.Add(this.Load_identificationVisuel);
            this.Controls.Add(this.Img_identificationVisuelPreview);
            this.Controls.Add(this.List_Camera);
            this.Controls.Add(this.Cam_Visuel1);
            this.Controls.Add(this.Btn_VérifierVisuel);
            this.Controls.Add(this.Btn_RetourVisuel);
            this.Controls.Add(this.Txt_Titre2);
            this.Controls.Add(this.Img_LogoOX);
            this.Name = "identificationVisuel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Load += new System.EventHandler(this.identificationVisuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_LogoOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_identificationVisuelPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_previewUserReconnu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_LogoOX;
        private System.Windows.Forms.Label Txt_Titre2;
        private WebCameraControl Webcam;
        private MetroFramework.Controls.MetroButton Btn_RetourVisuel;
        private MetroFramework.Controls.MetroButton Btn_VérifierVisuel;
        private WebCameraControl Cam_Visuel1;
        private System.Windows.Forms.ListBox List_Camera;
        private System.Windows.Forms.PictureBox Img_identificationVisuelPreview;
        private MetroFramework.Controls.MetroProgressSpinner Load_identificationVisuel;
        private MetroFramework.Controls.MetroLabel Txt_chargementMetro;
        private System.Windows.Forms.Label Lbl_infoutilisateur;
        private System.Windows.Forms.PictureBox Img_previewUserReconnu;
        private MetroFramework.Controls.MetroButton Btn_continuerToMdp;
    }
}