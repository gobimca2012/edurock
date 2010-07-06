<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceInfoView.aspx.cs"
    Theme="Default" Inherits="College_Ajaxer_InstituteCourceInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Institute Cources
        </div>
        <asp:ListView ID="ListInstituteCource" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                Cource
                            </td>
                            <td>
                                StartDate
                            </td>
                            <td>
                                EndDate
                            </td>
                            <td>
                                IsPublished
                            </td>
                            <%--<td>
                            HomeWorkEnable
                        </td>
                        <td>
                            AttendanceEnable
                        </td>
                        <td>
                            QuestionAnswerEnable
                        </td>
                        <td>
                            SelfRegistrationEnable
                        </td>
                        <td>
                            IsFree
                        </td>
                        <td>
                            Price
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
                        <aspajax:HyperLink ID="lnkFullvIew" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteCource.aspx") + "?icid=" + Eval("InstituteCourceID").ToString()%>'>    <%#Eval("Cource.CourceName")%></aspajax:HyperLink>
                    </td>
                    <%--<td>
                    <%#Eval("MetaDescription") %>
                </td>
                <td>
                    <%#Eval("MetaKeyword") %>
                </td>--%>
                    <td>
                        <%#Eval("StartDate") %>
                    </td>
                    <td>
                        <%#Eval("EndDate") %>
                    </td>
                    <td>
                        <%#Eval("IsPublished") %>
                    </td>
                    <%--<td>
                    <%#Eval("HomeWorkEnable") %>
                </td>
                <td>
                    <%#Eval("AttendanceEnable") %>
                </td>
                <td>
                    <%#Eval("QuestionAnswerEnable") %>
                </td>
                <td>
                    <%#Eval("SelfRegistrationEnable") %>
                </td>
                <td>
                    <%#Eval("IsFree") %>
                </td>
                <td>
                    <%#Eval("Price") %>
                </td>--%>
                    <td>
                        <%#Eval("Modifieddate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteCourceID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteCourceInfo.aspx") + "?icid=" + Eval("InstituteCourceID")%>'
                            ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkSubject" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteSubjectInfoView.aspx") + "?icid=" + Eval("InstituteCourceID").ToString()%>'
                            ContainnerID="#contentBox">Subjects</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div class="gray">
            <div>
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevInstituteCource" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextInstituteCource" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                    </div>
                </div>
            </div>
            <div style="float: left">
                <aspajax:HyperLink ID="hpAddInstituteCource" runat="server" NavigateUrl="~/College/Ajaxer/InstituteCourceInfo.aspx"
                    ContainnerID="#contentBox"><div class="gray"> Add New</div></aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
