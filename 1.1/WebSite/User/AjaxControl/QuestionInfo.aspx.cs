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

public partial class User_AjaxControl_QuestionInfo : AjaxPage
{


    private void AddData()
    {
        try
        {

            Guid QuestionID; if (false) { throw new Exception(""); } QuestionID = Guid.NewGuid();

            string QuestionText; if (false) { throw new Exception(""); } QuestionText = HtmlHelper.ControlValue(txtQuestionText.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int QuestionTypeID; if (false) { throw new Exception(""); } QuestionTypeID = Convert.ToInt32(HtmlHelper.ControlValue(ddQuestionType.ClientID));
            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int QuestionStatusID = 0;
            string tags = ""; if (false) { throw new Exception(""); } tags = HtmlHelper.ControlValue(txtTags.ClientID);
            DateTime ModifiedDate = DateTime.Now;

            new QuestionController().Add(QuestionID, QuestionText, Description, LoginUserID, ICID, tags, QuestionTypeID, QuestionStatusID, ModifiedDate);
            Response.Redirect("~/User/AjaxControl/Question.aspx?qid=" + QuestionID.ToString() + "&icid=" + ICID.ToString());
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

            Guid QuestionID = ID;

            string QuestionText; if (false) { throw new Exception(""); } QuestionText = HtmlHelper.ControlValue(txtQuestionText.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int QuestionTypeID; if (false) { throw new Exception(""); } QuestionTypeID = Convert.ToInt32(HtmlHelper.ControlValue(ddQuestionType.ClientID));
            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);
            int QuestionStatusID = 0;

            DateTime ModifiedDate = DateTime.Now;
            string tags; if (false) { throw new Exception(""); } tags = HtmlHelper.ControlValue(txtTags.ClientID);
            new QuestionController().UpdateByQuestionID(QuestionID, QuestionText, Description, LoginUserID, ICID, tags, QuestionTypeID, QuestionStatusID, ModifiedDate);

            Response.Redirect("~/User/AjaxControl/Question.aspx?qid=" + QuestionID.ToString()+"&icid="+ICID.ToString()) ;
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new QuestionController().GetbyQuestionID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];


            txtQuestionText.Text = data.QuestionText;
            txtDescription.Text = data.Description;
            new QuestionTypeController().BindQuestionType(ddQuestionType, data.QuestionTypeID.ToString(), new UserAuthontication().UserInstituteLoginID);


        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["qid"]);
        }
    }
    private int ICID
    {
        get
        {
            return Convert.ToInt32(AjaxState["icid"]);
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
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];

        }
        if (Request.Params["qid"] != null)
        {
            AjaxState["qid"] = Request.Params["qid"];
            BindData();
            lnkAddQuestion.Visible = false;
        }
        else
        {
            new QuestionTypeController().BindQuestionType(ddQuestionType, new UserAuthontication().UserInstituteLoginID);
            lnkUpdateQuestion.Visible = false;
        }
       
    }

}
