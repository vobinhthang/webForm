﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webStore.Models;
using webStore.Services.Clients.Users;

namespace webStore.Views
{
    public partial class GetProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Product> products = ProductService.GetAll();
                rptProduct.DataSource = products;
                rptProduct.DataBind();
            }
        }
    }
}