using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Controllers;
using DTO;
using PayPal;

public partial class ShoppingCart_AjaxControl_AccountInfo : AjaxPage
{
    protected override void OnInit(EventArgs e)
    {
        IsLogginMandatory = false;
        base.OnInit(e);
    }
    private void HideRegistrationControl()
    {
        txtUserName.Visible = false;
        txtPassword.Visible = false;
    }
    private void BindUserInfo()
    {
        var data = new UserController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
        if (data.Count > 0)
        {
            txtBillingAddress1.Text = data[0].Address1;
            txtBillingAddress2.Text = data[0].Address2;
            txtCity.Text = data[0].City;
            txtCountry.Text = data[0].Country;
            txtEmail.Text = new UserAuthontication().LoggedInEmail;
            txtFaxNumber.Text = data[0].Fax;
            txtFirstName.Text = data[0].FirstName;
            txtLandLineNumber.Text = data[0].LandLineNumber1;
            txtLastName.Text = data[0].LastName;
            txtMobileNumber.Text = data[0].MobileNumber1;
            txtState.Text = data[0].State;

        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["prvid"] != null)
        {
            AjaxState["prvid"] = Request.QueryString["prvid"];

        }
        if (new UserAuthontication().IsLoggedIn)
        {
            HideRegistrationControl();
            BindUserInfo();
        }
    }
    protected void ConfirmDetail_Click(object sender, AjaxControl.AjaxEventArg e)
    {
        RegisterCustomerDTO registerCustomerdto = GetDTOFromUI();
        registerCustomerdto.TotalUser = 100;
        registerCustomerdto.ValidMonth = 1;
        OrderDTO orderDto =Translator.GetByRegisterCustomerDTO(registerCustomerdto);
        AddOrderDetail(orderDto);
    }

    private void AddOrderDetail(OrderDTO orderDto)
    {
        new ShoppingController().UpdateOrderDetail(orderDto);
    }
    
    protected void Next_Click(object sender, AjaxControl.AjaxEventArg e)
    {
        RegisterCustomerDTO dto = GetDTOFromUI();
        dto.TotalUser = 100;
        dto.ValidMonth = 1;
        NewUserResponseDTO newUser = new CustomerController().RegisterNewCustomer(dto);
        OrderDTO orderDto =Translator.GetByRegisterCustomerDTO(dto);
        AddOrderDetail(orderDto);
        var productVersion = new ProductVersionController().GetbyProductVersionID(ProductVersionID);
        new ShoppingController().AddCartItem(productVersion[0]);
        Guid orderID = new ShoppingController().SaveCart(newUser.UserID.Value);
        if (orderID != Guid.Empty)
        {
            orderDto.Custom = orderID.ToString();
            orderDto.OrderID = orderID;
        }
        new PayPalStandardPaymentProcessor().PostProcessPayment(Translator.GetPayPalRequest(new ShoppingController().CartDto.orderDetail));
    }
     
    private RegisterCustomerDTO GetDTOFromUI()
    {
        RegisterCustomerDTO dto = new RegisterCustomerDTO();
        dto.FirstName = HtmlHelper.ControlValue(txtFirstName.ClientID);
        dto.Address1 = HtmlHelper.ControlValue(txtBillingAddress1.ClientID);
        dto.Address2 = HtmlHelper.ControlValue(txtBillingAddress2.ClientID);
        dto.City = HtmlHelper.ControlValue(txtCity.ClientID);
        dto.Country = HtmlHelper.ControlValue(txtCountry.ClientID);
        dto.Email = HtmlHelper.ControlValue(txtEmail.ClientID);
        dto.FaxNumber = HtmlHelper.ControlValue(txtFaxNumber.ClientID);
        dto.FirstName = HtmlHelper.ControlValue(txtFirstName.ClientID);
        dto.InstituteName = HtmlHelper.ControlValue(txtCompanyName.ClientID);
        dto.LandLineNumber = HtmlHelper.ControlValue(txtLandLineNumber.ClientID);
        dto.LastName = HtmlHelper.ControlValue(txtLastName.ClientID);
        dto.MobileNumber = HtmlHelper.ControlValue(txtMobileNumber.ClientID);
        dto.Password = HtmlHelper.ControlValue(txtPassword.ClientID);
        dto.State = HtmlHelper.ControlValue(txtState.ClientID);
        dto.Username = HtmlHelper.ControlValue(txtUserName.ClientID);
        return dto;
    }
    public Guid ProductVersionID
    {
        get
        {
            if (Request.QueryString["prvid"] != null)
            {
                AjaxState["prvid"] = Request.QueryString["prvid"];
                return new Guid(Request.QueryString["prvid"]);
            }
            else if (AjaxState["prvid"] != null)
            {
                return new Guid(AjaxState["prvid"]);
            }
            else
            {
                return Guid.Empty;
            }
        }

    }
}