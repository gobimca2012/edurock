<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccountInfo.aspx.cs" Inherits="ShoppingCart_AjaxControl_AccountInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="diverror" runat="server" class="error">
        </div>
        <div id="divNewUser" runat="server">
            <fieldset>
                <legend>Account Information</legend>
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
                        <span class="label">UserName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Password</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Cofirm Password</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Company Name</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">First Name</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Last Name</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Mobile Number</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Land Line Number</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtLandLineNumber" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Fax Number</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtFaxNumber" runat="server"></asp:TextBox>
                    </div>
                </div>
            </fieldset>
            <fieldset>
                <legend>Billing Address Information</legend>
                <div>
                    <div>
                        <span class="label">Billing Address 1</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtBillingAddress1" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Billing Address 2</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtBillingAddress2" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">State</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">City</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Country</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                    </div>
                </div>
            </fieldset>
        </div>
        <div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkNext" runat="server" RequestContainner="#accountInfo"
                    ResponseContainner="#accountInfo" EnableValidation="False" EnableViewState="False"
                    Increment="False" OnAjaxClick="Next_Click" Pagger="False"><div class="btn editbtn">Buy and Register</div></aspajax:AjaxLinkButton>
                <aspajax:AjaxLinkButton ID="lnkConfirmDetail" runat="server" RequestContainner="#accountInfo"
                    ResponseContainner="#accountInfo" EnableValidation="False" EnableViewState="False"
                    Increment="False" OnAjaxClick="ConfirmDetail_Click" Pagger="False"><div class="btn editbtn">Confim Detail</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
