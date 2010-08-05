<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceInfoView.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ListView ID="ListInstituteCource" runat="server" OnItemDataBound="ListInstituteCourceOnItemDataBound"
        DataKeyNames="InstituteCourceID">
        <LayoutTemplate>
            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
        </LayoutTemplate>
        <ItemTemplate>
            <div style="border-bottom:dashed 1px #cfcfcf;">
                <%--<div class="sub" style="float: left; margin-left: 7px;">
                </div>--%>
                <div style="float: left;line-height:24px;margin-left:5px;">
                    <aspajax:HyperLink ID="lnkFullvIew" runat="server" ContainnerID="#lander" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Lander.aspx") + "?icid=" + Eval("InstituteCourceID").ToString()%>'> <div >   <%#Eval("Cource.CourceName")%></div></aspajax:HyperLink>
                </div>
                <div class="clear">
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
    </form>
</body>
</html>
