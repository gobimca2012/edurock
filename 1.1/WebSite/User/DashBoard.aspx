<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="DashBoard.aspx.cs" Inherits="User_DashBoard" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<script type="text/javascript">
	function openExcel(strFilePath) {
		var yourSite = "http://www.yoursite.com";
		openExcelDocPath(yourSite + strFilePath, false);
	}
	function openExcelDocPath(strLocation, boolReadOnly) {
		var objExcel;
		objExcel = new ActiveXObject("Excel.Application");
		objExcel.Visible = true;
		objExcel.Workbooks.Open(strLocation, false, boolReadOnly);
	}
</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
