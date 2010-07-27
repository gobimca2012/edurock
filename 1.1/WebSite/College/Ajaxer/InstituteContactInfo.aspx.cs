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

public partial class College_Ajaxer_InstituteContactInfo :AjaxPage
{
    public int _InstituteID
    {
        get
        {
            return Convert.ToInt32(Request.Params["iid"]);
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
            lblAddress1.InnerHtml = data[0].Address;
            lblCity.InnerHtml = data[0].CityName;
            lblState.InnerHtml = data[0].StateName;
            lblCountry.InnerHtml = data[0].CountryName;
            lblContactNumber1.InnerHtml = data[0].TelePhone;
            lblEmail.InnerHtml = data[0].Email;
            lblWebSite.InnerHtml = data[0].WebSite;
        }
    }
}
