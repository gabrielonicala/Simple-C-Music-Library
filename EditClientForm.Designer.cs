
namespace ProiectPAW
{
    partial class EditClientForm
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
            this.lblEditClientName = new System.Windows.Forms.Label();
            this.lblEditClientAge = new System.Windows.Forms.Label();
            this.lblEditClientPreferences = new System.Windows.Forms.Label();
            this.tbEditClientAge = new System.Windows.Forms.TextBox();
            this.tbEditClientName = new System.Windows.Forms.TextBox();
            this.btnSaveEditClient = new System.Windows.Forms.Button();
            this.cbEditClientPreference = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEditClientName
            // 
            this.lblEditClientName.AutoSize = true;
            this.lblEditClientName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientName.Location = new System.Drawing.Point(57, 38);
            this.lblEditClientName.Name = "lblEditClientName";
            this.lblEditClientName.Size = new System.Drawing.Size(54, 19);
            this.lblEditClientName.TabIndex = 0;
            this.lblEditClientName.Text = "Name:";
            // 
            // lblEditClientAge
            // 
            this.lblEditClientAge.AutoSize = true;
            this.lblEditClientAge.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientAge.Location = new System.Drawing.Point(57, 73);
            this.lblEditClientAge.Name = "lblEditClientAge";
            this.lblEditClientAge.Size = new System.Drawing.Size(41, 19);
            this.lblEditClientAge.TabIndex = 1;
            this.lblEditClientAge.Text = "Age:";
            // 
            // lblEditClientPreferences
            // 
            this.lblEditClientPreferences.AutoSize = true;
            this.lblEditClientPreferences.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClientPreferences.Location = new System.Drawing.Point(57, 112);
            this.lblEditClientPreferences.Name = "lblEditClientPreferences";
            this.lblEditClientPreferences.Size = new System.Drawing.Size(97, 19);
            this.lblEditClientPreferences.TabIndex = 2;
            this.lblEditClientPreferences.Text = "Preferences:";
            // 
            // tbEditClientAge
            // 
            this.tbEditClientAge.Location = new System.Drawing.Point(152, 73);
            this.tbEditClientAge.Name = "tbEditClientAge";
            this.tbEditClientAge.Size = new System.Drawing.Size(144, 22);
            this.tbEditClientAge.TabIndex = 4;
            // 
            // tbEditClientName
            // 
            this.tbEditClientName.Location = new System.Drawing.Point(152, 33);
            this.tbEditClientName.Name = "tbEditClientName";
            this.tbEditClientName.Size = new System.Drawing.Size(144, 22);
            this.tbEditClientName.TabIndex = 5;
            // 
            // btnSaveEditClient
            // 
            this.btnSaveEditClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveEditClient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditClient.Location = new System.Drawing.Point(127, 160);
            this.btnSaveEditClient.Name = "btnSaveEditClient";
            this.btnSaveEditClient.Size = new System.Drawing.Size(96, 35);
            this.btnSaveEditClient.TabIndex = 6;
            this.btnSaveEditClient.Text = "Save";
            this.btnSaveEditClient.UseVisualStyleBackColor = false;
            this.btnSaveEditClient.Click += new System.EventHandler(this.btnSaveEditClient_Click);
            // 
            // cbEditClientPreference
            // 
            this.cbEditClientPreference.FormattingEnabled = true;
            this.cbEditClientPreference.Location = new System.Drawing.Point(153, 112);
            this.cbEditClientPreference.Name = "cbEditClientPreference";
            this.cbEditClientPreference.Size = new System.Drawing.Size(143, 24);
            this.cbEditClientPreference.TabIndex = 7;
            this.cbEditClientPreference.SelectedIndexChanged += new System.EventHandler(this.cbClientPreference_SelectedIndexChanged);
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(367, 223);
            this.Controls.Add(this.cbEditClientPreference);
            this.Controls.Add(this.btnSaveEditClient);
            this.Controls.Add(this.tbEditClientName);
            this.Controls.Add(this.tbEditClientAge);
            this.Controls.Add(this.lblEditClientPreferences);
            this.Controls.Add(this.lblEditClientAge);
            this.Controls.Add(this.lblEditClientName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "EditClientForm";
            this.Text = "EditClientForm";
            this.Load += new System.EventHandler(this.EditClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditClientName;
        private System.Windows.Forms.Label lblEditClientAge;
        private System.Windows.Forms.Label lblEditClientPreferences;
        private System.Windows.Forms.TextBox tbEditClientAge;
        private System.Windows.Forms.TextBox tbEditClientName;
        private System.Windows.Forms.Button btnSaveEditClient;
        private System.Windows.Forms.ComboBox cbEditClientPreference;
    }
}