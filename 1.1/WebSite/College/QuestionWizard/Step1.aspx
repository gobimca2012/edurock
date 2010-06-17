<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="Step1.aspx.cs" Inherits="College_QuestionWizard_Step1" Title="Untitled Page" %>

<%@ Register Src="../UserControl/AddSingleChoiceQuestion.ascx" TagName="AddSingleChoiceQuestion"
    TagPrefix="uc3" %>
<%@ Register Src="../UserControl/AddMultipleChoiceQuestion.ascx" TagName="AddMultipleChoiceQuestion"
    TagPrefix="uc4" %>
<%@ Register Src="../UserControl/AddSingleFillInTheBlank.ascx" TagName="AddSingleFillInTheBlank"
    TagPrefix="uc1" %>
<%@ Register src="../UserControl/AddMatchFollowing.ascx" tagname="AddMatchFollowing" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 576px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <%--<uc3:AddSingleChoiceQuestion ID="AddSingleChoiceQuestion1" runat="server" />--%>
    </div>
    <div class="contentbox">
        <div id="divError" runat="server">
        </div>
        <asp:Panel ID="panelSingleChoice" runat="server">
            <div id="EXM_Question">
                <table>
                    <tr>
                        <td>
                            Select your question Type
                        </td>
                        <div>
                            <td class="style1">
                                <asp:RadioButtonList ID="rdbQuestionType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rdbQuestionType_SelectedIndexChanged">
                                    <asp:ListItem Text="Single Choice" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Multiple Choice" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="Single Fill in the Blanks" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="Multiple Fill in the Blanks" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="Match words" Value="5"></asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </div>
                    </tr>
                </table>
                <div>
                    <asp:LinkButton ID="lnkNextStep" runat="server" OnClick="lnkNextStep_Click">Next 
                Step</asp:LinkButton>
                    
                </div>
            </div>
        </asp:Panel>
        <div>
            <asp:PlaceHolder ID="QuestionPlaceHolder" runat="server"></asp:PlaceHolder>
        </div>
    </div>
</asp:Content>
