<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="AccountSetting.aspx.cs" Inherits="User_AccountSetting" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <div id="tabs">
            <ul>
                <li><a href="#tabs-1">Personal Info</a></li>
                <li><a href="#tabs-2">Education Info</a></li>                
            </ul>
            <div id="tabs-1">
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
                    <div style="float: left">
                        <asp:LinkButton ID="lnkAdd" runat="server" OnClick="lnkAdd_Click">Update</asp:LinkButton>
                    </div>
                </div>
            </div>
            <div id="tabs-2">
                <p>
                    Mauris eleifend est et turpis. Duis id erat. Suspendisse potenti. Aliquam vulputate,
                    pede vel vehicula accumsan, mi neque rutrum erat, eu congue orci lorem eget lorem.
                    Vestibulum non ante. Class aptent taciti sociosqu ad litora torquent per conubia
                    nostra, per inceptos himenaeos. Fusce sodales. Quisque eu urna vel enim commodo
                    pellentesque. Praesent eu risus hendrerit ligula tempus pretium. Curabitur lorem
                    enim, pretium nec, feugiat nec, luctus a, lacus.</p>
                <p>
                    Duis cursus. Maecenas ligula eros, blandit nec, pharetra at, semper at, magna. Nullam
                    ac lacus. Nulla facilisi. Praesent viverra justo vitae neque. Praesent blandit adipiscing
                    velit. Suspendisse potenti. Donec mattis, pede vel pharetra blandit, magna ligula
                    faucibus eros, id euismod lacus dolor eget odio. Nam scelerisque. Donec non libero
                    sed nulla mattis commodo. Ut sagittis. Donec nisi lectus, feugiat porttitor, tempor
                    ac, tempor vitae, pede. Aenean vehicula velit eu tellus interdum rutrum. Maecenas
                    commodo. Pellentesque nec elit. Fusce in lacus. Vivamus a libero vitae lectus hendrerit
                    hendrerit.</p>
            </div>
        </div>
    </div>
</asp:Content>
