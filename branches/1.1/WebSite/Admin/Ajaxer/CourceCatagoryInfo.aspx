<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceCatagoryInfo.aspx.cs"
    Inherits="Admin_Ajaxer_CourceCatagoryInfo" %>

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
            <legend>CourceCatagory</legend>
            <table>
                <tr>
                    <td>
                        <span class="label">CourceCatagoryID</span>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">CatagoryName</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCatagoryName" runat="server"></asp:TextBox>
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
                        <span class="label">Description</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">CatagoryType</span>
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
                <aspajax:AjaxLinkButton ID="lnkAddcource" runat="server" RequestContainner="#courcecatagory"
                    ResponseContainner="#courcecatagory" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" RequestContainner="#courcecatagory"
                    ResponseContainner="#courcecatagory" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
