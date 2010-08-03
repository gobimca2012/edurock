<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddSingleChoiceQuestion.ascx.cs"
    Inherits="College_UserControl_AddSingleChoiceQuestion" %>
<%@ Register Src="../UserControl/ListAnswer.ascx" TagName="ListAnswer" TagPrefix="uc2" %>
<div class="contentbox">
    <div id="divError" runat="server">
    </div>
    <asp:Panel ID="panelSingleChoice" runat="server">
        <div id="EXM_Question">
            <div>
                <span class="label">Question</span>
            </div>
            <div class="style1">
                <asp:TextBox ID="txtQuestion" runat="server" Width="579px"></asp:TextBox>
            </div>
            <div>
                <span class="label">Description</span>
            </div>
            <div class="style1">
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="329px"
                    Width="576px"></asp:TextBox>
            </div>
            <div>
                <span class="label">Marks</span>
            </div>
            <div class="style1">
                <asp:TextBox ID="txtMarks" runat="server" Width="576px"></asp:TextBox>
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
