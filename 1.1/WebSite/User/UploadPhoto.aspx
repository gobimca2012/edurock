<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadPhoto.aspx.cs" Inherits="User_UploadPhoto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            Upload File
        </div>
        <div>
            <asp:FileUpload ID="fileUploader" runat="server" />
        </div>
        <div>
            <asp:LinkButton ID="lnkUpload" runat="server" onclick="lnkUpload_Click">Upload</asp:LinkButton>
        </div>
    </div>
    </form>
</body>
</html>
