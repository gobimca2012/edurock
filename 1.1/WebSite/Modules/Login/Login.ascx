<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="Modules_Login_Login" %>
<div style="margin:20px 20px;line-height:40px;">
    <div id="divMessage" runat="server" style="width: 80%;line-height:0px">
    </div>
    <div>
        <div>
            <div style="color: #fff;font-weight:bold">
                Username 
            </div>
            <div>
                <asp:TextBox ID="txtUsername" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div>
            <div style="color: #fff;font-weight:bold">
                Password 
            </div>
            <div>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox>
            </div>
        </div>
    </div>
    <div style="text-align:left;margin-top:10px;">
        <asp:LinkButton ID="lnkLogin" runat="server" OnClick="lnkLogin_Click"><div class="loginbtn"> </div></asp:LinkButton>
    </div>
</div>
