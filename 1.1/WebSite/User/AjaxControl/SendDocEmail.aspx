<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendDocEmail.aspx.cs" Inherits="User_AjaxControl_SendDocEmail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="trans" style="float: left; width: 400px">
        <div class="contentbox">
            <div class="gray">
                <div style="float: right">
                    <asp:HyperLink ID="lnkclose" runat="server"><div class="close"></div></asp:HyperLink>
                </div>
                <div id="lblName" runat="server" style="float: left">
                </div>
                <div style="clear: both">
                </div>
            </div>
            <div id="popupLoggedIn" runat="server">
                <div class="whitecont">
                    <div>
                        <span class="label">Enter email address</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <aspajax:AjaxLinkButton ID="lnkAddQuestion" runat="server" RequestContainner="#acont"
                            ResponseContainner="#acont" OnAjaxClick="AddAjaxClick"><div class="btn editbtn"><%=Resources.Default.Add_Text%></div></aspajax:AjaxLinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="tarrow" style="float: left">
    </div>
    <div style="clear: both">
    </div>
    </form>
</body>
</html>
