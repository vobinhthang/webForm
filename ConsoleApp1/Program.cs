using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=THANG-PC\\SQLEXPRESS;Initial Catalog=webform;Persist Security Info=True;User ID=sa;Password=sa123");
            if (conn != null)
            {
                Console.WriteLine("thanh cong");
            }
            else
            {
                Console.WriteLine("that bai");
            }
        }
    }
}
