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
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteUserTypeID").ToString(), "#User", "#User")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/InstituteUserTypeInfo.aspx") + "?cid=" + Eval("InstituteUserTypeID")%>'
                            ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevInstituteUserType" runat="server" Text="Prev"
                        OnAjaxClick="PrevAjaxClick" Pagger="true" Increment="false" RequestContainner="#User"
                        ResponseContainner="#User"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextInstituteUserType" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#User" Pagger="true" Increment="true" ResponseContainner="#User">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddInstituteUserType" runat="server" NavigateUrl="~/College/Ajaxer/InstituteUserTypeInfo.aspx"
                ContainnerID="#User">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
