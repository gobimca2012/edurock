<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lander.aspx.cs" Inherits="User_AjaxControl_Lander" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <div class="btn fl fl roundedall tp" rel="Get All Update">
                <span class="ques">&nbsp;</span>
                <aspajax:HyperLink ID="lnkAll" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/QuestionInfoView.aspx">All</aspajax:HyperLink></div>
            <div class="btn fl roundedall">
                <span class="ques">&nbsp;</span>
                <aspajax:HyperLink ID="lnkQ" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/QuestionInfoView.aspx">Questions</aspajax:HyperLink></div>
            <div class="btn fl roundedall">
                <span class="exm">&nbsp;</span>
                <aspajax:HyperLink ID="lnkExam" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/ExamInfoView.aspx">Exams</aspajax:HyperLink>
            </div>
            <%--<div class="btn fl roundedall"><span class="ques">&nbsp;</span>
                <aspajax:HyperLink ID="lnktut" runat="server" ContainnerID="#contentBox" NavigateUrl="~/All/Ajaxer/TutorialInfoView.aspx">Tutorials</aspajax:HyperLink></div>--%>
            <div class="btn fl roundedall">
                <span class="us">&nbsp;</span>
                <aspajax:HyperLink ID="lnkUsers" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/ICUserInfoView.aspx">Users</aspajax:HyperLink></div>
            <div class="btn fl roundedall">
                <span class="ques">&nbsp;</span>
                <aspajax:HyperLink ID="lnkHomeWork" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/HomeWorkInfoView.aspx">HomeWorks</aspajax:HyperLink></div>
            <div class="btn fl roundedall">
                <span class="ques">&nbsp;</span>
                <aspajax:HyperLink ID="lnkArticle" runat="server" ContainnerID="#contentBox">Articles</aspajax:HyperLink></div>
            <div class="btn fl roundedall">
                <span class="img">&nbsp;</span>
                <aspajax:HyperLink ID="lnkImage" runat="server" ContainnerID="#contentBox">Images</aspajax:HyperLink></div>
            <div class="btn fl roundedall">
                <span class="ques">&nbsp;</span>
                <aspajax:HyperLink ID="lnkAudio" runat="server" ContainnerID="#contentBox">Audios</aspajax:HyperLink></div>
        </div>
        <div>
            <div class="btn fl roundedall">
                <span class="vid">&nbsp;</span>
                <aspajax:HyperLink ID="lnkVideo" runat="server" ContainnerID="#contentBox">Videos</aspajax:HyperLink></div>
            <div class="btn fl roundedall">
                <span class="doc">&nbsp;</span>
                <aspajax:HyperLink ID="lnkDocument" runat="server" ContainnerID="#contentBox">Library</aspajax:HyperLink></div>
            <div class="btn fl roundedall">
                <span class="doc">&nbsp;</span>
                <aspajax:HyperLink ID="lnkEvent" runat="server" ContainnerID="#contentBox">Event</aspajax:HyperLink></div>
        </div>
        <div class="clear"></div>
    </div>
    </form>
</body>
</html>
