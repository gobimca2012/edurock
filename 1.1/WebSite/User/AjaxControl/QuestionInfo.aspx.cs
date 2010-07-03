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


            int QuestionStatusID = 0;

            DateTime ModifiedDate = DateTime.Now;

            new QuestionController().Add(QuestionID, QuestionText, LoginUserID, QuestionTypeID, QuestionStatusID, ModifiedDate);
            Response.Redirect("~/User/AjaxControl/QuestionInfoView.aspx");
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

            int QuestionStatusID = 0;

            DateTime ModifiedDate = DateTime.Now;

            new QuestionController().UpdateByQuestionID(QuestionID, QuestionText, LoginUserID, QuestionTypeID, QuestionStatusID, ModifiedDate);

            Response.Redirect("~/User/AjaxControl/QuestionInfoView.aspx");
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

            ddQuestionID.SelectedValue = data.QuestionID.ToString();

            txtQuestionText.Text = data.QuestionText;

            new QuestionTypeController().BindQuestionType(ddQuestionType, data.QuestionTypeID.ToString());
            

        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["qid"]);
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
        if (Request.Params["qid"] != null)
        {
            AjaxState["qid"] = Request.Params["qid"];
            BindData();
            lnkAddQuestion.Visible = false;
        }
        else
        {
            new QuestionTypeController().BindQuestionType(ddQuestionType);
            lnkUpdateQuestion.Visible = false;
        }
    }

}
