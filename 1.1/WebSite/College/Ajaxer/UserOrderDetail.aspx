<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserOrderDetail.aspx.cs"
    Inherits="User_AjaxControl_UserOrderDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            review your order details
        </div>
        <div class="whitecont">
            <asp:ListView ID="listUserOrder" runat="server" OnItemDataBound="OnItemDataBound"
                DataKeyNames="ProductVersionID">
                <LayoutTemplate>
                    <div>
                        <table>
                            <thead>
                                <tr>
                                    <td>
                                        Item Name
                                    </td>
                                    <td>
                                        Quantity
                                    </td>
                                    <td>
                                        Price
                                    </td>
                                    <td>
                                        Expiration Date
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
                            <%#Eval("ItemName")%>
                        </td>
                        <td>
                            <%#Eval("Quantity")%>
                        </td>
                        <td>
                            <%#Eval("Price")%>
                        </td>
                        <td>
                            <%#Eval("CustomerOrder.ExpireDate")%>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkrenew" runat="server" ContainnerID="#contentBox">Renew</aspajax:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
    </form>
</body>
</html>
