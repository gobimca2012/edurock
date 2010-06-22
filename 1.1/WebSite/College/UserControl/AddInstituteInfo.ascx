<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddInstituteInfo.ascx.cs"
    Inherits="College_UserControl_AddInstituteInfo" %>
<div id="divMessage" runat="server">
</div>
<fieldset>
    <legend>Institute</legend>
    <table>
        
        <tr>
            <td>
                <span class="label">Name</span>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="129px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span class="label">Address</span>
            </td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span class="label">CityName</span>
            </td>
            <td>
                <asp:TextBox ID="txtCityName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span class="label">StateName</span>
            </td>
            <td>
                <asp:TextBox ID="txtStateName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span class="label">CountryName</span>
            </td>
            <td>
                <asp:TextBox ID="txtCountryName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span class="label">TelePhone</span>
            </td>
            <td>
                <asp:TextBox ID="txtTelePhone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span class="label">Fax</span>
            </td>
            <td>
                <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span class="label">Email</span>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
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
                <span class="label">CollegeType</span>
            </td>
            <td>
                <asp:DropDownList ID="ddCollegeType" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <span class="label">ShortName</span>
            </td>
            <td>
                <asp:TextBox ID="txtShortName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span class="label">Description</span>
            </td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" Height="192px" 
                    TextMode="MultiLine" Width="450px"></asp:TextBox>
            </td>
        </tr>
    </table>
</fieldset>
<div>
    <asp:LinkButton ID="lnkAdd" runat="server" onclick="lnkAdd_Click">Update</asp:LinkButton>
</div>
