<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="Modules_Login_Login" %>
<div class="contentbox" style="position: absolute;padding:5px;width:200px">
    <div>
        <div>
            <div>
                Username :
            </div>
            <div>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>
        </div>
        <div>
            <div>
                Password :
            </div>
            <div>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
        </div>
    </div>
    <div>
        <asp:LinkButton ID="lnkLogin" runat="server" OnClick="lnkLogin_Click"><div class="btn editbtn"> Login</div></asp:LinkButton>
    </div>
</div>
