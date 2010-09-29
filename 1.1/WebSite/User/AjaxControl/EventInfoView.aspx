<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EventInfoView.aspx.cs" Inherits="User_AjaxControl_EventInfoView" %>

<%@ Register Src="../UserControl/UserToolTipLink1.1.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="contentbox">
            <div class="gray" id="header" runat="server">
                Events</div>
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
                       <div style="float: left;width:150px">
                            <div class="label">
                                Keyword</div>
                            <div>
                                <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                            </div>
                        </div>
                      <div style="float: left;width:150px">
                            <div class="label">
                                Start Date</div>
                            <div>
                                <asp:TextBox ID="txtstartDate" runat="server"></asp:TextBox>
                            </div>
                        </div>
                   <div style="float: left;width:150px">
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
            <div class="graycontent">
                <div class="fl" style="width: 100px">
                    <aspajax:AjaxLinkButton ID="lnkPrevMonth" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" EnableValidation="False" EnableViewState="False"
                        Increment="False" OnAjaxClick="PrevMonthAjax" Pagger="False"><div class="btn editbtn"> <<</div></aspajax:AjaxLinkButton>
                </div>
                <div class="fr" style="width: 100px">
                    <aspajax:AjaxLinkButton ID="lnkNextMonth" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" EnableValidation="False" EnableViewState="False"
                        Increment="False" OnAjaxClick="NextMonthAjax" Pagger="False"><div class="btn editbtn"> >></div></aspajax:AjaxLinkButton>
                </div>
                <div class="clear">
                </div>
                <div class="whitecont">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" Width="100%" BorderWidth="0px"
                        NextMonthText="" PrevMonthText="" CssClass="calender" OnDayRender="CalDayRender">
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TodayDayStyle BackColor="#CCCCCC" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                        <TitleStyle BackColor="White" BorderColor="White" BorderWidth="0px" Font-Bold="True" />
                    </asp:Calendar>
                </div>
            </div>
            <div>
                <asp:ListView ID="ListDocument" runat="server" DataKeyNames="ID" OnItemDataBound="ListDocumentOnItemDataBound">
                    <LayoutTemplate>
                        <div class="whitecont">
                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="dasbo">
                            <div style="float: left; width: 550px">
                                <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Event.aspx") + "?evid=" + Eval("ID").ToString()%>'>
                        &nbsp;&nbsp;&nbsp;&nbsp;<%#Eval("Title") %></aspajax:HyperLink>
                            </div>
                            <div class="invis fr">
                                <%#_HtmlHelper.ListViewLinkButtonDelete("lnkd", "delete", Eval("ID").ToString(), Eval("LoginUserID").ToString(), "#contentBox", "#contentBox")%>
                            </div>
                            <div class="fr">
                                <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" ModifiedDate='<%#Eval("ModifiedDate") %>'
                                    LoginUserID='<%#Eval("LoginUserID") %>' />
                            </div>
                            <div style="clear: both">
                            </div>
                            <div class="label">
                                Event Start Date
                                <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("param1").ToString())) %>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <div class="gray clear">
                <div>
                    <aspajax:HyperLink ID="hpAddDocument" runat="server" NavigateUrl="~/User/AjaxControl/EventInfo.aspx"
                        ContainnerID="#contentBox"><div class="btn"> <%=Resources.Default.Add_Text%></div></aspajax:HyperLink>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
