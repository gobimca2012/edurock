<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="Modules_Login_Login" %>
<div class="contentbox" style="position: absolute;padding:5px;">
    <table>
        <tr>
            <td>
                Username :
            </td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Password :
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <div>
        <asp:LinkButton ID="lnkLogin" runat="server" OnClick="lnkLogin_Click"><div class="btn"> Login</div></asp:LinkButton>
    </div>
</div>
