<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyLander.aspx.cs" Inherits="User_AjaxControl_MyLander" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <li><span class="all">&nbsp;</span>
                <aspajax:HyperLink ID="lnkMyAll" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/QuestionInfoView.aspx">All</aspajax:HyperLink></li>
            <li><span class="ques">&nbsp;</span>
                <aspajax:HyperLink ID="lnkMyQuestion" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/QuestionInfoView.aspx">Questions</aspajax:HyperLink></li>
            <li><span class="exm">&nbsp;</span>
                <aspajax:HyperLink ID="lnkMyExam" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/ExamInfoView.aspx">Exams</aspajax:HyperLink>
            </li>
            <li><span class="ques">&nbsp;</span>
                <aspajax:HyperLink ID="lnkMyHomeWork" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/HomeWorkInfoView.aspx">HomeWorks</aspajax:HyperLink></li>
            <li><span class="art"></span>
                <aspajax:HyperLink ID="lnkMyArticle" runat="server" ContainnerID="#contentBox">Articles</aspajax:HyperLink></li>
            <li><span class="img">&nbsp;</span>
                <aspajax:HyperLink ID="lnkMyImage" runat="server" ContainnerID="#contentBox">Images</aspajax:HyperLink></li>
            <li><span class="aud">&nbsp;</span>
                <aspajax:HyperLink ID="lnkMyAudio" runat="server" ContainnerID="#contentBox">Audios</aspajax:HyperLink></li>
            <li><span class="vid">&nbsp;</span>
                <aspajax:HyperLink ID="lnkMyVideo" runat="server" ContainnerID="#contentBox">Videos</aspajax:HyperLink></li>
            <li><span class="lbr">&nbsp;</span>
                <aspajax:HyperLink ID="lnkMyDocument" runat="server" ContainnerID="#contentBox">Library</aspajax:HyperLink></li>
            <li><span class="doc">&nbsp;</span>
                <aspajax:HyperLink ID="lnkMyResult" runat="server" ContainnerID="#contentBox">Result</aspajax:HyperLink></li>
        </ul>
    </div>
    </form>
</body>
</html>
