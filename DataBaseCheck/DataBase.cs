using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.DataBaseCheck
{
    class DataBase
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IO3D36PC;Initial Catalog=SportDB;Integrated Security=True;Encrypt=False");

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
