<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionStatusInfoView.aspx.cs"
    Inherits="Admin_Ajaxer_QuestionStatusInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListQuestionStatus" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                QuestionStatusID
                            </td>
                            <td>
                                QuestionStatusText
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
                        <%#Eval("QuestionStatusID") %>
                    </td>
                    <td>
                        <%#Eval("QuestionStatusText") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("QuestionStatusID").ToString(), "#QuestionStatus", "#QuestionStatus")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/QuestionStatusInfo.aspx") + "?qstatusid=" + Eval("QuestionStatusID")%>'
                            ContainnerID="#QuestionStatus">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevQuestionStatus" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#QuestionStatus" ResponseContainner="#QuestionStatus"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextQuestionStatus" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#QuestionStatus" Pagger="true" Increment="true" ResponseContainner="#QuestionStatus">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="lnkAddQuestionStatus" runat="server" NavigateUrl="~/Admin/Ajaxer/QuestionStatusInfo.aspx"
                ContainnerID="#QuestionStatus">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
