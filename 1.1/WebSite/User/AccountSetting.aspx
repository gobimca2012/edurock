<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="AccountSetting.aspx.cs" Inherits="User_AccountSetting" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>User</legend>
            <table>
                <tr>
                    <td>
                        <span class="label">UserID</span>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">LoginUserID</span>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">FirstName</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">LastName</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">MiddleName</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">BirthDate</span>
                    </td>
                    <td>
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
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">Address1</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">Address2</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">City</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">State</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">Country</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">WebSite</span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtWebSite" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span class="label">ModifiedDate</span>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </fieldset>
        <div>
            <div style="float: left">
                <asp:LinkButton ID="lnkUpdate" runat="server" OnClick="lnkUpdate_Click">Update</asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
