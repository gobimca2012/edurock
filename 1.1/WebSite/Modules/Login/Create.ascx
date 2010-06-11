<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Create.ascx.cs" Inherits="Modules_Login_Create" %>
<div class="contentbox">
    <fieldset>
        <legend>LoginUser</legend>
        <table>
            <tr>
                <td>
                    <span class="label">LoginUserID</span>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <span class="label">Username</span>
                </td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span class="label">Password</span>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Email:
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span class="label">UserType</span>
                </td>
                <td>
                    <asp:RadioButtonList ID="RdbType" runat="server">
                        <asp:ListItem Text="College" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Student" Value="1"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
        </table>
        <div>
            <asp:LinkButton ID="lnkRegister" runat="server" OnClick="lnkRegister_Click">Register</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lnkCancel" runat="server">Cancel</asp:LinkButton>
        </div>
</div>
</fieldset> 