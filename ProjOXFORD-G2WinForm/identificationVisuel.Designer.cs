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
            ((System.ComponentModel.ISupportInitialize)(this.Img_LogoOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_identificationVisuelPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Titre2
            // 
            this.Txt_Titre2.AutoSize = true;
            this.Txt_Titre2.Font = new System.Drawing.Font("Roboto Th", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titre2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Txt_Titre2.Location = new System.Drawing.Point(268, 60);
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
            this.Btn_RetourVisuel.Location = new System.Drawing.Point(23, 683);
            this.Btn_RetourVisuel.Name = "Btn_RetourVisuel";
            this.Btn_RetourVisuel.Size = new System.Drawing.Size(200, 50);
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
            this.Btn_VérifierVisuel.Location = new System.Drawing.Point(23, 599);
            this.Btn_VérifierVisuel.Name = "Btn_VérifierVisuel";
            this.Btn_VérifierVisuel.Size = new System.Drawing.Size(200, 50);
            this.Btn_VérifierVisuel.Style = MetroFramework.MetroColorStyle.Silver;
            this.Btn_VérifierVisuel.TabIndex = 3;
            this.Btn_VérifierVisuel.Text = "Vérifier";
            this.Btn_VérifierVisuel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Btn_VérifierVisuel.UseSelectable = true;
            this.Btn_VérifierVisuel.Click += new System.EventHandler(this.Btn_VérifierVisuel_Click);
            // 
            // Cam_Visuel1
            // 
            this.Cam_Visuel1.Location = new System.Drawing.Point(345, 153);
            this.Cam_Visuel1.Name = "Cam_Visuel1";
            this.Cam_Visuel1.Size = new System.Drawing.Size(830, 484);
            this.Cam_Visuel1.TabIndex = 4;
            this.Cam_Visuel1.Load += new System.EventHandler(this.Cam_Visuel1_Load);
            // 
            // List_Camera
            // 
            this.List_Camera.FormattingEnabled = true;
            this.List_Camera.Location = new System.Drawing.Point(354, 662);
            this.List_Camera.Name = "List_Camera";
            this.List_Camera.Size = new System.Drawing.Size(808, 69);
            this.List_Camera.TabIndex = 5;
            this.List_Camera.SelectedIndexChanged += new System.EventHandler(this.List_Camera_SelectedIndexChanged);
            // 
            // Img_identificationVisuelPreview
            // 
            this.Img_identificationVisuelPreview.Location = new System.Drawing.Point(23, 333);
            this.Img_identificationVisuelPreview.Name = "Img_identificationVisuelPreview";
            this.Img_identificationVisuelPreview.Size = new System.Drawing.Size(303, 234);
            this.Img_identificationVisuelPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_identificationVisuelPreview.TabIndex = 6;
            this.Img_identificationVisuelPreview.TabStop = false;
            // 
            // identificationVisuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 756);
            this.Controls.Add(this.Img_identificationVisuelPreview);
            this.Controls.Add(this.List_Camera);
            this.Controls.Add(this.Cam_Visuel1);
            this.Controls.Add(this.Btn_VérifierVisuel);
            this.Controls.Add(this.Btn_RetourVisuel);
            this.Controls.Add(this.Txt_Titre2);
            this.Controls.Add(this.Img_LogoOX);
            this.Name = "identificationVisuel";
            this.Load += new System.EventHandler(this.identificationVisuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_LogoOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_identificationVisuelPreview)).EndInit();
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
    }
}