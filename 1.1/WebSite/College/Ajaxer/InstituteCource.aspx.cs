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

public partial class College_Ajaxer_InstituteCource : AjaxPage
{

    private void BindData(int ID)
    {
        var dataBunch = new InstituteCourceController().GetbyInstituteCourceID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            if (data.InstituteCourceID != null)

                lblInstituteCourceID.InnerHtml = data.InstituteCourceID.ToString();

            if (data.InstituteID != null)

                lblInstituteID.InnerHtml = data.InstituteID.ToString();

            if (data.CourceID != null)

                lblCourceID.InnerHtml = data.CourceID.ToString();

            if (data.MetaDescription != null)

                lblMetaDescription.InnerHtml = data.MetaDescription.ToString();

            if (data.MetaKeyword != null)

                lblMetaKeyword.InnerHtml = data.MetaKeyword.ToString();



            if (data.Modifieddate != null)

                lblModifieddate.InnerHtml = data.Modifieddate.ToString();
        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(Request.Params["icid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData(ID);
    }

}
