<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetProduct.aspx.cs" Inherits="webStore.Views.GetProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Repeater ID="rptProduct" runat="server">
        <ItemTemplate>
            <div  style="float:left;width:150px">
                <div style="text-align:center">
                    <asp:HyperLink runat="server" ID="linkThumbnail">
                        <img src="<%# ResolveUrl(Convert.ToString(Eval("Thumbnail"))) %>" style="width:100%"/>
                    </asp:HyperLink>
                </div>
                <div >
                    <asp:HyperLink runat="server" ID="linkName">
                        <%# Eval("Name") %>
                    </asp:HyperLink>
                </div>
                <div >
                    Price: 200$
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>
