<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLander.aspx.cs" Inherits="College_Ajaxer_AdminLander" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/College/Ajaxer/InstituteInfoView.aspx"
                    ContainnerID="#contentBox">Institute Information</aspajax:HyperLink>
            </li>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkCource" runat="server" NavigateUrl="~/College/Ajaxer/InstituteCourceInfoView.aspx"
                    ContainnerID="#contentBox"><cram:SpaceLabel ID="ttspace" runat="server"></cram:SpaceLabel></aspajax:HyperLink></li>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkUSer" runat="server" ContainnerID="#contentBox" NavigateUrl="~/College/Ajaxer/InstituteUserInfoView.aspx">User</aspajax:HyperLink>
            </li>
           <%-- <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkUSerType" runat="server" ContainnerID="#contentBox" NavigateUrl="~/College/Ajaxer/InstituteUserTypeInfoView.aspx">User Type</aspajax:HyperLink>
            </li>--%>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkCourceCat" runat="server" NavigateUrl="~/College/Ajaxer/CourceCatagoryInfoView.aspx"
                    ContainnerID="#contentBox"><cram:SpaceLabel ID="SpaceLabel1" runat="server"></cram:SpaceLabel> Catagory</aspajax:HyperLink><%--<a href="#tabs-5">Cource Catagory</a>--%></li>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkQuestionType" runat="server" NavigateUrl="~/College/Ajaxer/QuestionTypeInfoView.aspx"
                    ContainnerID="#contentBox">Question Type</aspajax:HyperLink><%--<a href="#tabs-5">Cource Catagory</a>--%></li>
            <li class="btn roundedall">
                <aspajax:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/College/Ajaxer/InstituteUserTypeInfoView.aspx"
                    ContainnerID="#contentBox">User Role</aspajax:HyperLink><%--<a href="#tabs-5">Cource Catagory</a>--%></li>
                      <li class="btn roundedall">
                <aspajax:HyperLink ID="lnkSetting" runat="server" NavigateUrl="~/College/Ajaxer/PortalSetting.aspx"
                    ContainnerID="#contentBox">System Settings</aspajax:HyperLink><%--<a href="#tabs-5">Cource Catagory</a>--%></li>
        </ul>
    </div>
    </form>
</body>
</html>
