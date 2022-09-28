<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="webStore.Views.Admin.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentAdmin" runat="server">
    <form  runat="server">
        
        <div  class="container-fluid px-4">
            <asp:Label Font-Size="25px" Font-Bold="true"  CssClass="mt-5" runat="server" ID="lbTitle"></asp:Label>
        
        <div class="form-group" runat="server">
            <label>Tài khoản</label>
            <asp:TextBox ID="username" runat="server" CssClass="form-control"  placeholder="Nhập tài khoản" ></asp:TextBox>
        </div>
        <div class="form-group" runat="server">
            <label>Mật khẩu</label>
            <asp:TextBox runat="server" ID="password" CssClass="form-control" placeholder="Nhập mật khẩu"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validator" runat="server" ErrorMessage="Không được bỏ trống thông tin" ForeColor="Red" ControlToValidate="password"></asp:RequiredFieldValidator>
            <asp:Label runat="server" ID="lbMessage" ForeColor="Red"></asp:Label>
        </div>
        <asp:Button runat="server" ID="btnSave" OnClick="btnSave_Click"  CssClass="btn btn-primary" Text="Lưu"/>
            </div>
    </form>
</asp:Content>
