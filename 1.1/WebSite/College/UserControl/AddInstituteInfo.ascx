<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddInstituteInfo.ascx.cs"
    Inherits="College_UserControl_AddInstituteInfo" %>
<div id="divMessage" runat="server">
</div>
<fieldset>
    <legend>Institute</legend>
    <div>
        
        
            <div>
                <span class="label">Name</span>
            </div>
            <div>
                <asp:TextBox ID="txtName" runat="server" Width="129px"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">Address</span>
            </div>
            <div>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">CityName</span>
            </div>
            <div>
                <asp:TextBox ID="txtCityName" runat="server"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">StateName</span>
            </div>
            <div>
                <asp:TextBox ID="txtStateName" runat="server"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">CountryName</span>
            </div>
            <div>
                <asp:TextBox ID="txtCountryName" runat="server"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">TelePhone</span>
            </div>
            <div>
                <asp:TextBox ID="txtTelePhone" runat="server"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">Fax</span>
            </div>
            <div>
                <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">Email</span>
            </div>
            <div>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">WebSite</span>
            </div>
            <div>
                <asp:TextBox ID="txtWebSite" runat="server"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">CollegeType</span>
            </div>
            <div>
                <asp:DropDownList ID="ddCollegeType" runat="server">
                </asp:DropDownList>
            </div>
        
        
            <div>
                <span class="label">ShortName</span>
            </div>
            <div>
                <asp:TextBox ID="txtShortName" runat="server"></asp:TextBox>
            </div>
        
        
            <div>
                <span class="label">Description</span>
            </div>
            <div>
                <asp:TextBox ID="txtDescription" runat="server" Height="192px" 
                    TextMode="MultiLine" Width="450px"></asp:TextBox>
            </div>
        
    </div>
</fieldset>
<div>
    <asp:LinkButton ID="lnkAdd" runat="server" onclick="lnkAdd_Click">Update</asp:LinkButton>
</div>
