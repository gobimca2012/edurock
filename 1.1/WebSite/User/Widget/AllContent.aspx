<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllContent.aspx.cs" Inherits="User_AjaxControl_AllContent" %>

<%@ Register Src="../UserControl/UserToolTipLink1.1.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="float: left; width: 100%;">
        <div class="contentbox" style="margin-bottom:5px">
            <div class="clear gray">
                <div style="float: left">
                    <h3>
                        Active Stream</h3>
                </div>
                <div style="float: right">
                    <asp:HyperLink ID="lnkExpand" runat="server" CssClass="collapse"><div class=""></div></asp:HyperLink>
                </div>
                <div style="float: right">
                    <asp:HyperLink ID="lnkClose" runat="server"><div class="close tp" rel="remove this widget from page"></div></asp:HyperLink>
                </div>
            </div>
            <div class="whitecont vis" id="activestram">
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
                    <div id="searchbox" class="invis">
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
                                    Pagger="False"><div class="btn editbtn">Search</div> </aspajax:AjaxLinkButton>
                            </div>
                        </div>
                    </div>
                </div>
                <fieldset style="margin-right: 5px;">
                    <legend>All Activity </legend>
                    <div class="whitecont">
                        <div id="allcon">
                            <asp:ListView ID="ListQuestion" runat="server" DataKeyNames="ID,ContentType,ItemIndex" OnItemDataBound="ListQuestionOnItemDataBound">
                            <LayoutTemplate>
                                <div>
                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div class="dasbo">
                                   
                                    <div style="float: left">
                                        <span class='<%#GetCSSClass(Eval("ContentType").ToString()) %>'>&nbsp;</span>
                                        <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#getURL(Eval("ContentType").ToString(),Eval("ID").ToString()) %>'>
                            <%#Eval("Title") %></aspajax:HyperLink>
                                       
                                    </div>
                                    <div class="fl" id="isnewdiv" runat="server"></div>
                                     <div class="graycontent roundedall fr">
                                            Comments : <%#Eval("Comment")%>
                                        </div>
                                    <div style="float: right">
                                        <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>'
                                            ModifiedDate='<%#Eval("ModifiedDate") %>' />
                                    </div>
                                    <div class="clear">
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
                                    Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                            </div>
                            <div style="float: left">
                                <aspajax:AjaxLinkButton ID="lnkNextQuestion" runat="server" OnAjaxClick="NextAjaxClick"
                                    RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                            </div>
                            <div class="clear">
                            </div>
                        </div>
                        <div style="clear: both">
                        </div>
                    </div>
                </fieldset>
            </div>
        </div>
    </div>
    <div id="sidewidget" style="float: right; width: 34%;">
    </div>
    <div style="clear: both">
    </div>
    </form>
</body>
</html>
