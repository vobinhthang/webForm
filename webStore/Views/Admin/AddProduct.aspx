<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="webStore.Views.Admin.AddProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">Name</asp:Label>
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server">File image</asp:Label>
            <asp:FileUpload ID="file" runat="server"  />
            
        </div>
        <div>
            <asp:Button runat="server" Text="Upload" OnClick="Unnamed5_Click"/>
        </div>
        <div>
            <asp:Label ID="message" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
