<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webStore.Views.Admin.Default" %>
<asp:Content ID="ContentDefault" ContentPlaceHolderID="MainContentAdmin" runat="server">
   <form runat="server">
       <asp:DropDownList runat="server" ID="ddlProduct" OnSelectedIndexChanged="ddlProduct_SelectedIndexChanged"></asp:DropDownList>
        <asp:Label ID="lbMessages" runat="server" Text="abc"></asp:Label>
   </form>
</asp:Content>

