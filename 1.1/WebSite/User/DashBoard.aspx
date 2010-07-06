<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="DashBoard.aspx.cs" Inherits="User_DashBoard" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="float: left; width: 200px" id="sidemenu">
        <div style="height: 100px">
        </div>
        <div class="gbg roundedl leftmenu">
            <div id="courcel">
                <h5>
                    Cources</h5>
            </div>
            <div id="icource" class="invis">
            </div>
        </div>
        <div class="gbg roundedl leftmenu">
            <div id="questiontrg">
                <h5>
                    Question</h5>
            </div>
            <div id="questiontrgbox" class="invis">
                <div class="cin">
                    <aspajax:HyperLink ID="lnkMyQuestion" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/MyQuestion.aspx">My Questions</aspajax:HyperLink>
                </div>
                <div class="cin">
                    <aspajax:HyperLink ID="lnkAllQuestion" runat="server" ContainnerID="#contentBox"
                        NavigateUrl="~/User/AjaxControl/QuestionInfoView.aspx">All Question</aspajax:HyperLink>
                </div>
            </div>
            <div id="messageHead">
                <h5>
                    Messages</h5>
            </div>
            <div id="messagepn" class="invis">
                <div class="cin">
                    <aspajax:HyperLink ID="lnkNewMessage" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/MessageInfo.aspx">New Message</aspajax:HyperLink>
                </div>
                <div class="cin">
                    <aspajax:HyperLink ID="lnkInbox" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/InboxMessageInfoView.aspx">Inbox Message</aspajax:HyperLink>
                </div>
                <div class="cin">
                    <aspajax:HyperLink ID="lnkSent" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/SentMessageInfoView.aspx">Sent Message</aspajax:HyperLink>
                </div>
            </div>
            <div id="tut">
                <h5>
                    Tutorials</h5>
            </div>
            <div id="tutbox" class="invis">
                <div class="cin">
                    <aspajax:HyperLink ID="lnkMyTutorials" runat="server" ContainnerID="#contentBox"
                        NavigateUrl="~/College/Ajaxer/TutorialView.aspx">My Tutorials</aspajax:HyperLink>
                </div>
                <div class="cin">
                    <aspajax:HyperLink ID="lnkAllTutorials" runat="server" ContainnerID="#contentBox"
                        NavigateUrl="~/All/Ajaxer/TutorialInfoView.aspx">All Tutorials</aspajax:HyperLink>
                </div>
            </div>
        </div>
    </div>
    <div style="float: left; width: 800px">
        <div class="bksl roundedt">
            <div style="padding-top: 67px;">
                <div class="btn">
                    DashBoard</div>
                <div class="btn">
                    Account Setting</div>
                <div class="btn">
                    Activity Stream</div>
            </div>
        </div>
        <div class="gbg roundedall" style="clear:both;min-height:500px;margin:5px;">
            <div id="lander">
            </div>
            <div id="contentBox">
            </div>
        </div>
    </div>
</asp:Content>
