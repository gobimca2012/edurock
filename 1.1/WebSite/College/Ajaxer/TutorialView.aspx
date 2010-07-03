<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TutorialView.aspx.cs" Inherits="College_Ajaxer_TutorialView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
     <div id="tutpop"></div>
    <div>
        <asp:ListView ID="ListTutorial" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                           
                            <td>
                                Name
                            </td>
                            <td>
                                TutorialType
                            </td>
                            <td>
                                FilePath
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
                        <%#Eval("TutorialType.Name") %>
                    </td>
                    <td>
                        <%#Eval("FilePath") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("TutorialID").ToString(), "#tutorial", "#tutorial")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/CourceInfo.aspx") + "?cid=" + Eval("TutorialID")%>'
                            ContainnerID="#tutorial">Edit</aspajax:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevx" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#tutorial" ResponseContainner="#tutorial"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextx" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#tutorial" Pagger="true" Increment="true" ResponseContainner="#tutorial">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <%--<aspajax:HyperLink ID="lnkAdd" runat="server" NavigateUrl="~/Admin/Ajaxer/CourceInfo.aspx"
                ContainnerID="#tutorial">Add New</aspajax:HyperLink>--%>
            <asp:LinkButton ID="lnkAdd" runat="server">Add</asp:LinkButton>
        </div>
    </div>
    </form>
</body>
</html>
