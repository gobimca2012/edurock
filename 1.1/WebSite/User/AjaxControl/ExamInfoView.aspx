<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamInfoView.aspx.cs" Inherits="College_Ajaxer_ExamInfoView" %>

<%@ Register Src="../UserControl/UserToolTipLink.ascx" TagName="UserToolTipLink"
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
            Examinations
        </div>
        <div class="whitecont clear">
            <asp:ListView ID="ListExam" runat="server">
                <LayoutTemplate>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="dasbo">
                        <div style="float: left; width: 550px">
                            <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Exam.aspx") + "?eid=" + Eval("ID").ToString()%>'>
                        <%#Eval("Title") %></aspajax:HyperLink>
                        </div>
                        <div style="float: right">
                            
                                <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>'
                                    ModifiedDate='<%#Eval("ModifiedDate") %>' />
                        </div>
                        <div style="clear: both">
                        </div>
                        <div>
                            <aspajax:HyperLink ID="lnkExmStart" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/College/ExamIntroduction.aspx") + "?eid=" + Eval("ID").ToString()%>'>Start Exam</aspajax:HyperLink>
                        </div>
                        <div>
                            <%#_HtmlHelper.ListViewLinkButtonDelete("lnkd", "delete", Eval("ID").ToString(), Eval("LoginUserID").ToString(), "#contentBox", "#contentBox")%>
                        </div>
                        <div>
                            <aspajax:HyperLink ID="lnkExamAttenter" runat="server" ContainnerID="#contentBox"
                                NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/ExamAttender.aspx")+"?eid="+Eval("ID").ToString()%>'>Exam Attenders</aspajax:HyperLink>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevExam" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextExam" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
                <div class="clear">
                </div>
            </div>
            <div style="float: left">
                <aspajax:HyperLink ID="hpAddExam" runat="server" NavigateUrl="~/User/AjaxControl/ExamInfo.aspx"
                    ContainnerID="#contentBox"><div class="btn"> Add New Exam</div></aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
