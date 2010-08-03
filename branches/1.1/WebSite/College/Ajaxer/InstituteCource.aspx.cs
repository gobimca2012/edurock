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

            if (data.StartDate != null)

                lblStartDate.InnerHtml = data.StartDate.ToString();

            if (data.EndDate != null)

                lblEndDate.InnerHtml = data.EndDate.ToString();

            if (data.IsPublished != null)

                lblIsPublished.InnerHtml = data.IsPublished.ToString();

            if (data.HomeWorkEnable != null)

                lblHomeWorkEnable.InnerHtml = data.HomeWorkEnable.ToString();

            if (data.AttendanceEnable != null)

                lblAttendanceEnable.InnerHtml = data.AttendanceEnable.ToString();

            if (data.QuestionAnswerEnable != null)

                lblQuestionAnswerEnable.InnerHtml = data.QuestionAnswerEnable.ToString();

            if (data.SelfRegistrationEnable != null)

                lblSelfRegistrationEnable.InnerHtml = data.SelfRegistrationEnable.ToString();

            if (data.IsFree != null)

                lblIsFree.InnerHtml = data.IsFree.ToString();

            if (data.Price != null)

                lblPrice.InnerHtml = data.Price.ToString();

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
