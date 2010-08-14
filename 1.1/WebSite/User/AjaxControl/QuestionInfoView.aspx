<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionInfoView.aspx.cs"
    Inherits="User_AjaxControl_QuestionInfoView" %>

<%@ Register Src="../UserControl/UserToolTipLink1.1.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding: 5px;">
        <div class="contentbox">
            <div class="gray" id="header" runat="server">
                Questions
                <div id="dumi" runat="server" visible="false">
                    <ul>
                        <li>
                            <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                        </li>
                        <li>
                            <asp:DropDownList ID="ddQuestionType" runat="server">
                            </asp:DropDownList>
                        </li>
                        <li>
                            <asp:DropDownList ID="ddQuestionStatus" runat="server">
                            </asp:DropDownList>
                        </li>
                        <li class="btn roundedall">
                            <aspajax:AjaxLinkButton ID="lnkSearch" runat="server" RequestContainner="#contentBox"
                                ResponseContainner="#contentBox" EnableViewState="False" Increment="False" OnAjaxClick="SearchAjaxClick"
                                Pagger="False">Search</aspajax:AjaxLinkButton>
                        </li>
                        <li class="btn roundedall">
                            <aspajax:HyperLink ID="lnkMyQuestion" runat="server" ContainnerID="#contentBox" NavigateUrl="~/User/AjaxControl/MyQuestion.aspx">Your Questions</aspajax:HyperLink>
                        </li>
                    </ul>
                </div>
            </div>
            <div class="whitecont">
                <asp:ListView ID="ListQuestion" runat="server" DataKeyNames="LoginUserID,ID" OnItemDataBound="ListQuestionOnItemDataBound">
                    <LayoutTemplate>
                        <div>
                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="dasbo">
                            <div style="float: left; width: 550px" class="btitle">
                                <aspajax:HyperLink ID="lnkQuestionFull" runat="server" ContainnerID="#contentBox"
                                    NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Question.aspx")+"?qid="+Eval("ID")  %>'><%#Eval("Title") %></aspajax:HyperLink>
                            </div>
                            <div style="float: right">
                                <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>'
                                    ModifiedDate='<%#Eval("ModifiedDate") %>' />
                            </div>
                            <div class="clear">
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <div class="gray">
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevQuestion" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextQuestion" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                    </div>
                    <div class="fleft">
                        <aspajax:HyperLink ID="hpAddQuestion" runat="server" NavigateUrl="" ContainnerID="#contentBox"><div class="btn">Add New Question</div></aspajax:HyperLink>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
