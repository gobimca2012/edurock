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
            <asp:ListView ID="ListQuestion" runat="server">
                <LayoutTemplate>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div>
                        <div>
                            <aspajax:HyperLink ID="lnkQuestionFull" runat="server" ContainnerID="#Question" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Question.aspx")+"?qid="+Eval("QuestionID")  %>'><%#Eval("QuestionText") %></aspajax:HyperLink>
                        </div>
                        <div>
                            <div>
                                <asp:Image ID="imgProf" runat="server" ImageUrl='<%#ResolveUrl(Eval("PhotoPath").ToString()) %>'
                                    Width="100" />
                            </div>
                            by
                            <%#Eval("FirstName")%>&nbsp;<%#Eval("LastName")%>
                        </div>
                        <div>
                            <%#Eval("QuestionStatus")%>
                        </div>
                        <div>
                            <%#Eval("QuestionType")%>
                        </div>
                        <div>
                            <%#Eval("ModifiedDate") %>
                        </div>
                        <div>
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("QuestionID").ToString(), "#Question", "#Question")%>
                        </div>
                        <div>
                            <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/QuestionInfo.aspx") + "?cid=" + Eval("QuestionID")%>'
                                ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            <div>
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevQuestion" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#Question" ResponseContainner="#Question"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextQuestion" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#Question" Pagger="true" Increment="true" ResponseContainner="#Question">Next</aspajax:AjaxLinkButton>
                    </div>
                </div>
                <div style="clear: both">
                </div>
            </div>
            <div>
                <aspajax:HyperLink ID="hpAddQuestion" runat="server" NavigateUrl="~/User/AjaxControl/QuestionInfo.aspx"
                    ContainnerID="#Question">Add New</aspajax:HyperLink>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
