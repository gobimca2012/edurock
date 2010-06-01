<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CollegeMenu.ascx.cs" Inherits="LayoutControl_Menu_CollegeMenu" %>
<asp:Menu ID="CollegeMenu" runat="server" Orientation="Horizontal">
    <Items>
        <asp:MenuItem Text="Dashboard"></asp:MenuItem>
        <asp:MenuItem Text="Assignments"></asp:MenuItem>
        <asp:MenuItem Text="Online Exams" NavigateUrl="~/AddQuestion.aspx">
        </asp:MenuItem>
        <asp:MenuItem Text="Results"></asp:MenuItem>
        <asp:MenuItem Text="Profesors"></asp:MenuItem>
        <asp:MenuItem Text="Students"></asp:MenuItem>
    </Items>
    <StaticMenuItemStyle CssClass="menu" />
</asp:Menu>
