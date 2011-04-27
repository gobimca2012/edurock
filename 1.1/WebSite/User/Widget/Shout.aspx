<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Shout.aspx.cs" Inherits="User_Widget_Shout"
    EnableEventValidation="false" EnableViewState="false" EnableViewStateMac="false"
    ValidateRequest="false" %>

<%@ Register Src="../UserControl/UserToolTipLink1.1.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="clear gray">
            <div style="float: left">
                <h3 id="Widgetheader" runat="server">
                </h3>
            </div>
            <div style="float: right">
                <asp:HyperLink ID="lnkExpand" runat="server" CssClass="collapse"><div class=""></div></asp:HyperLink>
            </div>
            <div style="float: right">
                <asp:HyperLink ID="lnkClose" runat="server"><div class="close tp" rel="remove this widget from page"></div></asp:HyperLink>
            </div>
        </div>
        <div class="">
            <div id="divpost" class="graycontent roundedall">
                <div>
                    <asp:TextBox ID="txtShout" runat="server" TextMode="MultiLine" Width="93%"></asp:TextBox>
                </div>
                <div>
                    <aspajax:AjaxLinkButton ID="lnkPost" runat="server" EnableValidation="False" EnableViewState="False"
                        Increment="False" OnAjaxClick="Shout" Pagger="False">Post</aspajax:AjaxLinkButton>
                </div>
                <div style="float: right">
                    <font size="1">(Maximum characters: 140)<br>
                        You have
                        <asp:TextBox ID="txtCounter" runat="server" Width="25px" Text="140" ReadOnly="true"></asp:TextBox>
                        characters left.</font>
                </div>
                <div class="clear"></div>
            </div>
            <div>
                <div class="cbox">
                    <asp:ListView ID="ListDocument" runat="server" DataKeyNames="DocumentID">
                        <LayoutTemplate>
                            <div class="whitecont">
                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="dasbo">
                                <div style="float: left;">
                                    <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Shout.aspx") + "?did=" + Eval("DocumentID").ToString()%>'>
                        &nbsp;<%#Eval("Description")%></aspajax:HyperLink>
                                </div>
                                <%--<div class="invis fr">
                                <%#_HtmlHelper.ListViewLinkButtonDelete("lnkd", "delete", Eval("ID").ToString(), Eval("LoginUserID").ToString(), "#contentBox", "#contentBox")%>
                            </div>--%>
                                <div style="float: right">
                                    <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" ModifiedDate='<%#Eval("ModifiedDate") %>'
                                        LoginUserID='<%#Eval("LoginUserID") %>' />
                                </div>
                                <div style="clear: both">
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>
        </div>
        <script language="javascript" type="text/javascript">
            function limitText(limitFieldID, limitCountID, limitNum) {
                var limitField = document.getElementById(limitFieldID);
                var limitCount = document.getElementById(limitCountID);
                if (limitField.value.length < 1) {
                    limitCount.value = limitNum - 1;

                } else if (limitField.value.length > limitNum) {
                    limitField.value = limitField.value.substring(0, limitNum);
                } else {
                    limitCount.value = limitNum - limitField.value.length;
                }
            }
        </script>
    </div>
    </form>
</body>
</html>
