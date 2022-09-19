using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using webStore.Models;

namespace webStore.Services.Clients.Users
{
    public class UserService
    {
        public static List<User> Login(string _username, string _password)
        {
            List<User> users = new List<User>();



            SqlConnection conn = ConnectionDb.GetConnection();
            
                string sql = "select username,password from [User] where username='" + _username + "' and password='" + _password + "'";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType=System.Data.CommandType.Text;
                

                conn.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                

                while (sqlDataReader.Read())
                {
                    User user = new User();
                    user.Username = Convert.ToString(sqlDataReader["username"]);
                    user.Password = Convert.ToString(sqlDataReader["password"]);
                    users.Add(user);
                }
                
                sqlDataReader.Close();
                ConnectionDb.Close(conn);
                conn.Dispose();
                return users;
            

           
        }

        public static bool Register(string _username,string _password)
        {
            
            SqlConnection conn = ConnectionDb.GetConnection();

            string sql = "insert into [User](username,password) values(@Username,@Password)";
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@Username", _username);
            sqlCommand.Parameters.AddWithValue("@Password", _password);
            int rs =sqlCommand.ExecuteNonQuery();
            if (rs > 0)
            {
                ConnectionDb.Close(conn);
                conn.Dispose();
                return true;
            }
            else
            {
                ConnectionDb.Close(conn);
                conn.Dispose();
                return false;
            }
            
        }
    }
}