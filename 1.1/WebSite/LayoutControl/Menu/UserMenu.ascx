<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserMenu.ascx.cs" Inherits="LayoutControl_Menu_UserMenu" %>
<div class="menu">
    <asp:Menu ID="CollegeMenu" runat="server" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="Dashboard" NavigateUrl="~/User/DashBoard.aspx"></asp:MenuItem>
            
        </Items>
        <StaticMenuItemStyle CssClass="menu" />
    </asp:Menu>
</div>