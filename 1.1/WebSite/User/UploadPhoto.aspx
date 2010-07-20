<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadPhoto.aspx.cs" Inherits="User_UploadPhoto"
    EnableEventValidation="false" EnableViewState="false" EnableViewStateMac="false"
    ValidateRequest="false" ViewStateEncryptionMode="Never" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background:#fff">
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="whitecont">
            <div id="divMessage" runat="server">
            </div>
            <div>
                Upload File
            </div>
            <div>
                <asp:FileUpload ID="fileUploader" runat="server" />
            </div>
            <div>
                <asp:LinkButton ID="lnkUpload" runat="server" OnClick="lnkUpload_Click"><div class="btn"> Upload</div></asp:LinkButton>
            </div>
            <asp:Label ID="injectScript" runat="server"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
