<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceCatagoryInfo.aspx.cs"
    Inherits="College_Ajaxer_CourceCatagoryInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="divMessage" runat="server"></div>
        <fieldset>
            <legend>CourceCatagory</legend>
            <div>
                <div>
                    <div>
                        <span class="label">CourceCatagoryID</span>
                    </div>
                    <div>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">CatagoryName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtCatagoryName" runat="server"></asp:TextBox>
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
                        <span class="label">CatagoryType</span>
                    </div>
                    <div>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">ModifiedDate</span>
                    </div>
                    <div>
                    </div>
                </div>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
