﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceCatagoryInfoView.aspx.cs"
    Inherits="College_Ajaxer_CourceCatagoryInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListCourceCatagory" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                CourceCatagoryID
                            </td>
                            <td>
                                CatagoryName
                            </td>
                            <td>
                                LoginUserID
                            </td>
                            <td>
                                Description
                            </td>
                            <td>
                                CatagoryType
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
                        <%#Eval("CourceCatagoryID") %>
                    </td>
                    <td>
                        <%#Eval("CatagoryName") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("CatagoryType") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <aspajax:AjaxLinkButton ID="lnkDelete" runat="server" RequestContainner="" ResponseContainner=""
                            OnAjaxClick="DeleteajaxClick" QID='<%#Eval("CourceCatagoryID") %>'>Delete</aspajax:AjaxLinkButton>
                        <%#_htmlHelper.ListViewLinkButton("lnkd", "delete", Eval("CourceCatagoryID").ToString(), "#courcecatagory", "#courcecatagory")%>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkPrev" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                    Pagger="true" Increment="false" RequestContainner="#courcecatagory" ResponseContainner="#courcecatagory"></aspajax:AjaxLinkButton>
            </div>
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkNext" runat="server" OnAjaxClick="NextAjaxClick"
                    RequestContainner="#courcecatagory" Pagger="true" Increment="true" ResponseContainner="#courcecatagory">Next</aspajax:AjaxLinkButton>
            </div>
        </div>
        <div style="clear: both">
        </div>
    </div>
    <div>
        <aspajax:HyperLink ID="lnkAddnew" runat="server" NavigateUrl="CourceCatagoryInfo.aspx"
            ContainnerID="#courcecatagory">Add new</aspajax:HyperLink>
    </div>
    </div>
    </form>
</body>
</html>
