using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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

                DataTable dt = UserService.TableDataAll();
                gvUser.DataSource = dt;
                gvUser.DataBind();
                ViewState["data"] = dt;
                ViewState["sort"] = "Asc";
            }
        }
        public List<int> ItemsInt()
        {
            List<int> list = new List<int>();

            for (int i = 5; i <= 20;i+=5 )
            {
                list.Add(i);
                
            }

            return list;
        }
        protected void gvUser_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dtrslt = (DataTable)ViewState["data"];
            if (dtrslt.Rows.Count > 0)
            {
                if (Convert.ToString(ViewState["sort"]) == "Asc")
                {
                    dtrslt.DefaultView.Sort = e.SortExpression + " Desc";
                    ViewState["sort"] = "Desc";
                    
                }
                else
                {
                    dtrslt.DefaultView.Sort = e.SortExpression + " Asc";
                    ViewState["sort"] = "Asc";
                }
                gvUser.DataSource = dtrslt;
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
            int _id = Convert.ToInt32(gvUser.DataKeys[e.NewEditIndex].Value);
            User user = UserService.GetUserById(_id);
            string strid = user.Id.ToString();
            Response.Redirect("/views/admin/updateuser?id="+ strid);
            
        }

        protected void gvUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text.ToString())) { 
                gvUser.PageSize = Convert.ToInt32(ddlPageSize.SelectedItem.ToString());
            List<User> users = UserService.GetAll();
            gvUser.PageIndex = e.NewPageIndex;
            gvUser.DataSource = users;
                gvUser.DataBind();
            }
            else
            {
                gvUser.PageSize = Convert.ToInt32(ddlPageSize.SelectedItem.ToString());
                string _search = tbSearch.Text.ToString();
                List<User> users = UserService.SearchUser(_search);
                gvUser.PageIndex = e.NewPageIndex;
                gvUser.DataSource = users;
                gvUser.DataBind();
            }
        }

        protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text.ToString()))
            {
                List<User> users = UserService.GetAll();
                gvUser.PageSize=Convert.ToInt32(ddlPageSize.SelectedItem.ToString());
            
                gvUser.PageIndex = 0;
                gvUser.DataSource = users;
                gvUser.DataBind();
            }
            else
            {
                string _search = tbSearch.Text.ToString();
                List<User> users = UserService.SearchUser(_search);
                gvUser.PageSize = Convert.ToInt32(ddlPageSize.SelectedItem.ToString());

                gvUser.PageIndex = 0;
                gvUser.DataSource = users;
                gvUser.DataBind();
            }

        }

        protected void tbSearch_TextChanged(object sender, EventArgs e)
        {

            string _search = tbSearch.Text.ToString();
            List<User> users = UserService.SearchUser(_search);
           
            gvUser.DataSource = users;
            gvUser.DataBind();
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
