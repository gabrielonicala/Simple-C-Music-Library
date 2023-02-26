
namespace ProiectPAW
{
    partial class Music_Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_Library));
            this.lblMusicLibrary = new System.Windows.Forms.Label();
            this.btnViewClients = new System.Windows.Forms.Button();
            this.btnViewCategories = new System.Windows.Forms.Button();
            this.btnViewSongs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMusicLibrary
            // 
            this.lblMusicLibrary.AutoSize = true;
            this.lblMusicLibrary.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicLibrary.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicLibrary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMusicLibrary.Location = new System.Drawing.Point(149, 15);
            this.lblMusicLibrary.Name = "lblMusicLibrary";
            this.lblMusicLibrary.Size = new System.Drawing.Size(394, 63);
            this.lblMusicLibrary.TabIndex = 0;
            this.lblMusicLibrary.Text = "Music Library";
            // 
            // btnViewClients
            // 
            this.btnViewClients.BackColor = System.Drawing.Color.White;
            this.btnViewClients.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewClients.Location = new System.Drawing.Point(256, 81);
            this.btnViewClients.Name = "btnViewClients";
            this.btnViewClients.Size = new System.Drawing.Size(149, 37);
            this.btnViewClients.TabIndex = 1;
            this.btnViewClients.Text = "View clients";
            this.btnViewClients.UseVisualStyleBackColor = false;
            this.btnViewClients.Click += new System.EventHandler(this.btnViewClients_Click);
            // 
            // btnViewCategories
            // 
            this.btnViewCategories.BackColor = System.Drawing.Color.White;
            this.btnViewCategories.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCategories.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewCategories.Location = new System.Drawing.Point(256, 124);
            this.btnViewCategories.Name = "btnViewCategories";
            this.btnViewCategories.Size = new System.Drawing.Size(149, 37);
            this.btnViewCategories.TabIndex = 2;
            this.btnViewCategories.Text = "View categories";
            this.btnViewCategories.UseVisualStyleBackColor = false;
            this.btnViewCategories.Click += new System.EventHandler(this.btnViewCategories_Click);
            // 
            // btnViewSongs
            // 
            this.btnViewSongs.BackColor = System.Drawing.Color.White;
            this.btnViewSongs.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSongs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewSongs.Location = new System.Drawing.Point(256, 167);
            this.btnViewSongs.Name = "btnViewSongs";
            this.btnViewSongs.Size = new System.Drawing.Size(149, 37);
            this.btnViewSongs.TabIndex = 3;
            this.btnViewSongs.Text = "View all songs";
            this.btnViewSongs.UseVisualStyleBackColor = false;
            this.btnViewSongs.Click += new System.EventHandler(this.btnViewSongs_Click);
            // 
            // Music_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 239);
            this.Controls.Add(this.btnViewSongs);
            this.Controls.Add(this.btnViewCategories);
            this.Controls.Add(this.btnViewClients);
            this.Controls.Add(this.lblMusicLibrary);
            this.Name = "Music_Library";
            this.Text = "Music_Library";
            this.Load += new System.EventHandler(this.Music_Library_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusicLibrary;
        private System.Windows.Forms.Button btnViewClients;
        private System.Windows.Forms.Button btnViewCategories;
        private System.Windows.Forms.Button btnViewSongs;
    }
}