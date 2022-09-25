using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webStore.Models;
using webStore.Services.Clients.Users;

namespace webStore.Views.Admin
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(HttpContext.Current.Session["password"].ToString()))
            {
                password_old.Text = Page.Session["password"].ToString();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            
            if (password_old.Text != password_new.Text)
            {
                
                if (UserService.Update(Convert.ToInt32(HttpContext.Current.Session["Id"]), password_new.Text.Trim()))
                {
                    Response.Redirect("/views/admin/getalluser");
                    
                }
            }
            else
            {
                lbMessage.Text = "Mật khẩu mới trùng với mật khẩu cũ";
            }
            
        }
    }
}