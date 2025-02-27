using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SchoolAps
{
    internal class Koneksi
    {
        public static SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MSI;Initial Catalog=SekolahDB;Integrated Security=True";
            return conn;
        }
    }
}
