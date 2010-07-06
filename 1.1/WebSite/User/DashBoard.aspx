<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="DashBoard.aspx.cs" Inherits="User_DashBoard" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="float: left; width: 200px" id="sidemenu">
        <div id="courcel">
            <h5>
                Cources</h5>
        </div>
        <div id="icource" class="invis">
        </div>
        <div id="questiontrg">
            <h5>
                Question</h5>
        </div>
        <div id="questiontrgbox" class="invis">
            <div>
                <aspajax:HyperLink ID="lnkMyQuestion" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/MyQuestion.aspx">My Questions</aspajax:HyperLink>
            </div>
            <div>
                <aspajax:HyperLink ID="lnkAllQuestion" runat="server" ContainnerID="#contentBox"
                    NavigateUrl="~/User/AjaxControl/QuestionInfoView.aspx">All Question</aspajax:HyperLink>
            </div>
        </div>
        <div id="messageHead">
            <h5>
                Messages</h5>
        </div>
        <div id="messagepn" class="invis">
            <div>
                <aspajax:HyperLink ID="lnkNewMessage" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/MessageInfo.aspx">New Message</aspajax:HyperLink>
            </div>
            <div>
                <aspajax:HyperLink ID="lnkInbox" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/InboxMessageInfoView.aspx">Inbox Message</aspajax:HyperLink>
            </div>
            <div>
                <aspajax:HyperLink ID="lnkSent" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/SentMessageInfoView.aspx">Sent Message</aspajax:HyperLink>
            </div>
        </div>
        <div id="tut">
            <h5>
                Tutorials</h5>
        </div>
        <div id="tutbox" class="invis">
            <div>
                <aspajax:HyperLink ID="lnkMyTutorials" runat="server" ContainnerID="#contentBox"
                    NavigateUrl="~/College/Ajaxer/TutorialView.aspx">My Tutorials</aspajax:HyperLink>
            </div>
            <div>
                <aspajax:HyperLink ID="lnkAllTutorials" runat="server" ContainnerID="#contentBox"
                    NavigateUrl="~/All/Ajaxer/TutorialInfoView.aspx">All Tutorials</aspajax:HyperLink>
            </div>
        </div>
    </div>
    <div style="float: left; width: 800px">
        <div id="lander">
        </div>
        <div id="contentBox">
        </div>
    </div>
</asp:Content>
