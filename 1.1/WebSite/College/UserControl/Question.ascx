<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Question.ascx.cs" Inherits="College_UserControl_Question" %>
<div class="contentbox">
    <div id="DivSingleChoice" runat="server">
        <div>
            <span id="lblQuestion" runat="server" class="label"></span>
        </div>
        <div>
            <asp:RadioButtonList ID="chkOption" runat="server">
            </asp:RadioButtonList>
        </div>
    </div>
    <div id="DivMultipleChoice" runat="server">
        <div>
            <span id="lblMultiQustion" runat="server" class="label"></span>
        </div>
        <div>
            <asp:CheckBoxList ID="chkMulti" runat="server" />
        </div>
    </div>
    <div>
    </div>
    <div>
        Marks : <span id="lblMarks" runat="server" class="label"></span>
    </div>
    <div style="clear: both">
        <div style="float: left; padding: 5px;">
            <asp:LinkButton ID="lnkPrev" runat="server" Text="Prev" OnClick="lnkPrev_Click"></asp:LinkButton></div>
        <div style="float: left; padding: 5px;">
            <asp:LinkButton ID="lnkNext" runat="server" Text="Next" OnClick="lnkNext_Click"></asp:LinkButton></div>
    </div>
</div>
