<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceList.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="grayhead ">
        <div style="float: left">
            <cram:SpaceLabel ID="ttspace" runat="server"></cram:SpaceLabel> </div>
        <div style="float: right" class="exand" id="courseboxtrigger">
        </div>
        <div class="clear">
        </div>
    </div>
    <div id="coursebox" style="display:none">
        <asp:ListView ID="listCource" runat="server">
            <LayoutTemplate>
                <div>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div class="lmenuitem">
                    <aspajax:HyperLink ID="lnkFullView" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/AboutCource.aspx") + "?icid=" + Eval("InstituteCourceID").ToString()+"&iid="+_InstituteID.ToString()%>'><%#Eval("Cource.CourceName")%></aspajax:HyperLink>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
