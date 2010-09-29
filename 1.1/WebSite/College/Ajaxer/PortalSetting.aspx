<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PortalSetting.aspx.cs" Inherits="College_Ajaxer_PortalSetting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            System Setting
        </div>
        <div class="whitecont">
            <div>
                <div>
                    <span class="label">Space Header</span>
                </div>
                <div>
                    <asp:TextBox ID="txtSpace" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Catagory Header</span>
                </div>
                <div>
                    <asp:TextBox ID="txtCatagory" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" EnableValidation="False" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" EnableViewState="False" Increment="False" OnAjaxClick="SaveAjaxClick"
                    Pagger="False"><div class="btn">Save</div> </aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
