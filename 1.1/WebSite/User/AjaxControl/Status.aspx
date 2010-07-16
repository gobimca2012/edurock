<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Status.aspx.cs" Inherits="User_AjaxControl_Status" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <span id="lblStatus" runat="server"></span>
        </div>
        <div id="changestatus">
            <div>
                <asp:TextBox ID="txtStatus" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div style="text-align:right">
                <aspajax:AjaxLinkButton ID="lnkUpdateStatus" runat="server" EnableViewState="False" Increment="False" RequestContainner="#changestatus" ResponseContainner="#changestatus"
                    OnAjaxClick="UpdateAjaxClick" Pagger="False"><div class="btn" style="width:90px;float:right"> Update Status</div></aspajax:AjaxLinkButton>
                    <div style="clear:both"></div>
    
            </div>
        </div>
    </div>
    </form>
</body>
</html>
