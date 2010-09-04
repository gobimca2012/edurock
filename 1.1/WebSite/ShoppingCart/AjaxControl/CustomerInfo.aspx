<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerInfo.aspx.cs" Inherits="ShoppingCart_AjaxControl_CustomerInfo" %>

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
            <legend>CustomerInfo</legend>
            <div>
                
               
                <div>
                    <div>
                        <span class="label">FirstName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">LastName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">MobileNumber</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">OfficeNumber</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtOfficeNumber" runat="server"></asp:TextBox>
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
                        <span class="label">businessEmail</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtbusinessEmail" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">CurrencyCode</span>
                    </div>
                    <div>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">BillingFirstName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtBillingFirstName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">BillingLastName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtBillingLastName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">BillingAddress1</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtBillingAddress1" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">BillingAddress2</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtBillingAddress2" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">BillingCity</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtBillingCity" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">billingStateProvince</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtbillingStateProvince" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">billingCountry</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtbillingCountry" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">BillingEmail</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtBillingEmail" runat="server"></asp:TextBox>
                    </div>
                </div>
              
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddCustomerInfo" runat="server" RequestContainner="#CustomerInfo"
                    ResponseContainner="#CustomerInfo" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateCustomerInfo" runat="server" RequestContainner="#CustomerInfo"
                    ResponseContainner="#CustomerInfo" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
