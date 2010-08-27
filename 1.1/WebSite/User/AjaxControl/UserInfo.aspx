<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInfo.aspx.cs" Inherits="User_AjaxControl_UserInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
    <div class="gray">
    Edit User Info
    </div>
        <div id="divMessage" runat="server">
        </div>
        <div>
            <fieldset>
                <legend>User</legend>
                <div>
                    <div>
                        <div>
                            <asp:Image ID="imgProfilepic" runat="server" Width="100" />
                        </div>
                        <div>
                            <span class="label">FirstName</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">LastName</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">MiddleName</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">BirthDate</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <span>
                                <asp:DropDownList ID="ddDay" runat="server">
                                </asp:DropDownList>
                            </span><span>
                                <asp:DropDownList ID="ddMonth" runat="server">
                                </asp:DropDownList>
                            </span><span>
                                <asp:DropDownList ID="ddYear" runat="server">
                                </asp:DropDownList>
                            </span>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Address1</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Address2</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">City</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">State</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Country</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">WebSite</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtWebSite" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <div style="float: left">
                    <%--<asp:LinkButton ID="lnkUpdate" runat="server" OnClick="lnkUpdate_Click">Update</asp:LinkButton>--%>
                    <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" OnAjaxClick="AjaxUpdateClick"
                        RequestContainner="#contentBox" ResponseContainner="#contentBox"><div class="btn editbtn">Update</div> </aspajax:AjaxLinkButton>
                </div>
                <div>
                    <aspajax:AjaxLinkButton ID="lnkAddUserInfo" runat="server" OnAjaxClick="AjaxAddClick"
                        RequestContainner="#contentBox" ResponseContainner="#contentBox"><div class="btn editbtn"><%=Resources.Default.Add_Text%></div> </aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:HyperLink ID="lnkCancel" runat="server" NavigateUrl="UserInfoView.aspx"
                        ContainnerID="#contentBox"><div class="btn editbtn">Cancel</div> </aspajax:HyperLink>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
