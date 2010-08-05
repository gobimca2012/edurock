<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Filter.aspx.cs" Inherits="User_AjaxControl_Filter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="float: left; padding: 2px;">
            <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
        </div>
        <div style="float: left; padding: 2px;">
            <asp:TextBox ID="txtstartDate" runat="server"></asp:TextBox>
        </div>
        <div style="float: left; padding: 2px;">
            <asp:TextBox ID="txtEnddate" runat="server"></asp:TextBox>
        </div>
        <div style="float: left; padding: 2px;">
        </div>
        <div style="float: left; padding: 2px;">
            <aspajax:AjaxLinkButton ID="lnkSearch" runat="server"><div class="btn">Search</div> </aspajax:AjaxLinkButton>
        </div>
    </div>
    </form>
</body>
</html>
