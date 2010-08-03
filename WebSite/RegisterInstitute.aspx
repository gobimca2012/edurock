<%@ Page Language="C#" MasterPageFile="~/MasterPage/OutSideUser.master" AutoEventWireup="true"
    CodeFile="RegisterInstitute.aspx.cs" Inherits="RegisterInstitute" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div style="float: left">
            <aspajax:HyperLink ID="lnkUserReg" runat="server" NavigateUrl="~/All/Ajaxer/RegisterUser.aspx"
                ContainnerID="#contentBox"><div class="btn">User</div></aspajax:HyperLink>
        </div>
        <div style="float: left">
            <aspajax:HyperLink ID="lnkInstiReg" runat="server" NavigateUrl="~/All/Ajaxer/RegisterInstitute.aspx"
                ContainnerID="#contentBox"><div class="btn">Institute</div></aspajax:HyperLink>
        </div>
        <div style="clear: both">
        </div>
    </div>
    
    
</asp:Content>
