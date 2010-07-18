<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomeWork.aspx.cs" Inherits="User_AjaxControl_HomeWork" %>

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
                Home Work
            </div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkEdit" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn">Edit</div> </aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div id="HomeWork" style="padding: 5px;">
            <%-- <div>
                <div>
                    <span class="label">HomeWorkID</span>
                </div>
                <div>
                    <span id="lblHomeWorkID" runat="server"></span>
                </div>
            </div>--%>
            <div>
                <div>
                    <span class="label">Title</span>
                </div>
                <div>
                    <span id="lblTitle" runat="server" class="btitle"></span>
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
                    <span class="label">ShortDescription</span>
                </div>
                <div>
                    <p id="lblShortDescription" runat="server">
                    </p>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Cource</span>
                </div>
                <div>
                    <span id="lblInstituteCourceID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Subject</span>
                </div>
                <div>
                    <span id="lblInstituteSubjectID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    POST BY &nbsp;<asp:HyperLink ID="lnkTool" runat="server"></asp:HyperLink>&nbsp;on
                    &nbsp;<span id="lblModifiedDate" runat="server"></span>
                </div>
            </div>
             <div id="comment">
            </div>
            <div id="newcommentbox">
            </div>
        </div>
        <div class="gray">
            Home Work</div>
    </div>
    </form>
</body>
</html>
