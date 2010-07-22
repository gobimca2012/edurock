<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HeaderNavigation.ascx.cs"
    Inherits="LayoutControl_HeaderNavigation" %>
<%@ Register Assembly="AjaxControl" Namespace="AjaxControl" TagPrefix="cc1" %>
<%@ Register Src="../Modules/Login/Create.ascx" TagName="Create" TagPrefix="uc1" %>
<%@ Register Src="../Modules/Login/Login.ascx" TagName="Login" TagPrefix="uc2" %>
<div style="width: 1000px; margin: 0 auto; height: 50px">
    <div style="float: right; margin-right: 4px;" >
        <ul>
            <li id="liHome" runat="server" class="btn">
                <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
            </li>
            <li id="lilogin" runat="server" class="btn">
                <cc1:ShowHideLinkButton ID="lnkLogin" runat="server" Show="true" ContainnerID="#logindiv">Sign In</cc1:ShowHideLinkButton>
            </li>
            <li id="liCreate" runat="server" class="btn">
                <cc1:ShowHideLinkButton ID="lnkCreate" runat="server" Show="true" ContainnerID="#creatediv">Sign Up</cc1:ShowHideLinkButton>
            </li>
            <li id="liAccountsetting" runat="server" class="btn">
                <asp:HyperLink ID="lnkAccountSetting" runat="server" NavigateUrl="~/User/AccountSetting.aspx">Administration</asp:HyperLink>
            </li>
            <li id="lilogout" runat="server" class="btn">
                <asp:LinkButton ID="lnkLogout" runat="server" OnClick="lnkLogout_Click">LogOut</asp:LinkButton>
            </li>
            <li id="li1" runat="server" class="btn">
                <asp:HyperLink ID="lnkRegisterInstitute" runat="server" NavigateUrl="~/RegisterInstitute.aspx">Register Institute</asp:HyperLink>
            </li>
        </ul>
        <div id="logindiv" style="display: none">
            <uc2:Login ID="Login1" runat="server" />
        </div>
        <div id="creatediv" style="display: none">
            <uc1:Create ID="Create1" runat="server" />
        </div>
    </div>
</div>
<div style="clear: both">
</div>
<div>
    <div>
        <asp:PlaceHolder ID="ActionMenu" runat="server"></asp:PlaceHolder>
    </div>
</div>
