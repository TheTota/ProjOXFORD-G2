namespace ProjOXFORD_G2WinForm
{
    partial class identification1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Img_Topper1 = new System.Windows.Forms.PictureBox();
            this.Txt_Titre = new System.Windows.Forms.Label();
            this.Img_Unlock = new System.Windows.Forms.PictureBox();
            this.Txt_SousTitre1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Topper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Unlock)).BeginInit();
            this.SuspendLayout();
            // 
            // Img_Topper1
            // 
            this.Img_Topper1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Img_Topper1.Image = global::ProjOXFORD_G2WinForm.Properties.Resources._1topper;
            this.Img_Topper1.Location = new System.Drawing.Point(-1, 0);
            this.Img_Topper1.Name = "Img_Topper1";
            this.Img_Topper1.Size = new System.Drawing.Size(1252, 795);
            this.Img_Topper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Img_Topper1.TabIndex = 0;
            this.Img_Topper1.TabStop = false;
            this.Img_Topper1.Click += new System.EventHandler(this.Img_Topper1_Click);
            // 
            // Txt_Titre
            // 
            this.Txt_Titre.AutoSize = true;
            this.Txt_Titre.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Titre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Txt_Titre.Font = new System.Drawing.Font("Roboto", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Txt_Titre.Location = new System.Drawing.Point(224, 27);
            this.Txt_Titre.Name = "Txt_Titre";
            this.Txt_Titre.Size = new System.Drawing.Size(793, 115);
            this.Txt_Titre.TabIndex = 1;
            this.Txt_Titre.Text = "PROJET OXFORD";
            this.Txt_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Txt_Titre.Click += new System.EventHandler(this.Txt_Titre_Click);
            // 
            // Img_Unlock
            // 
            this.Img_Unlock.BackColor = System.Drawing.Color.Transparent;
            this.Img_Unlock.Image = global::ProjOXFORD_G2WinForm.Properties.Resources._1cadena;
            this.Img_Unlock.Location = new System.Drawing.Point(319, 281);
            this.Img_Unlock.Name = "Img_Unlock";
            this.Img_Unlock.Size = new System.Drawing.Size(626, 390);
            this.Img_Unlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_Unlock.TabIndex = 2;
            this.Img_Unlock.TabStop = false;
            this.Img_Unlock.Click += new System.EventHandler(this.Img_Unlock_Click);
            // 
            // Txt_SousTitre1
            // 
            this.Txt_SousTitre1.AutoSize = true;
            this.Txt_SousTitre1.Font = new System.Drawing.Font("Roboto Lt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SousTitre1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Txt_SousTitre1.Location = new System.Drawing.Point(213, 697);
            this.Txt_SousTitre1.Name = "Txt_SousTitre1";
            this.Txt_SousTitre1.Size = new System.Drawing.Size(837, 58);
            this.Txt_SousTitre1.TabIndex = 3;
            this.Txt_SousTitre1.Text = "APPUYER POUR VOUS AUTHENTIFIER";
            this.Txt_SousTitre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Txt_SousTitre1.Click += new System.EventHandler(this.label1_Click);
            // 
            // identification1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 784);
            this.Controls.Add(this.Txt_SousTitre1);
            this.Controls.Add(this.Img_Unlock);
            this.Controls.Add(this.Txt_Titre);
            this.Controls.Add(this.Img_Topper1);
            this.Name = "identification1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Topper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Unlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_Topper1;
        private System.Windows.Forms.Label Txt_Titre;
        private System.Windows.Forms.PictureBox Img_Unlock;
        private System.Windows.Forms.Label Txt_SousTitre1;
    }
}

