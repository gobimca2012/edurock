﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EXMQuestionList.aspx.cs"
    Inherits="User_AjaxControl_EXMQuestionList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Questions <span>
                <aspajax:HyperLink ID="lnkAddnew" runat="server" ContainnerID="#contentBox">Add new</aspajax:HyperLink>
            </span>
        </div>
        <div>
            <asp:ListView ID="ListEXM_Question" runat="server" 
                DataKeyNames="EXM_QuestionID,Q_Type" onitemdatabound="ItemdataBound">
                <LayoutTemplate>
                    <table id="ListQuestion">
                        <thead>
                            <tr>
                                <td>
                                    Question
                                </td>
                                <td>
                                    Q_Type
                                </td>
                                <td>
                                    Description
                                </td>
                                <td>
                                    Date
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                        </thead>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr id='<%#"foo_"+Eval("EXM_QuestionID")%>'>
                        <td>
                            <%#Eval("Question") %>
                        </td>
                        <td>
                            <%#BusinessLogic.CommonController.GetQuestionType(Convert.ToInt32(Eval("Q_Type")) )%>
                        </td>
                        <td>
                            <%#Eval("Description") %>
                        </td>
                        <td>
                            <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("ModifiedDate"))) %>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                        </td>
                        <td>
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("EXM_QuestionID").ToString(), "#contentBox", "#contentBox")%>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkAnswer" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/ExmAnswerInfoView.aspx") + "?qid=" + Eval("EXM_QuestionID").ToString()%>'>Answer</aspajax:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
        </div>
    </div>
    </form>
</body>
</html>