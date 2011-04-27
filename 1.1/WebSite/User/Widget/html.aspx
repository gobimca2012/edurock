<%@ Page Language="C#" AutoEventWireup="true" CodeFile="html.aspx.cs" Inherits="User_Widget_html"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="rohan1" runat="server">
    <div class="contentbox" style="margin-bottom:5px">
        <div class="clear gray">
            <div style="float: left">
                <h3 id="Widgetheader" runat="server">
                </h3>
            </div>
            <div style="float: right">
                <asp:HyperLink ID="lnkExpand" runat="server" CssClass="collapse"><div class=""></div></asp:HyperLink>
            </div>
            <div style="float: right">
                <asp:HyperLink ID="lnkClose" runat="server"><div class="close tp" rel="remove this widget from page"></div></asp:HyperLink>
            </div>
        </div>
        <div class="clear whitecont vis" id="htmlbox" runat="server">
            <div id="divPreviewBox" runat="server">
                <div id="divHtml" runat="server">
                </div>
                <div>
                    <aspajax:AjaxLinkButton ID="lnkEdit" runat="server" EnableValidation="False" EnableViewState="False"
                        Increment="False" OnAjaxClick="AjaxEdit" Pagger="False"><div class="btn editbtn"><%=Resources.Default.Edit_Text %></div></aspajax:AjaxLinkButton>
                </div>
            </div>
            <div id="divEditBox" runat="server">
                <div>
                    <span class="label">Header</span>
                </div>
                <div>
                    <asp:TextBox ID="txtHeader" runat="server"></asp:TextBox>
                </div>
                <div>
                    <span class="label">Body</span>
                </div>
                <div>
                    <asp:TextBox ID="txtEditor" runat="server" TextMode="MultiLine" Height="300" Width="100%"
                        CssClass="mceEditor"></asp:TextBox>
                </div>
                <div>
                    <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" EnableValidation="False" EnableViewState="False"
                        Increment="False" OnAjaxClick="AjaxUpdate" Pagger="False"><div class="btn editbtn">Update</div></aspajax:AjaxLinkButton>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
