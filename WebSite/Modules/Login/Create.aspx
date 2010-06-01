<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Modules_Login_Create" %>

<%@ Register Assembly="AjaxControl" Namespace="AjaxControl" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="float: right">
        <cc1:ShowHideLinkButton ID="lnkHide" runat="server" Show="false" ContainnerID="#creatediv">Close</cc1:ShowHideLinkButton></div>
    <div style="float: left">
        <table>
            <tr>
                <td>
                    Username
                </td>
                <td>
                    <cc1:TextBox ID="txtUsername" runat="server"></cc1:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <cc1:TextBox ID="txtPassword" runat="server"></cc1:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Confirm password:
                </td>
                <td>
                    <cc1:TextBox ID="txtConfirmPassword" runat="server"></cc1:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Email:
                </td>
                <td>
                    <cc1:TextBox ID="txtEmail" runat="server"></cc1:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:RadioButtonList ID="RdbType" runat="server">
                        <asp:ListItem Text="College" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Student" Value="1"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <cc1:AjaxLinkButton ID="lnkCancel" runat="server">Cancel</cc1:AjaxLinkButton>
                    <cc1:AjaxLinkButton ID="AjaxLinkButton1" runat="server" OnAjaxClick="AjaxClick" PostBackUrl="~/Modules/Login/Create.aspx">Rohan Ajax</cc1:AjaxLinkButton>
                </td>
            </tr>
        </table>
    </div>
    <div style="clear: both">
    </div>
    <div id="PanelSuccess" runat="server">
    </div>
    </form>
</body>
</html>
