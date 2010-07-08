<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InboxMessageInfoView.aspx.cs"
    Inherits="User_AjaxControl_InboxMessageInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Message Inbox</div>
        <div class="whitecont">
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
                                    <aspajax:HyperLink ID="lnkFullView" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Message.aspx")+"?mid="+Eval("MessageID").ToString() %>'> <%#Eval("Subject") %></aspajax:HyperLink>
                                </td>
                                <%#Eval("ModifiedDate") %>
                            </td>
                            <td>
                                <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("MessageID").ToString(), "#contentBox", "#contentBox")%>
                            </td>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            <div>
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevMessage" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextMessage" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                    </div>
                </div>
                <div style="clear: both">
                </div>
            </div>
        </div>
        <div class="gray">
            <div>
                <aspajax:HyperLink ID="hpAddMessage" runat="server" NavigateUrl="~/Admin/Ajaxer/MessageInfo.aspx"
                    ContainnerID="#contentBox">Add New</aspajax:HyperLink>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
