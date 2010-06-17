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
public partial class AddMatchFollowing : System.Web.UI.UserControl
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
                BindQuestionData();
                DivAnswerList.Visible = true; ;
                ListAnswer1._QuestionID = _QuestionID;
                lnkAdd.Visible = false;
                lnkUpdate.Visible = false;
            }
        }
        if (Request.QueryString["qid"] != null)
        {
            ListAnswer1._QuestionID = _QuestionID;

        }
    }
    private void BindQuestionData()
    {
        var data = new EXM_QuestionController().GetbyEXM_QuestionID(_QuestionID);
        if (data.Count > 0)
        {
            string[] QuestionPart = data[0].Question.Split(';');
            txtQuestion1.Text = QuestionPart[0];
            txtQuestion2.Text = QuestionPart[1];
            txtQuestion3.Text = QuestionPart[2];
            txtQuestion4.Text = QuestionPart[3];
            txtMarks.Text = data[0].Marks.ToString();
            txtDescription.Text = data[0].Description;
        }
    }
    protected void txtAdd_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtQuestion1.Text == "" || txtQuestion2.Text == "" || txtQuestion3.Text == "" || txtQuestion4.Text == "")
            {
                throw new Exception("Please enter All Questions");
            }
            int QuestionID = new EXM_QuestionController().Add(txtQuestion1.Text.Trim() + ";" + txtQuestion2.Text.Trim() + ";" + txtQuestion3.Text.Trim() + ";" + txtQuestion4.Text.Trim(), new UserAuthontication().LoggedInUserID, _ExamId, (int)QuestionType.Matchwords, txtDescription.Text, Convert.ToInt32(txtMarks.Text), DateTime.Now);
            if (QuestionID > 0)
            {
                divError.InnerHtml = "<div class='success'>Question has been successfully added</div>";
            }
        }
        catch (Exception ex)
        {
            divError.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    protected void txtUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtQuestion1.Text == "" || txtQuestion2.Text == "" || txtQuestion3.Text == "" || txtQuestion4.Text == "")
            {
                throw new Exception("Please enter All Questions");
            }
            if (new EXM_QuestionController().UpdateByEXM_QuestionID(_QuestionID, txtQuestion1.Text.Trim() + ";" + txtQuestion2.Text.Trim() + ";" + txtQuestion3.Text.Trim() + ";" + txtQuestion4.Text.Trim(), new UserAuthontication().LoggedInUserID, _ExamId, Convert.ToInt32(txtMarks.Text), (int)QuestionType.Matchwords, txtDescription.Text, DateTime.Now))
            {
                divError.InnerHtml = "<div class='success'>Question has been Updated</div>";
            }
            else
            {
                divError.InnerHtml = "<div class='error'>Please try later system has some internal Issue</div>";
            }
        }
        catch (Exception ex)
        {
            divError.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
}
