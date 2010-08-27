<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyQuestion.aspx.cs" Inherits="User_AjaxControl_MyQuestion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="contentbox">
            <div class="gray ">
                <h3>
                    Your Questions</h3>
            </div>
            <asp:ListView ID="ListQuestion" runat="server">
                <LayoutTemplate>
                    <table>
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
                        </thead>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <aspajax:HyperLink ID="lnkQuestionFull" runat="server" ContainnerID="#contentBox"
                                NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Question.aspx")+"?qid="+Eval("QuestionID")  %>'><%#Eval("QuestionText") %></aspajax:HyperLink>
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
                            <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/QuestionInfo.aspx") + "?qid=" + Eval("QuestionID")%>'
                                ContainnerID="#contentBox"><%=Resources.Default.Edit_Text %></aspajax:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
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
            <div class="gray ">
                <div>
                    <aspajax:HyperLink ID="hpAddQuestion" runat="server" NavigateUrl="~/User/AjaxControl/QuestionInfo.aspx"
                        ContainnerID="#contentBox"><%=Resources.Default.Add_Text%></aspajax:HyperLink>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
