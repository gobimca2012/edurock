<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserExamResult.aspx.cs" Inherits="User_AjaxControl_UserExamResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <asp:ListView ID="ListUserExam" runat="server">
            <LayoutTemplate>
                <table >
                    <thead class="gray">
                        <tr class="gray">
                            <td>
                                ExamName
                            </td>
                            <td>
                                SubjectName
                            </td>
                            <td>
                                Marks
                            </td>
                            <td>
                                Result
                            </td>
                            <td>
                                Start Date
                            </td>
                            <td>
                                End Date
                            </td>
                            <td>
                                Complete Time
                            </td>
                            <td>
                                Status
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("ExamName")%>
                    </td>
                    <td>
                        <%#Eval("SubjectName")%>
                    </td>
                    <td>
                        <%#Eval("Marks")%>/<%#Eval("ExamTotalMarks") %>
                    </td>
                    <td>
                        <%#new BusinessLogic.UserExamController().GetExamPassorFail(Convert.ToDecimal(Eval("Marks").ToString()), Convert.ToInt32(Eval("RequirePecentage").ToString()), Convert.ToDecimal(Eval("ExamTotalMarks").ToString()))%>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("StartDate").ToString()))%>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("EndDate")))%>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetTime(Convert.ToDateTime(Eval("EndTime").ToString()),Convert.ToDateTime(Eval("StartTime").ToString()))%>
                    </td>
                    <td>
                        <%#BusinessLogic.UserExamController.GetExamStatus(Convert.ToBoolean(Eval("IsFinish")))%>
                    </td>
            </ItemTemplate>
        </asp:ListView>
        <div style="display:none">
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevExam" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#Exam" ResponseContainner="#Exam"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextExam" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#Exam" Pagger="true" Increment="true" ResponseContainner="#Exam">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
        </div>
    </div>
    </form>
</body>
</html>
