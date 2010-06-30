<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInfo.aspx.cs" Inherits="User_AjaxControl_UserInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divMessage" runat="server">
    </div>
    <div>
        <fieldset>
            <legend>User</legend>
            <div>
                <div>
                    <div>
                        <span class="label">FirstName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">LastName</span>
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
                        <span class="label">BirthDate</span>
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
                        <span class="label">City</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">State</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Country</span>
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
        <div>
            <div style="float: left">
                <%--<asp:LinkButton ID="lnkUpdate" runat="server" OnClick="lnkUpdate_Click">Update</asp:LinkButton>--%>
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" OnAjaxClick="AjaxUpdateClick"
                    RequestContainner="#accountsetting" ResponseContainner="#accountsetting">Update</aspajax:AjaxLinkButton>
            </div>
            <div style="float: left">
                <aspajax:HyperLink ID="lnkAdd" runat="server" NavigateUrl="UserInfoView.aspx" ContainnerID="#accountsetting">Cancel</aspajax:HyperLink>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
