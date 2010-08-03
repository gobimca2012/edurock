<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteInfoView.aspx.cs"
    Inherits="All_Ajaxer_InstituteInfoViewaspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <ul>
            <li>
                <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
            </li>
            <li>
                <aspajax:AjaxLinkButton ID="lnkSearch" runat="server" EnableViewState="False" RequestContainner="#Institute"
                    ResponseContainner="#Institute" Increment="False" OnAjaxClick="SearchAjaxClick"
                    Pagger="False">Search</aspajax:AjaxLinkButton>
            </li>
        </ul>
    </div>
    <div class="contentbox">
        <asp:ListView ID="ListInstitute" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                Name
                            </td>
                            <td>
                                CityName
                            </td>
                            <td>
                                StateName
                            </td>
                            <td>
                                CountryName
                            </td>
                            <td>
                                WebSite
                            </td>
                            <td>
                                CollegeType
                            </td>
                            <td>
                                ShortName
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#Institute" NavigateUrl=' <%#ResolveUrl("~/All/Ajaxer/Institute.aspx")+"?iid="+Eval("InstituteID").ToString() %>'><%#Eval("Name") %></aspajax:HyperLink>
                    </td>
                    <td>
                        <%#Eval("CityName") %>
                    </td>
                    <td>
                        <%#Eval("StateName") %>
                    </td>
                    <td>
                        <%#Eval("CountryName") %>
                    </td>
                    <td>
                        <%#Eval("WebSite") %>
                    </td>
                    <td>
                        <%#Eval("CollegeType") %>
                    </td>
                    <td>
                        <%#Eval("ShortName") %>
                    </td>
                   
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevInstitute" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#Institute" ResponseContainner="#Institute"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextInstitute" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#Institute" Pagger="true" Increment="true" ResponseContainner="#Institute">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
