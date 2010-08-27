<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomeWorkInfoView.aspx.cs"
    Inherits="User_AjaxControl_HomeWorkInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray" id="header" runat="server">
            Homeworks</div>
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
        <asp:ListView ID="ListHomeWork" runat="server">
            <LayoutTemplate>
                <div class="whitecont">
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div style="clear: both" class="dasbo">
                    <div style="float: left;width:550px" class="btitle" >
                        <aspajax:HyperLink ID="lnkFull" runat="server" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/HomeWork.aspx")+"?hwid="+Eval("ID").ToString()%>'
                            ContainnerID="#contentBox"><%#Eval("Title") %></aspajax:HyperLink>
                    </div>
                    <div style="float: right">
                        Post on &nbsp;<%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                    </div>
                    <div style="clear: both">
                    </div>
                </div>
                
            </ItemTemplate>
        </asp:ListView>
        <div class="gray">
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevHomeWork" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextHomeWork" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="float: left">
                <aspajax:HyperLink ID="hpAddHomeWork" runat="server" NavigateUrl="~/User/AjaxControl/HomeWorkInfo.aspx"
                    ContainnerID="#contentBox"><div class="btn"><%=Resources.Default.Add_Text%> Homework</div></aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
