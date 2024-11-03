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
    public partial class HospitalPatientSignUp : Form
    {
        public HospitalPatientSignUp()
        {
            InitializeComponent();
        }

        SqlConnections SqlConnections = new SqlConnections();

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Patients (patient_name,patient_surname,patient_identity,patient_phone,patient_password,patient_gender) values (@patient_name,@patient_surname,@patient_identity,@patient_phone,@patient_password,@patient_gender)", SqlConnections.connect());
            sqlCommand.Parameters.AddWithValue("@patient_name",TxtPatientName.Text);
            sqlCommand.Parameters.AddWithValue("@patient_surname", TxtPatientSurname.Text);
            sqlCommand.Parameters.AddWithValue("@patient_identity", MskTxtIdentityNo.Text);
            sqlCommand.Parameters.AddWithValue("@patient_phone",MskTxtPatientPhone.Text);
            sqlCommand.Parameters.AddWithValue("@patient_password",TxtPassword.Text);
            sqlCommand.Parameters.AddWithValue("@patient_gender", CmbFemaleMale.Text);
           
            sqlCommand.ExecuteNonQuery();
            SqlConnections.connect().Close();
            MessageBox.Show("!! Patient Informations Added !! \n\nŞifreniz: " + TxtPassword.Text, "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
