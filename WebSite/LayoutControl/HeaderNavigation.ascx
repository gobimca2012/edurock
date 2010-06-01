<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HeaderNavigation.ascx.cs"
    Inherits="LayoutControl_HeaderNavigation" %>
<%@ Register Assembly="AjaxControl" Namespace="AjaxControl" TagPrefix="cc1" %>
<div style="float: right">
    <ul>
        <li>
            <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
        </li>
        <li>
            <cc1:ShowHideLinkButton ID="lnkLogin" runat="server" Show="true" ContainnerID="#logindiv">Login</cc1:ShowHideLinkButton>
        </li>
        <li>
            <cc1:ShowHideLinkButton ID="lnkCreate" runat="server" Show="true" ContainnerID="#creatediv">Create</cc1:ShowHideLinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkLogout" runat="server" OnClick="lnkLogout_Click">LogOut</asp:LinkButton></li>
    </ul>
    <div id="logindiv" style="display: none">
    </div>
    <div id="creatediv" style="display: none">
    </div>
</div>
<div style="clear: both">
</div>
<div>
    <asp:PlaceHolder ID="ActionMenu" runat="server"></asp:PlaceHolder>
</div>
