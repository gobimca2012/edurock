<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteSubjectInfoView.aspx.cs"
    Inherits="College_Ajaxer_InstituteSubjectController" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">Subjects</div>
            <asp:ListView ID="ListInstituteSubject" runat="server">
                <LayoutTemplate>
                    <table>
                        <thead>
                            <tr>
                                <td>
                                    SubjectText
                                </td>
                                <td>
                                    ModifiedDate
                                </td>
                            </tr>
                        </thead>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%#Eval("SubjectText") %>
                        </td>
                        <td>
                            <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                        </td>
                        <td>
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteSubjectID").ToString(), "#contentBox", "#contentBox")%>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteSubjectInfo.aspx") + "?isid=" + Eval("InstituteSubjectID")%>'
                                ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        
        <div class="gray">
            <div>
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevInstituteSubject" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextInstituteSubject" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                    </div>
                </div>
            </div>
            <div style="float: left">
                <aspajax:HyperLink ID="hpAddInstituteSubject" runat="server" ContainnerID="#contentBox"><div class="btn"> Add New</div></aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
