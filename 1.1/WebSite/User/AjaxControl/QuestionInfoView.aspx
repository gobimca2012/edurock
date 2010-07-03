<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionInfoView.aspx.cs"
    Inherits="User_AjaxControl_QuestionInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListQuestion" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                QuestionID
                            </td>
                            <td>
                                QuestionText
                            </td>
                            <td>
                                LoginUserID
                            </td>
                            <td>
                                QuestionTypeID
                            </td>
                            <td>
                                QuestionStatusID
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
                        <%#Eval("QuestionID") %>
                    </td>
                    <td>
                        <%#Eval("QuestionText") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#Eval("QuestionTypeID") %>
                    </td>
                    <td>
                        <%#Eval("QuestionStatusID") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("QuestionID").ToString(), "#Question", "#Question")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/QuestionInfo.aspx") + "?cid=" + Eval("QuestionID")%>'
                            ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                    </td>
                </tr>
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
    </form>
</body>
</html>
