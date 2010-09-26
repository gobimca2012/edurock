<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AboutWidget.aspx.cs" Inherits="User_AjaxControl_AboutInstitute" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox nobod">
        <div class="graycontent">
            <div id="Institutetitle" runat="server" style="float: left" class="title">
            </div>
            <div style="float: right" id="instidettrigger" class="exand">
            </div>
            <div class="clear">
            </div>
        </div>
        <div class="whitecont">
            <div id="instide" style="display: none">
                <p id="aboutInstitute" runat="server">
                </p>
            </div>
        </div>
       
    </div>
    <div class="contentbox nobod" id="divsubject" runat="server" visible="false">
        <div class="graycontent">
            <div style="float: left" class="title">
                Subjects
            </div>
            <div style="float: right" id="subjectboxtrigger" class="exand">
            </div>
            <div class="clear">
            </div>
        </div>
        <div class="whitecont" id="subjectbox" style="display:none">
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
        <div>
        </div>
    </div>
    <div id="instituteUser">
        <div class="graycontent">
            <div style="float: left" class="title">
                Users
            </div>
            <div style="float: right" id="userboxtrigger" class="exand">
            </div>
            <div class="clear">
            </div>
        </div>
        <div id="userbox" style="display: none;" class="whitecont">
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
                                    Width="50" Height="50" />
                            </div>
                            <%--<div>
                                <%#Eval("FirstName") %>&nbsp;<%#Eval("LastName")%>
                            </div>--%>
                        </asp:HyperLink>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div style="clear: both">
        </div>
    </div>
    </form>
</body>
</html>
