<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionInfo.aspx.cs" Inherits="User_AjaxControl_QuestionInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>Question</legend>
            <table>
               
                <tr>
                    <td>
                        <span class="label">QuestionText</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtQuestionText" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <span class="label">Description</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td>
                        <span class="label">QuestionTypeID</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddQuestionType" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
               
            </table>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddQuestion" runat="server" RequestContainner="#Question"
                    ResponseContainner="#Question" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateQuestion" runat="server" RequestContainner="#Question"
                    ResponseContainner="#Question" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
