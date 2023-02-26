
namespace ProiectPAW
{
    partial class SongsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongsForm));
            this.SongsDataView = new System.Windows.Forms.DataGridView();
            this.AddSongInFormBtn = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblSongs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SongsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // SongsDataView
            // 
            this.SongsDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SongsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongsDataView.Location = new System.Drawing.Point(40, 62);
            this.SongsDataView.Name = "SongsDataView";
            this.SongsDataView.RowHeadersWidth = 51;
            this.SongsDataView.RowTemplate.Height = 24;
            this.SongsDataView.Size = new System.Drawing.Size(870, 321);
            this.SongsDataView.TabIndex = 0;
            this.SongsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SongsDataView_CellContentClick);
            // 
            // AddSongInFormBtn
            // 
            this.AddSongInFormBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddSongInFormBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSongInFormBtn.Location = new System.Drawing.Point(428, 401);
            this.AddSongInFormBtn.Name = "AddSongInFormBtn";
            this.AddSongInFormBtn.Size = new System.Drawing.Size(75, 37);
            this.AddSongInFormBtn.TabIndex = 1;
            this.AddSongInFormBtn.Text = "Add";
            this.AddSongInFormBtn.UseVisualStyleBackColor = false;
            this.AddSongInFormBtn.Click += new System.EventHandler(this.AddSongInFormBtn_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(744, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 34);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(835, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 34);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.BackColor = System.Drawing.Color.White;
            this.lblSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongs.Location = new System.Drawing.Point(47, 27);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(75, 25);
            this.lblSongs.TabIndex = 4;
            this.lblSongs.Text = "Songs:";
            // 
            // SongsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.AddSongInFormBtn);
            this.Controls.Add(this.SongsDataView);
            this.Name = "SongsForm";
            this.Text = "SongsForm";
            this.Load += new System.EventHandler(this.SongsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SongsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SongsDataView;
        private System.Windows.Forms.Button AddSongInFormBtn;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblSongs;
    }
}