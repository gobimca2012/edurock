<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PublicUserInfoView.aspx.cs"
    Inherits="Widget_PublicUserInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="">
        <div class="clear gray">
            <div style="float: left">
                <h3>
                    <span id="lblFirstName" runat="server"></span>&nbsp; <span id="lblMiddleName" runat="server">
                    </span>&nbsp;<span id="lblLastName" runat="server"></span></h3>
            </div>
             <div style="float: right">
                <asp:HyperLink ID="lnkExpand" runat="server" CssClass="collapse"><div class=""></div></asp:HyperLink>
            </div>
            <div style="float: right">
                <asp:HyperLink ID="lnkClose" runat="server"><div class="close tp" rel="remove this widget from page"></div></asp:HyperLink>
            </div>
        </div>
        <div id="userbox" class="whitecont vis">
            <div id="pic" runat="server" visible="false">
                <div id="popupresponce">
                    <asp:Image ID="imgProfilepic" runat="server" Width="100" />
                </div>
                <div>
                    <asp:LinkButton ID="lnkChangeImage" runat="server">UpdatePic</asp:LinkButton>
                </div>
                <div id="propop">
                </div>
            </div>
            <div>
            </div>
            <div>
                <div>
                    <div class="label">
                        User's Role
                    </div>
                    <div>
                        <span id="lblUserRoles" runat="server"></span>
                    </div>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Date of Birth</span>
                </div>
                <div>
                    <span id="lblBirthDate" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Address</span>
                </div>
                <div>
                    <span id="lblAddress1" runat="server"></span>
                    <br />
                    <span id="lblAddress2" runat="server"></span>
                    <br />
                    <span id="lblCity" runat="server"></span>
                    <br />
                    <span id="lblState" runat="server"></span>
                    <br />
                    <span id="lblCountry" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">WebSite</span>
                </div>
                <div>
                    <span id="lblWebSite" runat="server"></span>
                </div>
            </div>
        </div>
        <div class="hcurv">
            <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox" NavigateUrl="UserInfo.aspx"><div class="btn"> Edit</div></aspajax:HyperLink>
        </div>
    </div>
    <div class="graycontent roundedall">
        <div>
            <div class="hcurv">
                User's Cource
            </div>
            <div class="whitecont">
                <span id="lblUserCource" runat="server"></span>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
