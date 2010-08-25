<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Institute.aspx.cs" Inherits="All_Ajaxer_Institute" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="contentbox">
            <div>
                <asp:HyperLink ID="lnkback" runat="server" Text="back to List" runat="server" NavigateUrl="~/Modules/Institute/List.aspx"></asp:HyperLink>
            </div>
            <div>
                <div>
                    <span class="label">Name</span>
                </div>
                <div>
                    <span id="lblName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Address</span>
                </div>
                <div>
                    <span id="lblAddress" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">CityName</span>
                </div>
                <div>
                    <span id="lblCityName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">StateName</span>
                </div>
                <div>
                    <span id="lblStateName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">CountryName</span>
                </div>
                <div>
                    <span id="lblCountryName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">TelePhone</span>
                </div>
                <div>
                    <span id="lblTelePhone" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Fax</span>
                </div>
                <div>
                    <span id="lblFax" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Email</span>
                </div>
                <div>
                    <span id="lblEmail" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">WebSite</span>
                </div>
                <div>
                    <span id="lblWebSite" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">CollegeType</span>
                </div>
                <div>
                    <span id="lblCollegeType" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ShortName</span>
                </div>
                <div>
                    <span id="lblShortName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Description</span>
                </div>
                <div>
                    <span id="lblDescription" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ModifiedDate</span>
                </div>
                <div>
                    <span id="lblModifiedDate" runat="server"></span>
                </div>
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="lnkInstituteCource" runat="server" ContainnerID="#Cource"><cram:SpaceLabel ID="ttspace" runat="server"></cram:SpaceLabel></aspajax:HyperLink>
        </div>
        <div id="Cource">
        </div>
    </div>
    </form>
</body>
</html>
