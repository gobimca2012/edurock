<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="Tutorial.aspx.cs" Inherits="College_Tutorial" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <ul>
            <li>
                <aspajax:HyperLink ID="lnkMyTutorials" runat="server" ContainnerID="#tutorial" NavigateUrl="~/College/Ajaxer/TutorialView.aspx">My Tutorials</aspajax:HyperLink>
            </li>
            <li>
                <aspajax:HyperLink ID="lnkAllTutorials" runat="server" ContainnerID="#tutorial" NavigateUrl="~/All/Ajaxer/TutorialInfoView.aspx">All Tutorials</aspajax:HyperLink>
            </li>
        </ul>
        <div id="tutorial">
        </div>
    </div>
</asp:Content>
