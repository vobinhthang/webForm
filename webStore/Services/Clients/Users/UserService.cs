﻿using System;
using System.Collections.Generic;
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
            
            

            using (SqlConnection conn = ConnectionDb.GetConnection())
            {
                string sql = "select username,password from [User] where username='" + _username + "' and password='" + _password + "'";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType=System.Data.CommandType.Text;
                

                conn.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                User user;
                while (sqlDataReader.Read())
                {
                    user = new User
                    {
                        userName = Convert.ToString(sqlDataReader["username"]),
                        password = Convert.ToString(sqlDataReader["password"]),
                    };

                    users.Add(user);
                }
                sqlDataReader.Close();
                ConnectionDb.Close(conn);
                return users;
            }

           
        }
    }
}