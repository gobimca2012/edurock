<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WidgetManager.aspx.cs" Inherits="User_WidgetManager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="blbg roundedall clear">
        <div style="float: left; width: 59%">
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkHtml" runat="server" EnableValidation="False" RequestContainner="#widgetmanager"
                    ResponseContainner="#widgetmanager" EnableViewState="False" Increment="False"
                    OnAjaxClick="AddAjaxWidget" Pagger="False"><div class="btn tp" rel="Add HTML widget to left panel">Html</div></aspajax:AjaxLinkButton>
            </div>
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkContent" runat="server" EnableValidation="False" RequestContainner="#widgetmanager"
                    ResponseContainner="#widgetmanager" EnableViewState="False" Increment="False"
                    OnAjaxClick="AddContentWidget" Pagger="False"><div class="btn tp" rel="Add your active stream to left panel">Active stream</div></aspajax:AjaxLinkButton>
            </div>
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkProfile" runat="server" EnableValidation="False" RequestContainner="#widgetmanager"
                    ResponseContainner="#widgetmanager" EnableViewState="False" Increment="False"
                    OnAjaxClick="AddProfileWidget" Pagger="False"><div class="btn tp" rel="add your profile info widget to left panel">ProfileInfo</div></aspajax:AjaxLinkButton>
            </div>
            <div class="graycontent clear roundedall">
                you can add this widget to your profile page's left side.drag and drop to organize
                your widget
            </div>
        </div>
        <div style="float: left; width: 40%">
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkRightHtml" runat="server" EnableValidation="False"
                    RequestContainner="#widgetmanager" ResponseContainner="#widgetmanager" EnableViewState="False"
                    Increment="False" OnAjaxClick="AddRightHtml" Pagger="False"><div class="btn tp" rel="add html widget to your profile right panel">Html</div></aspajax:AjaxLinkButton>
            </div>
             <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkRightShout" runat="server" EnableValidation="False"
                    RequestContainner="#widgetmanager" ResponseContainner="#widgetmanager" EnableViewState="False"
                    Increment="False" OnAjaxClick="AddRightShout" Pagger="False"><div class="btn tp" rel="add Shout widget to your profile right panel">Shout</div></aspajax:AjaxLinkButton>
            </div>
            <div class="graycontent clear roundedall">
                you can add this widget to your profile page's right side.drag and drop to organize
                your widget
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
    </form>
</body>
</html>
