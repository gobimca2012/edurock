﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceInfoView.aspx.cs" Inherits="College_Ajaxer_CourceInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
        </div>
        <div class="whitecont">
            <asp:ListView ID="ListCource" runat="server">
                <LayoutTemplate>
                    <table>
                        <thead>
                            <tr>
                                <td>
                                    CourceID
                                </td>
                                <td>
                                    CourceCatagoryID
                                </td>
                                <td>
                                    CourceName
                                </td>
                                <td>
                                    Description
                                </td>
                                <td>
                                    CourceType
                                </td>
                                <td>
                                    Modifieddate
                                </td>
                            </tr>
                        </thead>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%#Eval("CourceID") %>
                        </td>
                        <td>
                            <%#Eval("CourceCatagoryID") %>
                        </td>
                        <td>
                            <%#Eval("CourceName") %>
                        </td>
                        <td>
                            <%#Eval("Description") %>
                        </td>
                        <td>
                            <%#Eval("CourceType") %>
                        </td>
                        <td>
                            <%#Eval("Modifieddate") %>
                        </td>
                        <td>
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("CourceID").ToString(), "#courceinfo", "#courceinfo")%>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/CourceInfo.aspx") + "?cid=" + Eval("CourceID")%>'
                                ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
            <div>
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevx" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#courceinfo" ResponseContainner="#courceinfo"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextx" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#courceinfo" Pagger="true" Increment="true" ResponseContainner="#courceinfo">Next</aspajax:AjaxLinkButton>
                    </div>
                </div>
                <div style="clear: both">
                </div>
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="lnkAdd" runat="server" NavigateUrl="~/College/Ajaxer/CourceInfo.aspx"
                ContainnerID="#courceinfo"><div class="btn"> Add New</div></aspajax:HyperLink>
        </div>
    </div>
    </form>

    <script language='javascript' type='text/javascript'>
tinyMCE.init({
mode : 'textareas',
theme : 'advanced',
theme_advanced_buttons1: "bold, italic,underline",
theme_advanced_buttons2:"",
theme_advanced_buttons3:""
});
//you can also used “advanced” for themes
    </script>

</body>
</html>