<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccountSettingMenu.aspx.cs"
    Inherits="User_AjaxControl_AccountSettingMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="btn" style="float: left">
            <aspajax:HyperLink ID="lnkQ" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/UserInfoView.aspx"> Personal Info</aspajax:HyperLink></li>
            <%--<li><a href="#tabs-2">Education Info</a></li>--%>
        </div>
        <div class="btn" style="float: left">
            <aspajax:HyperLink ID="lnkChangePass" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/ChangePassword.aspx"> Change password</aspajax:HyperLink></li>
            <%--<li><a href="#tabs-2">Education Info</a></li>--%>
        </div>
        <div class="clear">
        </div>
    </div>
    </form>
</body>
</html>
