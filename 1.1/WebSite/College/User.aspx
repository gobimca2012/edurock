<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="User.aspx.cs" Inherits="College_User" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <ul>
            <li>
                <aspajax:HyperLink ID="lnkUSer" runat="server" ContainnerID="#User" NavigateUrl="~/College/Ajaxer/InstituteUserInfoView.aspx">User</aspajax:HyperLink>
            </li>
            <li>
                <aspajax:HyperLink ID="lnkUSerType" runat="server" ContainnerID="#User" NavigateUrl="~/College/Ajaxer/InstituteUserTypeInfoView.aspx">User Type</aspajax:HyperLink>
            </li>
        </ul>
    </div>
    <div class="contentbox">
        <div id="User">
        </div>
    </div>
</asp:Content>
