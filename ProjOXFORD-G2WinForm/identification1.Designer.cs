//-----------------------------------------------------------------------
// <copyright file="Identification1.Designer.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Loïc DELAUNAY</author>
//-----------------------------------------------------------------------

namespace ProjOXFORD_G2WinForm
{
    /// <content> An identification 1. </content>
    public partial class Identification1
    {
        /// <summary> The image topper 1 control. </summary>
        private System.Windows.Forms.PictureBox imgTopper1;

        /// <summary> The text titre control. </summary>
        private System.Windows.Forms.Label txtTitre;

        /// <summary> The image unlock control. </summary>
        private System.Windows.Forms.PictureBox imgUnlock;

        /// <summary> The text sous titre 1 control. </summary>
        private System.Windows.Forms.Label txtSousTitre1;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.imgTopper1 = new System.Windows.Forms.PictureBox();
            this.txtTitre = new System.Windows.Forms.Label();
            this.imgUnlock = new System.Windows.Forms.PictureBox();
            this.txtSousTitre1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)this.imgTopper1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.imgUnlock).BeginInit();
            this.SuspendLayout();
            //// imgTopper1
            this.imgTopper1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgTopper1.Image = global::ProjOXFORD_G2WinForm.Properties.Resources.AccueilNew;
            this.imgTopper1.Location = new System.Drawing.Point(-1, -2);
            this.imgTopper1.Name = "imgTopper1";
            this.imgTopper1.Size = new System.Drawing.Size(1929, 1080);
            this.imgTopper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTopper1.TabIndex = 0;
            this.imgTopper1.TabStop = false;
            this.imgTopper1.Click += new System.EventHandler(this.Img_Topper1_Click);
            //// txtTitre
            this.txtTitre.AutoSize = true;
            this.txtTitre.BackColor = System.Drawing.Color.Transparent;
            this.txtTitre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtTitre.Font = new System.Drawing.Font("Roboto", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.txtTitre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTitre.Location = new System.Drawing.Point(564, 60);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(793, 115);
            this.txtTitre.TabIndex = 1;
            this.txtTitre.Text = "PROJET OXFORD";
            this.txtTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTitre.Click += new System.EventHandler(this.Txt_Titre_Click);
            //// imgUnlock
            this.imgUnlock.BackColor = System.Drawing.Color.Transparent;
            this.imgUnlock.Image = global::ProjOXFORD_G2WinForm.Properties.Resources._1cadena;
            this.imgUnlock.Location = new System.Drawing.Point(572, 296);
            this.imgUnlock.Name = "imgUnlock";
            this.imgUnlock.Size = new System.Drawing.Size(777, 505);
            this.imgUnlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUnlock.TabIndex = 2;
            this.imgUnlock.TabStop = false;
            this.imgUnlock.Click += new System.EventHandler(this.Img_Unlock_Click);
            //// txtSousTitre1
            this.txtSousTitre1.AutoSize = true;
            this.txtSousTitre1.Font = new System.Drawing.Font("Roboto Lt", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.txtSousTitre1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtSousTitre1.Location = new System.Drawing.Point(122, 919);
            this.txtSousTitre1.Name = "txtSousTitre1";
            this.txtSousTitre1.Size = new System.Drawing.Size(1677, 115);
            this.txtSousTitre1.TabIndex = 3;
            this.txtSousTitre1.Text = "APPUYER POUR VOUS AUTHENTIFIER";
            this.txtSousTitre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSousTitre1.Click += new System.EventHandler(this.Label1_Click);
            //// Identification1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.txtSousTitre1);
            this.Controls.Add(this.imgUnlock);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.imgTopper1);
            this.Name = "Identification1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)this.imgTopper1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.imgUnlock).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}