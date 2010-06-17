<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Question.ascx.cs" Inherits="College_UserControl_Question" %>
<%--<asp:UpdatePanel ID="Update" runat="server" RenderMode="Inline" UpdateMode="Always" ChildrenAsTriggers="true">
    <ContentTemplate>--%>
<div style="float: left; width: 800px">
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
        <div id="divSingleFillIntheBlanck" runat="server">
            <div>
                <span id="lblPrefixText" runat="server"></span><span>
                    <asp:DropDownList ID="ddAnswer" runat="server">
                    </asp:DropDownList>
                </span><span id="lblsufixText" runat="server"></span>
            </div>
        </div>
        <div style="clear: both">
            Marks : <span id="lblMarks" runat="server" class="label"></span>
        </div>
        <div style="clear: both">
            <div style="float: left; padding: 5px;">
                <asp:LinkButton ID="lnkPrev" runat="server" Text="Prev" OnClick="lnkPrev_Click"></asp:LinkButton></div>
            <div style="float: left; padding: 5px;">
                <asp:LinkButton ID="lnkNext" runat="server" Text="Next" OnClick="lnkNext_Click"></asp:LinkButton></div>
                <div style="clear:both"></div>
        </div>
    </div>
</div>
<%--    </ContentTemplate>
</asp:UpdatePanel>--%>
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
