﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Article.aspx.cs" Inherits="User_AjaxControl_Article" %>

<%@ Register Src="../UserControl/FullViewSideInfo.ascx" TagName="FullViewSideInfo"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox"><div class="btn">Edit</div></aspajax:HyperLink>
        </div>
        <div id="Article" class="whitecont">
            <div class="fuleft">
                <div>
                    <div>
                        <span class="label">Title</span>
                    </div>
                    <div>
                        <span id="lblTitle" runat="server"></span>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span>
                    </div>
                    <div>
                        <span id="lblDescription" runat="server"></span>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">MetaDescription</span>
                    </div>
                    <div>
                        <span id="lblMetaDescription" runat="server"></span>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Tag</span>
                    </div>
                    <div>
                        <span id="lblTag" runat="server"></span>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Rating</span>
                    </div>
                    <div>
                        <span id="lblRating" runat="server"></span>
                    </div>
                </div>
            </div>
            <div class="furight">
                <uc1:FullViewSideInfo ID="FullViewSideInfo1" runat="server" />
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div class="gray">
        </div>
    </div>
    </form>
</body>
</html>
