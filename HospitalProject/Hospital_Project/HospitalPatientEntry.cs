using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hospital_Project
{
    public partial class HospitalPatientEntry : Form
    {
        public HospitalPatientEntry()
        {
            InitializeComponent();
        }

        SqlConnections SqlConnections = new SqlConnections();

        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HospitalPatientSignUp hospitalPatientSignUp = new HospitalPatientSignUp();
            hospitalPatientSignUp.Show();
            this.Hide();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Patients Where patient_identity = @patient_identity and patient_password=@patient_password", SqlConnections.connect());
            sqlCommand.Parameters.AddWithValue("@patient_identity", MskTxtIdentityNo.Text);
            sqlCommand.Parameters.AddWithValue("@patient_password", TxtPassword.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                HospitalPatientDetail patientDetailForm = new HospitalPatientDetail();
                patientDetailForm.identity = MskTxtIdentityNo.Text;
                patientDetailForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("!! The identity & password is wrong !!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            SqlConnections.connect().Close();

        }
    }
}
