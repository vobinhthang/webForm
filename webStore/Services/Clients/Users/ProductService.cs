using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using webStore.Models;

namespace webStore.Services.Clients.Users
{
    public class ProductService
    {
        public static void Create(Product product)
        {
            SqlConnection conn = ConnectionDb.GetConnection();
            string sql;
                sql = "insert into [Product](Name,Thumbnail) values(@name,@thumbnail)";
            
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@thumbnail", product.Thumbnail);
            int rs = sqlCommand.ExecuteNonQuery();
            if (rs > 0)
            {
                conn.Close();
                conn.Dispose();
                
            } 
        }
        public static List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            SqlConnection conn = ConnectionDb.GetConnection();

            string sql = "select Name,Thumbnail from [Product]";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            conn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Product product = new Product
                {
                    
                    Name = Convert.ToString(sqlDataReader["Name"]),
                    Thumbnail = Convert.ToString(sqlDataReader["Thumbnail"])
                };
                products.Add(product);
            }

            sqlDataReader.Close();
            conn.Close();
            conn.Dispose();
            return products;


        }
    }
}