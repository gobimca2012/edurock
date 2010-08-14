<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserToolTipLink1.1.ascx.cs"
    Inherits="User_UserControl_UserToolTipLink1_1" %>
<div class="udate">
    <div style="float: left;width:50%">
        <div id="lnkc" runat="server" visible="false">
            Last created by &nbsp;
            <asp:HyperLink ID="lnkTool" runat="server" Visible="false"></asp:HyperLink></div>
        <div id="lnke" runat="server" visible="false">
            Last edited by &nbsp;<asp:HyperLink ID="lnkETool" runat="server" Visible="false"></asp:HyperLink></div>
    </div>
    <div style="float: left">
        &nbsp;on&nbsp;<span id="lblDate" runat="server"></span>
    </div>
    <div style="clear: both">
</div>
</div>
<div style="clear: both">
</div>
