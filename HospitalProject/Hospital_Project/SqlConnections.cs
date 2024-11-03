using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Project
{
    internal class SqlConnections
    {
        public SqlConnection connect()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-1O31I5R\\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;

        }
    }
}
