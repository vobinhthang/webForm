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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["webform"].ConnectionString);
            if (conn!=null)
            {
                
                return conn;

            }
            return null;
        }
        public static void Close(SqlConnection conn)
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}