<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Modules_Login_Login" %>

<%@ Register Assembly="AjaxControl" Namespace="AjaxControl" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="float: right">
        <cc1:ShowHideLinkButton ID="lnkHide" runat="server" Show="false" ContainnerID="#logindiv">Close</cc1:ShowHideLinkButton></div>
    <div style="float: left">
        <table>
            <tr>
                <td>
                    Username :
                </td>
                <td>
                    <cc1:TextBox ID="txtUsername" runat="server"></cc1:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password :
                </td>
                <td>
                    <cc1:TextBox ID="txtPassword" runat="server"></cc1:TextBox>
                </td>
            </tr>
        </table>
        <div>
            <cc1:AjaxLinkButton ID="lnkLogin" runat="server" OnAjaxClick="LnkLoginAjaxClick"
                RequestContainner="#logindiv" ResponseContainner="#logindiv" PostBackUrl="~/Modules/Login/Login.aspx">Login</cc1:AjaxLinkButton>
        </div>
    </div>
    <div style="clear: both">
    </div>
    </form>
</body>
</html>
