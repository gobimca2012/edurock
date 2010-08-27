﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EducationView.aspx.cs" Inherits="User_AjaxControl_Education" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListUserEducation" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            
                            <td>
                                InstitueName
                            </td>
                            <td>
                                SubjectName
                            </td>
                            <td>
                                Year
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
                        <%#Eval("InstitueName") %>
                    </td>
                    <td>
                        <%#Eval("SubjectName") %>
                    </td>
                    <td>
                        <%#Eval("Year") %>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("UserEducationID").ToString(), "#education", "#education")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/EducationInfo.aspx") + "?eid=" + Eval("UserEducationID")%>'
                            ContainnerID="#education"><%=Resources.Default.Edit_Text %></aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevx" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#education" ResponseContainner="#education"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextx" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#education" Pagger="true" Increment="true" ResponseContainner="#education">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="lnkAdd" runat="server" NavigateUrl="~/User/AjaxControl/EducationInfo.aspx"
                ContainnerID="#education"><%=Resources.Default.Add_Text%></aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
