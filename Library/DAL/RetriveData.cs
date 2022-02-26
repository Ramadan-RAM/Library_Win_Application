using System.Data;
using System.Data.SqlClient;

namespace Library.DAL
{
    internal class RetriveData
    {
        public static SqlConnection con = new SqlConnection(DBConnect.connection);
        public static DataTable Executequery(string text, CommandType com)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = con,
                CommandType = com,
                CommandText = text
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            _ = da.Fill(dt);
            return dt.Tables[0];
        }

        public static DataTable Executequery(string text, CommandType com, params Pararmeter[] paramarr)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = con,
                CommandType = com,
                CommandText = text
            };
            foreach (Pararmeter prm in paramarr)
            {
                cmd.Parameters.Add(prm.pname, prm.pdtype).Value = prm.pvalue;

            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            _ = da.Fill(dt);
            return dt.Tables[0];
        }

        public static void ExecuteNonquery(string text, params Pararmeter[] paramarr)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = con,
                CommandType = CommandType.StoredProcedure,
                CommandText = text
            };
            foreach (Pararmeter prm in paramarr)
            {
                cmd.Parameters.Add(prm.pname, prm.pdtype).Value = prm.pvalue;
            }
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                _ = cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
            }
        }

        public class Pararmeter
        {
            public string pname;
            public SqlDbType pdtype;
            public object pvalue;
            public Pararmeter(string pname, SqlDbType pdtype, object pvalue)
            {
                this.pname = pname;
                this.pdtype = pdtype;
                this.pvalue = pvalue;

            }

        }
    }
}
