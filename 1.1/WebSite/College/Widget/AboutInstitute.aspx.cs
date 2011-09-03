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
using BusinessLogic;

public partial class College_Ajaxer_AboutInstitute : WidgetControl
{
    public int _InstituteID
    {
        get
        {
            return new UserAuthontication().InstituteID;
        }

    }
    protected override void OnLoad(EventArgs e)
    {
        this.IsLogginMandatory = false;
        BindData();
        base.OnLoad(e);
    }

    private void BindData()
    {
        var data = new InstituteController().GetbyInstituteID(_InstituteID);
        if (data.Count > 0)
        {
            //if (data[0].Logo != null)
            //    imgLogo.ImageUrl=ImageHelper.ResolveURL(data[0].Logo);
            lblName.InnerHtml = data[0].Name + "( " + data[0].ShortName + " )";
            if (data[0].Address != null)
                lblAddress1.InnerHtml = data[0].Address;
            if (data[0].CityName != null)
                lblCity.InnerHtml = data[0].CityName;
            if (data[0].StateName != null)
                lblState.InnerHtml = data[0].StateName;
            if (data[0].CountryName != null)
                lblCountry.InnerHtml = data[0].CountryName;
            if (data[0].TelePhone != null)
                lblContactNumber1.InnerHtml = data[0].TelePhone;
            if (data[0].Email != null)
                lblEmail.InnerHtml = data[0].Email;
            if (data[0].WebSite != null)
                lblWebSite.InnerHtml = data[0].WebSite;
        }
    }
}
