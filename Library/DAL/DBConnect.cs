
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Library.DAL
{
    internal class DBConnect
    {
        public static string connection = ConfigurationManager.
        ConnectionStrings["Library.Properties.Settings.ConnectionString"].ConnectionString;

        public static SqlConnection Conn = new SqlConnection(connection);

        public SqlCommand cmd = new SqlCommand();

        public DBConnect()
        {
            OpenConnection();
        }

        private void OpenConnection()
        {
            if (Conn.State != ConnectionState.Open)
            {

                Conn.Open();
            }
        }
    }
}
