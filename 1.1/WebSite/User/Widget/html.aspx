<%@ Page Language="C#" AutoEventWireup="true" CodeFile="html.aspx.cs" Inherits="User_Widget_html" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>
            Rohan Naik</h3>
        <asp:HyperLink ID="lnkClose" runat="server" >Close</asp:HyperLink>
        <div>
            <asp:TextBox ID="txtEditor" runat="server"></asp:TextBox>
        </div>
    </div>
    </form>
</body>
</html>
