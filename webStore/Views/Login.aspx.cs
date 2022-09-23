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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)

        {
            

            List<User> users = UserService.Login(user_name.Text.Trim(),password.Text.Trim());
            
            if (users.Count>0)
            {
                Page.Session["user_name"] = user_name.Text;
                Response.Redirect("/Views/Admin/");
                
            }         
            else
            {
               ltrMessage.Text = "Tài khoản hoặc mật khẩu không đúng";
                
            }

        }
    }
}
