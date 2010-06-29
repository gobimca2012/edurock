﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AvailableExam.ascx.cs"
    Inherits="User_UserControl_Exam_AvailableExam" %>
<div id="examOpen">
</div>
<div class="contentbox">
    <asp:ListView ID="ListExam" runat="server" DataKeyNames="ExamID" OnItemDataBound="ListUserExamOnItemDataBound">
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
                            ModifiedDate
                        </td>
                        <td>
                            Start Date
                        </td>
                        <td>
                            End Date
                        </td>
                        <%--<td>
                            Status
                        </td>--%>
                    </tr>
                </thead>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:HyperLink ID="lnkExam" runat="server">
                        <%#Eval("ExamName") %></asp:HyperLink>
                </td>
                <td>
                    <%#Eval("SubjectName") %>
                </td>
                <td>
                    <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("ModifiedDate"))) %>
                </td>
                <td>
                    <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("StartDate"))) %>
                </td>
                <td>
                    <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("EndDate"))) %>
                </td>
                <td>
                    <asp:HyperLink ID="lnkResult" runat="server">Results</asp:HyperLink>
                </td>
                <%-- <td>
                    <%#BusinessLogic.UserExamController.GetStatus(Convert.ToBoolean(Eval("IsFinish").ToString()))%>
                </td>--%>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</div>
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

<script type="text/javascript">
function PopUpExam(PopUpContainnerID, url, width, height, closeUrl)
{
   $(PopUpContainnerID).LoadPage(url);
   $(PopUpContainnerID).dialog(
   {
      // autoOpen : false,
      height : height + 'px',
      width : width + 'px',
      modal : true,
      position : ['center', 20],
      beforeclose : function()
      {
         SubmitAnswer(PopUpContainnerID, closeUrl)
         
      }

   }
   );
   return false;
}

//  ---------------------------------------


</script>

