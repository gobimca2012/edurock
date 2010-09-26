<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HeaderNavigation.ascx.cs"
    Inherits="LayoutControl_HeaderNavigation" %>
<%@ Register Assembly="AjaxControl" Namespace="AjaxControl" TagPrefix="cc1" %>
<%@ Register Src="../Modules/Login/Create.ascx" TagName="Create" TagPrefix="uc1" %>
<%@ Register Src="../Modules/Login/Login.ascx" TagName="Login" TagPrefix="uc2" %>
<div style="width: 1000px; margin: 0 auto; height: 50px">
    <div style="float: right; margin-right: 4px;">
        <div id="liHome" runat="server" class="fleft" visible="false">
            <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/Home.aspx"><div class="btn"> Home</div></asp:HyperLink>
        </div>
        <div id="lilogin" runat="server" class="fleft">
            <cc1:ShowHideLinkButton ID="lnkLogin" runat="server" ><div class="btn"> Sign in</div></cc1:ShowHideLinkButton>
        </div>
        <div id="liCreate" runat="server" class="fleft">
            <cc1:ShowHideLinkButton ID="lnkCreate" runat="server" Show="true" ContainnerID="#creatediv"><div class="btn"> Sign up</div></cc1:ShowHideLinkButton>
        </div>
        <div id="lilogout" runat="server" class="fleft">
            <asp:LinkButton ID="lnkLogout" runat="server" OnClick="lnkLogout_Click"><div class="btn"> Log out</div></asp:LinkButton>
        </div>
        <div id="li1" runat="server" class="fleft" visible="false">
            <asp:HyperLink ID="lnkRegisterInstitute" runat="server" NavigateUrl="~/RegisterInstitute.aspx"><div class="btn"> Sign up Institute</div></asp:HyperLink>
        </div>
        <div id="logindiv" style="display: none">
            <%--<uc2:Login ID="Login1" runat="server" />--%>
        </div>
        <div id="creatediv" style="display: none">
            <div id="registernew" style="position: absolute; width: 200px">
            </div>
        </div>
    </div>
</div>
<div style="clear: both">
</div>
<div>
    <div>
        <asp:PlaceHolder ID="ActionMenu" runat="server"></asp:PlaceHolder>
    </div>
</div>
