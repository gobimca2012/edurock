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
    private int UserExamID
    {
        get
        {
            if (Request.Cookies[CookieName.UserExamID.ToString()] != null)
            {
                return Convert.ToInt32(Request.Cookies[CookieName.UserExamID.ToString()].Value.ToString());

            }
            else
            {
                return 0;
            }
        }

        
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindQuestion();
            LoadQuestionUI();
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
        
    }

    protected void QuestionList_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        if (String.Equals(e.CommandName, "LoadQuestion"))
        {
            ListViewDataItem dataItem = (ListViewDataItem)e.Item;
            string QuestionID = ListQuestion.DataKeys[dataItem.DisplayIndex].Value.ToString();
            CurrentQuestion = QuestionList.Single(p => p.EXM_QuestionID == Convert.ToInt32(QuestionID));
            LoadQuestionUI();


        }
    }
    private void LoadQuestionUI()
    {
        DivSingleChoice.Visible = false;
        DivMultipleChoice.Visible = false;
        divSingleFillIntheBlanck.Visible = false;
        if (CurrentQuestion.Q_Type == (int)QuestionTypeEnum.SingleChoice)
        {
            DivSingleChoice.Visible = true;
            BindSingleChoiceQuestion();
        }
        else if (CurrentQuestion.Q_Type == (int)QuestionTypeEnum.MultipleChoice)
        {
            DivMultipleChoice.Visible = true;
            BindMultiChoiceQuestion();
        }
        else if (CurrentQuestion.Q_Type == (int)QuestionTypeEnum.SingleFillintheBlanks)
        {
            divSingleFillIntheBlanck.Visible = true;
            BindSingleFillIntheBlank();
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
    private void BindSingleFillIntheBlank()
    {
        string[] Questionpart = CurrentQuestion.Question.Split(';');
        lblPrefixText.InnerHtml = Questionpart[0] ;
        lblsufixText.InnerHtml = Questionpart[1];
        lblMarks.InnerText = CurrentQuestion.Marks.ToString();
        ddAnswer.DataSource = CurrentQuestion.EXM_Answers;
        ddAnswer.DataTextField = "Answer";
        ddAnswer.DataValueField = "EXM_AnswerID";
        ddAnswer.DataBind();
        ListItem noneItem = new ListItem();
        noneItem.Text = "Select";
        noneItem.Value = "0";
        ddAnswer.Items.Insert(0, noneItem);
        var data = new EXM_UserAnswerController().Gets(CurrentQuestion.EXM_QuestionID,new UserAuthontication().LoggedInUserID,UserExamID);
        foreach (EXM_UserAnswer answerData in data)
        {
            for (int i = 0; i < ddAnswer.Items.Count; i++)
                if (ddAnswer.Items[i].Value == answerData.EXM_AnswerID.ToString())
                    ddAnswer.Items[i].Selected = true;
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
        var data = new EXM_UserAnswerController().Gets(CurrentQuestion.EXM_QuestionID, new UserAuthontication().LoggedInUserID,UserExamID);
        //if (data.Count > 0)
        //{
        //    for (int i = 0; i < chkOption.Items.Count; i++)
        //        chkOption.SelectedValue = data[0].EXM_AnswerID.ToString();
        //}
        foreach (EXM_UserAnswer answerData in data)
        {
            for (int i = 0; i < chkOption.Items.Count; i++)
                if (chkOption.Items[i].Value == answerData.EXM_AnswerID.ToString())
                    chkOption.Items[i].Selected = true;
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
        var data = new EXM_UserAnswerController().Gets(CurrentQuestion.EXM_QuestionID, new UserAuthontication().LoggedInUserID,UserExamID);
        foreach (EXM_UserAnswer answerData in data)
        {
            for (int i = 0; i < chkMulti.Items.Count; i++)
                if (chkMulti.Items[i].Value == answerData.EXM_AnswerID.ToString())
                    chkMulti.Items[i].Selected = true;
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
        if (CurrentQuestion.Q_Type == (int)QuestionTypeEnum.SingleChoice)
        {
            
            if (chkOption.SelectedValue != "")
            {
                new EXM_UserAnswerController().UpdateByQuestionID(CurrentQuestion.EXM_QuestionID, Convert.ToInt32(chkOption.SelectedValue), new UserAuthontication().LoggedInUserID,UserExamID);
            }
        }
        else if (CurrentQuestion.Q_Type == (int)QuestionTypeEnum.MultipleChoice)
        {
            if (chkMulti.SelectedValue != "")
            {
                new EXM_UserAnswerController().Delete(CurrentQuestion.EXM_QuestionID,new UserAuthontication().LoggedInUserID,UserExamID);
                for (int i = 0; i < chkMulti.Items.Count; i++)
                {
                    if (chkMulti.Items[i].Selected)
                        new EXM_UserAnswerController().Add(UserExamID, new UserAuthontication().LoggedInUserID, CurrentQuestion.EXM_QuestionID, Convert.ToInt32(chkMulti.Items[i].Value), "", DateTime.Now);//  UpdateByQuestionID(CurrentQuestion.EXM_QuestionID, Convert.ToInt32(chkMulti.Items[i].Value), new UserAuthontication().LoggedInUserID);
                }
            }

        }
        else if (CurrentQuestion.Q_Type == (int)QuestionTypeEnum.SingleFillintheBlanks)
        {
            if (ddAnswer.SelectedValue != "")
            {
                new EXM_UserAnswerController().Delete(CurrentQuestion.EXM_QuestionID, new UserAuthontication().LoggedInUserID, UserExamID);
                for (int i = 0; i < ddAnswer.Items.Count; i++)
                {
                    if (ddAnswer.Items[i].Selected)
                        new EXM_UserAnswerController().Add(UserExamID, new UserAuthontication().LoggedInUserID, CurrentQuestion.EXM_QuestionID, Convert.ToInt32(ddAnswer.Items[i].Value), "", DateTime.Now);//  UpdateByQuestionID(CurrentQuestion.EXM_QuestionID, Convert.ToInt32(chkMulti.Items[i].Value), new UserAuthontication().LoggedInUserID);
                }
            }

        }
    }
    protected void lnkSubmitAnswer_Click(object sender, EventArgs e)
    {
        new UserExamController().Update(_ExamID, UserExamID, true);
    }
}
