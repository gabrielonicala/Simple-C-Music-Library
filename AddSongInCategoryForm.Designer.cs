
namespace ProiectPAW
{
    partial class AddSongInCategoryForm
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
            this.lblASICTitle = new System.Windows.Forms.Label();
            this.lblASICArtist = new System.Windows.Forms.Label();
            this.btnSaveSongInCategory = new System.Windows.Forms.Button();
            this.btnCancelSongInCategory = new System.Windows.Forms.Button();
            this.tbTitleSongInCategory = new System.Windows.Forms.TextBox();
            this.tbArtistSongInCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblASICTitle
            // 
            this.lblASICTitle.AutoSize = true;
            this.lblASICTitle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASICTitle.Location = new System.Drawing.Point(99, 46);
            this.lblASICTitle.Name = "lblASICTitle";
            this.lblASICTitle.Size = new System.Drawing.Size(45, 19);
            this.lblASICTitle.TabIndex = 0;
            this.lblASICTitle.Text = "Title:";
            this.lblASICTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblASICArtist
            // 
            this.lblASICArtist.AutoSize = true;
            this.lblASICArtist.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASICArtist.Location = new System.Drawing.Point(99, 92);
            this.lblASICArtist.Name = "lblASICArtist";
            this.lblASICArtist.Size = new System.Drawing.Size(53, 19);
            this.lblASICArtist.TabIndex = 1;
            this.lblASICArtist.Text = "Artist:";
            // 
            // btnSaveSongInCategory
            // 
            this.btnSaveSongInCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveSongInCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSongInCategory.Location = new System.Drawing.Point(130, 146);
            this.btnSaveSongInCategory.Name = "btnSaveSongInCategory";
            this.btnSaveSongInCategory.Size = new System.Drawing.Size(75, 39);
            this.btnSaveSongInCategory.TabIndex = 2;
            this.btnSaveSongInCategory.Text = "Save";
            this.btnSaveSongInCategory.UseVisualStyleBackColor = false;
            this.btnSaveSongInCategory.Click += new System.EventHandler(this.btnSaveSongInCategory_Click);
            // 
            // btnCancelSongInCategory
            // 
            this.btnCancelSongInCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelSongInCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSongInCategory.Location = new System.Drawing.Point(235, 146);
            this.btnCancelSongInCategory.Name = "btnCancelSongInCategory";
            this.btnCancelSongInCategory.Size = new System.Drawing.Size(75, 39);
            this.btnCancelSongInCategory.TabIndex = 3;
            this.btnCancelSongInCategory.Text = "Cancel";
            this.btnCancelSongInCategory.UseVisualStyleBackColor = false;
            this.btnCancelSongInCategory.Click += new System.EventHandler(this.btnCancelSongInCategory_Click);
            // 
            // tbTitleSongInCategory
            // 
            this.tbTitleSongInCategory.Location = new System.Drawing.Point(173, 43);
            this.tbTitleSongInCategory.Name = "tbTitleSongInCategory";
            this.tbTitleSongInCategory.Size = new System.Drawing.Size(179, 22);
            this.tbTitleSongInCategory.TabIndex = 4;
            // 
            // tbArtistSongInCategory
            // 
            this.tbArtistSongInCategory.Location = new System.Drawing.Point(173, 89);
            this.tbArtistSongInCategory.Name = "tbArtistSongInCategory";
            this.tbArtistSongInCategory.Size = new System.Drawing.Size(179, 22);
            this.tbArtistSongInCategory.TabIndex = 5;
            // 
            // AddSongInCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(480, 208);
            this.Controls.Add(this.tbArtistSongInCategory);
            this.Controls.Add(this.tbTitleSongInCategory);
            this.Controls.Add(this.btnCancelSongInCategory);
            this.Controls.Add(this.btnSaveSongInCategory);
            this.Controls.Add(this.lblASICArtist);
            this.Controls.Add(this.lblASICTitle);
            this.Name = "AddSongInCategoryForm";
            this.Text = "AddSongInCategoryForm";
            this.Load += new System.EventHandler(this.AddSongInCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblASICTitle;
        private System.Windows.Forms.Label lblASICArtist;
        private System.Windows.Forms.Button btnSaveSongInCategory;
        private System.Windows.Forms.Button btnCancelSongInCategory;
        private System.Windows.Forms.TextBox tbTitleSongInCategory;
        private System.Windows.Forms.TextBox tbArtistSongInCategory;
    }
}