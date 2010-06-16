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
using DataEntity;
using BusinessLogic;

public partial class College_UserControl_MultipleChoiceQuestion : System.Web.UI.UserControl
{
    public EXM_Question _Question
    {
        get;
        set;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindQuestionOption();
        for (int i = 0; i < chkOption.Items.Count; i++)
        {
            if (chkOption.Items[i].Selected)
                new EXM_UserAnswerController().UpdateByQuestionID(_Question.EXM_QuestionID, Convert.ToInt32(Request.Form[chkOption.ClientID.Replace('_', '$')]), new UserAuthontication().LoggedInUserID);
        }
    }
    private void BindQuestionOption()
    {

        lblQuestion.InnerText = _Question.Question;
        lblMarks.InnerText = _Question.Marks.ToString();
        //listOption.DataSource = _Question.EXM_Answers;
        //listOption.DataBind();
        chkOption.DataSource = _Question.EXM_Answers;
        chkOption.DataTextField = "Answer";
        chkOption.DataValueField = "EXM_AnswerID";
        chkOption.DataBind();
        var data = new EXM_UserAnswerController().GetbyEXM_QuestionID(_Question.EXM_QuestionID);
        if (data.Count > 0)
        {
            for (int i = 0; i < chkOption.Items.Count; i++)
                chkOption.SelectedValue = data[0].EXM_AnswerID.ToString();
        }

    }
}
