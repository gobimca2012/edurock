<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExmAnswerInfoView.aspx.cs"
    Inherits="User_AjaxControl_ExmAnswerInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            <div style="float: left">
            Answers 
            </div>
            <div style="float: right">
                <aspajax:HyperLink ID="hpAddEXM_Answer" runat="server" NavigateUrl="~/User/Ajaxer/EXMAnswerInfo.aspx"
                    ContainnerID="#contentBox"><div class="btn">Add new Answer</div></aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
            
        </div>
        <asp:ListView ID="ListEXM_Answer" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                EXM_AnswerID
                            </td>
                            <td>
                                EXM_QuestionID
                            </td>
                            <td>
                                Answer
                            </td>
                            <td>
                                IsRight
                            </td>
                            <td>
                                Marks
                            </td>
                            <td>
                                ModifiedDate
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("EXM_AnswerID") %>
                    </td>
                    <td>
                        <%#Eval("EXM_QuestionID") %>
                    </td>
                    <td>
                        <%#Eval("Answer") %>
                    </td>
                    <td>
                        <%#Eval("IsRight") %>
                    </td>
                    <td>
                        <%#Eval("Marks") %>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("EXM_AnswerID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/ExmAnswerInfoView.aspx") + "?eaid=" + Eval("EXM_AnswerID")%>'
                            ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div class="gray">
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevEXM_Answer" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextEXM_Answer" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="float: left">
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
