namespace ProjOXFORD_G2WinForm
{
    partial class IdentificationTermine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentificationTermine));
            this.Txt_Titre2 = new System.Windows.Forms.Label();
            this.Txt_infos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Titre2
            // 
            this.Txt_Titre2.AutoSize = true;
            this.Txt_Titre2.Font = new System.Drawing.Font("Roboto Lt", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titre2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Txt_Titre2.Location = new System.Drawing.Point(549, 60);
            this.Txt_Titre2.Name = "Txt_Titre2";
            this.Txt_Titre2.Size = new System.Drawing.Size(764, 67);
            this.Txt_Titre2.TabIndex = 2;
            this.Txt_Titre2.Text = "Vous avez bien été authentifié";
            // 
            // Txt_infos
            // 
            this.Txt_infos.AutoSize = true;
            this.Txt_infos.Font = new System.Drawing.Font("Roboto Th", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_infos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Txt_infos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Txt_infos.Location = new System.Drawing.Point(718, 281);
            this.Txt_infos.Name = "Txt_infos";
            this.Txt_infos.Size = new System.Drawing.Size(484, 65);
            this.Txt_infos.TabIndex = 3;
            this.Txt_infos.Text = "Bienvenue M. \"nom\"";
            this.Txt_infos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(443, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1034, 641);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjOXFORD_G2WinForm.Properties.Resources.LogoOxford;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // IdentificationTermine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Txt_infos);
            this.Controls.Add(this.Txt_Titre2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IdentificationTermine";
            this.Load += new System.EventHandler(this.IdentificationTermine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Txt_Titre2;
        private System.Windows.Forms.Label Txt_infos;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}