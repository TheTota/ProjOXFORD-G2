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
            ((System.ComponentModel.ISupportInitialize)(this.Img_LogoOX)).BeginInit();
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
            this.Txt_Titre2.Click += new System.EventHandler(this.Txt_Titre2_Click);
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
            this.Img_LogoOX.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Webcam
            // 
            this.Webcam.Location = new System.Drawing.Point(400, 400);
            this.Webcam.Name = "Webcam";
            this.Webcam.Size = new System.Drawing.Size(200, 200);
            this.Webcam.TabIndex = 5;
            // 
            // identificationVisuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 756);
            this.Controls.Add(this.Txt_Titre2);
            this.Controls.Add(this.Img_LogoOX);
            this.Name = "identificationVisuel";
            this.Load += new System.EventHandler(this.identificationVisuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_LogoOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_LogoOX;
        private System.Windows.Forms.Label Txt_Titre2;
        private WebCameraControl Webcam;
    }
}