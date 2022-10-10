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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Product> products = ProductService.GetAll();
                ddlProduct.DataSource = products;
                ddlProduct.DataTextField = "Name";
                ddlProduct.DataValueField = "Id";
                ddlProduct.DataBind();
                ddlProduct.Items.Insert(0,"asv");
            }
        }

        protected void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMessages.Text = "hahahahha";
        }
    }
}