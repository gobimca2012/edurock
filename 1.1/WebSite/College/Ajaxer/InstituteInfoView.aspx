<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteInfoView.aspx.cs"
    Inherits="College_Ajaxer_CollegeInfo" Theme="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
    <style type="text/css">
    .contentbox .label
    {
    margin : 2px 0px;
    
    }
    </style>
        <div class="gray ">
            Personal Info
        </div>
        <div id="Institute" style="padding: 5px 5px 5px 10px;">
            <div>
                <div id="popupresponce">
                    <asp:Image ID="imgProfilepic" runat="server" Width="200" />
                </div>
                <div>
                    <asp:LinkButton ID="lnkChangeImage" runat="server"><div class="btn"> UpdatePic</div></asp:LinkButton>
                </div>
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
        </div>
        <div class="gray ">
            <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl="InstituteInfo.aspx" ContainnerID="#contentBox"><div class="btn editbtn"><%=Resources.Default.Edit_Text %></div></aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
