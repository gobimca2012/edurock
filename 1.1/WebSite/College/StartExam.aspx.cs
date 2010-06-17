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
using System.Collections.Generic;
using System.Web.Services;
public partial class College_StartExam : BasePage
{
    private int _ExamID
    {
        get
        {
            if (Request.Cookies[CookieName.ExamID.ToString()] != null)
            {
                return Convert.ToInt32(Request.Cookies[CookieName.ExamID.ToString()].Value.ToString());

            }
            else
            {
                return 0;
            }
        }
    }
    public EXM_Question CurrentQuestion
    {
        get
        {
            if (Session[SessionName.CurrentQuestion.ToString()] != null)
            {
                return (EXM_Question)Session[SessionName.CurrentQuestion.ToString()];
            }
            return null;
        }
        set
        {
            Session[SessionName.CurrentQuestion.ToString()] = value;
        }
    }
    private List<EXM_Question> QuestionList
    {
        get
        {
            if (Session[SessionName.QuestionList.ToString()] != null)
            {
                return (List<EXM_Question>)Session[SessionName.QuestionList.ToString()];
            }
            return null;
        }
        set
        {
            Session[SessionName.QuestionList.ToString()] = value;
        }
    }
    private int CurrentQuestionIndex
    {
        get
        {
            if (ViewState["CurrentPageIndex"] != null)
            {
                return (int)ViewState["CurrentPageIndex"];
            }
            return 1;
        }
        set
        {
            ViewState["CurrentPageIndex"] = value;
        }
    }
    private DateTime StartTime
    {
        get
        {
            if (Session[SessionName.ExamStartTime.ToString()] != null)
            {
                return Convert.ToDateTime(Session[SessionName.ExamStartTime.ToString()].ToString());
            }
            else
            {
                var data = new UserExamController().GetbyExamID(_ExamID, new UserAuthontication().LoggedInUserID);
                if (data.Count > 0)
                {
                    if (data[0].StartTime != null)
                    {
                        return data[0].StartTime;
                    }
                    else
                    {

                        return DateTime.Now;
                    }
                }
                else
                {
                    return DateTime.Now;
                }
            }
        }
        set
        {
            Session[SessionName.ExamStartTime.ToString()] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
           // BindQuestion();  
            StartTime = DateTime.Now;
            new UserExamController().Add(new UserAuthontication().LoggedInUserID, _ExamID, DateTime.Now, DateTime.Now.AddHours(1), DateTime.Now);

        }
        JScripter.Loader objLoad = new JScripter.Loader(this.Page, false);
        string ScriptInj = objLoad.LoadPageScript("#time", ResolveUrl("~/CallBack.aspx") + "?tm=s&eid=" + _ExamID.ToString());
        JScripter.JScripter.IncludeJavascriptFile("counter", ResolveUrl("~/Jscript/jquery.countdownTimer.1-0-1.js"), this.Page);

        objLoad.InjectScript(string.Format("Timmer('{0}','{1}','{2}');", "#time", ResolveUrl("~/CallBack.aspx") + "?tm=s&eid=" + _ExamID.ToString(), "15000"), this.Page);

        
    }

    [WebMethod]
    public static string GetRemainingTime()
    {
        
        return "01:00";
    }
   
}
