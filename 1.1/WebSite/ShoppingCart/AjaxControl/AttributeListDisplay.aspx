<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AttributeListDisplay.aspx.cs"
    Inherits="ShoppingCart_AjaxControl_AttributeListDisplay" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="float: left">
        <h1 id="divTitle" runat="server">
        </h1>
    </div>
    <div style="float: right">
        <h1 id="divPrice" runat="server">
        </h1>
    </div>
    <div class="clear">
    </div>
    <div class="totalbox">
        <table>
            <tr>
                <td>
                    <h3>
                        Sub Total :</h3>
                </td>
                <td>
                    <h3 id="divSubTotal" runat="server">
                    </h3>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>
                        Total Due Today:</h3>
                </td>
                <td>
                    <h3 id="divTotalDue" runat="server">
                    </h3>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>
                        Total Recurring:</h3>
                </td>
                <td>
                    <h3 id="divTotalRecurring" runat="server">
                    </h3>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <div id="divDescription" runat="server">
        </div>
    </div>
    <div>
        <asp:ListView ID="ListVersionAttribute" runat="server">
            <LayoutTemplate>
                <table class="nctable">
                    <thead>
                        <tr>
                            <td class="head">
                                Features
                            </td>
                            <td class="head">
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <AlternatingItemTemplate>
                <tr>
                    <td>
                        <%#Eval("Name") %>
                    </td>
                    <td>
                        <%#Eval("Value") %>
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <ItemTemplate>
                <tr class="odd">
                    <td>
                        <%#Eval("Name") %>
                    </td>
                    <td>
                        <%#Eval("Value") %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <div>
        <aspajax:AjaxLinkButton ID="lnkNext" runat="server" RequestContainner="#contentBox"
            ResponseContainner="#contentBox" EnableValidation="False" EnableViewState="False"
            Increment="False" Pagger="False" OnAjaxClick="Order_Click"><div class="btn editbtn">Add to Cart</div></aspajax:AjaxLinkButton>
    </div>
    </form>
</body>
</html>
