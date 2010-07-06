<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteUserInUserTypeInfo.aspx.cs"
    Inherits="College_Ajaxer_InstituteUserInUserTypeInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
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
                <%--<asp:ListView ID="ListUser" runat="server">
                    <LayoutTemplate>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div>
                            <asp:CheckBox ID="chk" runat="server" Text='<%#Eval("InstituteLoginUser.Username") %>'  />
                        </div>
                    </ItemTemplate>
                </asp:ListView>--%>
                
            </div>
        </div>
    </div>
    <aspajax:AjaxLinkButton ID="lnkP"  runat="server" EnableViewState="False" RequestContainner="#contentBox" ResponseContainner="#contentBox"
        Increment="False" onajaxclick="AddAjaxClick" Pagger="False">Send</aspajax:AjaxLinkButton>
    </form>
</body>
</html>
