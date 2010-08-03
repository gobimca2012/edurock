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

public partial class Admin_Ajaxer_QuestionStatusInfo : AjaxPage
{


    private void AddData()
    {
        try
        {


            string QuestionStatusText; if (false) { throw new Exception(""); } QuestionStatusText = HtmlHelper.ControlValue(txtQuestionStatusText.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            DateTime ModifiedDate = DateTime.Now;

            new QuestionStatusController().Add(QuestionStatusText, LoginUserID, ModifiedDate);
            Response.Redirect("~/Admin/Ajaxer/QuestionStatusInfoView.aspx");
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

            int QuestionStatusID = ID;

            string QuestionStatusText; if (false) { throw new Exception(""); } QuestionStatusText = HtmlHelper.ControlValue(txtQuestionStatusText.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            DateTime ModifiedDate = DateTime.Now;

            new QuestionStatusController().UpdateByQuestionStatusID(QuestionStatusID, QuestionStatusText, LoginUserID, ModifiedDate);

            Response.Redirect("~/Admin/Ajaxer/QuestionStatusInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new QuestionStatusController().GetbyQuestionStatusID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];


            txtQuestionStatusText.Text = data.QuestionStatusText;


        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["qstatusid"]);
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
        if (Request.Params["qstatusid"] != null)
        {
            AjaxState["qstatusid"] = Request.Params["qstatusid"];
            BindData();
            lnkAddcource.Visible = false;
        }
        else
        {
            
            lnkUpdate.Visible = false;
        }
    }
}
	
