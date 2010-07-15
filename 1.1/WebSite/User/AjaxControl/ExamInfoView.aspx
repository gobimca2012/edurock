<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamInfoView.aspx.cs" Inherits="College_Ajaxer_ExamInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Exams
        </div>
        <div class="whitecont">
            <asp:ListView ID="ListExam" runat="server">
                <LayoutTemplate>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <%--<tr>
                    <td>
                        <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Exam.aspx") + "?eid=" + Eval("ExamID").ToString()%>'>
                        <%#Eval("ExamName") %></aspajax:HyperLink>
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
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
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
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/ExamInfo.aspx") + "?eid=" + Eval("ExamID")%>'
                            ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkExmStart" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/College/ExamIntroduction.aspx") + "?eid=" + Eval("ExamID").ToString()%>'>Start Exam</aspajax:HyperLink>
                    </td>
                </tr>--%>
                    <div style="float: left">
                        <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Exam.aspx") + "?eid=" + Eval("ExamID").ToString()%>'>
                        <%#Eval("ExamName") %></aspajax:HyperLink>
                    </div>
                    <div style="float: right">
                        <span>
                            <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %></span>
                    </div>
                    <div style="clear:both"></div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
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
            <div style="float: left">
                <aspajax:HyperLink ID="hpAddExam" runat="server" NavigateUrl="~/User/AjaxControl/ExamInfo.aspx"
                    ContainnerID="#contentBox">Add New</aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
