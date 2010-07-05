<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionTypeInfoView.aspx.cs"
    Inherits="Admin_Ajaxer_QuestionTypeInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListQuestionType" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                QuestionTypeID
                            </td>
                            <td>
                                QuestionTypeTnext
                            </td>
                            <td>
                                LoginUserID
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
                        <%#Eval("QuestionTypeID") %>
                    </td>
                    <td>
                        <%#Eval("QuestionTypeTnext") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("QuestionTypeID").ToString(), "#courceinfo", "#courceinfo")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/QuestionTypeInfo.aspx") + "?qtypeid=" + Eval("QuestionTypeID")%>'
                            ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevQuestionType" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#courceinfo" ResponseContainner="#courceinfo"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextQuestionType" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#courceinfo" Pagger="true" Increment="true" ResponseContainner="#courceinfo">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddQuestionType" runat="server" NavigateUrl="~/Admin/Ajaxer/QuestionTypeInfo.aspx"
                ContainnerID="#courceinfo">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
