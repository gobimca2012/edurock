<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductVersionInfoView.aspx.cs"
    Inherits="ShoppingCart_AjaxControl_ProductVersionInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListProductVersion" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                ProductID
                            </td>
                            <td>
                                Name
                            </td>
                            <td>
                                IsRecuringPrice
                            </td>
                            <td>
                                Discount
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
                        <%#Eval("ProductID") %>
                    </td>
                    <td>
                        <%#Eval("Name") %>
                    </td>
                    <td>
                        <%#Eval("IsRecuringPrice") %>
                    </td>
                    <td>
                        <%#Eval("Discount") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("ProductVersionID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/ShoppingCart/AjaxControl/ProductVersionInfo.aspx") + "?prvid=" + Eval("ProductVersionID")%>'
                            ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkAttributeAdd" runat="server" NavigateUrl='<%#ResolveUrl("~/ShoppingCart/AjaxControl/VersionAttributeInfoView.aspx") + "?prvid=" + Eval("ProductVersionID")%>'
                            ContainnerID="#contentBox">Add Attribute</aspajax:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="lnkBuy" runat="server" NavigateUrl='<%#ResolveUrl("~/ShoppingCart/Order.aspx") + "?prvid=" + Eval("ProductVersionID")%>'>Buy</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevProductVersion" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextProductVersion" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddProductVersion" runat="server" NavigateUrl="ProductVersionInfo.aspx"
                ContainnerID="#contentBox">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
