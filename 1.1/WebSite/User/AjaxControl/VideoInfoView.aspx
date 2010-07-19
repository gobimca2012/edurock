﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VideoInfoView.aspx.cs" Inherits="User_AjaxControl_VideoInfoView" %>

<%@ Register Src="../UserControl/UserToolTipLink.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray" id="header" runat="server">
            Images</div>
        <asp:ListView ID="ListDocument" runat="server" DataKeyNames="ID" OnItemDataBound="ListDocumentOnItemDataBound">
            <LayoutTemplate>
                <table>
                    
                    <div class="whitecont">
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </div>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
               
                <div class="dasbo">
                    <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + Eval("ID").ToString()%>'>
                    <div style="float: left;width:550px">
                        <%#Eval("Title") %>
                    </div>
                    </aspajax:HyperLink>
                    <div style="float: right">
                        <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" ModifiedDate='<%#Eval("ModifiedDate") %>'
                            LoginUserID='<%#Eval("LoginUserID") %>' />
                    </div>
                    <div style="clear: both">
                    </div>
                    <div>
                        <%#_HtmlHelper.ListViewLinkButtonDelete("lnkd", "delete", Eval("ID").ToString(), Eval("LoginUserID").ToString(), "#contentBox", "#contentBox")%>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div class="gray">
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevDocument" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextDocument" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div>
                <aspajax:HyperLink ID="hpAddDocument" runat="server" NavigateUrl="~/User/AjaxControl/DocumentInfo.aspx?dtype=1"
                    ContainnerID="#contentBox"><div class="btn"> Add New Video</div></aspajax:HyperLink>
            </div>
        </div>
        <div style="clear: both">
        </div>
    </div>
    </form>
</body>
</html>
