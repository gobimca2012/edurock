<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WidgetManager.aspx.cs" Inherits="User_WidgetManager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <aspajax:AjaxLinkButton ID="lnkHtml" runat="server" EnableValidation="False" RequestContainner="#widgetmanager" ResponseContainner="#widgetmanager"
                EnableViewState="False" Increment="False" onajaxclick="AddAjaxWidget" 
                Pagger="False"><div class="btn">Html</div></aspajax:AjaxLinkButton>
        </div>
    </div>
    </form>
</body>
</html>
