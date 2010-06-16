<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="StartExam.aspx.cs" Inherits="College_StartExam" Title="Untitled Page"
    EnableEventValidation="false" ValidateRequest="false" ViewStateEncryptionMode="Never"
    EnableViewStateMac="false" %>

<%@ Register Src="UserControl/ExamQuestionList.ascx" TagName="ExamQuestionList" TagPrefix="uc1" %>
<%@ Register Src="UserControl/SingleChoiceQuestion.ascx" TagName="SingleChoiceQuestion"
    TagPrefix="uc2" %>
<%@ Register Src="UserControl/Question.ascx" TagName="Question" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="float: left; width: 800px;">
        <uc3:Question ID="Question1" runat="server" />
    </div>
    <div style="float: right; width: 200px;">
        <div class="contentbox">
            <asp:ListView ID="ListQuestion" runat="server" DataKeyNames="EXM_QuestionID" OnItemCommand="QuestionList_ItemCommand">
                <LayoutTemplate>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div>
                        <div>
                        </div>
                        <div class="tab">
                            <asp:LinkButton ID="lnkOrder" runat="server" CommandName="LoadQuestion"><%#Eval("Order") %></asp:LinkButton>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
