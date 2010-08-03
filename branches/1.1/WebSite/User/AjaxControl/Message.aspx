<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Message.aspx.cs" Inherits="User_AjaxControl_Message" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <div>
                <asp:HyperLink ID="lnkback" runat="server" Text="back to List" runat="server" NavigateUrl="~/Modules/Message/List.aspx"></asp:HyperLink>
            </div>
            <div>
                <div>
                    <span class="label">MessageID</span>
                </div>
                <div>
                    <span id="lblMessageID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Subject</span>
                </div>
                <div>
                    <span id="lblSubject" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">MessageText</span>
                </div>
                <div>
                    <span id="lblMessageText" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ToLoginUserID</span>
                </div>
                <div>
                    <span id="lblToLoginUserID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">FromLoginUserID</span>
                </div>
                <div>
                    <span id="lblFromLoginUserID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ToLoginUserID</span>
                </div>
                <div>
                    <asp:Image ID="ImgTo" runat="server" Width="100"/>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">FromLoginUserID</span>
                </div>
                <div>
                    <asp:Image ID="ImgFrom" runat="server" Width="100" />
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
            <asp:LinkButton ID="lnkedit" runat="server" Text="Edit" CssClass="btnlnk"></asp:LinkButton>
            <asp:LinkButton ID="lnkAddNew" runat="server" Text="Add" CssClass="btnlnk"></asp:LinkButton>
        </div>
    </div>
    </form>
</body>
</html>
