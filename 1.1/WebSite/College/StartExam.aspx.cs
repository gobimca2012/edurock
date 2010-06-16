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
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindQuestion();            
        }
        
    }
  
    private void BindQuestion()
    {
        if (QuestionList == null)
        {
            var data = new EXM_QuestionController().GetbyExamID(_ExamID);
            QuestionList = data;
        }
        ListQuestion.DataSource = QuestionList;
        ListQuestion.DataBind();
        CurrentQuestion = QuestionList[0];
        CurrentQuestionIndex = 0;
    }

    protected void QuestionList_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        if (String.Equals(e.CommandName, "LoadQuestion"))
        {
            ListViewDataItem dataItem = (ListViewDataItem)e.Item;
            string QuestionID = ListQuestion.DataKeys[dataItem.DisplayIndex].Value.ToString();
            CurrentQuestion = QuestionList.Single(p => p.EXM_QuestionID == Convert.ToInt32(QuestionID));
            


        }
    }
   
}
