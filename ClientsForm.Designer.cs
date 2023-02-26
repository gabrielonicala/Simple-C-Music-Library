
namespace ProiectPAW
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.lblClients = new System.Windows.Forms.Label();
            this.ClientDataView = new System.Windows.Forms.DataGridView();
            this.btnAddClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClients.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(491, 9);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(79, 27);
            this.lblClients.TabIndex = 0;
            this.lblClients.Text = "Clients";
            // 
            // ClientDataView
            // 
            this.ClientDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ClientDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataView.Location = new System.Drawing.Point(24, 67);
            this.ClientDataView.Name = "ClientDataView";
            this.ClientDataView.RowHeadersWidth = 51;
            this.ClientDataView.RowTemplate.Height = 24;
            this.ClientDataView.Size = new System.Drawing.Size(1003, 272);
            this.ClientDataView.TabIndex = 1;
            this.ClientDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientDataView_CellContentClick);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddClient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(453, 372);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(148, 36);
            this.btnAddClient.TabIndex = 3;
            this.btnAddClient.Text = "Add client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.ClientDataView);
            this.Controls.Add(this.lblClients);
            this.Name = "ClientsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.DataGridView ClientDataView;
        private System.Windows.Forms.Button btnAddClient;
    }
}

