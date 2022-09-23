<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="webStore.Views.Register" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Register</title>
    <link rel="stylesheet" href="/Assets/css/register.css">    
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
                    <div class="confirm">
                        <div class="div">
                            <asp:TextBox ID="confirm"   runat="server" type="password" class="input" placeholder="Confirm password">
                            </asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="vali_confirm" runat="server" Font-Bold="true" ErrorMessage="*" Font-Size="20" ControlToValidate="confirm" ForeColor="Red">
                            </asp:RequiredFieldValidator> 
                        </div>
                    </div>
                    <div class="message">
                        <asp:Literal runat="server" ID="ltrMessage"></asp:Literal>
                    </div>
                    <div class="submit" >
                        <div class="div-button">
                            
                            <asp:Button   runat="server" Font-Size="18px" ForeColor="#050724" Font-Bold="true" Text="Sign up" CssClass="button" ID="btnRegister" EnableTheming="False" OnClick="btnRegister_Click" />
                        </div>
                    </div>
                    
                    <div class= "submit" style="margin-bottom:12px">
                        <div class="div-button">
                              <p class="text" style="font-size:15px;font-family:Arial;
                                        color:rgb(235, 235, 235)"> By creating an account, you agree and accept <br />
                                                           our
                                  <a href="#" style="color:rgb(235, 235, 235)">Terms</a> and  <a href="#" style="color:rgb(235, 235, 235)"> Privacy Policy</a>.
                              </p> 
                        </div>
                    </div>
                    <div style="height: 13.2%;border-top: solid 1px white;border-bottom-right-radius:10px;border-bottom-left-radius:10px"  >
                        <div class="div-button">
                              <p class="text" style="font-size:17px;font-family:Arial;color:white"> 
                                  Already have an account? 
                                  <a href="/Views/Login.aspx" style="color:white" >Log in</a>.
                              </p> 
                        </div>
                    </div>   
                </div>
            </div>
        </div>

        
    </form>
</body>
</html>
