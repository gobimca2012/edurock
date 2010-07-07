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
        <div class="gray">
            Homeworks</div>
        <asp:ListView ID="ListHomeWork" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                HomeWorkID
                            </td>
                            <td>
                                LoginUserID
                            </td>
                            <td>
                                Title
                            </td>
                            <td>
                                Description
                            </td>
                            <td>
                                ShortDescription
                            </td>
                            <td>
                                InstituteCourceID
                            </td>
                            <td>
                                InstituteSubjectID
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
                        <%#Eval("HomeWorkID") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#Eval("Title") %>
                    </td>
                    <td>
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("ShortDescription") %>
                    </td>
                    <td>
                        <%#Eval("InstituteCourceID") %>
                    </td>
                    <td>
                        <%#Eval("InstituteSubjectID") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("HomeWorkID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/HomeWorkInfo.aspx") + "?cid=" + Eval("HomeWorkID")%>'
                            ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                    </td>
                </tr>
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
            <div style="float:left">
                <aspajax:HyperLink ID="hpAddHomeWork" runat="server" NavigateUrl="~/User/AjaxControl/HomeWorkInfo.aspx"
                    ContainnerID="#contentBox">Add New</aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
