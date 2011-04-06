<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CommentInfoView.aspx.cs"
    Inherits="User_AjaxControl_CommentInfoView" %>

<%@ Register Src="../UserControl/UserBox.ascx" TagName="UserBox" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="graycontent roundedall">
        <div>
            <asp:ListView ID="ListComment" runat="server">
                <LayoutTemplate>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div style="float: left; padding: 2px; width: 70px">
                        <uc1:UserBox ID="UserBox1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>' />
                    </div>
                    <div style="float: left; padding: 2px; width: 70%;background:#fff;min-height:70px;margin-bottom:5px">
                        <%#Eval("CommentText") %>
                    </div>
                    <div style="float: right; padding: 2px; ">
                        <div>
                            <div class="btn">
                                <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("CommentID").ToString(), "#comment", "#comment")%></div>
                        </div>
                        <div>
                            <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("ModifiedDate").ToString())) %>
                        </div>
                    </div>
                    <div style="clear: both">
                    </div>
                </ItemTemplate>
            </asp:ListView>
            <div>
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevComment" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#Comment" ResponseContainner="#Comment"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextComment" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#Comment" Pagger="true" Increment="true" ResponseContainner="#Comment">Next</aspajax:AjaxLinkButton>
                    </div>
                </div>
                <div style="clear: both">
                </div>
            </div>
            <div>
                <%-- <aspajax:HyperLink ID="hpAddComment" runat="server" NavigateUrl="~/Admin/Ajaxer/CommentInfo.aspx"
                    ContainnerID="#Comment">Add New</aspajax:HyperLink>--%>
            </div>
        </div>
    </div>
    <%-- <div id="newcommentbox"></div>--%>
    </form>
</body>
</html>
