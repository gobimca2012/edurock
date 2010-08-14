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
public partial class College_ExamIntroduction : AjaxPage
{
    private int _ExamId
    {
        get
        {
            return Convert.ToInt32(Request.Params["eid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Remove(SessionName.ExamName.ToString());
        Session.Remove(SessionName.ExamList.ToString());
        Session.Remove(SessionName.QuestionList.ToString());
        Session.Remove(SessionName.CurrentQuestion.ToString());
        var userExamData = new UserExamController().GetByLoginUserID(new UserAuthontication().LoggedInUserID, _ExamId);

        if (!this.IsPostBack)
        {
            int _UserExamID = 0;
            if (userExamData.Count > 0)
            {
                if ((bool)userExamData[0].IsFinish)
                {
                    warnningMessage.InnerHtml = "you already Attend this Examination you can not attend again ";
                    lnkStart.Visible = false;
                }
                else
                {
                    _UserExamID = userExamData[0].UserExamID;
                    warnningMessage.InnerHtml = "you already start Examination please finished remaining question";
                }
            }
            else
            {

                _UserExamID = new UserExamController().Add(new UserAuthontication().LoggedInUserID, _ExamId, DateTime.Now, DateTime.Now, false, DateTime.Now);
            }
            Response.Cookies[CookieName.UserExamID.ToString()].Value = _UserExamID.ToString();
            Response.Cookies[CookieName.ExamID.ToString()].Value = Request.Params["eid"];
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
