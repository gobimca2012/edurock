<%@ Page Language="C#" MasterPageFile="~/MasterPage/Admin.master" AutoEventWireup="true"
    CodeFile="AdminOld.aspx.cs" Inherits="College_AccountSetting" Title="Untitled Page" %>

<%@ Register Src="UserControl/AddInstituteInfo.ascx" TagName="AddInstituteInfo" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<div style="float: left; width: 200px" id="sidemenu">
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
    </div>--%>
    <div style="width: 1000px">
        <div class="bksl roundedt">
            <div style="padding-top: 65px;">
                <div class="btn">
                    <asp:HyperLink ID="lnkDashBoard" runat="server" NavigateUrl="~/User/DashBoard.aspx">Dashboard</asp:HyperLink></div>
                <div class="btn">
                    Account Setting</div>
                <div class="btn">
                    Activity Stream</div>
            </div>
        </div>
        <div class="gbg roundedall" style="clear: both; min-height: 500px; margin: 5px;">
            <div id="lander" style="padding: 10px;">
                <ul>
                    <li class="btn roundedall">
                        <aspajax:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/College/Ajaxer/InstituteInfoView.aspx"
                            ContainnerID="#contentBox">Profile Edit</aspajax:HyperLink>
                    </li>
                    <li class="btn roundedall">
                        <aspajax:HyperLink ID="lnkCource" runat="server" NavigateUrl="~/College/Ajaxer/InstituteCourceInfoView.aspx"
                            ContainnerID="#contentBox">Cource</aspajax:HyperLink></li>
                    <li class="btn roundedall">
                        <aspajax:HyperLink ID="lnkUSer" runat="server" ContainnerID="#contentBox" NavigateUrl="~/College/Ajaxer/InstituteUserInfoView.aspx">User</aspajax:HyperLink>
                    </li>
                    <li class="btn roundedall">
                        <aspajax:HyperLink ID="lnkUSerType" runat="server" ContainnerID="#contentBox" NavigateUrl="~/College/Ajaxer/InstituteUserTypeInfoView.aspx">User Type</aspajax:HyperLink>
                    </li>
                    <li class="btn roundedall">
                        <aspajax:HyperLink ID="lnkCourceCat" runat="server" NavigateUrl="~/College/Ajaxer/CourceCatagoryInfoView.aspx"
                            ContainnerID="#contentBox">Cource Catagory</aspajax:HyperLink><%--<a href="#tabs-5">Cource Catagory</a>--%></li>
                    <li class="btn roundedall">
                        <aspajax:HyperLink ID="lnkQuestionType" runat="server" NavigateUrl="~/College/Ajaxer/QuestionTypeInfoView.aspx"
                            ContainnerID="#contentBox">Question Type</aspajax:HyperLink><%--<a href="#tabs-5">Cource Catagory</a>--%></li>
                    <li class="btn roundedall">
                        <aspajax:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/College/Ajaxer/InstituteUserTypeInfoView.aspx"
                            ContainnerID="#contentBox">User Role</aspajax:HyperLink><%--<a href="#tabs-5">Cource Catagory</a>--%></li>
                </ul>
            </div>
            <div class="gbg roundedall" style="clear: both; min-height: 500px; margin: 5px;">
                <div id="contentBox">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
