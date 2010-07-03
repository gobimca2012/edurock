<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TutorialInfo.aspx.cs" Inherits="College_TutorialInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="injectScript" runat="server"></asp:Label>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>Tutorial</legend>
            <table>
                <tr>
                    <td>
                        <span class="label">TutorialID</span>
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
                        <span class="label">Name</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
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
                        <span class="label">TutorialType</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddTutorialType" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">FilePath</span>
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUploader" runat="server" />
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
                <asp:LinkButton ID="lnkAdd" runat="server" onclick="lnkAdd_Click">Add</asp:LinkButton>
            </div>
            
        </fieldset>
    </div>
    </form>
</body>
</html>
