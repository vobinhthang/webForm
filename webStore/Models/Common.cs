using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webStore.Models
{
    public class Common
    {

        public static bool CheckLogin()
        {

            if (HttpContext.Current.Session["user_name"] == null)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
       
    }
   
}