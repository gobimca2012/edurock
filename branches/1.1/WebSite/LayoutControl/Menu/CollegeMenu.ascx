<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CollegeMenu.ascx.cs" Inherits="LayoutControl_Menu_CollegeMenu" %>
<div class="menu">
    <asp:Menu ID="CollegeMenu" runat="server" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="Online Exams" NavigateUrl="~/College/ListExam.aspx"></asp:MenuItem>
        </Items>
    </asp:Menu>
</div>
