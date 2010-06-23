<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserExamResult.ascx.cs"
    Inherits="User_UserControl_Exam_UserExamResult" %>
<asp:ListView ID="ListUserExam" runat="server" OnItemDataBound="ListUserExamOnItemDataBound">
    <LayoutTemplate>
        <table>
            <thead>
                <tr>
                    
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
                        StartDate
                    </td>
                    <td>
                        EndDate
                    </td>
                    <td>
                        Complete Time
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
                <%#Eval("Marks")%>
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
           
    </ItemTemplate>
</asp:ListView>
<div>
    <div style="float: right">
        <div style="float: left">
            <asp:LinkButton ID="lnkPrev" runat="server" Text="Prev" OnClick="Prev_Click"></asp:LinkButton>
        </div>
        <div style="float: left">
            <asp:LinkButton ID="lnkNext" runat="server" Text="Next" OnClick="Next_Click"></asp:LinkButton>
        </div>
    </div>
    <div style="clear: both">
    </div>
</div>
