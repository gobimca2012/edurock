<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="AccountSetting.aspx.cs" Inherits="College_AccountSetting" Title="Untitled Page" %>

<%@ Register Src="UserControl/AddInstituteInfo.ascx" TagName="AddInstituteInfo" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <div id="tabs">
            <ul>
                <li>
                    <aspajax:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/College/Ajaxer/InstituteInfoView.aspx"
                        ContainnerID="#courceinfo">Profile Edit</aspajax:HyperLink>
                </li>
                <li>
                    <aspajax:HyperLink ID="lnkCource" runat="server" NavigateUrl="~/College/Ajaxer/InstituteCourceInfoView.aspx"
                        ContainnerID="#courceinfo">Cource</aspajax:HyperLink></li>
                <li>
                    <aspajax:HyperLink ID="lnkUSer" runat="server" ContainnerID="#courceinfo" NavigateUrl="~/College/Ajaxer/InstituteUserInfoView.aspx">User</aspajax:HyperLink>
                </li>
                <li>
                    <aspajax:HyperLink ID="lnkUSerType" runat="server" ContainnerID="#courceinfo" NavigateUrl="~/College/Ajaxer/InstituteUserTypeInfoView.aspx">User Type</aspajax:HyperLink>
                </li>
                <li>
                    <aspajax:HyperLink ID="lnkCourceCat" runat="server" NavigateUrl="~/College/Ajaxer/CourceCatagoryInfoView.aspx"
                        ContainnerID="#courceinfo">Cource Catagory</aspajax:HyperLink><%--<a href="#tabs-5">Cource Catagory</a>--%></li>
                <li>
                    <aspajax:HyperLink ID="lnkQuestionType" runat="server" NavigateUrl="~/College/Ajaxer/QuestionTypeInfoView.aspx"
                        ContainnerID="#courceinfo">Question Type</aspajax:HyperLink><%--<a href="#tabs-5">Cource Catagory</a>--%></li>
            </ul>
            <div id="tabs-1">
                <div id="divMessage" runat="server">
                </div>
                <div id="accountsetting">
                </div>
            </div>
            <div id="tabs-2">
                <div id="courcecatagory">
                </div>
            </div>
            <div id="tabs-3">
                <div id="courceinfo">
                </div>
            </div>
            <div id="tabs-4">
                <div id="User">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
