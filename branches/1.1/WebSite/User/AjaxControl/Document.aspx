﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Document.aspx.cs" Inherits="User_AjaxControl_Document" %>

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
            <div style="float: left">
                Image</div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkEdit" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn"> Edit</div> </aspajax:HyperLink>
            </div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkShare" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn">  Share </div></aspajax:HyperLink></div>
            <div style="clear: both">
            </div>
        </div>
        <div class="whitecont">
            <div class="fuleft">
                <div>
                    <div>
                        <asp:Image ID="img" runat="server" Visible="false" Width="90%" />
                    </div>
                    <div id="videoPlayer">
                    </div>
                    <div>
                        <a id="lblFilePath" runat="server" target="_blank">
                            <div class="btn">
                                Download</div>
                        </a>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Name</span>
                    </div>
                    <div>
                        <span id="lblName" runat="server" class="btitle"></span>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span>
                    </div>
                    <div>
                        <p id="lblDescription" runat="server">
                        </p>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">MetaDescription</span>
                    </div>
                    <div>
                        <p id="lblMetaDescription" runat="server">
                        </p>
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
                <%-- <div>
                    <div>
                     
                    </div>
                    <div>
                        <div>
                            POST BY &nbsp;<asp:HyperLink ID="lnkTool" runat="server"></asp:HyperLink>&nbsp;on
                            &nbsp;<span id="lblModifiedDate" runat="server"></span>
                        </div>
                    </div>
                </div>--%>
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
            <div id="comment">
            </div>
            <div id="newcommentbox">
            </div>
        </div>
        <div class="gray">
            Image
        </div>
    </div>
    </form>
</body>
</html>
