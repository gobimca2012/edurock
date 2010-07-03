﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnswerInfo.aspx.cs" Inherits="User_AjaxControl_AnswerInfo" %>

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
            <legend>Answer</legend>
            <table>
                <tr>
                    <td>
                        <span class="label">AnswerID</span>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">AnswerText</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAnswerText" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">Description</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">QuestionID</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddQuestionID" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">AnswerStateID</span>
                    </td>
                    <td>
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
                        <span class="label">AnswerRate</span>
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
                <aspajax:AjaxLinkButton ID="lnkAddAnswer" runat="server" RequestContainner="#Answer"
                    ResponseContainner="#Answer" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateAnswer" runat="server" RequestContainner="#Answer"
                    ResponseContainner="#Answer" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
