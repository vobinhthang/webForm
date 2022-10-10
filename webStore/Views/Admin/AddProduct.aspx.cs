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
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Product> products = ProductService.GetAll();
                DdlProduct.DataSource = products;
                DdlProduct.DataTextField = "Name";
                DdlProduct.DataValueField = "Id";
                DdlProduct.DataBind();
                DdlProduct.Items.Insert(0, "asv");
            }
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            
            string imageFolderPath = "~/Assets/img/";
            string imageFileName = string.Empty;
            if (file.HasFile)
            {
                imageFileName = file.FileName;
                string imageServerPath = Server.MapPath(imageFolderPath + imageFileName);
                file.SaveAs(imageServerPath);
                message.Text = "them file anh thanh cong";
            }
            else
            {
                message.Text = "Khong co file nao";
            }
            Product product = new Product
            {
                Name = tbName.Text,
                Thumbnail = imageFolderPath + imageFileName
            };

            ProductService.Create(product);
        }

        protected void DdlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMessages.Text = "hahahahha";
        }

    }
}