<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="Cource.aspx.cs" Inherits="College_Cource" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <ul>
            <li>
                <aspajax:HyperLink ID="lnkCourceCat" runat="server" NavigateUrl="~/College/Ajaxer/CourceCatagoryInfoView.aspx"
                    ContainnerID="#courceinfo">Cource Catagory</aspajax:HyperLink>
            </li>
            <li>
                <aspajax:HyperLink ID="lnkCource" runat="server" NavigateUrl="~/College/Ajaxer/InstituteCourceInfoView.aspx"
                    ContainnerID="#courceinfo">Cource</aspajax:HyperLink>
            </li>
        </ul>
    </div>
    <div class="contentbox">
        <div id="courceinfo">
        </div>
    </div>
</asp:Content>
