using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webStore.Models;
using webStore.Services.Clients.Users;

namespace webStore.Views.Admin
{
    public partial class GetAllUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<User> users = UserService.GetAll();
                tbUser.DataSource = users;
                tbUser.DataBind();
            }
        }

        protected void tbUser_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
            switch (e.CommandName.ToString())
            {
                case "Delete":
                    if (UserService.Delete(Convert.ToInt32(e.CommandArgument.ToString())))
                    {
                        Response.Redirect("/views/admin/getalluser");
                    }
                    else
                    {
                        Response.Write("loi");
                        Response.End();
                    }
                    break;
                case "Update":
                    Label lbPassword = (Label)e.Item.FindControl("lbPassword");
                    Page.Session["password"] = lbPassword.Text;
                    int _id= Convert.ToInt32(e.CommandArgument.ToString());
                    Page.Session["Id"] = _id;
                    Response.Redirect("/views/admin/updateuser");
                    break;

            }
        }
        
        protected void tbUser_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lbID =(Label) e.Item.FindControl("lbID");
            foreach (Button bt in e.Item.Controls.OfType<Button>())
            {
                if (bt.CommandName=="Delete")
                {
                    bt.Attributes["onclick"] = "return confirm('Bạn có muốn xóa tài khoản có Id là "+lbID.Text+"')";
                }
            }
        }

        
    }
}