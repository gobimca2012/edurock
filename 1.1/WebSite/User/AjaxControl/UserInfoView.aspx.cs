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
using DataEntity;

public partial class User_AjaxControl_UserInfoView : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        JScripter.PopUp objPopup = new JScripter.PopUp(this.Page, false);
        objPopup.IframePopUp(lnkChangeImage, ResolveUrl("~/User/UploadPhoto.aspx"), "propop", "500", "500", ResolveUrl("~/User/AjaxControl/UserInfoView.aspx"), "#accountsetting");
            
        if (!this.IsAjaxPostBack)
        {
            var data = new UserController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
            if (data.Count > 0)
            {
                BindData(data[0]);
            }
            else
            {
                Response.Redirect("~/User/AjaxControl/UserInfo.aspx");
            }
        }
    }

    private void BindData(User data)
    {




        if (data.PhotoPath != null)
        {
            imgProfilepic.ImageUrl = ResolveUrl(data.PhotoPath);
        }
        if (data.FirstName != null)

            lblFirstName.InnerHtml = data.FirstName.ToString();

        if (data.LastName != null)

            lblLastName.InnerHtml = data.LastName.ToString();

        if (data.MiddleName != null)

            lblMiddleName.InnerHtml = data.MiddleName.ToString();

        if (data.BirthDate != null)

            lblBirthDate.InnerHtml = data.BirthDate.ToString();

        if (data.Address1 != null)

            lblAddress1.InnerHtml = data.Address1.ToString();

        if (data.Address2 != null)

            lblAddress2.InnerHtml = data.Address2.ToString();

        if (data.City != null)

            lblCity.InnerHtml = data.City.ToString();

        if (data.State != null)

            lblState.InnerHtml = data.State.ToString();

        if (data.Country != null)

            lblCountry.InnerHtml = data.Country.ToString();

        if (data.WebSite != null)

            lblWebSite.InnerHtml = data.WebSite.ToString();



    }

    protected void EditAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        Response.Redirect("~/User/AjaxControl/UserInfo.aspx");
    }
}