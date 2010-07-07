﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteUserInfo.aspx.cs"
    Inherits="College_Ajaxer_InstituteUserInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            New User</div>
        <div style="padding: 5px;">
            <div>
                <div>
                    <span class="label">Username</span>
                </div>
                <div>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Password</span>
                </div>
                <div>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    Email:
                </div>
                <div>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    User Type
                </div>
                <div>
                    <asp:DropDownList ID="ddUserType" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="gray">
            <aspajax:AjaxLinkButton ID="lnkUserAdd" runat="server" RequestContainner="#contentBox"
                ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
        </div>
    </div>
    </form>
</body>
</html>