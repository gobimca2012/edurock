<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Upop.aspx.cs" Inherits="User_AjaxControl_Upop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="trans" style="float: left;width:400px">
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
            <div class="whitecont">
                <div>
                    <div style="width: 360px">
                        <div style="float: left; width: 110">
                            <asp:Image ID="propic" runat="server" Width="100" />
                        </div>
                        <div style="float: left; text-align: left; width: 240px">
                            <div  class="btitle">
                                Status : <span id="lblStatus" runat="server" class="btext"></span>
                            </div>
                        </div>
                        <div style="clear: both">
                        </div>
                        <div class="btext">
                            <div>
                            </div>
                            <div>
                                Username :<span id="lblUserName" runat="server"></span>
                            </div>
                            <div>
                                <span id="Span2" runat="server"></span>
                            </div>
                        </div>
                        <div>
                            User Institute:&nbsp;<span id="lblGroup" runat="server"></span>
                        </div>
                        <div>
                            User Cource:&nbsp;<span id="lblCource" runat="server"></span>
                        </div>
                        <div>
                            <asp:HyperLink ID="lnkUserProfile" runat="server">Full Profile</asp:HyperLink>
                        </div>
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
