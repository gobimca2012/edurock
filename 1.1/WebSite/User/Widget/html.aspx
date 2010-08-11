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
        <asp:HyperLink ID="lnkClose" runat="server">Close</asp:HyperLink>
        <div id="divPreviewBox" runat="server">
            <div id="divHtml" runat="server">
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkEdit" runat="server" EnableValidation="False" 
                    EnableViewState="False" Increment="False" onajaxclick="AjaxEdit" Pagger="False"><div class="btn">Edit</div></aspajax:AjaxLinkButton>
            </div>
        </div>
        <div id="divEditBox" runat="server">
            <div>
                <asp:TextBox ID="txtEditor" runat="server" TextMode="MultiLine" Height="300" CssClass="mceEditor"></asp:TextBox>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" EnableValidation="False" 
                    EnableViewState="False" Increment="False" onajaxclick="AjaxUpdate" 
                    Pagger="False"><div class="btn">Update</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
