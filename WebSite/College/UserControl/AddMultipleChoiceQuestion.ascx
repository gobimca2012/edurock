<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddMultipleChoiceQuestion.ascx.cs"
    Inherits="AddMultipleChoiceQuestionSubLayout" %>
<%@ Register Src="../UserControl/ListAnswer.ascx" TagName="ListAnswer" TagPrefix="uc2" %>
<div class="contentbox">
    <div id="divError" runat="server">
    </div>
    <asp:Panel ID="panelSingleChoice" runat="server">
        <div id="EXM_Question">
            <div>
                <div>
                    <div>
                        <span class="label">Question</span>
                    </div>
                    <div class="style1">
                        <asp:TextBox ID="txtQuestion" runat="server" Width="579px"></asp:TextBox>
                    </div>
                </div>
             <%--   <div>
                    <div>
                        Select your question Type
                    </div>
                    <div>
                        <div class="style1">
                            <asp:RadioButtonList ID="rdbQuestionType" runat="server">
                                <asp:ListItem Text="Single Choice" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Multiple Choice" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Single Fill in the Blanks" Value="3"></asp:ListItem>
                                <asp:ListItem Text="Multiple Fill in the Blanks" Value="4"></asp:ListItem>
                                <asp:ListItem Text="Match words" Value="5"></asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                    </div>
                </div>--%>
                <div>
                    <div>
                        <span class="label">Description</span>
                    </div>
                    <div class="style1">
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="329px"
                            Width="576px"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Marks</span>
                    </div>
                    <div class="style1">
                        <asp:TextBox ID="txtMarks" runat="server" Width="576px"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>
                <asp:LinkButton ID="lnkNextStep" runat="server" OnClick="lnkNextStep_Click">Next 
                Step</asp:LinkButton>
                <asp:LinkButton ID="lnkUpdate" runat="server" OnClick="lnkUpdate_Click" Visible="false">Update</asp:LinkButton>
            </div>
        </div>
    </asp:Panel>
    <div id="DivAnswerList" runat="server" visible="false">
        <uc2:ListAnswer ID="ListAnswer1" runat="server" />
    </div>
</div>
