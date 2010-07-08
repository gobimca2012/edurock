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

public partial class User_AjaxControl_SingleChoiceInfo : AjaxPage
{

    private int _ExamID
    {
        get
        {
            return Convert.ToInt32(AjaxState["eid"]);
        }
    }
    private int _QuestionType
    {
        get
        {
            return Convert.ToInt32(AjaxState["qtype"]);
        }
    }
    private void AddData()
    {
        try
        {


            string Question; if (false) { throw new Exception(""); } Question = HtmlHelper.ControlValue(txtQuestion.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int ExamID = _ExamID;

            int Q_Type = 1;

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string marks; if (false) { throw new Exception(""); } marks = HtmlHelper.ControlValue(txtMarks.ClientID);
            DateTime ModifiedDate = DateTime.Now;



            bool IsActive = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsActive.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsActive.ClientID) == "on")
                    IsActive = true;


            new EXM_QuestionController().Add(Question, LoginUserID, ExamID, Q_Type, Description, Convert.ToInt32(marks), ModifiedDate);
            //new EXM_QuestionController().Add(Question, LoginUserID, ExamID, Q_Type, Marks, Description, ModifiedDate, Order, IsActive);
            Response.Redirect("~/User/AjaxControl/EXMQuestionList.aspx?eid="+_ExamID.ToString());
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void EditData()
    {
        try
        {

            int EXM_QuestionID = ID;

            string Question; if (false) { throw new Exception(""); } Question = HtmlHelper.ControlValue(txtQuestion.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int ExamID = _ExamID;

            int Q_Type = 1;

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string marks; if (false) { throw new Exception(""); } marks = HtmlHelper.ControlValue(txtMarks.ClientID);
            DateTime ModifiedDate = DateTime.Now;



            bool IsActive = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsActive.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsActive.ClientID) == "on")
                    IsActive = true;

            int Order = 0;
            new EXM_QuestionController().UpdateByEXM_QuestionID(EXM_QuestionID, Question, LoginUserID, ExamID, Convert.ToInt32(marks), Q_Type, Description, ModifiedDate);

            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new EXM_QuestionController().GetbyEXM_QuestionID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            
            txtQuestion.Text = data.Question;


            txtMarks.Text = data.Marks.ToString();

            txtDescription.Text = data.Description;

            
            chkIsActive.Checked =(bool) data.IsActive;

        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["qid"]);
        }
    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();

    }
    protected void UpdateAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        EditData();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["eid"] != null)
        {
            AjaxState["eid"] = Request.Params["eid"];

        }
        if (Request.Params["qid"] != null)
        {
            AjaxState["qid"] = Request.Params["qid"];
            BindData();
            lnkAddEXM_Question.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateEXM_Question.Visible = false;
        }
        
    }

}
