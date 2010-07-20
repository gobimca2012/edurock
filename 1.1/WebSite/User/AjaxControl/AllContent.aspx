<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllContent.aspx.cs" Inherits="User_AjaxControl_AllContent" %>

<%@ Register Src="../UserControl/UserToolTipLink.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="float: left; width: 65%;">
        <div class="contentbox">
            <div class="hcurv">
                All Activity
            </div>
            <div class="whitecont">
                <div id="allcon">
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
                                <div>
                                    <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>'
                                        ModifiedDate='<%#Eval("ModifiedDate") %>' />
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>
            <div class="hcurv">
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevQuestion" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#Question" ResponseContainner="#Question"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextQuestion" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#Question" Pagger="true" Increment="true" ResponseContainner="#Question">Next</aspajax:AjaxLinkButton>
                    </div>
                    <div class="clear">
                    </div>
                </div>
                <div style="clear: both">
                </div>
            </div>
        </div>
    </div>
    <div id="sidewidget" style="float: right; width:34%;">
    </div>
    <div style="clear: both">
    </div>
    </form>
</body>
</html>
