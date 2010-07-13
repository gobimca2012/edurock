<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ICUserInfoView.aspx.cs" Inherits="User_AjaxControl_ICUserInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Users
        </div>
        <asp:ListView ID="ListUser" runat="server">
            <LayoutTemplate>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </LayoutTemplate>
            <ItemTemplate>
                <div style="float: left; width: 130px;">
                    <div>
                        <div>
                            <asp:Image ID="imgPic" runat="server" Width="100" ImageUrl='<%#ResolveUrl(Eval("PhotoPath").ToString()) %>' />
                        </div>
                        <div>
                            <%#Eval("FirstName") %></div>
                    </div>
            </ItemTemplate>
        </asp:ListView>
        <div class="gray">
            <div>
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevUser" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#User" ResponseContainner="#User"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextUser" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#User" Pagger="true" Increment="true" ResponseContainner="#User">Next</aspajax:AjaxLinkButton>
                    </div>
                </div>
                Isers
                <div style="clear: both">
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
