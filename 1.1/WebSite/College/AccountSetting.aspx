<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true" CodeFile="AccountSetting.aspx.cs" Inherits="College_AccountSetting" Title="Untitled Page" %>

<%@ Register src="UserControl/AddInstituteInfo.ascx" tagname="AddInstituteInfo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:AddInstituteInfo ID="AddInstituteInfo1" runat="server" />
</asp:Content>

