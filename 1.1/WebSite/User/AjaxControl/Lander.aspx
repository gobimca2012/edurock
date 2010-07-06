<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lander.aspx.cs" Inherits="User_AjaxControl_Lander" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="display:block;padding:10px 0px;">
        <ul>
            <li class="gray roundedall">
                <aspajax:HyperLink ID="lnkQ" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/QuestionInfoView.aspx">Questions</aspajax:HyperLink></li>
            <li class="gray roundedall">Exam</li>
            <li class="gray roundedall">
                <aspajax:HyperLink ID="lnktut" runat="server" ContainnerID="#contentBox" NavigateUrl="~/All/Ajaxer/TutorialInfoView.aspx">Tutorials</aspajax:HyperLink></li>
            <li class="gray roundedall">
                <aspajax:HyperLink ID="lnkUsers" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/ICUserInfoView.aspx">Users</aspajax:HyperLink></li>
            <li class="gray roundedall">Home Work</li>
            <li class="gray roundedall">Blog</li>
            <li class="gray roundedall">Image</li>
            <li class="gray roundedall">Audio</li>
            <li class="gray roundedall">video</li>
            <li class="gray roundedall">Document</li>
        </ul>
    </div>
    </form>
</body>
</html>
