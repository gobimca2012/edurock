<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteUserInUserTypeInfo.aspx.cs"
    Inherits="College_Ajaxer_InstituteUserInUserTypeInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            User roles</div>
        <asp:ListView ID="ListUserRoles" runat="server" DataKeyNames="InstituteUserInUserTypeID">
            <LayoutTemplate>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </LayoutTemplate>
            <ItemTemplate>
                <div>
                    <%#Eval("InstituteUserType.Name") %>
                </div>
                <div>
                    <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteUserInUserTypeID").ToString(), "#contentBox", "#contentBox")%>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div class="gray">
        </div>
    </div>
    <div class="contentbox">
        <div class="gray">
            User roles</div>
        <div>
            <div>
                <div>
                    <span class="label">UserRole</span>
                </div>
                <div>
                    <asp:DropDownList ID="ddRoles" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <div>
                <div>
                </div>
            </div>
        </div>
        <div class="gray">
            <aspajax:AjaxLinkButton ID="lnkP" runat="server" EnableViewState="False" RequestContainner="#contentBox"
                ResponseContainner="#contentBox" Increment="False" OnAjaxClick="AddAjaxClick"
                Pagger="False">Add</aspajax:AjaxLinkButton>
        </div>
    </div>
    </form>
</body>
</html>
