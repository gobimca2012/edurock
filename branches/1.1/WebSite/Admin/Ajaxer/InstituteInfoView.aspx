<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteInfoView.aspx.cs"
    Inherits="Admin_Ajaxer_InstituteInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListInstitute" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                Name
                            </td>
                            <td>
                                Address
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
                                Email
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
                        <%#Eval("Name") %>
                    </td>
                    <td>
                        <%#Eval("Address") %>
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
                        <%#Eval("Email") %>
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
                    
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteID").ToString(), "#institute", "#institute")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/CourceInfo.aspx") + "?cid=" + Eval("InstituteID")%>'
                            ContainnerID="#institute">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevx" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#institute" ResponseContainner="#institute"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextx" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#institute" Pagger="true" Increment="true" ResponseContainner="#institute">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="lnkAdd" runat="server" NavigateUrl="~/Admin/Ajaxer/CourceInfo.aspx"
                ContainnerID="#institute">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
