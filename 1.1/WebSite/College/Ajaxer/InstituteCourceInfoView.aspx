﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceInfoView.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel ID="InstituteCource" runat="server">
        <asp:ListView ID="ListInstituteCource" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                CourceName
                            </td>
                            <td>
                                Cource Catagory
                            </td>
                            <td>
                                Date
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("Cource.CourceName")%>
                    </td>
                    <td>
                        <%#Eval("Cource.CourceCatagory.CatagoryName")%>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteCourceID").ToString(), "#courceinfo", "#courceinfo")%>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
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
        <div>
            <aspajax:HyperLink ID="lnkAddiCo" runat="server" ContainnerID="#courceinfo" NavigateUrl="~/College/Ajaxer/InstituteCourceInfo.aspx">Add New</aspajax:HyperLink>
        </div>
    </asp:Panel>
    </form>
</body>
</html>
