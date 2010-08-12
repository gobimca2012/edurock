<%@ Page Language="C#" AutoEventWireup="true" CodeFile="html.aspx.cs" Inherits="User_Widget_html" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="clear gray">
            <div style="float: left">
                <h3>
                    Rohan Naik</h3>
            </div>
            <div style="float: right">
                <asp:HyperLink ID="lnkClose" runat="server"><div class="btn"> Close</div></asp:HyperLink>
            </div>
        </div>
        <div class="clear ">
            <div id="divPreviewBox" runat="server">
                <div id="divHtml" runat="server">
                </div>
                <div>
                    <aspajax:AjaxLinkButton ID="lnkEdit" runat="server" EnableValidation="False" EnableViewState="False"
                        Increment="False" OnAjaxClick="AjaxEdit" Pagger="False"><div class="btn">Edit</div></aspajax:AjaxLinkButton>
                </div>
            </div>
            <div id="divEditBox" runat="server">
                <div>
                    <asp:TextBox ID="txtEditor" runat="server" TextMode="MultiLine" Height="300" CssClass="mceEditor"></asp:TextBox>
                </div>
                <div>
                    <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" EnableValidation="False" EnableViewState="False"
                        Increment="False" OnAjaxClick="AjaxUpdate" Pagger="False"><div class="btn">Update</div></aspajax:AjaxLinkButton>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
