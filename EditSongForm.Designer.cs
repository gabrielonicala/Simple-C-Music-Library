
namespace ProiectPAW
{
    partial class EditSongForm
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
            this.lblEditSongTitle = new System.Windows.Forms.Label();
            this.lblEditSongArtist = new System.Windows.Forms.Label();
            this.lblEditSongCategory = new System.Windows.Forms.Label();
            this.tbEditSongTitle = new System.Windows.Forms.TextBox();
            this.tbEditSongArtist = new System.Windows.Forms.TextBox();
            this.cbEditSongCategory = new System.Windows.Forms.ComboBox();
            this.btnEditSongSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditSongTitle
            // 
            this.lblEditSongTitle.AutoSize = true;
            this.lblEditSongTitle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSongTitle.Location = new System.Drawing.Point(55, 36);
            this.lblEditSongTitle.Name = "lblEditSongTitle";
            this.lblEditSongTitle.Size = new System.Drawing.Size(45, 19);
            this.lblEditSongTitle.TabIndex = 0;
            this.lblEditSongTitle.Text = "Title:";
            // 
            // lblEditSongArtist
            // 
            this.lblEditSongArtist.AutoSize = true;
            this.lblEditSongArtist.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSongArtist.Location = new System.Drawing.Point(55, 79);
            this.lblEditSongArtist.Name = "lblEditSongArtist";
            this.lblEditSongArtist.Size = new System.Drawing.Size(53, 19);
            this.lblEditSongArtist.TabIndex = 1;
            this.lblEditSongArtist.Text = "Artist:";
            // 
            // lblEditSongCategory
            // 
            this.lblEditSongCategory.AutoSize = true;
            this.lblEditSongCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSongCategory.Location = new System.Drawing.Point(55, 123);
            this.lblEditSongCategory.Name = "lblEditSongCategory";
            this.lblEditSongCategory.Size = new System.Drawing.Size(76, 19);
            this.lblEditSongCategory.TabIndex = 2;
            this.lblEditSongCategory.Text = "Category:";
            // 
            // tbEditSongTitle
            // 
            this.tbEditSongTitle.Location = new System.Drawing.Point(135, 33);
            this.tbEditSongTitle.Name = "tbEditSongTitle";
            this.tbEditSongTitle.Size = new System.Drawing.Size(121, 22);
            this.tbEditSongTitle.TabIndex = 3;
            // 
            // tbEditSongArtist
            // 
            this.tbEditSongArtist.Location = new System.Drawing.Point(135, 76);
            this.tbEditSongArtist.Name = "tbEditSongArtist";
            this.tbEditSongArtist.Size = new System.Drawing.Size(121, 22);
            this.tbEditSongArtist.TabIndex = 4;
            // 
            // cbEditSongCategory
            // 
            this.cbEditSongCategory.FormattingEnabled = true;
            this.cbEditSongCategory.Location = new System.Drawing.Point(135, 120);
            this.cbEditSongCategory.Name = "cbEditSongCategory";
            this.cbEditSongCategory.Size = new System.Drawing.Size(121, 24);
            this.cbEditSongCategory.TabIndex = 5;
            // 
            // btnEditSongSave
            // 
            this.btnEditSongSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditSongSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSongSave.Location = new System.Drawing.Point(113, 173);
            this.btnEditSongSave.Name = "btnEditSongSave";
            this.btnEditSongSave.Size = new System.Drawing.Size(75, 30);
            this.btnEditSongSave.TabIndex = 6;
            this.btnEditSongSave.Text = "Save";
            this.btnEditSongSave.UseVisualStyleBackColor = false;
            this.btnEditSongSave.Click += new System.EventHandler(this.btnEditSongSave_Click);
            // 
            // EditSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(320, 231);
            this.Controls.Add(this.btnEditSongSave);
            this.Controls.Add(this.cbEditSongCategory);
            this.Controls.Add(this.tbEditSongArtist);
            this.Controls.Add(this.tbEditSongTitle);
            this.Controls.Add(this.lblEditSongCategory);
            this.Controls.Add(this.lblEditSongArtist);
            this.Controls.Add(this.lblEditSongTitle);
            this.Name = "EditSongForm";
            this.Text = "EditSongForm";
            this.Load += new System.EventHandler(this.EditSongForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditSongTitle;
        private System.Windows.Forms.Label lblEditSongArtist;
        private System.Windows.Forms.Label lblEditSongCategory;
        private System.Windows.Forms.TextBox tbEditSongTitle;
        private System.Windows.Forms.TextBox tbEditSongArtist;
        private System.Windows.Forms.ComboBox cbEditSongCategory;
        private System.Windows.Forms.Button btnEditSongSave;
    }
}