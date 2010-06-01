<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Create.ascx.cs" Inherits="Modules_Login_Create" %>
<table>
    <tr>
        <td>
            Username
        </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Password:
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Confirm password:
        </td>
        <td>
            <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
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
            <asp:LinkButton ID="lnkCreate" runat="server">Add</asp:LinkButton>
        </td>
        <td>
            <asp:LinkButton ID="lnkCancel" runat="server">Cancel</asp:LinkButton>
        </td>
    </tr>
</table>
