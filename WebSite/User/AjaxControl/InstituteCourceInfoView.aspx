<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceInfoView.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ListView ID="ListInstituteCource" runat="server" OnItemDataBound="ListInstituteCourceOnItemDataBound" DataKeyNames="InstituteCourceID">
        <LayoutTemplate>
            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
        </LayoutTemplate>
        <ItemTemplate>
            <div>
                <aspajax:HyperLink ID="lnkFullvIew" runat="server" ContainnerID="#lander" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Lander.aspx") + "?icid=" + Eval("InstituteCourceID").ToString()%>'> <div class="cin">   <%#Eval("Cource.CourceName")%></div></aspajax:HyperLink>
            </div>
        </ItemTemplate>
    </asp:ListView>
    </form>
</body>
</html>
