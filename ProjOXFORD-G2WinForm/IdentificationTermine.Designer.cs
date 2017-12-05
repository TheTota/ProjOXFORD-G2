//-----------------------------------------------------------------------
// <copyright file="IdentificationTermine.Designer.cs" company="SIO">
//     Copyright (c) SIO. All rights reserved.
// </copyright>
// <author>Loïc DELAUNAY</author>
//-----------------------------------------------------------------------

namespace ProjOXFORD_G2WinForm
{
    /// <content> An identification termine. </content>
    public partial class IdentificationTermine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer _components = null;

        /// <summary> The picture box 1 control. </summary>
        private System.Windows.Forms.PictureBox pictureBox1;

        /// <summary> The text titre 2 control. </summary>
        private System.Windows.Forms.Label txtTitre2;

        /// <summary> The text infos control. </summary>
        private System.Windows.Forms.Label txtInfos;

        /// <summary> The picture box 2 control. </summary>
        private System.Windows.Forms.PictureBox pictureBox2;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentificationTermine));
            this.txtTitre2 = new System.Windows.Forms.Label();
            this.txtInfos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitre2
            // 
            this.txtTitre2.AutoSize = true;
            this.txtTitre2.Font = new System.Drawing.Font("Roboto Lt", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTitre2.Location = new System.Drawing.Point(549, 60);
            this.txtTitre2.Name = "Txt_Titre2";
            this.txtTitre2.Size = new System.Drawing.Size(764, 67);
            this.txtTitre2.TabIndex = 2;
            this.txtTitre2.Text = "Vous avez bien été authentifié";
            // 
            // txtInfos
            // 
            this.txtInfos.AutoSize = true;
            this.txtInfos.Font = new System.Drawing.Font("Roboto Th", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtInfos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInfos.Location = new System.Drawing.Point(718, 281);
            this.txtInfos.Name = "Txt_infos";
            this.txtInfos.Size = new System.Drawing.Size(484, 65);
            this.txtInfos.TabIndex = 3;
            this.txtInfos.Text = "Bienvenue M. \"nom\"";
            this.txtInfos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Controls.Add(this.txtInfos);
            this.Controls.Add(this.txtTitre2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IdentificationTermine";
            this.Load += new System.EventHandler(this.IdentificationTermine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}