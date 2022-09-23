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
            string sql = ConfigurationManager.ConnectionStrings["webForm"].ConnectionString;
            SqlConnection conn = new SqlConnection(sql);
            
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