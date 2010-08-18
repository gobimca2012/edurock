<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteInfo.aspx.cs" Inherits="College_Ajaxer_InstituteInfo"
    Theme="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Edit Personal Info
        </div>
        <div id="divMessage" runat="server">
        </div>
        <div>
            <fieldset>
                <legend>Institute</legend>
                <div>
                    <div>
                        <div>
                            <span class="label">Name</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Address</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">City Name</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtCityName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">State Name</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtStateName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Country Name</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtCountryName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">TelePhone</span><span class="valmsg" >(Required)*</span>
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
                            <span class="label">Email</span><span class="valmsg" >(Required)*</span>
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
                            <span class="label">CollegeType</span><span class="valmsg" >(Required)*</span>
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
                            <span class="label">Short Name</span><span class="valmsg" >(Required)*</span>
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
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" CssClass="mceEditor"
                                Height="400px"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="clear">
        </div>
        <div class="gray">
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn editbtn"> Update</div></aspajax:AjaxLinkButton>
            </div>
            <div style="float: left">
                <aspajax:HyperLink ID="lnkCancel" runat="server" ContainnerID="#contentBox" NavigateUrl="InstituteInfoView.aspx"><div class="btn editbtn"> Cancel</div></aspajax:HyperLink>
            </div>
            <div style="clear">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
