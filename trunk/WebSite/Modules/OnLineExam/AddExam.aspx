<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddExam.aspx.cs" Inherits="Modules_OnLineExam_AddExam" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="ErrorMessage" runat="server"></div>
    <div>
        <table>
            <tr>
                <td>
                    Exam name
                </td>
                <td>
                    <aspajax:TextBox ID="txtExamName" runat="server"></aspajax:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Subject name
                </td>
                <td>
                    <aspajax:TextBox ID="txtSubjectName" runat="server"></aspajax:TextBox>
                </td>
            </tr>
        </table>
        <div>
            <aspajax:AjaxLinkButton ID="lnkStep2" runat="server" OnAjaxClick="NextAjaxClick" RequestContainner="#addque" ResponseContainner="#addque" PostBackUrl="~/Modules/OnLineExam/AddExam.aspx">Next</aspajax:AjaxLinkButton>
        </div>
    </div>
    </form>
</body>
</html>
