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
            <div style="float: left">
                Share Your Data</div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkBack" runat="server" ContainnerID="#contentBox"><div class="btn"> Back to FullView</div></aspajax:HyperLink>
            </div>
            <div class="clear">
            </div>
        </div>
        <fieldset>
            <legend>All User Access</legend>
            <div>
                <%--<asp:CheckBox ID="chkEditAllUser" runat="server" Text="Can Edit" Checked="false" />--%>
                <aspajax:CheckBox ID="chkEditAllUser" CustomID="chkAllEdit$AllUSer" runat="server"
                    Checked="false"></aspajax:CheckBox><span>All User Can Edit</span>
            </div>
            <div>
                <%--<asp:CheckBox ID="chkViewAllUser" runat="server" Text="Can View" Checked="true"/>--%>
                <aspajax:CheckBox ID="chkViewAllUser" CustomID="chkAllView$AllUSer" runat="server"
                    Checked="true"></aspajax:CheckBox><span>All User can View</span>
            </div>
        </fieldset>
        <div>
            <div class="graycontent">
                <div class="title" style="float: left">
                    Share with Users
                </div>
                <div id="userboxtigger" style="float: right" class="exand">
                </div>
                <div class="clear">
                </div>
            </div>
            <div id="userbox" style="display: none">
                <div class="graycontent">
                    <div class="label">
                        Search using Username</div>
                    <div>
                        <asp:TextBox ID="txtSearchUser" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <aspajax:AjaxLinkButton ID="lnkSearchUser" runat="server" ResponseContainner="#contentBox"
                            RequestContainner="#contentBox" EnableValidation="False" EnableViewState="False"
                            Increment="False" OnAjaxClick="AjaxSearchUser" Pagger="False"><div class="btn">Search User</div> </aspajax:AjaxLinkButton>
                    </div>
                </div>
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
                                            <%-- <td>
                                            Can Add
                                        </td>--%>
                                            <td>
                                                Can Edit
                                            </td>
                                            <td>
                                                Can View
                                            </td>
                                            <%--<td>
                                            Can Delete
                                        </td>--%>
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
                                <%-- <td>
                                <aspajax:CheckBox CustomID='<%#"chkAdd$"+Eval("LoginUserID").ToString()%>' ID="chkA"
                                    runat="server" Checked='<%#Eval("EnableAdd") %>'></aspajax:CheckBox>
                            </td>--%>
                                <td>
                                    <aspajax:CheckBox CustomID='<%#"chkEdit$"+Eval("LoginUserID").ToString() %>' ID="chkE"
                                        runat="server" Checked='<%#Eval("EnableEdit") %>'></aspajax:CheckBox>
                                </td>
                                <td>
                                    <aspajax:CheckBox CustomID='<%#"chkView$"+Eval("LoginUserID").ToString() %>' ID="chkV"
                                        runat="server" Checked='<%#Eval("EnableView") %>'></aspajax:CheckBox>
                                </td>
                                <%--<td>
                                <aspajax:CheckBox CustomID='<%#"chkDelete$"+Eval("LoginUserID").ToString() %>' ID="chkD"
                                    runat="server" Checked='<%#Eval("EnableDelete") %>'></aspajax:CheckBox>
                            </td>--%>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="hcurv">
                    <aspajax:AjaxLinkButton ID="lnkSave" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" EnableViewState="False" Increment="False" OnAjaxClick="SaveAjaxClick"
                        Pagger="False"><div class="btn">Save</div> </aspajax:AjaxLinkButton>
                </div>
            </div>
        </div>
        <div>
            <div class="graycontent">
                <div class="title" style="float: left">
                    Share with Group
                </div>
                <div id="roleboxtrigger" style="float: right" class="exand">
                </div>
                <div class="clear">
                </div>
            </div>
            <div id="rolebox" style="display: none">
                <div class="whitecont">
                    <asp:ListView ID="ListGroup" runat="server">
                        <LayoutTemplate>
                            <div>
                                <table>
                                    <thead>
                                        <tr>
                                            <td>
                                                Group
                                            </td>
                                            <%--  <td>
                                            Can Add
                                        </td>--%>
                                            <td>
                                                Can Edit
                                            </td>
                                            <td>
                                                Can View
                                            </td>
                                            <%-- <td>
                                            Can Delete
                                        </td>--%>
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
                                <%--<td>
                                <aspajax:CheckBox CustomID='<%#"chkgAdd$"+Eval("InstituteUserTypeID").ToString()%>'
                                    ID="chkgA" runat="server" Checked='<%#Eval("EnableAdd") %>'></aspajax:CheckBox>
                            </td>--%>
                                <td>
                                    <aspajax:CheckBox CustomID='<%#"chkgEdit$"+Eval("InstituteUserTypeID").ToString() %>'
                                        ID="chkgE" runat="server" Checked='<%#Eval("EnableEdit") %>'></aspajax:CheckBox>
                                </td>
                                <td>
                                    <aspajax:CheckBox CustomID='<%#"chkgView$"+Eval("InstituteUserTypeID").ToString() %>'
                                        ID="chkgV" runat="server" Checked='<%#Eval("EnableView") %>'></aspajax:CheckBox>
                                </td>
                                <%-- <td>
                                <aspajax:CheckBox CustomID='<%#"chkgDelete$"+Eval("InstituteUserTypeID").ToString() %>'
                                    ID="chkgD" runat="server" Checked='<%#Eval("EnableDelete") %>'></aspajax:CheckBox>
                            </td>--%>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="hcurv">
                    <aspajax:AjaxLinkButton ID="lnkUpdateGroup" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" EnableViewState="False" Increment="False" OnAjaxClick="SaveGroupAjaxClick"
                        Pagger="False"><div class="btn">Save</div> </aspajax:AjaxLinkButton>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
