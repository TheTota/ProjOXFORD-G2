namespace ProjOXFORD_G2WinForm
{
    partial class identificationMDP
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Titre3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // Txt_Titre3
            // 
            this.Txt_Titre3.AutoSize = true;
            this.Txt_Titre3.Font = new System.Drawing.Font("Roboto Th", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titre3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Txt_Titre3.Location = new System.Drawing.Point(268, 60);
            this.Txt_Titre3.Name = "Txt_Titre3";
            this.Txt_Titre3.Size = new System.Drawing.Size(810, 65);
            this.Txt_Titre3.TabIndex = 2;
            this.Txt_Titre3.Text = "Merci de saisir votre mot de passe";
            // 
            // identificationMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 756);
            this.Controls.Add(this.Txt_Titre3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "identificationMDP";
            this.Load += new System.EventHandler(this.identificationMDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Txt_Titre3;
    }
}