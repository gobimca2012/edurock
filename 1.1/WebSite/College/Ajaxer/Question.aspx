<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Question.aspx.cs" Inherits="College_Ajaxer_Question" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="float: left; width: 800px">
        <div id="exami">
            
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
                       <div id="multiCheck" runat="server">
                       
                       </div>
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
                        <aspajax:AjaxLinkButton ID="lnkPrev" runat="server" Text="Prev" RequestContainner="#exam" ResponseContainner="#exam" 
                            PostBackUrl="Question.aspx" OnAjaxClick="PrevAjaxClick" ></aspajax:AjaxLinkButton></div>
                    <div style="float: left; padding: 5px;">
                        <aspajax:AjaxLinkButton ID="lnkNext" runat="server" Text="Next" RequestContainner="#exam"
                            PostBackUrl="Question.aspx" ResponseContainner="#exam" OnAjaxClick="NextAjaxClick"></aspajax:AjaxLinkButton></div>
                    <div style="clear: both">
                    </div>
                </div>
            </div>
        </div>
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
    <div>
        <asp:LinkButton ID="lnkSubmitAnswer" runat="server" OnClick="lnkSubmitAnswer_Click">Submit Answers</asp:LinkButton>
    </div>
    </form>
</body>
</html>
