﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadResponse.aspx.cs" Inherits="User_AjaxControl_UploadResponse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="img" runat="server" Width="100" />
    </div>
    <div >
    <span id="lblFileName" runat="server"></span>
    </div>
    <div>
        <asp:HiddenField ID="filePath" runat="server" />
    </div>
    </form>
</body>
</html>
