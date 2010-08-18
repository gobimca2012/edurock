<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="User_AjaxControl_ChangePassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="whitecont">
            <div id="divMessage" runat="server">
            </div>
            <div class="label">
                Current password
            </div>
            <div>
                <asp:TextBox ID="txtCurrentPassword" runat="server"></asp:TextBox>
            </div>
            <div class="label">
                New password
            </div>
            <div>
                <asp:TextBox ID="txtNewPassword" runat="server"></asp:TextBox>
            </div>
            <div class="label">
                Confirm password
            </div>
            <div>
                <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="btnChange" runat="server" EnableValidation="False" EnableViewState="False"
                    RequestContainner="#contentBox" ResponseContainner="#contentBox" Increment="False"
                    OnAjaxClick="AjaxChangePassword" Pagger="False"><div class="btn editbtn">Change</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
