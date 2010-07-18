<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceUserInfoView.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceUserInfoView" %>

<%@ Register Src="~/User/UserControl/UserNameToolTipLink.ascx" TagName="UserNameToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
        </div>
        <div class="whitecont">
            <asp:ListView ID="ListInstituteCourceUser" runat="server">
                <LayoutTemplate>
                    <table>
                        <thead>
                            <tr>
                                <td>
                                    Cource
                                </td>
                                <td>
                                    User
                                </td>
                                <%-- <td>
                                    Type
                                </td>--%>
                                <td>
                                    Modifieddate
                                </td>
                            </tr>
                        </thead>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%#new BusinessLogic.InstituteCourceController().GetInstituteCourceName(Convert.ToInt32( Eval("InstituteCourceID"))) %>
                        </td>
                        <td>
                            <uc1:UserNameToolTipLink ID="UserNameToolTipLink1" runat="server" LoginUserID='<%# Eval("LoginUserID") %>' />
                        </td>
                        <%-- <td>
                            <%#Eval("Type") %>
                        </td>--%>
                        <td>
                            <%#Eval("Modifieddate") %>
                        </td>
                        <td>
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteCourceUserID").ToString(), "#contentBox", "#contentBox")%>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteCourceUserInfo.aspx") + "?icuid=" + Eval("InstituteCourceUserID")%>'
                                ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevInstituteCourceUser" runat="server" Text="Prev"
                        OnAjaxClick="PrevAjaxClick" Pagger="true" Increment="false" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextInstituteCourceUser" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="float: left">
                <aspajax:HyperLink ID="hpAddInstituteCourceUser" runat="server" ContainnerID="#contentBox">Add New</aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
