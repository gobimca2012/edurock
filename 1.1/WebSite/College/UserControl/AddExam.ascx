<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddExam.ascx.cs" Inherits="College_UserControl_AddExam" %>

<div class="contentbox">
    <fieldset>
        <legend>Exam</legend>
        <table>
            <tr>
                <td>
                    <span class="label">ExamName</span>
                </td>
                <td>
                    <asp:TextBox ID="txtExamName" runat="server" Width="570px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span class="label">SubjectName</span>
                </td>
                <td>
                    <asp:TextBox ID="txtSubjectName" runat="server" Width="569px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span class="label">Description</span>
                </td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" Width="773px" 
                        TextMode="MultiLine" Height="673px"></asp:TextBox>
                </td>
            </tr>
        </table>
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
