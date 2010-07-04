﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InboxMessageInfoView.aspx.cs"
    Inherits="User_AjaxControl_InboxMessageInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListMessage" runat="server">
            <LayoutTemplate>
                <div>
                    <table>
                        <thead>
                            <tr>
                                <td>
                                    To
                                </td>
                                <td>
                                    Subject
                                </td>
                                <td>
                                    Date
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                        </thead>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                <td>
                        <%#Eval("FromFullName") %>
                    <td>
                    <td>
                        <aspajax:HyperLink ID="lnkFullView" runat="server" ContainnerID="#Message" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Message.aspx")+"?mid="+Eval("MessageID").ToString() %>'> <%#Eval("Subject") %></aspajax:HyperLink>
                    </td>
                    
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("MessageID").ToString(), "#Message", "#Message")%>
                    </td>
                    
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevMessage" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#Message" ResponseContainner="#Message"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextMessage" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#Message" Pagger="true" Increment="true" ResponseContainner="#Message">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddMessage" runat="server" NavigateUrl="~/Admin/Ajaxer/MessageInfo.aspx"
                ContainnerID="#Message">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>