<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Ratting.ascx.cs" Inherits="User_UserControl_Ratting" %>
<div>
    <div class="graycontent">
        <div style="float: left">
            <aspajax:HyperLink ID="lnkUprate" runat="server" ContainnerID="#rattingbox" ><div class="uprate tp" rel="Give Good Rate"></div></aspajax:HyperLink>
        </div>
        <div style="float: left">
            <aspajax:HyperLink ID="lnkDownrate" runat="server" ContainnerID="#rattingbox"><div class="downrate tp" rel="Give Bad Rate"></div></aspajax:HyperLink>
        </div>
        <div class="clear">
        </div>
        <div id="rattingbox">
        </div>
    </div>
</div>
