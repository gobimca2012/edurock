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
                <div class="whitecont">
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div class="dashbo">
                    <div class="fl">
                        <%#Eval("InstituteUserType.Name") %>
                    </div>
                    <div class="fr">
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteUserInUserTypeID").ToString(), "#contentBox", "#contentBox")%>
                    </div>
                    <div class="clear">
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div class="gray">
        </div>
    </div>
    <div class="contentbox">
        <div class="gray">
            User roles</div>
        <div class="whitecont">
            <div>
                <div>
                    <span class="label">User Role</span><span class="valmsg">(Required)*</span>
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
                Pagger="False"><div class="btn editbtn"> <%=Resources.Default.Add_Text%></div></aspajax:AjaxLinkButton>
        </div>
    </div>
    </form>
</body>
</html>
