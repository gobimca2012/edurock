using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Linq;
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
public partial class College_UserControl_SingleChoiceQuestion : System.Web.UI.UserControl
{
    public EXM_Question CurrentQuestion
    {
        get;
        set;

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
        BindQuestionOption();
        if (this.IsPostBack)
        {
            
        }
        else
        {
            
        }
    }
    private void BindQuestionOption()
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
    protected void ListAnswer_ItemBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem dataItem = (ListViewDataItem)e.Item;
        RadioButton rbButton = (RadioButton)dataItem.FindControl("chkOption");
        if (rbButton != null)
        {
            rbButton.Attributes["onclick"] = string.Format("SetSingleRadioButton('{0}',this)", "listOption.*Group1");
        }
    }
  
    protected void lnkNext_Click1(object sender, EventArgs e)
    {
        string Selectedvalue = CommonController.GetValueFromRequestparam(chkOption.ID);
        if (Selectedvalue != "")
        {
            new EXM_UserAnswerController().UpdateByQuestionID(CurrentQuestion.EXM_QuestionID, Convert.ToInt32(Selectedvalue), new UserAuthontication().LoggedInUserID);
        }
        CurrentQuestion = QuestionList.Single(p => p.Order == (CurrentQuestion.Order + 1));
    }
    private void LoadQuestionUI()
    {
        PlaceHolder QuestionBox=(PlaceHolder) this.Page.FindControl("QuestionBox");
        if (QuestionBox != null)
        {
            QuestionBox.Controls.Clear();
            if (CurrentQuestion.Q_Type == (int)QuestionType.SingleChoice)
            {
                College_UserControl_SingleChoiceQuestion newControl = (College_UserControl_SingleChoiceQuestion)CommonController.GetControl("~/College/UserControl/SingleChoiceQuestion.ascx");
                newControl.CurrentQuestion = CurrentQuestion;
                QuestionBox.Controls.Add(newControl);
            }
            else if (CurrentQuestion.Q_Type == (int)QuestionType.MultipleChoice)
            {
                College_UserControl_MultipleChoiceQuestion newControl = (College_UserControl_MultipleChoiceQuestion)CommonController.GetControl("~/College/UserControl/MultipleChoiceQuestion.ascx");
                newControl._Question = CurrentQuestion;
                QuestionBox.Controls.Add(newControl);
            }
            else if (CurrentQuestion.Q_Type == (int)QuestionType.SingleFillintheBlanks)
            {
                College_UserControl_SingleFillInTheBlankQuestion newControl = (College_UserControl_SingleFillInTheBlankQuestion)CommonController.GetControl("~/College/UserControl/SingleFillInTheBlankQuestion.ascx");
                newControl._Question = CurrentQuestion;
                QuestionBox.Controls.Add(newControl);
            }
            //lnkNext.Visible = true;
            //lnkPrev.Visible = true;
            //if (CurrentQuestion.Order == QuestionList.Count)
            //{
            //    lnkNext.Visible = false;

            //}
            //else if (CurrentQuestion.Order == 1)
            //{
            //    lnkPrev.Visible = false;
            //}
        }

    }
}
