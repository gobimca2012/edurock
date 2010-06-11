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
public partial class College_ExamIntroduction : BasePage
{
    private int _ExamId
    {
        get
        {
            return Convert.ToInt32(Request.QueryString["eid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            Response.Cookies[CookieName.ExamID.ToString()].Value = Request.QueryString["eid"];
            BindData();
        }
    }
    private void BindData()
    {
        var data = new ExamController().GetbyExamID(_ExamId);
        if (data.Count > 0)
        {
            lblExamName.InnerText = data[0].ExamName;
            lblDescription.InnerHtml = data[0].Description;
            lblSubjectName.InnerHtml = data[0].SubjectName;
        }
    }
}
