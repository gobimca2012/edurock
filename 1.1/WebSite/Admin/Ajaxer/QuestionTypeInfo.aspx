﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionTypeInfo.aspx.cs"
    Inherits="Admin_Ajaxer_QuestionTypeInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>QuestionType</legend>
            <table>
                <tr>
                    <td>
                        <span class="label">QuestionTypeID</span>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">QuestionTypeTnext</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtQuestionTypeTnext" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">LoginUserID</span>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">ModifiedDate</span>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddQuestionType" runat="server" RequestContainner="#QuestionType"
                    ResponseContainner="#QuestionType" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateQuestionType" runat="server" RequestContainner="#QuestionType"
                    ResponseContainner="#QuestionType" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>