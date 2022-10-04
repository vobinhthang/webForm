using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webStore.Views.Admin
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            if (file.HasFile)
            {
                file.SaveAs(Server.MapPath("~/Assets/img/" +file.FileName));
                message.Text = "tem file anh thanh cong";
            }
            else
            {
                message.Text = "Khong co file nao";
            }
        }
    }
}