<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WidgetPage.aspx.cs" Inherits="User_WidgetPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="btn tp" rel="Customize your profile and present it to your people">
            <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox">Edit</aspajax:HyperLink></div>
        <div class="blbg roundedall">
            <div id="widgetmanager">
            </div>
        </div>
        <br />
        <div id="widgetLeft" style="float: left; width: 59%" class="contentbox">
        </div>
        <div id="widgetright" style="float: right; width: 40%" class="contentbox">
        </div>
        <div class="clear">
        </div>
    </div>
    </form>
</body>
</html>
