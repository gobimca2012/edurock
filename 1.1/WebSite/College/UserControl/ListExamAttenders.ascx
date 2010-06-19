<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListExamAttenders.ascx.cs"
    Inherits="College_UserControl_ListExamAttenders" %>
<asp:ListView ID="ListUserExam" runat="server">
    <LayoutTemplate>
        <table>
            <thead>
                <tr>
                    <td>
                        UserExamID
                    </td>
                    <td>
                        LoginUserID
                    </td>
                    <td>
                        ExamID
                    </td>
                    <td>
                        StartTime
                    </td>
                    <td>
                        EndDate
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
                <%#Eval("UserExamID") %>
            </td>
            <td>
                <%#Eval("LoginUserID") %>
            </td>
            <td>
                <%#Eval("ExamID") %>
            </td>
            <td>
                <%#Eval("StartTime") %>
            </td>
            <td>
                <%#Eval("EndDate") %>
            </td>
            <td>
                <%#Eval("ModifiedDate") %>
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