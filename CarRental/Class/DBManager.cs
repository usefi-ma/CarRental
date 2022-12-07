using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Class
{
    public class DBManager
    {
        public string ConnectionString { get; set; }

        public DBManager()
        {
            ConnectionString = "data source =(local);initial catalog=MyCarRental;integrated security = true";
        }

        public bool ManageData(string queryString)
        {
            bool status = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                status = true;
            }
            return status;
        }

        public DataTable SelectData(string queryString)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            cmd = new SqlCommand(queryString, conn);
            var reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();
            return dt;
        }

    }
    
}
