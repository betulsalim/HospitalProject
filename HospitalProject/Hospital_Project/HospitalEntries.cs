﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HospitalPatientEntry patientEntryForm = new HospitalPatientEntry();
            patientEntryForm.Show();
            this.Hide();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            HospitalDoctorEntry doctorEntryForm = new HospitalDoctorEntry();
            doctorEntryForm.Show();
            this.Hide();
        }

        private void BtnSecretary_Click(object sender, EventArgs e)
        {
            HospitalSecretaryEntry secretaryEntryForm = new HospitalSecretaryEntry();
            secretaryEntryForm.Show();
            this.Hide();
        }
    }
}
