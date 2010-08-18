<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteUserTypeInfoView.aspx.cs"
    Inherits="College_Ajaxer_InstituteUserTypeInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            User Type</div>
        <div>
            <asp:ListView ID="ListInstituteUserType" runat="server">
                <LayoutTemplate>
                    <table>
                        <thead>
                            <tr>
                                <td>
                                    Name
                                </td>
                                <td>
                                    Description
                                </td>
                                <td>
                                    ModifiedDate
                                </td>
                            </tr>
                        </thead>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%#Eval("Name") %>
                        </td>
                        <td>
                            <%#Eval("Description") %>
                        </td>
                        <td>
                            <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                        </td>
                        <td>
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteUserTypeID").ToString(), "#contentBox", "#contentBox")%>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteUserTypeInfo.aspx") + "?cid=" + Eval("InstituteUserTypeID")%>'
                                ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkAccess" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteTypeAccessInfo.aspx") + "?iutid=" + Eval("InstituteUserTypeID")%>'
                                ContainnerID="#contentBox">Access</aspajax:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevInstituteUserType" runat="server" Text="Prev"
                        OnAjaxClick="PrevAjaxClick" Pagger="true" Increment="false" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextInstituteUserType" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="float: left">
                <aspajax:HyperLink ID="hpAddInstituteUserType" runat="server" NavigateUrl="~/College/Ajaxer/InstituteUserTypeInfo.aspx"
                    ContainnerID="#contentBox"><div class="btn editbtn"> Add New</div></aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
