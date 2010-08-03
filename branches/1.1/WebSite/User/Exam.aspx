<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true" CodeFile="Exam.aspx.cs" Inherits="User_Exam" Title="Untitled Page" %>

<%@ Register src="UserControl/Exam/AvailableExam.ascx" tagname="AvailableExam" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:AvailableExam ID="AvailableExam1" runat="server" />
</asp:Content>

