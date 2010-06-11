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

public partial class College_QuestionWizard_Step1 : BasePage
{
    private int _ExamId
    {
        get
        {
            if (Request.QueryString["eid"] != null)
            {
                return Convert.ToInt32(Request.QueryString["eid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    private int _EditExamID
    {
        get
        {
            return Convert.ToInt32(ViewState["EditExamID"]);
        }
        set
        {
            ViewState["EditExamID"] = value;
        }
    }
    private int _QuestionID
    {
        get
        {
            if (Request.QueryString["qid"] != null)
            {
                return Convert.ToInt32(Request.QueryString["qid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    protected override void OnInitComplete(EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Request.QueryString["qid"] != null)
            {
                lnkNextStep.Visible = false;
                var data = new EXM_QuestionController().GetbyEXM_QuestionID(_QuestionID);
                if (data.Count > 0)
                {
                    LoadQuestionBox(data[0].Q_Type);
                    rdbQuestionType.SelectedValue = data[0].Q_Type.ToString();
                }

            }
        }
        if (Request.QueryString["qid"] != null)
        {

        }
        base.OnInitComplete(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!this.IsPostBack)
        //{
        //    if (Request.QueryString["qid"] != null)
        //    {
        //        lnkNextStep.Visible = false;
        //        var data = new EXM_QuestionController().GetbyEXM_QuestionID(_QuestionID);
        //        if (data.Count > 0)
        //        {
        //            LoadQuestionBox(data[0].Q_Type);
        //            rdbQuestionType.SelectedValue = data[0].Q_Type.ToString();
        //        }

        //    }
        //}
        //if (Request.QueryString["qid"] != null)
        //{

        //}
    }


    protected void lnkNextStep_Click(object sender, EventArgs e)
    {


    }

    protected void rdbQuestionType_SelectedIndexChanged(object sender, EventArgs e)
    {
        int QuestionType = Convert.ToInt32(rdbQuestionType.SelectedValue);
        LoadQuestionBox(QuestionType);
    }
    private void LoadQuestionBox(int Type)
    {
        if (Type == (int)QuestionType.SingleChoice)
        {
            AddSingleChoiceQuestionSubLayout AddSingleFillInTheBlankControl = (AddSingleChoiceQuestionSubLayout)CommonController.GetControl("~/College/UserControl/AddSingleChoiceQuestion.ascx");            
            QuestionPlaceHolder.Controls.Add(AddSingleFillInTheBlankControl);
        }
        else if (Type == (int)QuestionType.MultipleChoice)
        {
            AddMultipleChoiceQuestionSubLayout AddSingleFillInTheBlankControl = (AddMultipleChoiceQuestionSubLayout)CommonController.GetControl("~/College/UserControl/AddMultipleChoiceQuestion.ascx");
            QuestionPlaceHolder.Controls.Add(AddSingleFillInTheBlankControl);
        }
        else if (Type == (int)QuestionType.SingleFillintheBlanks)
        {
            AddSingleFillInTheBlank AddSingleFillInTheBlankControl = (AddSingleFillInTheBlank)CommonController.GetControl("~/College/UserControl/AddSingleFillInTheBlank.ascx");
            QuestionPlaceHolder.Controls.Add(AddSingleFillInTheBlankControl);
        }
    }
}
