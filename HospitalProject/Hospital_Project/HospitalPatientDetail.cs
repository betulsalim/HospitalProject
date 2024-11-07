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
    public partial class HospitalPatientDetail : Form
    {
        public HospitalPatientDetail()
        {
            InitializeComponent();
        }
        public string identity,patientName,patientSurname;
        SqlConnections SqlConnection = new SqlConnections();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctors.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select doctor_name,doctor_surname From Tbl_Doctors where doctor_department=@doctor_department",SqlConnection.connect());
            cmd.Parameters.AddWithValue("@doctor_department", CmbDepartment.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CmbDoctors.Items.Add(reader[0] + " " +  reader[1]);
            }
            SqlConnection.connect().Close();
        }

        
        private void HospitalPatientDetail_Load(object sender, EventArgs e)
        {
            LblPatientIdentity.Text = identity;

            //Name Surname ---Pull

            SqlCommand sqlCommand = new SqlCommand("Select patient_name,patient_surname From Tbl_Patients Where patient_identity = @patient_identity", SqlConnection.connect());
            sqlCommand.Parameters.AddWithValue("@patient_identity", LblPatientIdentity.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();  
            while (reader.Read())
            {
                LblPatientName.Text = reader[0].ToString();
                LblPatientSurname.Text = reader[1].ToString();
            }
            SqlConnection.connect().Close();

            //Appointment History

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Tbl_Appointments Where patient_identity=" + identity, SqlConnection.connect());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


            //Department ---Pull
            SqlCommand command = new SqlCommand("Select department_name From Tbl_Departments ", SqlConnection.connect());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CmbDepartment.Items.Add(sqlDataReader[0].ToString());
            }
            SqlConnection.connect().Close();
        }
    }
}
