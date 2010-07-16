<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Upop.aspx.cs" Inherits="User_AjaxControl_Upop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="trans" style="float: left">
        <div class="whitecont" style="text-align: left">
            <div style="float: right">
                <asp:HyperLink ID="lnkclose" runat="server">Close</asp:HyperLink>
            </div>
            <div>
                <div>
                    <div style="float: left">
                        <asp:Image ID="propic" runat="server" Width="100" />
                    </div>
                    <div style="float: left; text-align: left" class="btitle">
                        <div>
                            Real Name : <span id="lblName" runat="server"></span>
                        </div>
                        <div>
                            Username :<span id="lblUserName" runat="server"></span>
                        </div>
                        <div>
                            <span id="Span2" runat="server"></span>
                        </div>
                    </div>
                    <div style="clear: both">
                    </div>
                    <div>
                        User Institute:&nbsp;<span id="lblGroup" runat="server"></span>
                    </div>
                    <div>
                        <asp:HyperLink ID="lnkUserProfile" runat="server">Full Profile</asp:HyperLink>
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
