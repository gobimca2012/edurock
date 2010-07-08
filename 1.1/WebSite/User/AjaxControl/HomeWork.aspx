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
            Home Work <span class="btn">
                <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox">Edit</aspajax:HyperLink>
            </span>
        </div>
        <div id="HomeWork" style="padding: 5px;">
            <div>
                <asp:HyperLink ID="lnkback" runat="server" Text="back to List" runat="server" NavigateUrl="~/Modules/HomeWork/List.aspx"></asp:HyperLink>
            </div>
            <div>
                <div>
                    <span class="label">HomeWorkID</span>
                </div>
                <div>
                    <span id="lblHomeWorkID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">LoginUserID</span>
                </div>
                <div>
                    <span id="lblLoginUserID" runat="server"></span>
                </div>
            </div>
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
                    <span class="label">ShortDescription</span>
                </div>
                <div>
                    <span id="lblShortDescription" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">InstituteCourceID</span>
                </div>
                <div>
                    <span id="lblInstituteCourceID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">InstituteSubjectID</span>
                </div>
                <div>
                    <span id="lblInstituteSubjectID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ModifiedDate</span>
                </div>
                <div>
                    <span id="lblModifiedDate" runat="server"></span>
                </div>
            </div>
        </div>
        <div class="gray">
            Home Work</div>
    </div>
    </form>
</body>
</html>
