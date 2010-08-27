<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamInfoView.aspx.cs" Inherits="College_Ajaxer_ExamInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListExam" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                ExamID
                            </td>
                            <td>
                                ExamName
                            </td>
                            <td>
                                SubjectName
                            </td>
                            <td>
                                InstituteCourceID
                            </td>
                            <td>
                                InstituteSubjectID
                            </td>
                            <td>
                                Description
                            </td>
                            <td>
                                LoginUserID
                            </td>
                            <td>
                                ModifiedDate
                            </td>
                            <td>
                                ExamTime
                            </td>
                            <td>
                                IsActive
                            </td>
                            <td>
                                RequirePecentage
                            </td>
                            <td>
                                StartDate
                            </td>
                            <td>
                                EndDate
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("ExamID") %>
                    </td>
                    <td>
                        <%#Eval("ExamName") %>
                    </td>
                    <td>
                        <%#Eval("SubjectName") %>
                    </td>
                    <td>
                        <%#Eval("InstituteCourceID") %>
                    </td>
                    <td>
                        <%#Eval("InstituteSubjectID") %>
                    </td>
                    <td>
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                    </td>
                    <td>
                        <%#Eval("ExamTime") %>
                    </td>
                    <td>
                        <%#Eval("IsActive") %>
                    </td>
                    <td>
                        <%#Eval("RequirePecentage") %>
                    </td>
                    <td>
                        <%#Eval("StartDate") %>
                    </td>
                    <td>
                        <%#Eval("EndDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("ExamID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/ExamInfo.aspx") + "?cid=" + Eval("ExamID")%>'
                            ContainnerID="#courceinfo"><%=Resources.Default.Edit_Text %></aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevExam" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextExam" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddExam" runat="server" NavigateUrl="~/Admin/Ajaxer/ExamInfo.aspx"
                ContainnerID="#contentBox"><%=Resources.Default.Add_Text%></aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
