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
        
        public static User GetUserById(int _id)
        {
            User user = null;

            SqlConnection conn = ConnectionDb.GetConnection();

            string sql = "select ID,username,password from [Users] where ID=@id";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            conn.Open();

            sqlCommand.Parameters.AddWithValue("@id", _id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                user = new User
                {
                    Id = Convert.ToInt32(sqlDataReader["ID"]),
                    Username = Convert.ToString(sqlDataReader["username"]),
                    Password = Convert.ToString(sqlDataReader["password"])
                };
            }

            sqlDataReader.Close();
            ConnectionDb.Close(conn);
            conn.Dispose();
            return user;
        }
        public static List<User> GetAll()
        {
            List<User> users = new List<User>();

            SqlConnection conn = ConnectionDb.GetConnection();

            string sql = "select ID,username,password from [Users]";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            conn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                User user = new User
                {
                    Id = Convert.ToInt32(sqlDataReader["ID"]),
                    Username = Convert.ToString(sqlDataReader["username"]),
                    Password = Convert.ToString(sqlDataReader["password"])
                };
                users.Add(user);
            }

            sqlDataReader.Close();
            ConnectionDb.Close(conn);
            conn.Dispose();
            return users;


        }
        public static List<User> Login(string _username, string _password)
        {
            List<User> users = new List<User>();



            SqlConnection conn = ConnectionDb.GetConnection();
            
                string sql = "select username,password from [Users] where username='" + _username + "' and password='" + _password + "'";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType=System.Data.CommandType.Text;
                
                conn.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
    
                if (sqlDataReader.Read())
                {
                    User user = new User
                    {
                        Username = Convert.ToString(sqlDataReader["username"]),
                        Password = Convert.ToString(sqlDataReader["password"])
                    };
                    users.Add(user);
                }
                
                sqlDataReader.Close();
                ConnectionDb.Close(conn);
                conn.Dispose();
                return users;
                       

        }

        public static bool Register(string _username,string _password)
        {
            try
            {

                SqlConnection conn = ConnectionDb.GetConnection();

                string sql = "insert into [Users](username,password) values(@Username,@Password)";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = System.Data.CommandType.Text;

                sqlCommand.Parameters.AddWithValue("@Username", _username);
                sqlCommand.Parameters.AddWithValue("@Password", _password);

                int rs = sqlCommand.ExecuteNonQuery();
                if (rs > 0)
                {
                    ConnectionDb.Close(conn);
                    conn.Dispose();
                    return true;
                }
                return false;

            }
            catch
            {
                return false;
            }
        }
        
        public static bool Delete(int _id)
        {
            SqlConnection conn = ConnectionDb.GetConnection();

            string sql = "delete from [Users] where ID=@Id";
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@Id", _id);

            int rs = sqlCommand.ExecuteNonQuery();
            if (rs > 0)
            {
                ConnectionDb.Close(conn);
                conn.Dispose();
                return true;
            }
            return false;
        }
        public static bool Update(int _id,string _password)
        {
            SqlConnection conn = ConnectionDb.GetConnection();

            string sql = "update [Users] set password=@password where ID=@Id";
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@password", _password);
            sqlCommand.Parameters.AddWithValue("@Id", _id);

            int rs = sqlCommand.ExecuteNonQuery();
            if (rs > 0)
            {
                ConnectionDb.Close(conn);
                conn.Dispose();
                return true;
            }
            return false;
        }

        public static bool CreateOrUpdate(User user)
        {
            SqlConnection conn = ConnectionDb.GetConnection();
            string sql = "";
            if (user.Id != 0)
            {
                sql = "update [Users] set username=@username,password=@password where ID=@Id";
            }
            else
            {
                sql = "insert into [Users](username,password) values(@username,@password)";
            }
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@username", user.Username);
            sqlCommand.Parameters.AddWithValue("@password", user.Password);
            sqlCommand.Parameters.AddWithValue("@Id", user.Id);

            int rs = sqlCommand.ExecuteNonQuery();
            if (rs > 0)
            {
                ConnectionDb.Close(conn);
                conn.Dispose();
                return true;
            }
            return false;
        }
    }
}