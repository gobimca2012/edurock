<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdminNavigation.ascx.cs"
    Inherits="LayoutControl_Menu_AdminNavigation" %>
<div class="menu">
    <asp:Menu ID="CollegeMenu" runat="server" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="Cource" NavigateUrl="~/Admin/Cource.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Colleges" NavigateUrl="~/Admin/Cource.aspx"></asp:MenuItem>
            <asp:MenuItem Text="UserList" NavigateUrl="~/Admin/Cource.aspx"></asp:MenuItem>
        </Items>
    </asp:Menu>
</div>
