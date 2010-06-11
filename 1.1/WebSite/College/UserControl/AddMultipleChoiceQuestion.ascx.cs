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

public partial class AddMultipleChoiceQuestionSubLayout : System.Web.UI.UserControl
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Request.QueryString["qid"] != null)
            {
                BindData(_QuestionID);
                DivAnswerList.Visible = true; ;
                ListAnswer1._QuestionID = _QuestionID;
                lnkNextStep.Visible = false;
                lnkUpdate.Visible = true;

            }
        }
        if (Request.QueryString["qid"] != null)
        {
            ListAnswer1._QuestionID = _QuestionID;

        }
    }

    private void BindData(int ID)
    {
        var dataBunch = new EXM_QuestionController().GetbyEXM_QuestionID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            txtQuestion.Text = data.Question;
            _EditExamID = data.ExamID;
            
            if (data.Marks != null)
                txtMarks.Text = data.Marks.ToString();
            txtDescription.Text = data.Description;



        }
    }
    private void EditData(int ID)
    {

        int EXM_QuestionID; if (true) { EXM_QuestionID = _QuestionID; }

        string Question; if (true) { Question = txtQuestion.Text; }

        int LoginUserID; if (true) { LoginUserID = new UserAuthontication().LoggedInUserID; }

        int ExamID; if (true) { ExamID = _EditExamID; }

        int Q_Type; if (true) { Q_Type = 1; }

        string Description; if (true) { Description = txtDescription.Text; }
        int Marks = 1;
        Marks = Convert.ToInt32(txtMarks.Text);
        DateTime ModifiedDate; if (true) { ModifiedDate = DateTime.Now; }

        new EXM_QuestionController().UpdateByEXM_QuestionID(EXM_QuestionID, Question, LoginUserID, ExamID, Marks, Q_Type, Description, ModifiedDate);
        divError.InnerHtml = "<div class='success'>Success Fully Updated</div>";
        //Response.Redirect("~/College/QuestionWizard/ListQuestion.aspx");
    }

    protected void lnkNextStep_Click(object sender, EventArgs e)
    {
        int QuestionID = AddData();
        Response.Redirect("~/College/QuestionWizard/Step2.aspx?qid=" + QuestionID.ToString());
    }
    private int AddData()
    {


        string Question; if (true) { Question = txtQuestion.Text; }

        int LoginUserID; if (true) { LoginUserID = new UserAuthontication().LoggedInUserID; }

        int ExamID; if (true) { ExamID = _ExamId; }

        int Q_Type; if (true) { Q_Type = 1; }

        string Description; if (true) { Description = txtDescription.Text; }

        int Marks = 1;
        Marks = Convert.ToInt32(txtMarks.Text);

        DateTime ModifiedDate; if (true) { ModifiedDate = DateTime.Now; }

        return new EXM_QuestionController().Add(Question, LoginUserID, ExamID, Q_Type, Description, Marks, ModifiedDate);
    }

    protected void lnkUpdate_Click(object sender, EventArgs e)
    {
        EditData(_QuestionID);
    }
}
