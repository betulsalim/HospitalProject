namespace Hospital_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnDoctor = new System.Windows.Forms.Button();
            this.BtnSecretary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatient.BackgroundImage")));
            this.BtnPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPatient.Location = new System.Drawing.Point(58, 257);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(173, 142);
            this.BtnPatient.TabIndex = 0;
            this.BtnPatient.UseVisualStyleBackColor = true;
            this.BtnPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoctor.BackgroundImage")));
            this.BtnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoctor.Location = new System.Drawing.Point(280, 257);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(179, 142);
            this.BtnDoctor.TabIndex = 1;
            this.BtnDoctor.UseVisualStyleBackColor = true;
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // BtnSecretary
            // 
            this.BtnSecretary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSecretary.BackgroundImage")));
            this.BtnSecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecretary.Location = new System.Drawing.Point(530, 257);
            this.BtnSecretary.Name = "BtnSecretary";
            this.BtnSecretary.Size = new System.Drawing.Size(174, 142);
            this.BtnSecretary.TabIndex = 2;
            this.BtnSecretary.UseVisualStyleBackColor = true;
            this.BtnSecretary.Click += new System.EventHandler(this.BtnSecretary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(532, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "AQUAMARINE  HOSPITAL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(400, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(741, 441);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSecretary);
            this.Controls.Add(this.BtnDoctor);
            this.Controls.Add(this.BtnPatient);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AQUAMARINE HOSPITAL ENTRY";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button BtnDoctor;
        private System.Windows.Forms.Button BtnSecretary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

