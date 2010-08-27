<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TutorialView.aspx.cs" Inherits="College_Ajaxer_TutorialView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="tutpop">
    </div>
    <div class="contentbox">
        <asp:ListView ID="ListTutorial" runat="server" OnItemDataBound="ListTutorialOnItemDataBound"
            DataKeyNames="LoginUserID">
            <LayoutTemplate>
                <div>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div>
                    <div>
                        <%#Eval("Name") %>
                    </div>
                    <div>
                        <%#Eval("TutorialType.Name") %>
                    </div>
                    <div>
                        <%#Eval("FilePath") %>
                    </div>
                    <div>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                    </div>
                    <div id="divMy" runat="server">
                        <div>
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("TutorialID").ToString(), "#contentBox", "#contentBox")%>
                        </div>
                    </div>
                </div>
                <hr />
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevx" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextx" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
           <%-- <%--<aspajax:HyperLink ID="lnkAdd" runat="server" NavigateUrl="~/Admin/Ajaxer/CourceInfo.aspx"
                ContainnerID="#contentBox">Add New</aspajax:HyperLink>--%>
            <asp:LinkButton ID="lnkAdd" runat="server"><%=Resources.Default.Add_Text%></asp:LinkButton>
        </div>
    </div>
    </form>
</body>
</html>
