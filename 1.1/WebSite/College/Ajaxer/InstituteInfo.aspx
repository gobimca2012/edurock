﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteInfo.aspx.cs" Inherits="College_Ajaxer_InstituteInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>Institute</legend>
            <div>
                <div>
                    <div>
                        <span class="label">Name</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Address</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">CityName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtCityName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">StateName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtStateName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">CountryName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtCountryName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">TelePhone</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtTelePhone" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Fax</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Email</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">WebSite</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtWebSite" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">CollegeType</span>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddCollegeType" runat="server">
                            <asp:ListItem Text="Private College" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Semi Goverment College" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Private Tution Classes" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Private School" Value="4"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">ShortName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtShortName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" RequestContainner="#courceinfo"
                    ResponseContainner="#courceinfo" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:HyperLink ID="lnkCancel" runat="server" ContainnerID="#courceinfo" NavigateUrl="InstituteInfoView.aspx">Cancel</aspajax:HyperLink>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
