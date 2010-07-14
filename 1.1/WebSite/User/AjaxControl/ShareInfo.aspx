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
            Share</div>
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
                            <aspajax:CheckBox CustomID='<%#"chkAdd"+Eval("LoginUserID").ToString()%>' ID="chkA"
                                runat="server"></aspajax:CheckBox>
                        </td>
                        <td>
                            <aspajax:CheckBox CustomID='<%#"chkEdit"+Eval("LoginUserID").ToString() %>' ID="chkE"
                                runat="server"></aspajax:CheckBox>
                        </td>
                        <td>
                            <aspajax:CheckBox CustomID='<%#"chkView"+Eval("LoginUserID").ToString() %>' ID="chkV"
                                runat="server"></aspajax:CheckBox>
                        </td>
                        <td>
                            <aspajax:CheckBox CustomID='<%#"chkDelete"+Eval("LoginUserID").ToString() %>' ID="chkD"
                                runat="server"></aspajax:CheckBox>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="gray">
            <aspajax:AjaxLinkButton ID="lnkSave" runat="server" RequestContainner="#contentBox"
                ResponseContainner="#contentBox" EnableViewState="False" Increment="False" OnAjaxClick="SaveAjaxClick"
                Pagger="False"><div class="btn">Save</div> </aspajax:AjaxLinkButton>
            Share</div>
    </div>
    </form>
</body>
</html>
