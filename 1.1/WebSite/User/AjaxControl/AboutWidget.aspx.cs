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

public partial class User_AjaxControl_AboutInstitute : AjaxPage
{
    private int InstituteCourceID
    {
        get
        {
            if (AjaxState.ContainsKey("icid"))
            {
                return Convert.ToInt32(AjaxState["icid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
        }
        BindData();
    }
    private void BindData()
    {
        if (InstituteCourceID > 0)
        {
            var data = new InstituteCourceController().GetbyInstituteCourceID(InstituteCourceID);
            if (data.Count > 0)
            {
                aboutInstitute.InnerHtml = data[0].MetaDescription;
                Institutetitle.InnerHtml = data[0].Cource.CourceName;
                listSubject.DataSource = data[0].InstituteSubjects;
                listSubject.DataBind();
                listUser.DataSource = new InstituteUserController().GetUserByInsituteCourceID(InstituteCourceID);
                listUser.DataBind();
            }
        }
        else
        {
            divsubject.Visible = false;
            var data = new InstituteController().GetbyInstituteID(new UserAuthontication().UserInstituteID);
            if (data.Count > 0)
            {
                aboutInstitute.InnerHtml = data[0].Description;
                Institutetitle.InnerHtml = data[0].Name;
            }
        }
    }
}
