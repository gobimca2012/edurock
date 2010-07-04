﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BusinessLogic;

public partial class User_AjaxControl_UserInfo : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!this.IsAjaxPostBack)
        {
            var data = new UserController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
            if (data.Count > 0)
            {
                BindData();
                lnkAddUserInfo.Visible = false;
                lnkUpdate.Visible = true;
            }
            else
            {
                CommonController.BindDay(ddDay);
                CommonController.BindMonth(ddMonth);
                CommonController.BindYear(ddYear);
                lnkAddUserInfo.Visible = true;
                lnkUpdate.Visible = false;
            }
        }
    }
    private void EditData()
    {

        string FirstName; if (false) { throw new Exception(""); } FirstName = HtmlHelper.ControlValue(txtFirstName.ClientID);

        string LastName; if (false) { throw new Exception(""); } LastName = HtmlHelper.ControlValue(txtLastName.ClientID);

        string MiddleName; if (false) { throw new Exception(""); } MiddleName = HtmlHelper.ControlValue(txtMiddleName.ClientID);

        DateTime BirthDate; if (HtmlHelper.ControlValue(ddYear.ClientID) == "0" || HtmlHelper.ControlValue(ddMonth.ClientID) == "0" || HtmlHelper.ControlValue(ddDay.ClientID) == "0") { throw new Exception("Please Enter your BirthDate"); } BirthDate = CommonController.GetDate(Convert.ToInt32(HtmlHelper.ControlValue(ddDay.ClientID)), Convert.ToInt32(HtmlHelper.ControlValue(ddMonth.ClientID)), Convert.ToInt32(HtmlHelper.ControlValue(ddYear.ClientID)));

        string Address1; if (false) { throw new Exception(""); } Address1 = HtmlHelper.ControlValue(txtAddress1.ClientID);

        string Address2; if (false) { throw new Exception(""); } Address2 =HtmlHelper.ControlValue(txtAddress2.ClientID);

        string City; if (false) { throw new Exception(""); } City = HtmlHelper.ControlValue(txtCity.ClientID);

        string State; if (false) { throw new Exception(""); } State =HtmlHelper.ControlValue(txtState.ClientID);

        string Country; if (false) { throw new Exception(""); } Country =HtmlHelper.ControlValue(txtCountry.ClientID);

        string WebSite; if (false) { throw new Exception(""); } WebSite =HtmlHelper.ControlValue(txtWebSite.ClientID);

        new UserController().Add(new UserAuthontication().LoggedInUserID, FirstName, LastName, MiddleName, BirthDate, Address1, Address2, City, State, Country, WebSite);
    }

    private void AddData()
    {
        try
        {

            int LoginUserID; LoginUserID = new UserAuthontication().LoggedInUserID;

            string FirstName; if (false) { throw new Exception("First Name Mandatory"); } FirstName = HtmlHelper.ControlValue(txtFirstName.ClientID);

            string LastName; if (false) { throw new Exception("Last Name Mandatory"); } LastName = HtmlHelper.ControlValue(txtLastName.ClientID);

            string MiddleName; if (false) { throw new Exception("Middle Name Mandatory"); } MiddleName = HtmlHelper.ControlValue(txtMiddleName.ClientID);

            DateTime BirthDate; if (HtmlHelper.ControlValue(ddYear.ClientID) == "0" || HtmlHelper.ControlValue(ddMonth.ClientID) == "0" || HtmlHelper.ControlValue(ddDay.ClientID) == "0") { throw new Exception("Please Enter your BirthDate"); } BirthDate = CommonController.GetDate(Convert.ToInt32(HtmlHelper.ControlValue(ddDay.ClientID)), Convert.ToInt32(HtmlHelper.ControlValue(ddMonth.ClientID)), Convert.ToInt32(HtmlHelper.ControlValue(ddYear.ClientID)));

            string Address1; Address1 = HtmlHelper.ControlValue(txtAddress1.ClientID);

            string Address2; Address2 = HtmlHelper.ControlValue(txtAddress2.ClientID);

            string City; if (false) { throw new Exception(""); } City = HtmlHelper.ControlValue(txtCity.ClientID);

            string State; if (false) { throw new Exception(""); } State = HtmlHelper.ControlValue(txtState.ClientID);

            string Country; if (false) { throw new Exception(""); } Country = HtmlHelper.ControlValue(txtCountry.ClientID);

            string WebSite; if (false) { throw new Exception(""); } WebSite = HtmlHelper.ControlValue(txtWebSite.ClientID);

            DateTime ModifiedDate; if (false) { throw new Exception(""); } Convert.ToDateTime(ModifiedDate = DateTime.Now);

            new UserController().Add(LoginUserID, FirstName, LastName, MiddleName, BirthDate, Address1, Address2, City, State, Country, WebSite, ModifiedDate);
            Response.Redirect("~/User/AjaxControl/UserInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    private void BindData()
    {
        CommonController.BindDay(ddDay);
        CommonController.BindMonth(ddMonth);
        CommonController.BindYear(ddYear);
        var dataBunch = new UserController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            imgProfilepic.ImageUrl = ResolveUrl( data.PhotoPath);
            txtFirstName.Text = data.FirstName;

            txtLastName.Text = data.LastName;

            txtMiddleName.Text = data.MiddleName;

            ddDay.SelectedValue = data.BirthDate.Value.Day.ToString();
            ddMonth.SelectedValue = data.BirthDate.Value.Month.ToString();
            ddYear.SelectedValue = data.BirthDate.Value.Year.ToString();

            txtAddress1.Text = data.Address1;

            txtAddress2.Text = data.Address2;

            txtCity.Text = data.City;

            txtState.Text = data.State;

            txtCountry.Text = data.Country;

            txtWebSite.Text = data.WebSite;



        }
    }
    protected void AjaxUpdateClick(object sender, AjaxControl.AjaxEventArg e)
    {
        EditData();
        Response.Redirect("~/User/AjaxControl/UserInfoView.aspx");
        
    }
    protected void AjaxAddClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();
        

    }
}