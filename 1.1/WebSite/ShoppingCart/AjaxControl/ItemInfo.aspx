<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ItemInfo.aspx.cs" Inherits="ShoppingCart_AjaxControl_ItemInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>Item</legend>
            <div>
               
                <div>
                    <div>
                        <span class="label">Name</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">ItemType</span>
                    </div>
                    <div>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Price</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">ApplicationURL</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtApplicationURL" runat="server"></asp:TextBox>
                    </div>
                </div>
               
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddItem" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateItem" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
