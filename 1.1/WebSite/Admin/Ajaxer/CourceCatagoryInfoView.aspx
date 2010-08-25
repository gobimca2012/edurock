<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceCatagoryInfoView.aspx.cs"
    Inherits="Admin_Ajaxer_CourceCatagoryInfoView" %>

<%@ Register Src="~/User/UserControl/UserNameToolTipLink.ascx" TagName="UserNameToolTipLink"
    TagPrefix="uc1" %>
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
                                <cram:SpaceLabel ID="ttspace" runat="server"></cram:SpaceLabel>  Catagory
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
                        <uc1:UserNameToolTipLink ID="UserNameToolTipLink1" runat="server" LoginUserID='<%# Eval("LoginUserID") %>' />
                    </td>
                    <td>
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("CatagoryType") %>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("CourceCatagoryID").ToString(), "#courcecatagory", "#courcecatagory")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/CourceCatagoryInfo.aspx") + "?ccid=" + Eval("CourceCatagoryID")%>'
                            ContainnerID="#courcecatagory"> Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevx" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#courcecatagory" ResponseContainner="#courcecatagory"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextx" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#courcecatagory" Pagger="true" Increment="true" ResponseContainner="#courcecatagory">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="lnkAdd" runat="server" NavigateUrl="~/Admin/Ajaxer/CourceCatagoryInfo.aspx"
                ContainnerID="#courcecatagory">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
