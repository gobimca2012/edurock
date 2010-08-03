<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AboutCource.aspx.cs" Inherits="College_Ajaxer_AboutCource" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="instituteCourceBuk">
        <div style="float: left; width: 70%">
            <div style="border-right: dashed 1px">
                <fieldset>
                    <legend>About Cource</legend>
                    <div>
                        <div id="lblDescription" runat="server">
                        </div>
                        <div class="label">
                            Priceing Information
                        </div>
                        <div id="lblprice" runat="server">
                        </div>
                        <div id="divmessage" runat="server">
                        </div>
                        <div>
                            <aspajax:AjaxLinkButton ID="lnkJoinCource" RequestContainner="#contentBox" ResponseContainner="#contentBox"
                                runat="server" EnableValidation="False" EnableViewState="False" Increment="False"
                                OnAjaxClick="AjaxJoinCource" Pagger="False">
                       <div class="btn">Join cource</div>
                            </aspajax:AjaxLinkButton>
                        </div>
                        <div class="label">
                            Duration
                        </div>
                        <div id="lblDuration" runat="server">
                        </div>
                    </div>
                </fieldset>
            </div>
        </div>
        <div style="float: right; width: 30%">
            <div class="graycontent roundedall">
                <fieldset>
                    <legend>Subjects</legend>
                    <div>
                        <div>
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
                                </ItemTemplate>
                            </asp:ListView>
                        </div>
                    </div>
                </fieldset>
            </div>
            <div>
                <fieldset>
                    <legend>Users</legend>
                    <asp:ListView ID="ListCourceUser" runat="server">
                        <LayoutTemplate>
                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="float: left; width: 50px; padding: 3px">
                                <asp:HyperLink ID="lnkU" runat="server" NavigateUrl='<%#ResolveUrl("~/User/User.aspx") + "?usid=" + Eval("LoginUserID")%>'>
                                    <div>
                                        <div>
                                            <asp:Image ID="imgPic" runat="server" Width="45" ImageUrl='<%#ResolveUrl(Eval("PhotoPath").ToString()) %>' />
                                        </div>
                                        <div>
                                            <UNameLink:UNameLink ID="UNameLink1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>' />
                                        </div>
                                    </div>
                                </asp:HyperLink>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </fieldset>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
