<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionInfoView.aspx.cs"
    Inherits="User_AjaxControl_QuestionInfoView" %>

<%@ Register Src="../UserControl/UserToolTipLink.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray ">
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
                    <%-- <table>
                        <thead>
                            <tr>
                                <td>
                                    Question
                                </td>
                                <td>
                                    Status
                                </td>
                                <td>
                                    Type
                                </td>
                                <td>
                                    Date
                                </td>
                            </tr>
                        </thead>--%>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </div>
                    <%--</table>--%>
                </LayoutTemplate>
                <ItemTemplate>
                    <%--<tr>
                        <td>
                            <span>
                                <aspajax:HyperLink ID="lnkQuestionFull" runat="server" ContainnerID="#contentBox"
                                    NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Question.aspx")+"?qid="+Eval("QuestionID")  %>'><%#Eval("QuestionText") %></aspajax:HyperLink></span>
                            by
                            <asp:HyperLink ID="lnkTool" runat="server">     <%#Eval("FirstName")%>&nbsp;<%#Eval("LastName")%></asp:HyperLink>
                        </td>
                        <td>
                            <%#Eval("QuestionStatus")%>
                        </td>
                        <td>
                            <%#Eval("QuestionType")%>
                        </td>
                        <td>
                            <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("QuestionID").ToString(), "#contentBox", "#contentBox")%>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/QuestionInfo.aspx") + "?cid=" + Eval("QuestionID")%>'
                                ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                        </td>
                    </tr>--%>
                    <div class="dasbo">
                        <div class="btitle">
                            <aspajax:HyperLink ID="lnkQuestionFull" runat="server" ContainnerID="#contentBox"
                                NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Question.aspx")+"?qid="+Eval("ID")  %>'><%#Eval("Title") %></aspajax:HyperLink>
                        </div>
                        <div>
                            <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>'
                                ModifiedDate='<%#Eval("ModifiedDate") %>' />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray ">
            <div>
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevQuestion" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextQuestion" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                    </div>
                </div>
                <div style="clear: both">
                </div>
            </div>
            <div>
                <aspajax:HyperLink ID="hpAddQuestion" runat="server" NavigateUrl="" ContainnerID="#contentBox"><div class="btn">Add New Question</div></aspajax:HyperLink>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
