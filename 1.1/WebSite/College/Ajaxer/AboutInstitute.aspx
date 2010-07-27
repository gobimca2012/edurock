<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AboutInstitute.aspx.cs" Inherits="College_Ajaxer_AboutInstitute" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="graycontent roundedall">
            <%--<div style="float: left">
                <asp:Image ID="imgLogo" runat="server" Width="150px" />
            </div>--%>
            <div style="float: left;padding:5px;">
                <h3 id="lblName" runat="server">
                </h3>
                <div style="clear: both">
                </div>
                <div style="float: left;padding:5px" >
                    <div class="label">
                        Address</div>
                    <div id="lblAddress1" runat="server">
                    </div>
                    <div id="lblAddress2" runat="server">
                    </div>
                    <div id="lblCity" runat="server">
                    </div>
                    <div id="lblState" runat="server">
                    </div>
                    <div id="lblCountry" runat="server">
                    </div>
                </div>
                <div style="float: left;padding:5px;">
                    <div class="label">
                        Email</div>
                    <div id="lblEmail" runat="server">
                    </div>
                    <div class="label">
                        Contact Number1</div>
                    <div id="lblContactNumber1" runat="server">
                    </div>
                    <div class="label">
                        Contact Number 2</div>
                    <div id="lblWebSite" runat="server">
                    </div>
                </div>
                <div style="clear: both">
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
