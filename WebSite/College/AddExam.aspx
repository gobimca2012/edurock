<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true" CodeFile="AddExam.aspx.cs" Inherits="College_AddExam" Title="Untitled Page"  EnableEventValidation="false" ValidateRequest="false" %>

<%@ Register src="UserControl/AddExam.ascx" tagname="AddExam" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:AddExam ID="AddExam1" runat="server" />
</asp:Content>

