<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="Message.aspx.cs" Inherits="User_Message" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <div>
            <ul>
                <li>
                    <aspajax:HyperLink ID="lnkNewMessage" runat="server" ContainnerID="#Message" NavigateUrl="~/User/AjaxControl/MessageInfo.aspx">New Message</aspajax:HyperLink>
                </li>
                <li>
                    <aspajax:HyperLink ID="lnkInbox" runat="server" ContainnerID="#Message" NavigateUrl="~/User/AjaxControl/InboxMessageInfoView.aspx">Inbox Message</aspajax:HyperLink>
                </li>
                 <li>
                    <aspajax:HyperLink ID="lnkSent" runat="server" ContainnerID="#Message" NavigateUrl="~/User/AjaxControl/SentMessageInfoView.aspx">Sent Message</aspajax:HyperLink>
                </li>
            </ul>
        </div>
        <div id="Message">
        </div>
    </div>
</asp:Content>
