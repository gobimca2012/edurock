<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Upop.aspx.cs" Inherits="User_AjaxControl_Upop" %>

<%@ Register Src="~/User/UserControl/UserToolTipLink.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="trans" style="float: left; width: 400px">
        <div class="contentbox">
            <div class="gray">
                <div style="float: right">
                    <asp:HyperLink ID="lnkclose" runat="server"><div class="close"></div></asp:HyperLink>
                </div>
                <div id="lblName" runat="server" style="float: left">
                </div>
                <div style="clear: both">
                </div>
            </div>
            <div id="popupLoggedIn" runat="server">
                <div class="whitecont">
                    <div>
                        <div style="width: 360px">
                            <div style="float: left; width: 110">
                                <asp:Image ID="propic" runat="server" Width="100" />
                            </div>
                            <div style="float: left; text-align: left; width: 240px">
                                <div>
                                    <span class="label">Status :</span> <span id="lblStatus" runat="server" class="btext">
                                    </span>
                                </div>
                            </div>
                            <div style="clear: both">
                            </div>
                            <div class="dasbo">
                                <div>
                                    <span class="label">Username :</span> <span id="lblUserName" runat="server"></span>
                                </div>
                            </div>
                            <div class="dasbo">
                                <span class="label">User Role:</span>&nbsp;<span id="lblRole" runat="server"></span>
                            </div>
                            <div class="dasbo">
                                <span class="label">User Institute:</span> &nbsp;<span id="lblGroup" runat="server"></span>
                            </div>
                            <div class="dasbo">
                                <span class="label">User Cource:</span>&nbsp;<span id="lblCource" runat="server"></span>
                            </div>
                            <div>
                                <div>
                                    recent Activity
                                </div>
                                <asp:ListView ID="ListQuestion" runat="server" DataKeyNames="ID,ContentType" OnItemDataBound="ListQuestionOnItemDataBound">
                                    <LayoutTemplate>
                                        <div>
                                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                                        </div>
                                    </LayoutTemplate>
                                    <ItemTemplate>
                                        <div class="dasbo">
                                            <div>
                                                <span class='<%#GetCSSClass(Eval("ContentType").ToString()) %>'>&nbsp;</span>
                                                <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#getURL(Eval("ContentType").ToString(),Eval("ID").ToString()) %>'>
                            <%#Eval("Title") %></aspajax:HyperLink>
                                            </div>
                                            <%-- <div>
                                            <uc1:usertooltiplink id="UserToolTipLink1" runat="server" loginuserid='<%#Eval("LoginUserID") %>'
                                                modifieddate='<%#Eval("ModifiedDate") %>' />
                                        </div>--%>
                                        </div>
                                    </ItemTemplate>
                                </asp:ListView>
                            </div>
                            <div>
                                <asp:HyperLink ID="lnkUserProfile" runat="server"><div class="btn">Full Profile</div> </asp:HyperLink>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="popupLoggedOut" runat="server" visible="false">
                <div class="whitecont">
                    <h3>
                        Please sign in to System</h3>
                </div>
            </div>
        </div>
    </div>
    <div class="tarrow" style="float: left">
    </div>
    <div style="clear: both">
    </div>
    </form>
</body>
</html>
