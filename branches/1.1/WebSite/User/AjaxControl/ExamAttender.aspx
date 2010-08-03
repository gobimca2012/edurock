<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamAttender.aspx.cs" Inherits="User_AjaxControl_ExamAttender" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListUserExam" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                User
                            </td>
                            <td>
                                Marks
                            </td>
                            <td>
                                StartTime
                            </td>
                            <td>
                                EndDate
                            </td>
                            <td>
                                RequirePercentage
                            </td>
                            <td>
                                Status
                            </td>
                            <td>
                                Time Took
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
                        <%#Eval("FirstName") %>&nbsp;<%#Eval("LastName")%>
                    </td>
                    <td>
                        <%#Eval("Marks") %>/<%#Eval("ExamTotalMarks")%>
                    </td>
                    <td>
                        <%#Eval("StartTime") %>
                    </td>
                    <td>
                        <%#Eval("EndTime") %>
                    </td>
                    <td>
                        <%#Eval("RequirePecentage")%>
                    </td>
                    <td>
                        <%#Eval("IsFinish") %>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetTime(Convert.ToDateTime(Eval("EndTime").ToString()), Convert.ToDateTime(Eval("StartTime").ToString()))%>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("ModifiedDate").ToString())) %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
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
    </div>
    </form>
</body>
</html>
