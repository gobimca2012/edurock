<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ExamQuestionList.ascx.cs"
    Inherits="College_UserControl_ExamQuestionList" %>
<asp:ListView ID="ListQuestion" runat="server" DataKeyNames="EXM_QuestionID">
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
