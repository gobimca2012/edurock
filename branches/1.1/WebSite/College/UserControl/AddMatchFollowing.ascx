<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddMatchFollowing.ascx.cs"
    Inherits="AddMatchFollowing" %>
<style type="text/css">
    .style1
    {
        width: 545px;
    }
</style>
<%@ Register Src="../UserControl/ListAnswer.ascx" TagName="ListAnswer" TagPrefix="uc2" %>
<div class="contentbox">
    <div id="divError" runat="server">
    </div>
    <div>
        <table>
            <tr>
                <td>
                    Question 1
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtQuestion1" runat="server" CssClass="qtxt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Question 2
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtQuestion2" runat="server" CssClass="qtxt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Question 3
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtQuestion3" runat="server" CssClass="qtxt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Question 4
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtQuestion4" runat="server" CssClass="qtxt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Description
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtDescription" runat="server" CssClass="qtxt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Marks
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtMarks" runat="server" CssClass="qtxt"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:LinkButton ID="lnkAdd" runat="server" OnClick="txtAdd_Click">Add</asp:LinkButton>
        <asp:LinkButton ID="lnkUpdate" runat="server" Visible="false" OnClick="txtUpdate_Click">Update</asp:LinkButton>
    </div>
    <div id="DivAnswerList" runat="server" visible="false">
        <uc2:ListAnswer ID="ListAnswer1" runat="server" />
    </div>
</div>
