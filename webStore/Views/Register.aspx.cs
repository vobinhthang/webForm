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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            
                if (password.Text.Trim().Equals(confirm.Text.Trim()))
                {
                    if (!UserService.Register(user_name.Text.Trim(), password.Text.Trim()))
                    {
                    ltrMessage.Text = "";
                    Response.Write("<script>alert('Tài khoản đăng ký đã tồn tại !')</script>");

                    }
                    else
                    {
                    ltrMessage.Text = "";
                    user_name.Text = "";
                    password.Text = "";
                    Response.Write("<script>alert('Đăng ký tài khoản thành công !')</script>");
                        
                    }
                }
                else
                {
                    ltrMessage.Text = "Mật khẩu nhập lại không đúng";
                }
            
            
        }
    }
}