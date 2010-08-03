<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true" CodeFile="ExamResult.aspx.cs" Inherits="User_ExamResult" Title="Untitled Page" %>

<%@ Register src="UserControl/Exam/UserExamResult.ascx" tagname="UserExamResult" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:UserExamResult ID="UserExamResult1" runat="server" />
</asp:Content>

