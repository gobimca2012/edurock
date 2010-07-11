<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lander.aspx.cs" Inherits="User_AjaxControl_Lander" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding: 5px;">
        <ul>
            <li class="btn roundedall"><span class="ques"></span><span>
                <aspajax:HyperLink ID="lnkQ" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/QuestionInfoView.aspx">Questions</aspajax:HyperLink></span></li>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkExam" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/ExamInfoView.aspx">Exams</aspajax:HyperLink>
            </li>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="lnktut" runat="server" ContainnerID="#contentBox" NavigateUrl="~/All/Ajaxer/TutorialInfoView.aspx">Tutorials</aspajax:HyperLink></li>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkUsers" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/ICUserInfoView.aspx">Users</aspajax:HyperLink></li>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkHomeWork" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/HomeWorkInfoView.aspx">HomeWorks</aspajax:HyperLink></li>
            <li class="btn roundedall">Blog</li>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkImage" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/DocumentInfoView.aspx?dtype=1">Images</aspajax:HyperLink></li>
            <li class="btn roundedall">Audio</li>
            <li class="btn roundedall">video</li>
            <li class="btn roundedall">Document</li>
        </ul>
    </div>
    </form>
</body>
</html>
