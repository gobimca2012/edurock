<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CompleteOrder.aspx.cs" Inherits="ShoppingCart_AjaxControl_CompleteOrder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <aspajax:AjaxLinkButton ID="lnkCompleteOrder" runat="server" RequestContainner="#contentBox"
            ResponseContainner="#contentBox" EnableValidation="False" EnableViewState="False"
            Increment="False" Pagger="False"><div class="btn editbtn">CompleteOrder</div></aspajax:AjaxLinkButton>
    </div>
    </form>
</body>
</html>
