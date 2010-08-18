<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WidgetPage.aspx.cs" Inherits="User_WidgetPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="btn tp editbtn" rel="Customize your profile and present it to your people"
            id="divEdit" runat="server">
            <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox">Edit</aspajax:HyperLink></div>
        <div id="divwidmanager" runat="server">
            <div id="widgetmanager">
            </div>
        </div>
        <br />
        <div style="float: left; width: 59%;padding-right:5px; border-right: dashed 1px" class="contentbox nobod">
            <div id="widgetLeft">
            </div>
        </div>
        <div id="widgetright" style="float: right; width: 40%" class="contentbox nobod">
        </div>
        <div class="clear">
        </div>
    </div>
    </form>
</body>
</html>
