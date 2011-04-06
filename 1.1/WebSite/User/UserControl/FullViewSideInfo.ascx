<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FullViewSideInfo.ascx.cs"
    Inherits="User_UserControl_FullViewSideInfo" %>
<%@ Register Src="UserToolTipLink.ascx" TagName="UserToolTipLink" TagPrefix="uc1" %>
<%@ Register Src="Ratting.ascx" TagName="Ratting" TagPrefix="uc2" %>
<div>
    <uc2:Ratting ID="Ratting1" runat="server" />
</div>
<div class="graycontent roundedall">
    <div>
        <span class="label"></span>
        <cram:SpaceLabel ID="lblspace" runat="server"></cram:SpaceLabel>
        Name: </span><span id="lblCourceName" runat="server"></span>
    </div>
    <div style="display: none;">
        <cram:CategoryLabel ID="lblcat" runat="server"></cram:CategoryLabel>
        Name: <span id="lblSubjectName" runat="server"></span>
    </div>
</div>
<div class="graycontent roundedall">
    <uc1:UserToolTipLink ID="UserToolTipLink1" runat="server" />
</div>
