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
using DataEntity;
public partial class College_UserControl_ExamQuestionList : System.Web.UI.UserControl
{
    private int _ExamID
    {
        get
        {
            if (Request.Cookies[CookieName.ExamID.ToString()] != null)
            {
                return Convert.ToInt32(Request.Cookies[CookieName.ExamID.ToString()].Value);

            }
            else
            {
                return 0;
            }
        }
    }
    public EXM_Question DefaultQuestionID
    {
        get;
        set;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindQuestion();
    }
    private void BindQuestion()
    {
        var data = new EXM_QuestionController().GetbyExamID(_ExamID);
        ListQuestion.DataSource = data;
        ListQuestion.DataBind();
        DefaultQuestionID = data[0];
    }
}
