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
            if (!IsPostBack)
            {
                List<User> users = UserService.GetAll();
                gvUser.DataSource = users;
                gvUser.DataBind();
            }
        }

        protected void gvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int _id = Convert.ToInt32(gvUser.DataKeys[e.RowIndex].Value);
            if (UserService.Delete(_id))
            {
                Response.Redirect("/views/admin/getalluser");
            }
            else
            {
                Response.Write("loi");
                Response.End();
            }
        }
        protected void gvUser_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lbID = (Label)e.Row.FindControl("lbID");
                foreach (Button bt in e.Row.Cells[3].Controls.OfType<Button>())
                {
                    if (bt.CommandName == "Delete")
                    {
                        bt.Attributes["onclick"] = "if(!confirm('Do you want to delete with ID: " + lbID.Text + "?')){ return false; };";

                    }
                }
            }


        }
        
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("/views/admin/updateuser");
        }

        protected void gvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {

            User user = UserService.GetId();
            string _id = user.Id.ToString();
            Response.Redirect("/views/admin/updateuser?id="+_id);
            
        }




        //protected void tbUser_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    Label lbID =(Label) e.Item.FindControl("lbID");
        //    foreach (Button bt in e.Item.Controls.OfType<Button>())
        //    {
        //        if (bt.CommandName=="Delete")
        //        {
        //            bt.Attributes["onclick"] = "return confirm('Bạn có muốn xóa tài khoản có Id là "+lbID.Text+"')";
        //        }
        //    }
        //}


        //protected void tbUser_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{

        //    switch (e.CommandName.ToString())
        //    {
        //        case "Delete":
        //            if (UserService.Delete(Convert.ToInt32(e.CommandArgument.ToString())))
        //            {
        //                Response.Redirect("/views/admin/getalluser");
        //            }
        //            else
        //            {
        //                Response.Write("loi");
        //                Response.End();
        //            }
        //            break;
        //        case "Update":
        //            Label lbPassword = (Label)e.Item.FindControl("lbPassword");
        //            Page.Session["password"] = lbPassword.Text;
        //            int _id= Convert.ToInt32(e.CommandArgument.ToString());
        //            Page.Session["Id"] = _id;
        //            Response.Redirect("/views/admin/updateuser");
        //            break;

        //    }
        //}




    }
}
