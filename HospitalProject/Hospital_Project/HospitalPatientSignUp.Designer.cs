namespace Hospital_Project
{
    partial class HospitalPatientSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalPatientSignUp));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskTxtIdentityNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPatientName = new System.Windows.Forms.TextBox();
            this.TxtPatientSurname = new System.Windows.Forms.TextBox();
            this.MskTxtPatientPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbFemaleMale = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Sign Up Panel";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(372, 440);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(227, 32);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // MskTxtIdentityNo
            // 
            this.MskTxtIdentityNo.Location = new System.Drawing.Point(372, 364);
            this.MskTxtIdentityNo.Mask = "00000000000";
            this.MskTxtIdentityNo.Name = "MskTxtIdentityNo";
            this.MskTxtIdentityNo.Size = new System.Drawing.Size(227, 32);
            this.MskTxtIdentityNo.TabIndex = 4;
            this.MskTxtIdentityNo.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Identity No:";
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.Salmon;
            this.BtnSignUp.Location = new System.Drawing.Point(119, 585);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(480, 43);
            this.BtnSignUp.TabIndex = 9;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Patient Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Patient Surname:";
            // 
            // TxtPatientName
            // 
            this.TxtPatientName.Location = new System.Drawing.Point(372, 134);
            this.TxtPatientName.Name = "TxtPatientName";
            this.TxtPatientName.Size = new System.Drawing.Size(227, 32);
            this.TxtPatientName.TabIndex = 1;
            // 
            // TxtPatientSurname
            // 
            this.TxtPatientSurname.Location = new System.Drawing.Point(372, 211);
            this.TxtPatientSurname.Name = "TxtPatientSurname";
            this.TxtPatientSurname.Size = new System.Drawing.Size(227, 32);
            this.TxtPatientSurname.TabIndex = 2;
            // 
            // MskTxtPatientPhone
            // 
            this.MskTxtPatientPhone.Location = new System.Drawing.Point(372, 292);
            this.MskTxtPatientPhone.Mask = "(999) 000-00-00";
            this.MskTxtPatientPhone.Name = "MskTxtPatientPhone";
            this.MskTxtPatientPhone.Size = new System.Drawing.Size(227, 32);
            this.MskTxtPatientPhone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gender:";
            // 
            // CmbFemaleMale
            // 
            this.CmbFemaleMale.FormattingEnabled = true;
            this.CmbFemaleMale.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.CmbFemaleMale.Location = new System.Drawing.Point(372, 507);
            this.CmbFemaleMale.Name = "CmbFemaleMale";
            this.CmbFemaleMale.Size = new System.Drawing.Size(227, 33);
            this.CmbFemaleMale.TabIndex = 19;
            // 
            // HospitalPatientSignUp
            // 
            this.AcceptButton = this.BtnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(741, 679);
            this.Controls.Add(this.CmbFemaleMale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MskTxtPatientPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPatientSurname);
            this.Controls.Add(this.TxtPatientName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskTxtIdentityNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HospitalPatientSignUp";
            this.Text = "Hospital Patient Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskTxtIdentityNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPatientName;
        private System.Windows.Forms.TextBox TxtPatientSurname;
        private System.Windows.Forms.MaskedTextBox MskTxtPatientPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbFemaleMale;
    }
}