<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteTypeAccessInfoView.aspx.cs"
    Inherits="College_Ajaxer_InstituteTypeAccessInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListInstituteTypeAccess" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                InstituteTypeAccessID
                            </td>
                            <td>
                                InstituteUserTypeID
                            </td>
                            <td>
                                CanAddExam
                            </td>
                            <td>
                                CanAddQuestion
                            </td>
                            <td>
                                CanAddUser
                            </td>
                            <td>
                                CanAddCource
                            </td>
                            <td>
                                CanAddSubject
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
                        <%#Eval("InstituteTypeAccessID") %>
                    </td>
                    <td>
                        <%#Eval("InstituteUserTypeID") %>
                    </td>
                    <td>
                        <%#Eval("CanAddExam") %>
                    </td>
                    <td>
                        <%#Eval("CanAddQuestion") %>
                    </td>
                    <td>
                        <%#Eval("CanAddUser") %>
                    </td>
                    <td>
                        <%#Eval("CanAddCource") %>
                    </td>
                    <td>
                        <%#Eval("CanAddSubject") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteTypeAccessID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteTypeAccessInfo.aspx") + "?cid=" + Eval("InstituteTypeAccessID")%>'
                            ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevInstituteTypeAccess" runat="server" Text="Prev"
                        OnAjaxClick="PrevAjaxClick" Pagger="true" Increment="false" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextInstituteTypeAccess" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddInstituteTypeAccess" runat="server" NavigateUrl="~/College/Ajaxer/InstituteTypeAccessInfo.aspx"
                ContainnerID="#contentBox">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
