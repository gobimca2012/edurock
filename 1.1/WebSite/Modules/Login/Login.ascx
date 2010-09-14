<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="Modules_Login_Login" %>
<div >
    <div>
        <div>
            <div style="color:#fff">
                Username :
            </div>
            <div>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>
        </div>
        <div>
            <div style="color:#fff">
                Password :
            </div>
            <div>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
        </div>
    </div>
    <div>
        <asp:LinkButton ID="lnkLogin" runat="server" OnClick="lnkLogin_Click"><div class="btnlogin"> </div></asp:LinkButton>
    </div>
</div>
