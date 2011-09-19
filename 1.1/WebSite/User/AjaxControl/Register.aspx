<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="User_AjaxControl_Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <div class="label">
                UserName</div>
            <div>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div>
            <div class="label">
                Password</div>
            <div>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </div>
        </div>
        <div>
            <div class="label">
                Confirm Password</div>
            <div>
                <asp:TextBox ID="txtConPassword" runat="server"></asp:TextBox>
            </div>
        </div>
        <div>
            <div class="label">
                Institute Name</div>
            <div>
                <asp:TextBox ID="txtInstituteName" runat="server"></asp:TextBox>
            </div>
        </div>
        <div>
            <div class="label">
                Email</div>
            <div>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
        </div>
        
    </div>
    </form>
</body>
</html>
