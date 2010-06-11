<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddSingleFillInTheBlank.ascx.cs"
    Inherits="AddSingleFillInTheBlank" %>
<%@ Register Src="../UserControl/ListAnswer.ascx" TagName="ListAnswer" TagPrefix="uc2" %>
<div id="divError" runat="server">
</div>
<asp:Panel ID="panelSingleChoice" runat="server">
    <div id="EXM_Question">
        <table>
            <tr>
                <td>
                    <span class="label">Question</span>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtQuestionPart1" runat="server" Width="579px"></asp:TextBox>
                    <span style="border-bottom: solid 1px">Fill in the Blank</span><br />
                    <asp:TextBox ID="txtQuestionPart2" runat="server" Width="579px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Select your question Type
                </td>
                <td class="style1">
                    <asp:RadioButtonList ID="rdbQuestionType" runat="server">
                        <asp:ListItem Text="Single Choice" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Multiple Choice" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Single Fill in the Blanks" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Multiple Fill in the Blanks" Value="4"></asp:ListItem>
                        <asp:ListItem Text="Match words" Value="5"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <span class="label">Description</span>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="329px"
                        Width="670px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span class="label">Marks</span>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtMarks" runat="server" Width="62px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div>
            <asp:LinkButton ID="lnkNextStep" runat="server" OnClick="lnkNextStep_Click">Next 
                Step</asp:LinkButton>
            <asp:LinkButton ID="lnkUpdate" runat="server" OnClick="lnkUpdate_Click" Visible="false">Update</asp:LinkButton>
        </div>
    </div>
    <div id="DivAnswerList" runat="server" visible="false">
        <uc2:ListAnswer ID="ListAnswer1" runat="server" />
    </div>
</asp:Panel>
