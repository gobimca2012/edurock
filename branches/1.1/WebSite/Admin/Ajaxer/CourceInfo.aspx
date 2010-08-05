﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceInfo.aspx.cs" Inherits="Admin_Ajaxer_CourceInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divMessage" runat="server">
    </div>
    <asp:Panel ID="CourceAdd" runat="server">
        <fieldset>
            <legend>Cource</legend>
            <table>
                <tr>
                    <td>
                        <span class="label">CourceID</span>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">CourceCatagoryID</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddCatagory" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">CourceName</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCourceName" runat="server"></asp:TextBox>
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
                        <span class="label">CourceType</span>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">Modifieddate</span>
                    </td>
                    <td>
                        
                    </td>
                </tr>
            </table>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddcource" runat="server" RequestContainner="#courceinfo"
                    ResponseContainner="#courceinfo" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" RequestContainner="#courceinfo"
                    ResponseContainner="#courceinfo" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
            <asp:HiddenField ID="_AjaxState" runat="server" />
        </fieldset>
    </asp:Panel>
    </form>
</body>
</html>