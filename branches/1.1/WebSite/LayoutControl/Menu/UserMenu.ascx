﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserMenu.ascx.cs" Inherits="LayoutControl_Menu_UserMenu" %>
<div class="menu">
    <asp:Menu ID="CollegeMenu" runat="server" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="Dashboard" NavigateUrl="~/User/DashBoard.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Available Exams" NavigateUrl="~/User/Exam.aspx"></asp:MenuItem>
            
            <asp:MenuItem Text="Institute" NavigateUrl="~/All/Institute.aspx"></asp:MenuItem>
        </Items>
    </asp:Menu>
</div>