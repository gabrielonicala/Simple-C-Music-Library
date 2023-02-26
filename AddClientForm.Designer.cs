
namespace ProiectPAW
{
    partial class AddClientForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblClientPreference = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.cbClientPreference = new System.Windows.Forms.ComboBox();
            this.btnClientSave = new System.Windows.Forms.Button();
            this.btnClientCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(34, 71);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 19);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblClientPreference
            // 
            this.lblClientPreference.AutoSize = true;
            this.lblClientPreference.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPreference.Location = new System.Drawing.Point(34, 100);
            this.lblClientPreference.Name = "lblClientPreference";
            this.lblClientPreference.Size = new System.Drawing.Size(137, 19);
            this.lblClientPreference.TabIndex = 2;
            this.lblClientPreference.Text = "Prefered category:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(177, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 22);
            this.tbName.TabIndex = 3;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(177, 68);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(180, 22);
            this.tbAge.TabIndex = 4;
            // 
            // cbClientPreference
            // 
            this.cbClientPreference.FormattingEnabled = true;
            this.cbClientPreference.Location = new System.Drawing.Point(177, 100);
            this.cbClientPreference.Name = "cbClientPreference";
            this.cbClientPreference.Size = new System.Drawing.Size(180, 24);
            this.cbClientPreference.TabIndex = 5;
            this.cbClientPreference.SelectedIndexChanged += new System.EventHandler(this.cbPreference_SelectedIndexChanged);
            // 
            // btnClientSave
            // 
            this.btnClientSave.BackColor = System.Drawing.Color.White;
            this.btnClientSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSave.Location = new System.Drawing.Point(67, 141);
            this.btnClientSave.Name = "btnClientSave";
            this.btnClientSave.Size = new System.Drawing.Size(121, 46);
            this.btnClientSave.TabIndex = 6;
            this.btnClientSave.Text = "Save";
            this.btnClientSave.UseVisualStyleBackColor = false;
            this.btnClientSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClientCancel
            // 
            this.btnClientCancel.BackColor = System.Drawing.Color.White;
            this.btnClientCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCancel.Location = new System.Drawing.Point(220, 141);
            this.btnClientCancel.Name = "btnClientCancel";
            this.btnClientCancel.Size = new System.Drawing.Size(121, 46);
            this.btnClientCancel.TabIndex = 7;
            this.btnClientCancel.Text = "Cancel";
            this.btnClientCancel.UseVisualStyleBackColor = false;
            this.btnClientCancel.Click += new System.EventHandler(this.btnClientCancel_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 209);
            this.Controls.Add(this.btnClientCancel);
            this.Controls.Add(this.btnClientSave);
            this.Controls.Add(this.cbClientPreference);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblClientPreference);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "AddClientForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblClientPreference;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.ComboBox cbClientPreference;
        private System.Windows.Forms.Button btnClientSave;
        private System.Windows.Forms.Button btnClientCancel;
    }
}