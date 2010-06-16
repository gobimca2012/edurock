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
public partial class College_UserControl_Question : System.Web.UI.UserControl
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            LoadQuestionUI();
    }
    private void LoadQuestionUI()
    {
        DivSingleChoice.Visible = false;
        DivMultipleChoice.Visible = false;
        if (CurrentQuestion.Q_Type == (int)QuestionType.SingleChoice)
        {
            DivSingleChoice.Visible = true;
            BindSingleChoiceQuestion();
        }
        else if (CurrentQuestion.Q_Type == (int)QuestionType.MultipleChoice)
        {
            DivMultipleChoice.Visible = true;
            BindMultiChoiceQuestion();
        }
        else if (CurrentQuestion.Q_Type == (int)QuestionType.SingleFillintheBlanks)
        {

        }
        lnkNext.Visible = true;
        lnkPrev.Visible = true;
        if (CurrentQuestion.Order == QuestionList.Count)
        {
            lnkNext.Visible = false;

        }
        else if (CurrentQuestion.Order == 1)
        {
            lnkPrev.Visible = false;
        }

    }
    private void BindSingleChoiceQuestion()
    {
        lblQuestion.InnerText = CurrentQuestion.Question;
        lblMarks.InnerText = CurrentQuestion.Marks.ToString();
        chkOption.DataSource = CurrentQuestion.EXM_Answers;
        chkOption.DataTextField = "Answer";
        chkOption.DataValueField = "EXM_AnswerID";
        chkOption.DataBind();
        //listOption.DataSource = _Question.EXM_Answers;
        //listOption.DataBind();
        var data = new EXM_UserAnswerController().GetbyEXM_QuestionID(CurrentQuestion.EXM_QuestionID);
        if (data.Count > 0)
        {
            for (int i = 0; i < chkOption.Items.Count; i++)
                chkOption.SelectedValue = data[0].EXM_AnswerID.ToString();
        }
    }
    private void BindMultiChoiceQuestion()
    {
        lblMultiQustion.InnerText = CurrentQuestion.Question;
        lblMarks.InnerText = CurrentQuestion.Marks.ToString();
        //listOption.DataSource = _Question.EXM_Answers;
        //listOption.DataBind();
        chkMulti.DataSource = CurrentQuestion.EXM_Answers;
        chkMulti.DataTextField = "Answer";
        chkMulti.DataValueField = "EXM_AnswerID";
        chkMulti.DataBind();
        var data = new EXM_UserAnswerController().GetbyEXM_QuestionID(CurrentQuestion.EXM_QuestionID);
        if (data.Count > 0)
        {
            for (int i = 0; i < chkMulti.Items.Count; i++)
                chkMulti.SelectedValue = data[0].EXM_AnswerID.ToString();
        }
    }
    protected void lnkNext_Click(object sender, EventArgs e)
    {
        UpdateAnswer();
        CurrentQuestion = QuestionList.Single(p => p.Order == (CurrentQuestion.Order + 1));
        LoadQuestionUI();
    }
    protected void lnkPrev_Click(object sender, EventArgs e)
    {
        UpdateAnswer();
        CurrentQuestion = QuestionList.Single(p => p.Order == (CurrentQuestion.Order - 1));
        LoadQuestionUI();
    }
    private void UpdateAnswer()
    {
        if (CurrentQuestion.Q_Type == (int)QuestionType.SingleChoice)
        {
            
            if (chkOption.SelectedValue != "")
            {
                new EXM_UserAnswerController().UpdateByQuestionID(CurrentQuestion.EXM_QuestionID, Convert.ToInt32(chkOption.SelectedValue), new UserAuthontication().LoggedInUserID);
            }
        }
        else if (CurrentQuestion.Q_Type == (int)QuestionType.MultipleChoice)
        {
            if (chkMulti.SelectedValue != "")
            {
                new EXM_UserAnswerController().DeletebyEXM_QuestionID(CurrentQuestion.EXM_QuestionID);
                for (int i = 0; i < chkMulti.Items.Count; i++)
                {
                    if (chkMulti.Items[i].Selected)
                        new EXM_UserAnswerController().Add(new UserAuthontication().LoggedInUserID, CurrentQuestion.EXM_QuestionID, Convert.ToInt32(chkMulti.Items[i].Value), "", DateTime.Now);//  UpdateByQuestionID(CurrentQuestion.EXM_QuestionID, Convert.ToInt32(chkMulti.Items[i].Value), new UserAuthontication().LoggedInUserID);
                }
            }

        }
        else if (CurrentQuestion.Q_Type == (int)QuestionType.SingleFillintheBlanks)
        {

        }
    }
}
