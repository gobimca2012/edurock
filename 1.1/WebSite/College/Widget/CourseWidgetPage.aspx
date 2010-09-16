<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourseWidgetPage.aspx.cs"
    Inherits="College_Widget_CourseWidgetPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="gbg roundedall">
            <div style="padding: 5px;">
                <div class="btn tp editbtn fl" rel="Customize your profile and present it to your people"
                    id="divEdit" runat="server">
                    <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox">Edit</aspajax:HyperLink></div>
                <div class="fl">
                    <aspajax:HyperLink ID="lnkShare" runat="server" ContainnerID="#contentBox"><div class="btn editbtn">  Share </div></aspajax:HyperLink></div>
            </div>
            <div class="clear">
            </div>
            <div id="divwidmanager" runat="server" class="clear">
                <div id="widgetmanager">
                </div>
            </div>
        </div>
        <br />
        <div style="float: left; width: 59%; margin-left: 5px;">
            <div id="widgetLeft">
            </div>
        </div>
        <div style="float: right; width: 40%">
            <div id="widgetright" class="">
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
    </div>
    </form>
</body>
</html>
