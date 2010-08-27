<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TutorialInfo.aspx.cs" Inherits="College_TutorialInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <asp:Label ID="injectScript" runat="server"></asp:Label>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>Tutorial</legend>
            <div>
                <div>
                    <div>
                        <span class="label">Name</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">TutorialType</span>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddTutorialType" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">FilePath</span>
                    </div>
                    <div>
                        <asp:FileUpload ID="FileUploader" runat="server" />
                    </div>
                </div>
            </div>
            <div>
                <asp:LinkButton ID="lnkAdd" runat="server" OnClick="lnkAdd_Click"><%=Resources.Default.Add_Text%></asp:LinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
