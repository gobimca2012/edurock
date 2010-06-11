<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HeaderNavigation.ascx.cs"
    Inherits="LayoutControl_HeaderNavigation" %>
<%@ Register Assembly="AjaxControl" Namespace="AjaxControl" TagPrefix="cc1" %>
<%@ Register Src="../Modules/Login/Create.ascx" TagName="Create" TagPrefix="uc1" %>
<%@ Register Src="../Modules/Login/Login.ascx" TagName="Login" TagPrefix="uc2" %>
<div style="float: right">
    <ul>
        <li>
            <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
        </li>
        <li>
            <cc1:ShowHideLinkButton ID="lnkLogin" runat="server" Show="true" ContainnerID="#logindiv">Sign In</cc1:ShowHideLinkButton>
        </li>
        <li>
            <cc1:ShowHideLinkButton ID="lnkCreate" runat="server" Show="true" ContainnerID="#creatediv">Sign Up</cc1:ShowHideLinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkLogout" runat="server" >LogOut</asp:LinkButton></li>
    </ul>
    <div id="logindiv" style="display: none">
        <uc2:Login ID="Login1" runat="server" />
    </div>
    <div id="creatediv" style="display: none">
        <uc1:Create ID="Create1" runat="server" />
    </div>
</div>
<div style="clear: both">
</div>
<div>
    <asp:PlaceHolder ID="ActionMenu" runat="server"></asp:PlaceHolder>
</div>
