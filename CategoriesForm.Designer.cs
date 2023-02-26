
namespace ProiectPAW
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            this.CategoriesDataView = new System.Windows.Forms.DataGridView();
            this.lblCategories = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesDataView
            // 
            this.CategoriesDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CategoriesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDataView.Location = new System.Drawing.Point(56, 57);
            this.CategoriesDataView.Name = "CategoriesDataView";
            this.CategoriesDataView.RowHeadersWidth = 51;
            this.CategoriesDataView.RowTemplate.Height = 24;
            this.CategoriesDataView.Size = new System.Drawing.Size(471, 201);
            this.CategoriesDataView.TabIndex = 0;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.White;
            this.lblCategories.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(67, 20);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(101, 22);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "Categories:";
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 294);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.CategoriesDataView);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriesDataView;
        private System.Windows.Forms.Label lblCategories;
    }
}