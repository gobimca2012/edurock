﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="User_AjaxControl_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="hidden" name="url" value="http://www.crameasy.com///Repository/Document/vt3soft/DailySprintBacklogV1 0.xls"
            runat="server" id="url">
        <input type="hidden" name="apikey" value="" runat="server" id="apikey" />
        <input type="hidden" name="output" value="editor" runat="server" id="output" />
        <input type="hidden" name="mode" value="normaledit">
        <input type="hidden" name="filename" runat="server" id="filename" />
        <input type="hidden" name="lang" value="[en/fr/de/ja/it...]">
        <input type="hidden" name="skey" value="" runat="server" id="skey" />
        <input type="hidden" name="id" value="12345678" runat="server" id="id" />
        <input type="hidden" name="format" value="doc" runat="server" id="format" />
        <input type="hidden" name="saveurl" value="[http://xyz.com/docs/save.php]" runat="server"
            id="saveurl" />
        <asp:Button ID="Button1" runat="server" Text="Button" PostBackUrl="https://sheet.zoho.com/remotedoc.im"/>
    </div>
    </form>
</body>
</html>
