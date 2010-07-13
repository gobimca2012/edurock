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
using System.Web.Services;
using System.Collections.Generic;
using DataEntity;
using BusinessLogic;

public partial class User_Service :AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        EnableAjaxState = false;
        if (Request.Params["icid"] != null)
        {
            new InstituteSubjectController().BindInstituteSubject(ddSubject, Convert.ToInt32(Request.Params["icid"]));
            ddSubject.Visible = true;
        }
    }
    [WebMethod]
    public List<InstituteSubject> GetSubject(string InstituteCourceID)
    {
        return new InstituteSubjectController().GetbyInstituteCourceID(Convert.ToInt32( InstituteCourceID));
    }
}
