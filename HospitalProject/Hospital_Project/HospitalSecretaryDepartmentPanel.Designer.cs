namespace Hospital_Project
{
    partial class HospitalSecretaryDepartmentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalSecretaryDepartmentPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdateDepartmentInformations = new System.Windows.Forms.Button();
            this.BtnDeleteDepartment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAddDepartment = new System.Windows.Forms.Button();
            this.TxtNewDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbNewDepartmentName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Secretary\'s Department Panel";
            // 
            // BtnUpdateDepartmentInformations
            // 
            this.BtnUpdateDepartmentInformations.BackColor = System.Drawing.Color.Pink;
            this.BtnUpdateDepartmentInformations.Location = new System.Drawing.Point(51, 338);
            this.BtnUpdateDepartmentInformations.Name = "BtnUpdateDepartmentInformations";
            this.BtnUpdateDepartmentInformations.Size = new System.Drawing.Size(511, 45);
            this.BtnUpdateDepartmentInformations.TabIndex = 29;
            this.BtnUpdateDepartmentInformations.Text = "Update Department Informations";
            this.BtnUpdateDepartmentInformations.UseVisualStyleBackColor = false;
            // 
            // BtnDeleteDepartment
            // 
            this.BtnDeleteDepartment.BackColor = System.Drawing.Color.Pink;
            this.BtnDeleteDepartment.Location = new System.Drawing.Point(319, 269);
            this.BtnDeleteDepartment.Name = "BtnDeleteDepartment";
            this.BtnDeleteDepartment.Size = new System.Drawing.Size(243, 45);
            this.BtnDeleteDepartment.TabIndex = 28;
            this.BtnDeleteDepartment.Text = "Delete Department";
            this.BtnDeleteDepartment.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(718, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 437);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Departments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnAddDepartment
            // 
            this.BtnAddDepartment.BackColor = System.Drawing.Color.Pink;
            this.BtnAddDepartment.Location = new System.Drawing.Point(51, 269);
            this.BtnAddDepartment.Name = "BtnAddDepartment";
            this.BtnAddDepartment.Size = new System.Drawing.Size(252, 45);
            this.BtnAddDepartment.TabIndex = 26;
            this.BtnAddDepartment.Text = "Add New Department";
            this.BtnAddDepartment.UseVisualStyleBackColor = false;
            // 
            // TxtNewDepartmentName
            // 
            this.TxtNewDepartmentName.Location = new System.Drawing.Point(352, 148);
            this.TxtNewDepartmentName.Name = "TxtNewDepartmentName";
            this.TxtNewDepartmentName.Size = new System.Drawing.Size(206, 32);
            this.TxtNewDepartmentName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Department Id:";
            // 
            // CmbNewDepartmentName
            // 
            this.CmbNewDepartmentName.FormattingEnabled = true;
            this.CmbNewDepartmentName.Location = new System.Drawing.Point(352, 190);
            this.CmbNewDepartmentName.Name = "CmbNewDepartmentName";
            this.CmbNewDepartmentName.Size = new System.Drawing.Size(206, 33);
            this.CmbNewDepartmentName.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Department Name:";
            // 
            // HospitalSecretaryDepartmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1278, 495);
            this.Controls.Add(this.CmbNewDepartmentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnUpdateDepartmentInformations);
            this.Controls.Add(this.BtnDeleteDepartment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAddDepartment);
            this.Controls.Add(this.TxtNewDepartmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HospitalSecretaryDepartmentPanel";
            this.Text = "HospitalSecretaryDepartmentPanel";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUpdateDepartmentInformations;
        private System.Windows.Forms.Button BtnDeleteDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAddDepartment;
        private System.Windows.Forms.TextBox TxtNewDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbNewDepartmentName;
        private System.Windows.Forms.Label label4;
    }
}