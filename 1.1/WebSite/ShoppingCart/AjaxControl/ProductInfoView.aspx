<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductInfoView.aspx.cs"
    Inherits="ShoppingCart_AjaxControl_ProductInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListProduct" runat="server" DataKeyNames="ProductID">
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
                                Description
                            </td>
                            <td>
                                ShortDescription
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
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("ShortDescription") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("ProductID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/ShoppingCart/AjaxControl/ProductInfo.aspx") + "?prid=" + Eval("ProductID")%>'
                            ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkPrVersionAdd" runat="server" NavigateUrl='<%#ResolveUrl("~/ShoppingCart/AjaxControl/ProductVersionInfoView.aspx") + "?prid=" + Eval("ProductID")%>'
                            ContainnerID="#contentBox">Add version</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevProduct" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextProduct" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddProduct" runat="server" NavigateUrl="~/ShoppingCart/AjaxControl/ProductInfo.aspx"
                ContainnerID="#contentBox">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
