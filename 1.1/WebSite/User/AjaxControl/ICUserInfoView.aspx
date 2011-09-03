<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ICUserInfoView.aspx.cs" Inherits="User_AjaxControl_ICUserInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div id="header" runat="server" class="gray">
        </div>
        <asp:ListView ID="ListUser" runat="server">
            <LayoutTemplate>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </LayoutTemplate>
            <ItemTemplate>
                <div style="float: left; height: 150px; height: 130px;" class="graycontent cbox">
                    <asp:HyperLink ID="lnkU" runat="server" NavigateUrl='<%#ResolveUrl("~/User/User.aspx") + "?usid=" + Eval("LoginUserID")%>'>
                        <div>
                            <div style="max-height: 100px; height: 100px; background: #f0f0f0; overflow: hidden">
                                <asp:Image ID="imgPic" runat="server" Width="100" ImageUrl='<%#ImageHelper.ResolveURL(Eval("PhotoPath").ToString()) %>' />
                            </div>
                            <div class="invis" style="text-align: center">
                                <%#Eval("FirstName") %>
                                &nbsp;<%#Eval("LastName") %></div>
                        </div>
                    </asp:HyperLink>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div class="hcurv clear">
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
                <div style="clear: both">
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
