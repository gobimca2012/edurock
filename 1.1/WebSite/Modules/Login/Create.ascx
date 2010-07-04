<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Create.ascx.cs" Inherits="Modules_Login_Create" %>
<div class="contentbox">
    <fieldset>
        <legend>LoginUser</legend>
        <div>
            <div>
                <div>
                    <span class="label">LoginUserID</span>
                </div>
                <div>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Username</span>
                </div>
                <div>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Password</span>
                </div>
                <div>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    Email:
                </div>
                <div>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">UserType</span>
                </div>
                <div>
                    <asp:RadioButtonList ID="RdbType" runat="server">
                        <asp:ListItem Text="College" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Student" Value="1"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
        </div>
        <div>
            <asp:LinkButton ID="lnkRegister" runat="server" OnClick="lnkRegister_Click">Register</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lnkCancel" runat="server">Cancel</asp:LinkButton>
        </div>
</div>
</fieldset> 