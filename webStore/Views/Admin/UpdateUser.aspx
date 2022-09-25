<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="webStore.Views.Admin.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentAdmin" runat="server">
    <form  runat="server">
        <div class="form-group" runat="server">
            <label>Mật khẩu cũ</label>
            <asp:TextBox ID="password_old" runat="server" CssClass="form-control"  ></asp:TextBox>
        </div>
        <div class="form-group" runat="server">
            <label>Mật khẩu mới</label>
            <asp:TextBox runat="server" ID="password_new" CssClass="form-control" placeholder="Nhập mật khẩu mới"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validator" runat="server" ErrorMessage="Không được bỏ trống thông tin" ForeColor="Red" ControlToValidate="password_new"></asp:RequiredFieldValidator>
            <asp:Label runat="server" ID="lbMessage" ForeColor="Red"></asp:Label>
            
        </div>
        <asp:Button runat="server" ID="btnSave" OnClick="btnSave_Click"  CssClass="btn btn-primary" Text="Lưu"/>

    </form>
</asp:Content>
