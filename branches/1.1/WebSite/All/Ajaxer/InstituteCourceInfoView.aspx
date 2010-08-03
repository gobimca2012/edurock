<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceInfoView.aspx.cs"
    Inherits="All_Ajaxer_InstituteCourceInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div>
            <asp:ListView ID="ListCource" runat="server">
                <LayoutTemplate>
                    <table>
                        <thead>
                            <tr>
                                <td>
                                    CourceName
                                </td>
                                <td>
                                    CourceCatagory
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
                            <%#Eval("Cource.CourceName") %>
                        </td>
                        <td>
                            <%#Eval("Cource.CourceCatagory.CatagoryName")%>
                        </td>
                        <td>
                            <%#Eval("Cource.CourceType")%>
                        </td>
                        <td>
                            <%#Eval("Cource.Modifieddate")%>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
            <div>
                <div style="float: right">
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkPrevCource" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                            Pagger="true" Increment="false" RequestContainner="#Cource" ResponseContainner="#Cource"></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkNextCource" runat="server" OnAjaxClick="NextAjaxClick"
                            RequestContainner="#Cource" Pagger="true" Increment="true" ResponseContainner="#Cource">Next</aspajax:AjaxLinkButton>
                    </div>
                </div>
                <div style="clear: both">
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
