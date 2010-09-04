<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddQuantity.aspx.cs" Inherits="ShoppingCart_AjaxControl_AddToCart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <span id="lblTitle" runat="server"></span>
        </div>
        <div>
            <span id="lblQuantityText" runat="server"></span>
        </div>
        <div>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        </div>
        <div>
            <aspajax:AjaxLinkButton ID="lnkNext" runat="server" EnableValidation="False"  RequestContainner="#contentBox" ResponseContainner="#contentBox"
                EnableViewState="False" Increment="False" onajaxclick="AjaxNextClick" 
                Pagger="False">Next</aspajax:AjaxLinkButton>
        </div>
    </div>
    </form>
</body>
</html>
