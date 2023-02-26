
namespace ProiectPAW
{
    partial class CategorySongsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorySongsForm));
            this.CategorySongFormDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CategorySongFormDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategorySongFormDataView
            // 
            this.CategorySongFormDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CategorySongFormDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategorySongFormDataView.Location = new System.Drawing.Point(34, 27);
            this.CategorySongFormDataView.Name = "CategorySongFormDataView";
            this.CategorySongFormDataView.RowHeadersWidth = 51;
            this.CategorySongFormDataView.RowTemplate.Height = 24;
            this.CategorySongFormDataView.Size = new System.Drawing.Size(591, 252);
            this.CategorySongFormDataView.TabIndex = 0;
            this.CategorySongFormDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CategorySongsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(665, 308);
            this.Controls.Add(this.CategorySongFormDataView);
            this.Name = "CategorySongsForm";
            this.Text = "SongsForm";
            this.Load += new System.EventHandler(this.CategorySongsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategorySongFormDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategorySongFormDataView;
    }
}