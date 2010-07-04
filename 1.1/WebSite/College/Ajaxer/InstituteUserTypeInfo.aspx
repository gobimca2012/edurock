<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteUserTypeInfo.aspx.cs"
    Inherits="College_Ajaxer_InstituteUserTypeInfo" %>

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
            <legend>InstituteUserType</legend>
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
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddInstituteUserType" runat="server" RequestContainner="#User"
                    ResponseContainner="#User" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateInstituteUserType" runat="server" RequestContainner="#User"
                    ResponseContainner="#User" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
