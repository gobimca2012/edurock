﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="Cource.aspx.cs" Inherits="Admin_Cource" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <ul>
            <li>
                <asp:HyperLink ID="lnkCourceCat" runat="server" NavigateUrl="~/Admin/CourceCatagory.aspx">Cource Catagory</asp:HyperLink></li>
        </ul>
    </div>
    <div id="courceinfo">
    </div>
</asp:Content>