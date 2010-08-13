<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WidgetPage.aspx.cs" Inherits="User_WidgetPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox">Edit</aspajax:HyperLink>
        <div id="widgetmanager">
        </div>
        <div id="widgetLeft" style="float: left; width: 60%">
        </div>
        <div id="widgetright" style="float: right; width: 40%">
        </div>
        <div class="clear">
        </div>
    </div>
    </form>
</body>
</html>
