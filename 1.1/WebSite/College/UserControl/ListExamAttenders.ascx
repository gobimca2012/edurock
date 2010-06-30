<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListExamAttenders.ascx.cs"
    Inherits="College_UserControl_ListExamAttenders" %>
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
                <%#Eval("Marks") %>
            </td>
            <td>
                <%#Eval("StartTime") %>
            </td>
            <td>
                <%#Eval("EndTime") %>
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
            <asp:LinkButton ID="lnkPrev" runat="server" Text="Prev" OnClick="Prev_Click"></asp:LinkButton>
        </div>
        <div style="float: left">
            <asp:LinkButton ID="lnkNext" runat="server" Text="Next" OnClick="Next_Click"></asp:LinkButton>
        </div>
    </div>
    <div style="clear: both">
    </div>
</div>
