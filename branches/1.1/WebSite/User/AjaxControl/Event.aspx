<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Event.aspx.cs" Inherits="User_AjaxControl_Event" %>

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
                Event
            </div>
            <div style="float: right">
                <span style="float: left">
                    <aspajax:HyperLink ID="lnkEdit" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn"> Edit</div></aspajax:HyperLink></span>
                <span style="float: left">
                    <aspajax:HyperLink ID="lnkShare" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn">  Share Event</div></aspajax:HyperLink></span>
                <div style="clear: both">
                </div>
            </div>
        <div style="clear: both">
        </div>
    </div>
    <div id="Event" class="whitecont">
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
                    <span class="label">StartDate</span>
                </div>
                <div>
                    <span id="lblStartDate" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">EndDate</span>
                </div>
                <div>
                    <span id="lblEndDate" runat="server"></span>
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
                    <span class="label">ContactPerson</span>
                </div>
                <div>
                    <span id="lblContactPerson" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ContactEmail</span>
                </div>
                <div>
                    <span id="lblContactEmail" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ContactPhone</span>
                </div>
                <div>
                    <span id="lblContactPhone" runat="server"></span>
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
    </div>
    </form>
</body>
</html>
