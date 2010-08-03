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

public partial class User_AjaxControl_SingleFillIntheBlankInfo : AjaxPage
{
    private void FormValidation()
    {
        lnkAddUserInfo.EnableValidation = true;
        lnkUpdate.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddUserInfo.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdate.ClientID);
        objValidate.Medatory(txtQuestionPart1, "Please enter Question part 1", this.Page);
        objValidate.Medatory(txtQuestionPart2, "Please enter Question part 2", this.Page);
        objValidate.Medatory(txtMarks, "Please enter Question Marks", this.Page);
        objValidate.DigitOnly(txtMarks, "Please enter Number only", this.Page);
    }
    protected void AjaxUpdateClick(object sender, AjaxControl.AjaxEventArg e)
    {
        EditData();
        

    }
    protected void AjaxAddClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();


    }
    private int _ExamID
    {
        get
        {
            return Convert.ToInt32(AjaxState["eid"]);
        }
        set
        {
            AjaxState["eid"] = value.ToString();
        }
    }
    private void AddData()
    {


        string Question; if (true) { Question = HtmlHelper.ControlValue(txtQuestionPart1.ClientID) + ";" + HtmlHelper.ControlValue(txtQuestionPart2.ClientID); }

        int LoginUserID; if (true) { LoginUserID = new UserAuthontication().LoggedInUserID; }

        int ExamID; if (true) { ExamID = _ExamID; }

        int Q_Type; if (true) { Q_Type = 3; }

        string Description; if (true) { Description = HtmlHelper.ControlValue(txtDescription.ClientID); }

        int Marks = 1;
        Marks = Convert.ToInt32(HtmlHelper.ControlValue(txtMarks.ClientID));

        DateTime ModifiedDate; if (true) { ModifiedDate = DateTime.Now; }

        new EXM_QuestionController().Add(Question, LoginUserID, ExamID, Q_Type, Description, Marks, ModifiedDate);
        Response.Redirect("~/User/AjaxControl/EXMQuestionList.aspx?eid=" + _ExamID.ToString());
    }
    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["qid"]);
        }
        set
        {
            AjaxState["qid"] = value.ToString();
        }
    }
    private void BindData()
    {
        var dataBunch = new EXM_QuestionController().GetbyEXM_QuestionID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            string[] Questions = data.Question.Split(';');
            txtQuestionPart1.Text = Questions[0];
            txtQuestionPart2.Text = Questions[1];

            if (data.Marks != null)
                txtMarks.Text = data.Marks.ToString();
            txtDescription.Text = data.Description;



        }
    }
    private void EditData()
    {

        int EXM_QuestionID; if (true) { EXM_QuestionID = ID; }

        string Question; if (true) { Question = HtmlHelper.ControlValue(txtQuestionPart1.ClientID) + ";" + HtmlHelper.ControlValue(txtQuestionPart2.ClientID); }

        int LoginUserID; if (true) { LoginUserID = new UserAuthontication().LoggedInUserID; }

        int ExamID; if (true) { ExamID = _ExamID; }

        int Q_Type; if (true) { Q_Type = 3; }

        string Description; if (true) { Description = HtmlHelper.ControlValue(txtDescription.ClientID); }

        int Marks = 1;
        Marks = Convert.ToInt32(HtmlHelper.ControlValue(txtMarks.ClientID));

        DateTime ModifiedDate; if (true) { ModifiedDate = DateTime.Now; }

        new EXM_QuestionController().UpdateByEXM_QuestionID(EXM_QuestionID, Question, LoginUserID, ExamID, Marks, Q_Type, Description, ModifiedDate);
        Response.Redirect("~/User/AjaxControl/EXMQuestionList.aspx?eid=" + _ExamID.ToString());
        divMessage.InnerHtml = "<div class='success'>Success Fully Updated</div>";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        FormValidation();
        if (Request.Params["eid"] != null)
        {
            _ExamID = Convert.ToInt32(Request.Params["eid"]);
        }
        if (Request.Params["qid"] != null)
        {
            lnkAddUserInfo.Visible = false;
            ID = Convert.ToInt32(Request.Params["qid"]);
            BindData();

        }
        else
        {
            lnkUpdate.Visible = false;
        }
        
    }
}
