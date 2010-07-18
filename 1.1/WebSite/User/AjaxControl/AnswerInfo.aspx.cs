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

public partial class User_AjaxControl_AnswerInfo : AjaxPage
{

    private Guid _QuestionID
    {
        get
        {
            if (Request.Params["qid"] != null)
            {
                AjaxState["qid"] = Request.Params["qid"];
                return new Guid(Request.Params["qid"]);
            }
            else
            {
                return new Guid(AjaxState["qid"]);
            }
        }
    }
    private void AddData()
    {
        try
        {

            Guid AnswerID = Guid.NewGuid();

            string AnswerText; if (HtmlHelper.ControlValue(txtAnswerText.ClientID) == "") { throw new Exception("Please enter Answer"); } AnswerText = HtmlHelper.ControlValue(txtAnswerText.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            Guid QuestionID = _QuestionID;

            int AnswerStateID = 0;

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int AnswerRate = 0;

            DateTime ModifiedDate = DateTime.Now;

            new AnswerController().Add(AnswerID, AnswerText, Description, QuestionID, AnswerStateID, LoginUserID, AnswerRate, ModifiedDate);
            Response.Redirect("~/User/AjaxControl/AnswerInfoView.aspx?qid=" + QuestionID);
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    private void PreventData()
    {

        txtAnswerText.Text = HtmlHelper.ControlValue(txtAnswerText.ClientID);
        txtDescription.Text = HtmlHelper.ControlValue(txtDescription.ClientID);

    }

    private void EditData()
    {
        try
        {

            Guid AnswerID = Guid.Empty;

            string AnswerText; if (false) { throw new Exception(""); } AnswerText = HtmlHelper.ControlValue(txtAnswerText.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);


            int AnswerStateID = 0;

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int AnswerRate = 0;

            DateTime ModifiedDate = DateTime.Now;

            new AnswerController().UpdateByAnswerID(AnswerID, AnswerText, Description, _QuestionID, AnswerStateID, LoginUserID, AnswerRate, ModifiedDate);

            Response.Redirect("~/User/AjaxControl/AnswerInfoView.aspx?qid=" + _QuestionID);
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new AnswerController().GetbyAnswerID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];



            txtAnswerText.Text = data.AnswerText;

            txtDescription.Text = data.Description;




        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["aid"]);
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
        }
        if (Request.Params["aid"] != null)
        {
            AjaxState["aid"] = Request.Params["aid"];
            BindData();
            lnkAddAnswer.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateAnswer.Visible = false;
        }
    }

}
