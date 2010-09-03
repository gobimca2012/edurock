<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ItemInfoView.aspx.cs" Inherits="ShoppingCart_AjaxControl_ItemInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListItem" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                ItemID
                            </td>
                            <td>
                                Name
                            </td>
                            <td>
                                ItemType
                            </td>
                            <td>
                                Price
                            </td>
                            <td>
                                ApplicationURL
                            </td>
                            <td>
                                ModifiedDate
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("ItemID") %>
                    </td>
                    <td>
                        <%#Eval("Name") %>
                    </td>
                    <td>
                        <%#Eval("ItemType") %>
                    </td>
                    <td>
                        <%#Eval("Price") %>
                    </td>
                    <td>
                        <%#Eval("ApplicationURL") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("ItemID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/ItemInfo.aspx") + "?cid=" + Eval("ItemID")%>'
                            ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevItem" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextItem" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddItem" runat="server" NavigateUrl="~/ShoppingCart/AjaxControl/ItemInfo.aspx"
                ContainnerID="#contentBox">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
