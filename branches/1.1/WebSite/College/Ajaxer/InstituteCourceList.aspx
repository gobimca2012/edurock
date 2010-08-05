﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceList.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="grayhead ">Cources</div>
    <div class="graycontent roundedall" style="line-height: 22px;">
        <asp:ListView ID="listCource" runat="server">
            <LayoutTemplate>
                <div>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div>
                    <aspajax:HyperLink ID="lnkFullView" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/AboutCource.aspx") + "?icid=" + Eval("InstituteCourceID").ToString()+"&iid="+_InstituteID.ToString()%>'><%#Eval("Cource.CourceName")%></aspajax:HyperLink>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>