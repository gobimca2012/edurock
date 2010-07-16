<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FullViewSideInfo.ascx.cs"
    Inherits="User_UserControl_FullViewSideInfo" %>
<%@ Register Src="UserToolTipLink.ascx" TagName="UserToolTipLink" TagPrefix="uc1" %>
<div class="graycontent roundedall">
    <div>
        Ratting:<span id="lblRatting" runat="server"></span>
    </div>
    <div>
        Created By : <span id="lblCreatedBy" runat="server"></span>
    </div>
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
