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

public partial class User_AjaxControl_Lander : AjaxPage
{
    private int ICID
    {
        get
        {
            if (Request.Params["icid"] != null)
            {
                return Convert.ToInt32(Request.Params["icid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ICID > 0)
        {
            lnkQ.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfoView.aspx") + "?icid=" + ICID.ToString();
            lnktut.NavigateUrl = ResolveUrl("~/All/Ajaxer/TutorialInfoView.aspx") + "?icid=" + ICID.ToString();
            lnkExam.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfoView.aspx") + "?icid=" + ICID.ToString();

        }
    }
}
