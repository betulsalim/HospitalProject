namespace Hospital_Project
{
    partial class HospitalDoctorUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalDoctorUpdate));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDoctorSurname = new System.Windows.Forms.TextBox();
            this.TxtDoctorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskTxtIdentityNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbDoctorDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Doctor Update Panel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Doctor Department:";
            // 
            // TxtDoctorSurname
            // 
            this.TxtDoctorSurname.Location = new System.Drawing.Point(468, 252);
            this.TxtDoctorSurname.Name = "TxtDoctorSurname";
            this.TxtDoctorSurname.Size = new System.Drawing.Size(227, 32);
            this.TxtDoctorSurname.TabIndex = 42;
            // 
            // TxtDoctorName
            // 
            this.TxtDoctorName.Location = new System.Drawing.Point(468, 175);
            this.TxtDoctorName.Name = "TxtDoctorName";
            this.TxtDoctorName.Size = new System.Drawing.Size(227, 32);
            this.TxtDoctorName.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Doctor Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Doctor Name:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(215, 592);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(480, 43);
            this.BtnUpdate.TabIndex = 38;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(468, 481);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(227, 32);
            this.TxtPassword.TabIndex = 37;
            // 
            // MskTxtIdentityNo
            // 
            this.MskTxtIdentityNo.Location = new System.Drawing.Point(468, 405);
            this.MskTxtIdentityNo.Mask = "00000000000";
            this.MskTxtIdentityNo.Name = "MskTxtIdentityNo";
            this.MskTxtIdentityNo.Size = new System.Drawing.Size(227, 32);
            this.MskTxtIdentityNo.TabIndex = 36;
            this.MskTxtIdentityNo.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Identity No:";
            // 
            // CmbDoctorDepartment
            // 
            this.CmbDoctorDepartment.FormattingEnabled = true;
            this.CmbDoctorDepartment.Location = new System.Drawing.Point(468, 328);
            this.CmbDoctorDepartment.Name = "CmbDoctorDepartment";
            this.CmbDoctorDepartment.Size = new System.Drawing.Size(227, 33);
            this.CmbDoctorDepartment.TabIndex = 45;
            // 
            // HospitalDoctorUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(902, 681);
            this.Controls.Add(this.CmbDoctorDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDoctorSurname);
            this.Controls.Add(this.TxtDoctorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskTxtIdentityNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HospitalDoctorUpdate";
            this.Text = "HospitalDoctorUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDoctorSurname;
        private System.Windows.Forms.TextBox TxtDoctorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskTxtIdentityNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbDoctorDepartment;
    }
}