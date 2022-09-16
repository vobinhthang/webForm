using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace webStore.Models
{
    public class ConnectionDb
    {
        
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source=THANG-PC\\SQLEXPRESS; Initial Catalog=webform; User ID=sa;Password=sa123");
            if (conn!=null)
            {
                
                return conn;

            }
            return null;
        }
        public static void Close(SqlConnection conn)
        {
                conn.Close();
            
        }
    }
}