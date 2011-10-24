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
        divNewUser.Visible = false;
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
        int loginUserID;
        if (!new UserAuthontication().IsLoggedIn)
        {
            NewUserResponseDTO newUser = new CustomerController().RegisterNewCustomer(dto);
            loginUserID = newUser.UserID.Value;
        }
        else
        {
            loginUserID = LoginUserID;
        }
        OrderDTO orderDto =Translator.GetByRegisterCustomerDTO(dto);
        AddOrderDetail(orderDto);
        var productVersion = new ProductVersionController().GetbyProductVersionID(ProductVersionID);
        new ShoppingController().AddCartItem(productVersion[0]);
        Guid orderID = new ShoppingController().SaveCart(loginUserID);
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
        if (new UserAuthontication().IsLoggedIn)
        {
            dto = GetDTOFromLoggedInUser();
        }
        else
        {
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
        }
        return dto;
    }

    private RegisterCustomerDTO GetDTOFromLoggedInUser()
    {
        RegisterCustomerDTO dto = new RegisterCustomerDTO();
        var loggedinUserDetails=new UserController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
        dto.FirstName = loggedinUserDetails[0].FirstName;
        dto.Address1 = loggedinUserDetails[0].Address1;
        dto.Address2 = loggedinUserDetails[0].Address2;
        dto.City = loggedinUserDetails[0].City;
        dto.Country = loggedinUserDetails[0].Country;
        dto.Email = new UserAuthontication().LoggedInEmail;
        dto.FaxNumber = loggedinUserDetails[0].Fax;
        dto.FirstName = loggedinUserDetails[0].FirstName;
        dto.InstituteName = "";
        dto.LandLineNumber = loggedinUserDetails[0].LandLineNumber1;
        dto.LastName = loggedinUserDetails[0].LastName;
        dto.MobileNumber = loggedinUserDetails[0].MobileNumber1;
        dto.Password = "";
        dto.State = loggedinUserDetails[0].State;
        dto.Username = new UserAuthontication().LoggedInUserName;
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