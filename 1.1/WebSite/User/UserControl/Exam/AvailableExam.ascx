<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AvailableExam.ascx.cs"
    Inherits="User_UserControl_Exam_AvailableExam" %>
<div class="contentbox">
    <asp:ListView ID="ListExam" runat="server" DataKeyNames="ExamID">
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
                    </tr>
                </thead>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:HyperLink ID="lnkExam" runat="server" NavigateUrl='<%#ResolveUrl("~/College/ExamIntroduction.aspx")+"?eid="+Eval("ExamID") %>'>
                        <%#Eval("ExamName") %></asp:HyperLink>
                </td>
                <td>
                    <%#Eval("SubjectName") %>
                </td>
                <td>
                    <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("ModifiedDate"))) %>
                </td>
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
