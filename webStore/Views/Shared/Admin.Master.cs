using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webStore.Models;

namespace webStore.Views.Shared
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Common.CheckLogin())
            {
                lbHelloUser.Text = Page.Session["user_name"].ToString();
            }
            else
            {
                Response.Redirect("/views/login.aspx");
            }
        }

       
    }
}