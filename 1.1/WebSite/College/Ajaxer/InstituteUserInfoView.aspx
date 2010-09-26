<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteUserInfoView.aspx.cs"
    Inherits="College_Ajaxer_InstituteUserInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            <ul>
                <li>
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                </li>
                <li>
                    <asp:DropDownList ID="ddType" runat="server">
                    </asp:DropDownList>
                </li>
                <li>
                    <aspajax:AjaxLinkButton ID="lnkSearch" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" OnAjaxClick="SearchAjaxClick">Search</aspajax:AjaxLinkButton>
                </li>
            </ul>
        </div>
        <div>
            <asp:ListView ID="ListInstituteUser" runat="server">
                <LayoutTemplate>
                    <table>
                        <thead>
                            <tr>
                                <td>
                                    Username
                                </td>
                                <td>
                                    Password
                                </td>
                                <%-- <td>
                                    InstituteUserType
                                </td>--%>
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
                            <%#Eval("InstituteLoginUser.Username")%>
                        </td>
                        <td>
                            <%#Eval("InstituteLoginUser.Password")%>
                        </td>
                        <%--<td>
                            <%#Eval("InstituteUserType.Name")%>
                        </td>--%>
                        <td>
                            <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                        </td>
                        <td>
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteUserID").ToString(), "#contentBox", "#contentBox")%>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkRole" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteUserInUserTypeInfo.aspx") + "?uid=" + Eval("LoginUserID")%>'>Roles</aspajax:HyperLink>
                        </td>
                        <td>
                            <aspajax:HyperLink ID="lnkUserCource" runat="server" Visible="false" ContainnerID="#contentBox"
                                NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteCourceUserInfoView.aspx")+"?uid="+Eval("LoginUserID") %>'> <cram:SpaceLabel ID="lblcc" runat="server" EnableViewState="false" CssClass="label"></cram:SpaceLabel></aspajax:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevInstituteUser" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextInstituteUser" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="float: left">
                <aspajax:HyperLink ID="hpAddInstituteUser" runat="server" NavigateUrl="~/College/Ajaxer/InstituteUserInfo.aspx"
                    ContainnerID="#contentBox"><div class="btn editbtn"><%=Resources.Default.Add_Text%></div></aspajax:HyperLink>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
