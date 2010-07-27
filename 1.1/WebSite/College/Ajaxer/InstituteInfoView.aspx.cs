using System;
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
using DataEntity;
using BusinessLogic;
using Common;
public partial class College_Ajaxer_CollegeInfo : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var data = new InstituteController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
        JScripter.PopUp objPopup = new JScripter.PopUp(this.Page, false);
        //objPopup.IframePopUp(lnkChangeImage, ResolveUrl("~/User/UploadPhoto.aspx")+"?uptype=0", "propop", "500", "500", ResolveUrl("~/User/AjaxControl/UserInfoView.aspx"), "#accountsetting");
        objPopup.IframePopUp(lnkChangeImage, ResolveUrl("~/User/UploadPhoto.aspx") + "?iid="+data[0].InstituteID.ToString()+"&uptype="+((int)DocumentTypeEnum.UploadInstitutePic).ToString(), "ipop", "500", "500", ResolveUrl("~/User/AjaxControl/UploadResponse.aspx"), "#popupresponce");
        if (data.Count > 0)
        {
            BindData(data[0]);
        }
    }
    private void BindData(Institute data)
    {

        
        if (data.Name != null)

            lblName.InnerHtml = data.Name.ToString();

        if (data.Address != null)

            lblAddress.InnerHtml = data.Address.ToString();

        if (data.CityName != null)

            lblCityName.InnerHtml = data.CityName.ToString();

        if (data.StateName != null)

            lblStateName.InnerHtml = data.StateName.ToString();

        if (data.CountryName != null)

            lblCountryName.InnerHtml = data.CountryName.ToString();

        if (data.TelePhone != null)

            lblTelePhone.InnerHtml = data.TelePhone.ToString();

        if (data.Fax != null)

            lblFax.InnerHtml = data.Fax.ToString();

        if (data.Email != null)

            lblEmail.InnerHtml = data.Email.ToString();

        if (data.WebSite != null)

            lblWebSite.InnerHtml = data.WebSite.ToString();

        if (data.CollegeType != null)

            lblCollegeType.InnerHtml = data.CollegeType.ToString();

        if (data.ShortName != null)

            lblShortName.InnerHtml = data.ShortName.ToString();

        if (data.Description != null)

            lblDescription.InnerHtml = data.Description.ToString();

        
    }

}
