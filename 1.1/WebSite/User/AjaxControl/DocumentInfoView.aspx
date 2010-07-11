﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocumentInfoView.aspx.cs"
    Inherits="User_AjaxControl_DocumentInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Images</div>
        <asp:ListView ID="ListDocument" runat="server" DataKeyNames="DocumentID" OnItemDataBound="ListDocumentOnItemDataBound">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                DocumentID
                            </td>
                            <td>
                                Name
                            </td>
                            <td>
                                Description
                            </td>
                            <td>
                                MetaDescription
                            </td>
                            <td>
                                Tag
                            </td>
                            <td>
                                LoginUserID
                            </td>
                            <td>
                                Rating
                            </td>
                            <td>
                                FilePath
                            </td>
                            <td>
                                DocumentType
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
                        <%#Eval("DocumentID") %>
                    </td>
                    <td>
                        <%#Eval("Name") %>
                    </td>
                    <td>
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("MetaDescription") %>
                    </td>
                    <td>
                        <%#Eval("Tag") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#Eval("Rating") %>
                    </td>
                    <td>
                        <%#Eval("FilePath") %>
                    </td>
                    <td>
                        <%#Eval("DocumentType") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("DocumentID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/DocumentInfo.aspx") + "?dtype=1&did=" + Eval("DocumentID")%>'
                            ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div class="gray">
            <div style="float: right">
                <div style="float: left">
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
                    ContainnerID="#contentBox">Add New</aspajax:HyperLink>
            </div>
        </div>
        <div style="clear: both">
        </div>
    </div>
    </form>
</body>
</html>
