<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="Step2.aspx.cs" Inherits="College_QuestionWizard_Step2" Title="Untitled Page" %>

<%@ Register Src="../UserControl/ListAnswer.ascx" TagName="ListAnswer" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
    <div id="divError" runat="server"></div>
        <div id="EXM_Answer">
            <fieldset>
                <legend>EXM_Answer</legend>
                <table>
                    <tr>
                        <td>
                            <span class="label">Answer</span>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class="label">IsRight</span>
                        </td>
                        <td>
                            <asp:CheckBox ID="chkIsRight" runat="server" />
                        </td>
                    </tr>
                </table>
            </fieldset>
            <asp:LinkButton ID="lnkAdd" runat="server" Text="Add" OnClick="lnkAdd_Click"></asp:LinkButton>
        </div>
    </div>
    <div>
        
    </div>
</asp:Content>
