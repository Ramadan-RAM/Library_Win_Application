using System.Configuration;
using System;
using System.Data.SqlClient;
using System.Windows;
//using System.Data;
//using Microsoft.Azure.Documents;

namespace Library.DAL
{
    public class Userlogin
    {
        public static string connection = ConfigurationManager.ConnectionStrings["Library.Properties.Settings.ConnectionString"].ConnectionString;
        public static SqlConnection Conn = new SqlConnection(connection);
        public SqlCommand cmd = new SqlCommand();

        public static bool UserLogin(string username, string password)
        {
            bool valid = false;
            //SQL Login Query.
            string SQLloginQuery = "SELECT * FROM User_Info WHERE Username = @username AND User_Password = @password";
            SqlCommand cmdLogin = new SqlCommand(SQLloginQuery, Conn);
            _ = cmdLogin.Parameters.AddWithValue("@username", username);
            _ = cmdLogin.Parameters.AddWithValue("@password", password);
            try
            {

                Conn.Open();
                int result = (int)cmdLogin.ExecuteScalar();
                if (result > 0)
                {
                    valid = true;
                    _ = MessageBox.Show("Login success");
                }
                else
                {
                    _ = MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message.ToString();
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return valid;
        }

        //This is a method I use to get the user
        //public static User GetUserById(int userId
        //{
        //    string SQLreadQuery = "SELECT Username, Password, IsAdmin, UserCreatedDate " +
        //                          "FROM Users WHERE UserId = " + userId; //or SELECT ea column or *.
        //    SqlCommand cmdRead = new SqlCommand(SQLreadQuery, Conn);
        //    try
        //    {
        //        Conn.Open();
        //        SqlDataReader reader = cmdRead.ExecuteReader(CommandBehavior.SingleRow);
        //        if (reader.Read())
        //        {
        //            User user = new User()
        //            {
        //                user.UserID = Convert.ToInt32(reader["UserId"]),
        //                user.Username = reader["Username"].ToString(),
        //                user.Password = reader["Password"].ToString(),
        //                user.IsAdmin = Convert.ToBoolean(reader["IsAdmin"]),
        //                user.UserCreatedDate = Convert.ToDateTime(reader["UserCreatedDate"]);
        //        }
        //        return user;
        //    }
        //        else
        //    {
        //        return null;
        //    }
        //}
        //    catch (Exception ex)
        //    {
        //        ex.Message.ToString();
        //        return null;
        //    }
        //    finally
        //    {
        //        Conn.Close();
        //    }
    }
}