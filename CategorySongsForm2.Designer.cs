
namespace ProiectPAW
{
    partial class CategorySongsForm2
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
            this.CategorySongFormDataView2 = new System.Windows.Forms.DataGridView();
            this.btnASIC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategorySongFormDataView2)).BeginInit();
            this.SuspendLayout();
            // 
            // CategorySongFormDataView2
            // 
            this.CategorySongFormDataView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CategorySongFormDataView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategorySongFormDataView2.Location = new System.Drawing.Point(34, 34);
            this.CategorySongFormDataView2.Name = "CategorySongFormDataView2";
            this.CategorySongFormDataView2.RowHeadersWidth = 51;
            this.CategorySongFormDataView2.RowTemplate.Height = 24;
            this.CategorySongFormDataView2.Size = new System.Drawing.Size(592, 250);
            this.CategorySongFormDataView2.TabIndex = 0;
            // 
            // btnASIC
            // 
            this.btnASIC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnASIC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASIC.Location = new System.Drawing.Point(304, 302);
            this.btnASIC.Name = "btnASIC";
            this.btnASIC.Size = new System.Drawing.Size(75, 47);
            this.btnASIC.TabIndex = 1;
            this.btnASIC.Text = "Add";
            this.btnASIC.UseVisualStyleBackColor = false;
            this.btnASIC.Click += new System.EventHandler(this.btnASIC_Click);
            // 
            // CategorySongsForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 361);
            this.Controls.Add(this.btnASIC);
            this.Controls.Add(this.CategorySongFormDataView2);
            this.Name = "CategorySongsForm2";
            this.Text = "CategorySongsForm2";
            this.Load += new System.EventHandler(this.CategorySongsForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategorySongFormDataView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategorySongFormDataView2;
        private System.Windows.Forms.Button btnASIC;
    }
}