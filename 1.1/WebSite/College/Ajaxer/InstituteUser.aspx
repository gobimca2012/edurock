<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteUser.aspx.cs" Inherits="College_Ajaxer_InstituteUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="contentbox nobod">
            <div class="graycontent">
                <div id="Institutetitle" runat="server" style="float: left" class="title">
                    Users
                </div>
                <div style="float: right" id="instituteuserboxtrigger" class="exand">
                </div>
                <div class="clear">
                </div>
            </div>
            <div class="whitecont">
                <div id="instituteuserbox" style="display: none">
                    <asp:ListView ID="ListUser" runat="server">
                        <LayoutTemplate>
                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="float: left; width: 50px; padding: 3px; height: 80px; overflow: hidden">
                                <asp:HyperLink ID="lnkU" runat="server" NavigateUrl='<%#ResolveUrl("~/User/User.aspx") + "?usid=" + Eval("LoginUserID")%>'>
                                    <div>
                                        <div>
                                            <asp:Image ID="imgPic" runat="server" Width="45" Height="45" ImageUrl='<%#ResolveUrl(Eval("PhotoPath").ToString()) %>' />
                                        </div>
                                        <div>
                                            <UNameLink:UNameLink ID="UNameLink1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>' />
                                        </div>
                                    </div>
                                </asp:HyperLink>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>
        </div>
      
    </div>
    </form>
</body>
</html>
