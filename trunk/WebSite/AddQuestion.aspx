<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="AddQuestion.aspx.cs" Inherits="AddQuestion" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <aspajax:HyperLink ID="lnkAddExam" runat="server" NavigateUrl="~/Modules/OnLineExam/AddExam.aspx"
            ContainnerID="#addque">Add New Exam</aspajax:HyperLink>
    </div>
    <div id="addque">
    </div>
</asp:Content>
