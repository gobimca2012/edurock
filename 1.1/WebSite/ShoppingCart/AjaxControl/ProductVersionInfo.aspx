<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductVersionInfo.aspx.cs"
    Inherits="ShoppingCart_AjaxControl_ProductVersion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>ProductVersion</legend>
            <table>
                <tr>
                    <td>
                        <span class="label">Name</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">Description</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">ShortDescription</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtShortDescription" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">IsRecuringPrice</span>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkIsRecuringPrice" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">Recuring Time in Month</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRecurringTime" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">QuantityIn</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtQuantityIn" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">Price in Doller</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">Discount</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddProductVersion" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateProductVersion" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
