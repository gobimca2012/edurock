<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShareInfo.aspx.cs" Inherits="User_ShareInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Share Your Data</div>
        <fieldset>
            <legend>All User Access</legend>
            <div>
                <%--<asp:CheckBox ID="chkEditAllUser" runat="server" Text="Can Edit" Checked="false" />--%>
                <aspajax:CheckBox ID="chkEditAllUser" CustomID="chkAllEdit$AllUSer" runat="server" Checked="false"></aspajax:CheckBox><span>All User Can Edit</span>
            </div>
            <div>
                <%--<asp:CheckBox ID="chkViewAllUser" runat="server" Text="Can View" Checked="true"/>--%>
                <aspajax:CheckBox ID="chkViewAllUser" CustomID="chkAllView$AllUSer" runat="server" Checked="true"></aspajax:CheckBox><span>All User can View</span>
            </div>
        </fieldset>
        <fieldset>
            <legend>Share with Users</legend>
            <div class="whitecont">
                <asp:ListView ID="listUsers" runat="server">
                    <LayoutTemplate>
                        <div>
                            <table>
                                <thead>
                                    <tr>
                                        <td>
                                            Users
                                        </td>
                                        <td>
                                            Can Add
                                        </td>
                                        <td>
                                            Can Edit
                                        </td>
                                        <td>
                                            Can View
                                        </td>
                                        <td>
                                            Can Delete
                                        </td>
                                    </tr>
                                </thead>
                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                            </table>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%#Eval("Username") %>
                            </td>
                            <td>
                                <aspajax:CheckBox CustomID='<%#"chkAdd$"+Eval("LoginUserID").ToString()%>' ID="chkA"
                                    runat="server" Checked='<%#Eval("EnableAdd") %>'></aspajax:CheckBox>
                            </td>
                            <td>
                                <aspajax:CheckBox CustomID='<%#"chkEdit$"+Eval("LoginUserID").ToString() %>' ID="chkE"
                                    runat="server" Checked='<%#Eval("EnableEdit") %>'></aspajax:CheckBox>
                            </td>
                            <td>
                                <aspajax:CheckBox CustomID='<%#"chkView$"+Eval("LoginUserID").ToString() %>' ID="chkV"
                                    runat="server" Checked='<%#Eval("EnableView") %>'></aspajax:CheckBox>
                            </td>
                            <td>
                                <aspajax:CheckBox CustomID='<%#"chkDelete$"+Eval("LoginUserID").ToString() %>' ID="chkD"
                                    runat="server" Checked='<%#Eval("EnableDelete") %>'></aspajax:CheckBox>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <div class="hcurv">
                <aspajax:AjaxLinkButton ID="lnkSave" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" EnableViewState="False" Increment="False" OnAjaxClick="SaveAjaxClick"
                    Pagger="False"><div class="btn">Save</div> </aspajax:AjaxLinkButton>
            </div>
        </fieldset>
        <fieldset>
            <legend>Share with Group</legend>
            <div class="whitecont">
                <asp:ListView ID="ListGroup" runat="server">
                    <LayoutTemplate>
                        <div>
                            <table>
                                <thead>
                                    <tr>
                                        <td>
                                            Users
                                        </td>
                                        <td>
                                            Can Add
                                        </td>
                                        <td>
                                            Can Edit
                                        </td>
                                        <td>
                                            Can View
                                        </td>
                                        <td>
                                            Can Delete
                                        </td>
                                    </tr>
                                </thead>
                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                            </table>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%#Eval("Name") %>
                            </td>
                            <td>
                                <aspajax:CheckBox CustomID='<%#"chkgAdd$"+Eval("InstituteUserTypeID").ToString()%>'
                                    ID="chkgA" runat="server" Checked='<%#Eval("EnableAdd") %>'></aspajax:CheckBox>
                            </td>
                            <td>
                                <aspajax:CheckBox CustomID='<%#"chkgEdit$"+Eval("InstituteUserTypeID").ToString() %>'
                                    ID="chkgE" runat="server" Checked='<%#Eval("EnableEdit") %>'></aspajax:CheckBox>
                            </td>
                            <td>
                                <aspajax:CheckBox CustomID='<%#"chkgView$"+Eval("InstituteUserTypeID").ToString() %>'
                                    ID="chkgV" runat="server" Checked='<%#Eval("EnableView") %>'></aspajax:CheckBox>
                            </td>
                            <td>
                                <aspajax:CheckBox CustomID='<%#"chkgDelete$"+Eval("InstituteUserTypeID").ToString() %>'
                                    ID="chkgD" runat="server" Checked='<%#Eval("EnableDelete") %>'></aspajax:CheckBox>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <div class="hcurv">
                <aspajax:AjaxLinkButton ID="lnkUpdateGroup" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" EnableViewState="False" Increment="False" OnAjaxClick="SaveGroupAjaxClick"
                    Pagger="False"><div class="btn">Save</div> </aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
