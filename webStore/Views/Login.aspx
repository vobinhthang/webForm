<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="webStore.Views.Login" %>


<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Login</title>
        <link rel="stylesheet" href="/Assets/css/login.css">
        
    </head>
<body>
        <form id="form1" runat="server">
        <div class="content">
            <div class="panel">
                <div class="temp-login">
                    <div class="logo-user">
                        <img src="/Assets/img/user.png"/>
                    </div>
                    
                    <div class="user-name">
                        <div class="div">  
                            <asp:TextBox ID="user_name" runat="server" class="input" placeholder="User name"  ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="vali_user" runat="server" Font-Bold="true" ErrorMessage="*" Font-Size="20" ControlToValidate="user_name" ForeColor="Red">
                            </asp:RequiredFieldValidator> 
                        </div>
                    </div>
                    <br />
                    <div class="password">
                        <div class="div">
                            <asp:TextBox ID="password"   runat="server" type="password" class="input" placeholder="Password">
                            </asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="vali_pass" runat="server" Font-Bold="true" ErrorMessage="*" Font-Size="20" ControlToValidate="password" ForeColor="Red">
                            </asp:RequiredFieldValidator> 
                        </div>
                    </div>
                    <div class="message">
                        <asp:Literal runat="server" ID="ltrMessage"></asp:Literal>
                    </div>
                    <div class="submit" >
                        <div class="div-button">
                            
                            <asp:Button runat="server" Font-Size="18px" ForeColor="#00574f" Font-Bold="true" Text="Sign in" CssClass="button" OnClick="Unnamed1_Click" ID="btnLogin" EnableTheming="true" />
                        </div>
                    </div>
                    
                    <div class= "submit" style="margin-bottom:12px">
                        <div class="div-button">
                              <p class="text" style="font-size:15px;font-family:Arial;
                                        color:rgb(235, 235, 235)"> Can't remember your password? 
                                  <a href="#" style="color:rgb(235, 235, 235)">Recover it</a>
                              </p> 
                        </div>
                    </div>
                    <div style="height: 13.2%;border-top: solid 1px rgb(0,184,170);border-bottom-right-radius:10px;border-bottom-left-radius:10px"  >
                        <div class="div-button">
                              <p class="text" style="font-size:17px;font-family:Arial;color:white"> 
                                  Don't Have an Account? 
                                  <a href="/Views/Register.aspx" style="color:white">Create it</a>
                              </p> 
                        </div>
                    </div>   
                </div>
            </div>
        </div>

        </form>
        
        <script src="/Assets/js/common.js" >
              
        </script>
</body>
</html>
