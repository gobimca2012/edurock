<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnswerInfoView.aspx.cs" Inherits="User_AjaxControl_AnswerInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListAnswer" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                AnswerID
                            </td>
                            <td>
                                AnswerText
                            </td>
                            <td>
                                Description
                            </td>
                            <td>
                                QuestionID
                            </td>
                            <td>
                                AnswerStateID
                            </td>
                            <td>
                                LoginUserID
                            </td>
                            <td>
                                AnswerRate
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
                        <%#Eval("AnswerID") %>
                    </td>
                    <td>
                        <%#Eval("AnswerText") %>
                    </td>
                    <td>
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("QuestionID") %>
                    </td>
                    <td>
                        <%#Eval("AnswerStateID") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#Eval("AnswerRate") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("AnswerID").ToString(), "#Answer", "#Answer")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/AnswerInfo.aspx") + "?cid=" + Eval("AnswerID")%>'
                            ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevAnswer" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#Answer" ResponseContainner="#Answer"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextAnswer" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#Answer" Pagger="true" Increment="true" ResponseContainner="#Answer">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddAnswer" runat="server" 
                ContainnerID="#Answer">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
