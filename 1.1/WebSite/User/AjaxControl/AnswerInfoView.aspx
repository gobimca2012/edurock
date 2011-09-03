<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnswerInfoView.aspx.cs" Inherits="User_AjaxControl_AnswerInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListAnswer" runat="server" DataKeyNames="LoginUserID,AnswerID,AnswerStatus"
            OnItemDataBound="ListAnswerOnItemDataBound">
            <LayoutTemplate>
                <div style="width: 100%">
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div>
                    <div style="float: left; width: 87%; background: #fff; margin: 5px; padding: 10px;">
                        <div>
                            <div class="fl">
                                <asp:Image ID="imgProf" runat="server" ImageUrl='<%#ImageHelper.ResolveURL(Eval("PhotoPath").ToString()) %>'
                                    Width="50" />
                            </div>
                            <div class="fl">
                                <span class="btitle">
                                    <%#Eval("AnswerText") %></span>
                                <br />
                                <span style="font-size: 14px; font-weight: bold">"</span>
                                <%#Eval("Description") %>
                                <span style="font-size: 14px; font-weight: bold">"</span>
                            </div>
                            <div class="fr">
                                Post By
                                <%#Eval("FirstName") %>
                                &nbsp;<%#Eval("LastName") %>
                                <br />
                                <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                                <br />
                                <div class="label roundedall">
                                    <%#Eval("AnswerStatus") %>
                                </div>
                            </div>
                            <div class="clear">
                            </div>
                        </div>
                       
                    </div>
                    <div style="float: right">
                        <div id="UserAction" runat="server">
                            <div id="stateDiv" runat="server">
                                <asp:DropDownList ID="ddState" runat="server" Visible="false">
                                </asp:DropDownList>
                            </div>
                            <div>
                                <div class="btn">
                                    <%# _HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("AnswerID").ToString(), "#Answer", "#Answer")%></div>
                            </div>
                            <%-- <div>
                                <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/AnswerInfo.aspx") + "?cid=" + Eval("AnswerID")%>'
                                    ContainnerID="#courceinfo"><div class="btn"> Edit</div></aspajax:HyperLink>
                            </div>--%>
                            <div id="acceptAnswer" runat="server" visible="true">
                                <div class="btn">
                                    <%#_HtmlHelper.ListViewLinkButton("lnkda", "Accept","accept", Eval("AnswerID").ToString(),"1", "#Answer", "#Answer")%></div>
                            </div>
                            <div id="rejectanswer" runat="server" visible="true">
                                <div class="btn">
                                    <%#_HtmlHelper.ListViewLinkButton("lnkda", "Reject","accept", Eval("AnswerID").ToString(),"2", "#Answer", "#Answer")%></div>
                            </div>
                        </div>
                    </div>
                    <div style="clear: both">
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevAnswer" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#Answer" ResponseContainner="#Answer"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextAnswer" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#Answer" Pagger="true" Increment="true" ResponseContainner="#Answer">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <div class="btn">
                <aspajax:HyperLink ID="hpAddAnswer" runat="server" ContainnerID="#Answer">Give new Answer</aspajax:HyperLink></div>
        </div>
    </div>
    </form>
</body>
</html>
