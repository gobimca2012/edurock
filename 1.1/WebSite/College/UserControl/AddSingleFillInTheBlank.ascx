<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddSingleFillInTheBlank.ascx.cs"
    Inherits="AddSingleFillInTheBlank" %>
<%@ Register Src="../UserControl/ListAnswer.ascx" TagName="ListAnswer" TagPrefix="uc2" %>
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
                    <asp:TextBox ID="txtQuestionPart1" runat="server" Width="579px"></asp:TextBox>
                    <span style="border-bottom: solid 1px">Fill in the Blank</span><br />
                    <asp:TextBox ID="txtQuestionPart2" runat="server" Width="579px"></asp:TextBox>
                </div>
            </div>
           
            <div>
                <div>
                    <span class="label">Description</span>
                </div>
                <div class="style1">
                    <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="329px"
                        Width="670px"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Marks</span>
                </div>
                <div class="style1">
                    <asp:TextBox ID="txtMarks" runat="server" Width="62px"></asp:TextBox>
                </div>
            </div>
        </div>
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
