<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FullViewSideInfo.ascx.cs"
    Inherits="User_UserControl_FullViewSideInfo" %>
<%@ Register Src="UserToolTipLink.ascx" TagName="UserToolTipLink" TagPrefix="uc1" %>
<%@ Register src="Ratting.ascx" tagname="Ratting" tagprefix="uc2" %>
<div>
    <uc2:Ratting ID="Ratting1" runat="server" />
</div>
<div class="graycontent roundedall">
    <div>
        Cource Name: <span id="lblCourceName" runat="server"></span>
    </div>
    <div>
        Subject Name: <span id="lblSubjectName" runat="server"></span>
    </div>
</div>
<div class="graycontent roundedall">
    <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" />
</div>
