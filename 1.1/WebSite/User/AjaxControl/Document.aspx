<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Document.aspx.cs" Inherits="User_AjaxControl_Document" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            <div style="float:left">
                Image</div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox"><div class="btn">Edit</div> </aspajax:HyperLink>
            </div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkDelete" runat="server"><div class="btn">Delete</div> </aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div class="whitecont">
            <div>
                <asp:HyperLink ID="lnkback" runat="server" Text="back to List" runat="server" NavigateUrl="~/Modules/Document/List.aspx"></asp:HyperLink>
            </div>
            <div>
                <div>
                    <span class="label">DocumentID</span>
                </div>
                <div>
                    <span id="lblDocumentID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Name</span>
                </div>
                <div>
                    <span id="lblName" runat="server"></span>
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
                    <span class="label">LoginUserID</span>
                </div>
                <div>
                    <span id="lblLoginUserID" runat="server"></span>
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
            <div>
                <div>
                    <span class="label">FilePath</span>
                </div>
                <div>
                    <span id="lblFilePath" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">DocumentType</span>
                </div>
                <div>
                    <span id="lblDocumentType" runat="server"></span>
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
            Image
        </div>
    </div>
    </form>
</body>
</html>
