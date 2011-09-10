<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VersionAttributeInfo.aspx.cs"
    Inherits="ShoppingCart_AjaxControl_VersionAttributeInfo" %>

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
            <legend>VersionAttribute</legend>
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
                        <span class="label">Value</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddVersionAttribute" runat="server" RequestContainner="#VersionAttribute"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateVersionAttribute" runat="server" RequestContainner="#VersionAttribute"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
