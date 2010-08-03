<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="ExamAttenders.aspx.cs" Inherits="College_ExamAttenders" Title="Untitled Page" %>

<%@ Register Src="UserControl/ListExamAttenders.ascx" TagName="ListExamAttenders"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <uc1:ListExamAttenders ID="ListExamAttenders1" runat="server" />
    </div>
</asp:Content>
