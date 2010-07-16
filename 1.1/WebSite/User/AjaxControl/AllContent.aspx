<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllContent.aspx.cs" Inherits="User_AjaxControl_AllContent" %>

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
        <div class="gray">
        </div>
        <div class="whitecont">
            <asp:ListView ID="ListQuestion" runat="server" DataKeyNames="ID,ContentType" OnItemDataBound="ListQuestionOnItemDataBound">
                <LayoutTemplate>
                    <%-- <table>
                    <thead>
                        <tr>
                            <td>
                                QuestionID
                            </td>
                            <td>
                                QuestionText
                            </td>
                            <td>
                                Description
                            </td>
                            <td>
                                LoginUserID
                            </td>
                            <td>
                                InstituteCourceID
                            </td>
                            <td>
                                InstituteSubjectID
                            </td>
                            <td>
                                tag
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
                    </thead>--%>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </div>
                    <%--</table>--%>
                </LayoutTemplate>
                <ItemTemplate>
                    <%--<tr>
                    <td>
                        <%#Eval("QuestionID") %>
                    </td>
                    <td>
                        <%#Eval("QuestionText") %>
                    </td>
                    <td>
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#Eval("InstituteCourceID") %>
                    </td>
                    <td>
                        <%#Eval("InstituteSubjectID") %>
                    </td>
                    <td>
                        <%#Eval("tag") %>
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
                </tr>--%>
                    <div class="dasbo">
                        <div>
                            <span class='<%#GetCSSClass(Eval("ContentType").ToString()) %>'>&nbsp;</span>
                            <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#getURL(Eval("ContentType").ToString(),Eval("ID").ToString()) %>'>
                            <%#Eval("Title") %></aspajax:HyperLink>
                        </div>
                        <div>
                            <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>'
                                ModifiedDate='<%#Eval("ModifiedDate") %>' />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
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
    </div>
    </form>
</body>
</html>
