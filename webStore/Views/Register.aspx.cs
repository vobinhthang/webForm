using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webStore.Models;
using webStore.Services.Clients.Users;

namespace webStore.Views
{
    public partial class Register : System.Web.UI.Page
    {
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {       
           if (!UserService.Register(user_name.Text.Trim(),password.Text.Trim()))
           {
                Response.Write("loi");
                Response.End();
            }
            else
            {
                Response.Write("complate");
                Response.End();
            }

        }
    }
}