<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AudioInfoView.aspx.cs" Inherits="User_AjaxControl_AudioInfoView" %>

<%@ Register Src="../UserControl/UserToolTipLink1.1.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Audios</div>
        <div class="graycontent">
            <div style="float: left" class="title">
                Search
            </div>
            <div style="float: right" class="expand" id="searchboxtrigger">
                <div>
                </div>
            </div>
            <div class="clear">
            </div>
            <div id="searchbox" runat="server" class="invis">
                <div>
                    <div style="float: left;">
                        <div class="label">
                            Keyword</div>
                        <div>
                            <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div style="float: left;">
                        <div class="label">
                            Start Date</div>
                        <div>
                            <asp:TextBox ID="txtstartDate" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div style="float: left;">
                        <div class="label">
                            End Date</div>
                        <div>
                            <asp:TextBox ID="txtEnddate" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="clear">
                    </div>
                    <div>
                        <aspajax:AjaxLinkButton ID="lnkSearch" runat="server" EnableValidation="False" EnableViewState="False"
                            Increment="False" OnAjaxClick="AjaxSearch" RequestContainner="#contentBox" ResponseContainner="#contentBox"
                            Pagger="False"><div class="btn">Search</div> </aspajax:AjaxLinkButton>
                    </div>
                </div>
            </div>
        </div>
        <asp:ListView ID="ListDocument" runat="server" DataKeyNames="ID" OnItemDataBound="ListDocumentOnItemDataBound">
            <LayoutTemplate>
                <div class="whitecont">
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div class="dasbo cbox">
                    <div style="float: left; width: 550px">
                        <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + Eval("ID").ToString()%>'>
                        &nbsp;<%#Eval("Title") %></aspajax:HyperLink>
                    </div>
                    <div class="fr invis">
                        <%#_HtmlHelper.ListViewLinkButtonDelete("lnkd", "delete", Eval("ID").ToString(), Eval("LoginUserID").ToString(), "#contentBox", "#contentBox")%>
                    </div>
                    <div style="float: right">
                        <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" ModifiedDate='<%#Eval("ModifiedDate") %>'
                            LoginUserID='<%#Eval("LoginUserID") %>' />
                    </div>
                    <div style="clear: both">
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div class="gray">
            <div style="float: right">
                <div style="float: left;">
                    <aspajax:AjaxLinkButton ID="lnkPrevDocument" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextDocument" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div>
                <aspajax:HyperLink ID="hpAddDocument" runat="server" NavigateUrl="~/User/AjaxControl/DocumentInfo.aspx?dtype=1"
                    ContainnerID="#contentBox"><div class="btn"> <%=Resources.Default.Add_Text%></div></aspajax:HyperLink>
            </div>
        </div>
        <div style="clear: both">
        </div>
    </div>
    </form>
</body>
</html>
