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
    private void FormValidation()
    {
        lnkAddQuestion.EnableValidation = true;
        lnkUpdateQuestion.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddQuestion.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateQuestion.ClientID);
        
        objValidate.Medatory(txtQuestionText, "Please enter Question Title", this.Page);
        objValidate.Medatory(txtDescription, "Please enter Question Description", this.Page);
        objValidate.DrowDownMendatory(ddCource, "Please select Cource", this.Page,"0");
        objValidate.DrowDownMendatory(ddSubject, "Please select Subject", this.Page,"0");
        objValidate.DrowDownMendatory(ddQuestionType, "Please select Question Type", this.Page,"0");


    }

    private void AddData()
    {
        try
        {

            Guid QuestionID; if (false) { throw new Exception(""); } QuestionID = Guid.NewGuid();

            string QuestionText; if (HtmlHelper.ControlValue(txtQuestionText.ClientID)=="") { throw new Exception("Please entr Question title"); } QuestionText = HtmlHelper.ControlValue(txtQuestionText.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;
            int InstituteCourceID; if (HtmlHelper.ControlValue("ddCource") == "" || HtmlHelper.ControlValue("ddCource")=="0") { throw new Exception("Please select cource"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue("ddCource"));
            int InstituteSubjectID; if (HtmlHelper.ControlValue("ddSubject") == "" || HtmlHelper.ControlValue("ddSubject")=="0") { throw new Exception("Please select subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue("ddSubject"));
            int QuestionTypeID; if (HtmlHelper.ControlValue(ddQuestionType.ClientID) == "" || HtmlHelper.ControlValue(ddQuestionType.ClientID)=="0") { throw new Exception("Please select question type"); } QuestionTypeID = Convert.ToInt32(HtmlHelper.ControlValue(ddQuestionType.ClientID));
            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID)=="" ) { throw new Exception("Please enter descrition"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int QuestionStatusID = 0;
            string tags = ""; if (false) { throw new Exception(""); } tags = HtmlHelper.ControlValue(txtTags.ClientID);
            DateTime ModifiedDate = DateTime.Now;

            new QuestionController().Add(QuestionID, QuestionText, Description, LoginUserID, InstituteCourceID, InstituteSubjectID, tags, QuestionTypeID, QuestionStatusID, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} hasbeen Added Successfully", "Question", QuestionText);
            Response.Redirect("~/User/AjaxControl/Question.aspx?qid=" + QuestionID.ToString());// + "&icid=" + ICID.ToString());
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    public void PreventData()
    {

        
        txtQuestionText.Text = HtmlHelper.ControlValue(txtQuestionText.ClientID);

        txtDescription.Text = HtmlHelper.ControlValue(txtDescription.ClientID);


        new InstituteSubjectController().BindInstituteSubject(ddSubject, Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID)), HtmlHelper.ControlValue(ddSubject.ClientID));
        new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID, HtmlHelper.ControlValue(ddCource.ClientID));


        txtTags.Text = HtmlHelper.ControlValue(txtTags.ClientID);
        
      

    }
    private void EditData()
    {
        try
        {

            Guid QuestionID = ID;

            string QuestionText; if (HtmlHelper.ControlValue(txtQuestionText.ClientID) == "") { throw new Exception("Please entr Question title"); } QuestionText = HtmlHelper.ControlValue(txtQuestionText.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;
            int InstituteCourceID; if (HtmlHelper.ControlValue("ddCource") == "" || HtmlHelper.ControlValue("ddCource") == "0") { throw new Exception("Please select cource"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue("ddCource"));
            int InstituteSubjectID; if (HtmlHelper.ControlValue("ddSubject") == "" || HtmlHelper.ControlValue("ddSubject") == "0") { throw new Exception("Please select subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue("ddSubject"));
            int QuestionTypeID; if (HtmlHelper.ControlValue(ddQuestionType.ClientID) == "" || HtmlHelper.ControlValue(ddQuestionType.ClientID) == "0") { throw new Exception("Please select question type"); } QuestionTypeID = Convert.ToInt32(HtmlHelper.ControlValue(ddQuestionType.ClientID));
            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID) == "") { throw new Exception("Please enter descrition"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int QuestionStatusID = 0;

            DateTime ModifiedDate = DateTime.Now;
            string tags; if (false) { throw new Exception(""); } tags = HtmlHelper.ControlValue(txtTags.ClientID);
            new QuestionController().UpdateByQuestionID(QuestionID, QuestionText, Description, LoginUserID, InstituteCourceID,InstituteSubjectID, tags, QuestionTypeID, QuestionStatusID, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} hasbeen Updated Successfully", "Question", QuestionText);
            Response.Redirect("~/User/AjaxControl/Question.aspx?qid=" + QuestionID.ToString());//+"&icid="+ICID.ToString()) ;
        }
        catch (Exception ex)
        {
            PreventData();
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
            new InstituteSubjectController().BindInstituteSubject(ddSubject, Convert.ToInt32(data.InstituteCourceID.ToString()), data.InstituteSubjectID.ToString());
            new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID, data.InstituteCourceID.ToString());


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
        FormValidation();
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
            new InstituteCourceController().BindInstituteCourceByLoginUserID(ddCource, new UserAuthontication().UserInstituteID,new UserAuthontication().LoggedInUserID);
        }
        ddCource.Attributes["onchange"] = string.Format("ddChange('#{0}','#{1}','{2}');", ddCource.ClientID, "ddrep", (ResolveUrl("~/User/Service.aspx") + "?icid="));
       
    }

}
