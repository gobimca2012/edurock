<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConfirmShopping.aspx.cs"
    Inherits="ShoppingCart_AjaxControl_ConfirmShopping" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <div>
                <span id="lblTitle" runat="server"></span>
            </div>
            <div>
                <span id="lblPricePerItem" runat="server"></span>
            </div>
            <div>
                <span id="lblQuantityText" runat="server"></span>
            </div>
            <div>
                <span id="lblQuantity" runat="server"></span>
            </div>
            <div>
                <span id="lblTotalPrice" runat="server"></span>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkConfirm" runat="server" EnableValidation="False" 
                    EnableViewState="False" Increment="False" onajaxclick="AjaxConfirmClick" 
                    Pagger="False">Confirm</aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
