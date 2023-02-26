
namespace ProiectPAW
{
    partial class AddSongForm
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
            this.btnSongSave = new System.Windows.Forms.Button();
            this.cbSongCategory = new System.Windows.Forms.ComboBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblSongCategory = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSongCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSongSave
            // 
            this.btnSongSave.BackColor = System.Drawing.Color.White;
            this.btnSongSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongSave.Location = new System.Drawing.Point(132, 165);
            this.btnSongSave.Name = "btnSongSave";
            this.btnSongSave.Size = new System.Drawing.Size(103, 33);
            this.btnSongSave.TabIndex = 13;
            this.btnSongSave.Text = "Save";
            this.btnSongSave.UseVisualStyleBackColor = false;
            this.btnSongSave.Click += new System.EventHandler(this.btnSongSave_Click);
            // 
            // cbSongCategory
            // 
            this.cbSongCategory.FormattingEnabled = true;
            this.cbSongCategory.Location = new System.Drawing.Point(200, 110);
            this.cbSongCategory.Name = "cbSongCategory";
            this.cbSongCategory.Size = new System.Drawing.Size(187, 24);
            this.cbSongCategory.TabIndex = 12;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(200, 76);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(187, 22);
            this.tbArtist.TabIndex = 11;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(200, 46);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(187, 22);
            this.tbTitle.TabIndex = 10;
            // 
            // lblSongCategory
            // 
            this.lblSongCategory.AutoSize = true;
            this.lblSongCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongCategory.Location = new System.Drawing.Point(96, 113);
            this.lblSongCategory.Name = "lblSongCategory";
            this.lblSongCategory.Size = new System.Drawing.Size(76, 19);
            this.lblSongCategory.TabIndex = 9;
            this.lblSongCategory.Text = "Category:";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(96, 79);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(53, 19);
            this.lblArtist.TabIndex = 8;
            this.lblArtist.Text = "Artist:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(96, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 19);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title:";
            this.lblTitle.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnSongCancel
            // 
            this.btnSongCancel.BackColor = System.Drawing.Color.White;
            this.btnSongCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongCancel.Location = new System.Drawing.Point(257, 165);
            this.btnSongCancel.Name = "btnSongCancel";
            this.btnSongCancel.Size = new System.Drawing.Size(103, 33);
            this.btnSongCancel.TabIndex = 14;
            this.btnSongCancel.Text = "Cancel";
            this.btnSongCancel.UseVisualStyleBackColor = false;
            this.btnSongCancel.Click += new System.EventHandler(this.btnSongCancel_Click);
            // 
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 251);
            this.Controls.Add(this.btnSongCancel);
            this.Controls.Add(this.btnSongSave);
            this.Controls.Add(this.cbSongCategory);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblSongCategory);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddSongForm";
            this.Text = "AddSongForm";
            this.Load += new System.EventHandler(this.AddSongForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSongSave;
        private System.Windows.Forms.ComboBox cbSongCategory;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblSongCategory;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSongCancel;
    }
}