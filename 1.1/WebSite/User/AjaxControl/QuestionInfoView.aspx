<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionInfoView.aspx.cs"
    Inherits="User_AjaxControl_QuestionInfoView" %>

<%@ Register Src="../UserControl/UserToolTipLink1.1.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding: 5px;">
        <div class="contentbox">
            <div class="gray" id="header" runat="server">
                Images</div>
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
            <div class="clear">
            </div>
            <div class="cbox">
                <asp:ListView ID="ListQuestion" runat="server" DataKeyNames="LoginUserID,ID" OnItemDataBound="ListQuestionOnItemDataBound">
                    <LayoutTemplate>
                        <div>
                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="dasbo">
                            <div style="float: left; width: 550px" class="btitle">
                                <aspajax:HyperLink ID="lnkQuestionFull" runat="server" ContainnerID="#contentBox"
                                    NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Question.aspx")+"?qid="+Eval("ID")  %>'><%#Eval("Title") %></aspajax:HyperLink>
                            </div>
                            <div class="invis fr">
                                <%#_HtmlHelper.ListViewLinkButtonDelete("lnkd", "delete", Eval("ID").ToString(), Eval("LoginUserID").ToString(), "#contentBox", "#contentBox")%>
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
            <div class="gray">
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevQuestion" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextQuestion" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                    </div>
                    <div class="fleft">
                        <aspajax:HyperLink ID="hpAddQuestion" runat="server" NavigateUrl="" ContainnerID="#contentBox"><div class="btn"><%=Resources.Default.Add_Text%> Question</div></aspajax:HyperLink>
                    </div>
                </div>
                <div class="clear">
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
