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
        int queryID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            queryID = Convert.ToInt32(Page.Request.QueryString["id"]);

            if (!Page.IsPostBack)
            {
                if (queryID > 0)
                {
                    lbTitle.Text = "Cập nhập người dùng";
                    User user = UserService.GetUserById(queryID);
                    
                    username.Text = user.Username;
                    password.Text = user.Password;
                    
                }
                else
                {
                    lbTitle.Text = "Thêm mới người dùng ";
                }
            }
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            
            user.Username = username.Text;
            user.Password = password.Text;
            if (UserService.CreateOrUpdate(user))
            {
                Response.Redirect("/views/admin/getalluser");
            }
        }
    }
}