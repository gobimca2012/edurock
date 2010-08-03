<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddExam.ascx.cs" Inherits="College_UserControl_AddExam" %>
<div class="contentbox">
    <fieldset>
        <legend>Exam</legend>
        <div>
            <span class="label">ExamName</span>
        </div>
        <div>
            <asp:TextBox ID="txtExamName" runat="server" Width="570px"></asp:TextBox>
        </div>
        <div>
            <span class="label">SubjectName</span>
        </div>
        <div>
            <asp:TextBox ID="txtSubjectName" runat="server" Width="569px"></asp:TextBox>
        </div>
        <div>
            <span class="label">Description</span>
        </div>
        <div>
            <asp:TextBox ID="txtDescription" runat="server" Width="773px" TextMode="MultiLine"
                Height="673px"></asp:TextBox>
        </div>
        <div>
            Examination Time
        </div>
        <div>
            <span>Hours :
                <asp:TextBox ID="txtHour" runat="server"></asp:TextBox></span><span>&nbsp;Minuts :
                    <asp:TextBox ID="txtMinut" runat="server"></asp:TextBox></span>
        </div>
        <div>
            Required Percentage for Pass
        </div>
        <div>
            <asp:TextBox ID="txtRequiredPecent" runat="server"></asp:TextBox>
        </div>
        <div>
            Start Date
        </div>
        <div>
            <span>
                <asp:TextBox ID="TxtStart" runat="server"></asp:TextBox></span>
        </div>
        <div>
            End Date
        </div>
        <div>
            <span>
                <asp:TextBox ID="TxtEndDate" runat="server"></asp:TextBox></span>
        </div>
    </fieldset>
    <asp:LinkButton ID="lnkAdd" runat="server" Text="Add" OnClick="lnkAdd_Click"></asp:LinkButton>
    <asp:LinkButton ID="lnkSave" runat="server" Text="Update" OnClick="lnkSave_Click"
        Visible="false"></asp:LinkButton>
</div>

<script language='javascript' type='text/javascript'>
tinyMCE.init({
mode : 'textareas',
theme : 'advanced',
theme_advanced_buttons1: "bold, italic,underline",
theme_advanced_buttons2:"",
theme_advanced_buttons3:""
});
//you can also used “advanced” for themes
</script>

