<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="AccountSetting.aspx.cs" Inherits="User_AccountSetting" Title="Untitled Page" %>

<%@ Register Src="UserControl/AccountSetting/Education.ascx" TagName="Education"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <div id="tabs">
            <ul>
                <li><a href="#tabs-1">Personal Info</a></li>
                <li><a href="#tabs-2">Education Info</a></li>
            </ul>
            <div id="tabs-1">
                <div id="divMessage" runat="server">
                </div>
                <div id="accountsetting">
                </div>
            </div>
            <div id="tabs-2">
                <div id="education"></div>
            </div>
        </div>
    </div>
    
</asp:Content>
