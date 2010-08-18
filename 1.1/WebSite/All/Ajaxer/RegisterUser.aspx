<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterUser.aspx.cs" Inherits="All_Ajaxer_RegisterUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>Register</legend>
            <div>
                <div>
                    <div>
                        <span class="label">Username</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Password</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Confirm password</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">First name</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Last name</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">User Email </span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtUseremail" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Select Institute </span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddInstitute" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Select Cource </span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div id="ddrep">
                        <asp:DropDownList ID="ddCource" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <div>
                    <div style="float: left">
                        <aspajax:AjaxLinkButton ID="lnkRegisterNewUser" runat="server" EnableViewState="False" RequestContainner="#registernew"
                            ResponseContainner="#registernew" Increment="False" OnAjaxClick="RegisterAjax"
                            EnableValidation="true" Pagger="False"><div class="btn editbtn"> Register</div> </aspajax:AjaxLinkButton>
                    </div>
                </div>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
