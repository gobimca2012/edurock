﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AboutWidget.aspx.cs" Inherits="User_AjaxControl_AboutInstitute" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            <div id="Institutetitle" runat="server" >
            </div>
        </div>
        <div class="whitecont">
            <p id="aboutInstitute" runat="server">
            </p>
        </div>
        <div class="gray">
        </div>
    </div>
    <div class="contentbox" id="divsubject" runat="server">
        <div class="gray">
            Subjects
        </div>
        <div class="whitecont">
            <asp:ListView ID="listSubject" runat="server">
                <LayoutTemplate>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div>
                        <%#Eval("SubjectText") %>
                    </div>
                    <div style="clear: both">
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
        </div>
    </div>
    <div id="instituteUser">
        <asp:ListView ID="listUser" runat="server">
            <LayoutTemplate>
                <div>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div style="float: left; padding: 1px;">
                    <asp:HyperLink ID="lnkU" runat="server" NavigateUrl='<%#ResolveUrl("~/User/User.aspx") + "?usid=" + Eval("LoginUserID")%>'>
                        <div>
                            <asp:Image ID="img" runat="server" ImageUrl='<%#ResolveUrl(Eval("PhotoPath").ToString())%>'
                                Width="50" />
                        </div>
                        <div>
                            <%#Eval("FirstName") %>&nbsp;<%#Eval("LastName")%>
                        </div>
                    </asp:HyperLink>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div style="clear: both">
        </div>
    </div>
    </form>
</body>
</html>