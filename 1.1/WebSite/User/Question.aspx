<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="Question.aspx.cs" Inherits="User_Question" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ul>
        <li>
            <aspajax:HyperLink ID="lnkMyQuestion" runat="server" ContainnerID="#Question" NavigateUrl="~/User/AjaxControl/MyQuestion.aspx">My Questions</aspajax:HyperLink>
        </li>
        <li>
            <aspajax:HyperLink ID="lnkAllQuestion" runat="server" ContainnerID="#Question" NavigateUrl="~/User/AjaxControl/QuestionInfoView.aspx">All Question</aspajax:HyperLink>
        </li>
    </ul>
    <div id="Question">
    </div>
</asp:Content>
