<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<%@ Register Src="Modules/Login/Login.ascx" TagName="Login" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="body">
        <%--   <div class="login"  style="margin:0 auto;position:absolute;left:500px">
            <div class="top">
            </div>
            <div class="mid">
            
                <uc1:Login ID="Login1" runat="server" />
            
            </div>
            <div class="bot">
            </div>
        </div>--%>
        <div style="height: 527px;">
            <div style="margin: auto auto; width: 900px; left: 300px; position: absolute;" id="loginbx">
                <div class="loginhead">
                </div>
                <div class="loginbxbg">
                    <div style="float: left; width: 196px; text-align: right; margin-top: 90px;">
                        <%--<div>
                        <asp:HyperLink ID="lnkdocument" runat="server">Documentation</asp:HyperLink>
                    </div>
                    <div>
                        <asp:HyperLink ID="HyperLink1" runat="server">Customer support</asp:HyperLink>
                    </div>--%>
                        <div>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://vt3soft.com/EditionandPrice.aspx">Pricing</asp:HyperLink>
                        </div>
                        <div>
                            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="http://vt3soft.com/EditionandPrice.aspx">Editions</asp:HyperLink>
                        </div>
                    </div>
                    <div class="loginbx" style="float: left;">
                        <uc1:Login ID="Login1" runat="server" />
                    </div>
                    <div style="float: left; margin-top: 90px;">
                        <div>
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="http://www.vt3soft.com/ShoppingCart/Step1/tabid/95/pid/c473d400-d8d6-4d5f-90dd-ab10e497c3cc/Default.aspx">Try FREE EDITION</asp:HyperLink>
                        </div>
                        <div style="display: none">
                            <asp:HyperLink ID="HyperLink3" runat="server">Customer support</asp:HyperLink>
                        </div>
                        <div>
                            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="http://vt3soft.com/EditionandPrice.aspx">BUY NOW</asp:HyperLink>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div style="width: 100%; clear: both; position: relative; font-size: 11px; color: #fff"
            class="footerbg">
            <div class="page" style="min-height: 0px;">
                <div style="padding: 15px">
                    <div class="fl">
                        <div>
                            <asp:Image ID="clogo" runat="server" ImageUrl="~/App_Themes/Default/Images/crameasylogo.png" />
                        </div>
                        <div>
                            <span>Powered by crameasy on demand solution</span>
                        </div>
                    </div>
                    <div class="fr">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Themes/Default/Images/vt3logo.png"
                            Height="80px" />
                    </div>
                    <div class="fr" style="vertical-align: bottom; margin-right: 11px; margin-top: 50px;">
                        <span>Supported web browsers</span>
                        <asp:HyperLink ID="HyperLink7" alt="vt3soft" runat="server" NavigateUrl="http://vt3soft.com">View List and download</asp:HyperLink>
                        <br />
                        <span>Copyright ©</span>
                        <asp:HyperLink ID="HyperLink6" alt="vt3soft" runat="server" NavigateUrl="http://vt3soft.com">VT3Soft</asp:HyperLink>
                        <span>2008 -2010. All Rights Reserved</span>
                    </div>
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function() {
            $("#loginbx").animate({


                top: "100"
            }, 1500);
        });
    
    </script>

    </form>
</body>
</html>
