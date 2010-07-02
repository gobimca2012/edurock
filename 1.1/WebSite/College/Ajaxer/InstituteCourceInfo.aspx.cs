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

public partial class College_Ajaxer_InstituteCourceInfo :AjaxPage
{
    private int InstituteCourceID
    {
        get
        {
            return Convert.ToInt32(Request.QueryString["icid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        new CourceController().BindCource(ddCourceID);
    }

    private void AddData()
    {
        try
        {

            int InstituteID; if (false) { throw new Exception(""); } InstituteID = new UserAuthontication().InstituteID;

            int CourceID; if (HtmlHelper.ControlValue(ddCourceID.ClientID)==null ) { throw new Exception("Please Select Cource"); } CourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCourceID.ClientID));

            DateTime Modifieddate; if (false) { throw new Exception(""); } Modifieddate = DateTime.Now;

            new InstituteCourceController().Add( InstituteID, CourceID, Modifieddate);
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void EditData()
    {




        int InstituteID; if (false) { throw new Exception(""); } InstituteID = new UserAuthontication().InstituteID;

        int CourceID; if (false) { throw new Exception(""); } CourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCourceID.ClientID));

        DateTime Modifieddate; if (false) { throw new Exception(""); } Modifieddate = DateTime.Now;

        new InstituteCourceController().UpdateByInstituteCourceID(InstituteCourceID, InstituteID, CourceID, Modifieddate);
    }

    private void BindData()
    {
        var dataBunch = new InstituteCourceController().GetbyInstituteCourceID(InstituteCourceID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            
            ddCourceID.SelectedValue = data.CourceID.ToString();

           
        }
    }



    protected void AddICourceAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();
        Response.Redirect("~/College/Ajaxer/InstituteCourceInfoView.aspx");
    }
}
