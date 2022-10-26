<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" AutoEventWireup="true" CodeBehind="GetAllUser.aspx.cs" Inherits="webStore.Views.Admin.GetAllUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentAdmin" runat="server">
    <form runat="server">

        
                <div  class="container-fluid px-4">
        <h1 class="mt-4">Danh sách người dùng</h1>
        <ol class="breadcrumb mb-4">
            <li class="breadcrumb-item"><a href="/views/admin/">Quay lại</a></li>
            <li class="breadcrumb-item active">Quản lý người dùng</li>
        </ol>
        <asp:Button ID="btnCreate"   runat="server" CssClass="mr-4 mb-3 btn btn-success" Text="Tạo mới" OnClick="btnCreate_Click"/> 
        
            
            <asp:DropDownList  AutoPostBack="true" OnSelectedIndexChanged="ddlPageSize_SelectedIndexChanged"  SelectMethod="ItemsInt" Width="100px" runat="server" ID="ddlPageSize">
            
        </asp:DropDownList>
           
            <span style="margin-right:300px">thông tin trên một trang</span>
            
            <span >Sắp xếp theo tài khoản</span>
            <asp:DropDownList AutoPostBack="true" runat="server" ID="ddlSortUsername" OnSelectedIndexChanged="ddlSortUsername_SelectedIndexChanged">
                <asp:ListItem>Không</asp:ListItem>
                <asp:ListItem>Tăng dần</asp:ListItem>
                <asp:ListItem>Giảm dần</asp:ListItem>
            </asp:DropDownList>

             <asp:TextBox CssClass="mx-5" AutoPostBack="true" OnTextChanged="tbSearch_TextChanged" placeholder="Tìm kiếm"  runat="server" ID="tbSearch"></asp:TextBox>

            <asp:GridView OnSorting="gvUser_Sorting"  AllowSorting="true" OnPageIndexChanging="gvUser_PageIndexChanging"  PageSize="5" AllowPaging="True" CssClass="table" GridLines="None" ID="gvUser" runat ="server" EnableViewState="False" AutoGenerateColumns="False" OnRowDeleting="gvUser_RowDeleting" OnRowEditing="gvUser_RowEditing" DataKeyNames="ID" OnRowDataBound="gvUser_RowDataBound">
            <Columns >
                
                <asp:TemplateField  HeaderText="ID"  SortExpression="ID">
                    
                    <ItemTemplate >  
                    <asp:Label runat="server" ID="lbID" Text='<%#:Eval("ID")%>' Visible="false"></asp:Label>
                    <asp:Label runat="server" ID="lbPassword" Text='<%#:Eval("password")%>' Visible="false"></asp:Label>
                      <%#Eval("ID")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField  HeaderText="Tài khoản" >
                    <ItemTemplate>  
                          <a href="/views/admin/updateuser?id=<%#Eval("ID") %>"> <%#Eval("username") %></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField  HeaderText="Mật khẩu">
                    <ItemTemplate>  
                          <%#Eval("password")%>
                    </ItemTemplate>
                </asp:TemplateField>
              
                <asp:CommandField ShowDeleteButton="true" DeleteText="Xóa"  ButtonType="Button" ControlStyle-CssClass="btn btn-danger"  />
                <asp:CommandField ShowEditButton="true" UpdateText="Sửa"  ButtonType="Button" ControlStyle-CssClass="btn btn-warning"  />
            
               
            </Columns>
            <PagerSettings Mode="NumericFirstLast" PageButtonCount="3"/>
            
            <HeaderStyle CssClass="thead-dark"/>

      </asp:GridView>
           
       
        </div>
           
        
    </form>
</asp:Content>
 <%--<asp:Repeater id="tbUser" runat="server" OnItemCommand="tbUser_ItemCommand" OnItemDataBound="tbUser_ItemDataBound">
          <HeaderTemplate>
             <table class="table">
                <thead class="thead-dark">
                    <tr>
                        <th>ID</th>
                        <th>Tài khoản</th>
                        <th>Mật khẩu</th>
                        <th></th>
                    </tr>
                </thead>
          </HeaderTemplate>
          <ItemTemplate>
              <tbody>
                <tr>
                     <asp:Label runat="server" ID="lbID" Text='<%#:Eval("ID")%>' Visible="false"></asp:Label>
                    <asp:Label runat="server" ID="lbPassword" Text='<%#:Eval("password")%>' Visible="false"></asp:Label>
                    <td><%#Eval("ID") %></td>
                    <td><a href="#"><%#Eval("username") %></a> </td>
                    <td> <%#Eval("password") %> </td>
                    <td>
                        <asp:Button ID="btnDelete" CommandName="Delete" CommandArgument='<%#:Eval("ID")%>' runat="server" CssClass="mr-2 btn btn-danger" Text="Delete"/> 
                        <asp:Button ID="btnUpdate" CommandName="Update" CommandArgument='<%#:Eval("ID")%>' runat="server"  CssClass="ml-2 btn btn-warning" Text="Update"/> 
                    </td>
                </tr>
            </tbody>
          </ItemTemplate>
          <FooterTemplate>
             </table>
          </FooterTemplate>
       </asp:Repeater>--%>