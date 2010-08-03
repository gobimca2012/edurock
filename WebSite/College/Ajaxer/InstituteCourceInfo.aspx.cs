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

public partial class College_Ajaxer_InstituteCourceInfo : AjaxPage
{

    private void FormValidation()
    {

        lnkAddInstituteCource.EnableValidation = true;
        lnkUpdateInstituteCource.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddInstituteCource.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateInstituteCource.ClientID);
        objValidate.Medatory(txtEndDate, "Please enter End Date", this.Page);
        objValidate.Medatory(txtStartDate, "Please enter Start Date", this.Page);
        objValidate.DrowDownMendatory(ddCource, "Please select Course", this.Page,"0");
        objValidate.DigitOnly(txtPrice, "Please enter Number only", this.Page);
        


    }
    private void AddData()
    {
        try
        {



            int InstituteID = new UserAuthontication().InstituteID;

            int CourceID; if (false) { throw new Exception(""); } CourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            string MetaKeyword; if (false) { throw new Exception(""); } MetaKeyword = HtmlHelper.ControlValue(txtMetaKeyword.ClientID);

            DateTime StartDate; if (false) { throw new Exception(""); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (false) { throw new Exception(""); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));

            bool IsPublished = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkIsPublished.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsPublished.ClientID) == "on")
                    IsPublished = true;

            bool HomeWorkEnable = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkHomeWorkEnable.ClientID) != "")
                if (HtmlHelper.ControlValue(chkHomeWorkEnable.ClientID) == "on")
                    HomeWorkEnable = true;

            bool AttendanceEnable = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkAttendanceEnable.ClientID) != "")
                if (HtmlHelper.ControlValue(chkAttendanceEnable.ClientID) == "on")
                    AttendanceEnable = true;

            bool QuestionAnswerEnable = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkQuestionAnswerEnable.ClientID) != "")
                if (HtmlHelper.ControlValue(chkQuestionAnswerEnable.ClientID) == "on")
                    QuestionAnswerEnable = true;

            bool SelfRegistrationEnable = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkSelfRegistrationEnable.ClientID) != "")
                if (HtmlHelper.ControlValue(chkSelfRegistrationEnable.ClientID) == "on")
                    SelfRegistrationEnable = true;

            bool IsFree = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkIsFree.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsFree.ClientID) == "on")
                    IsFree = true;

            decimal Price = 0;
            if (HtmlHelper.ControlValue(txtPrice.ClientID) != "")
            {
                Price = Convert.ToDecimal(HtmlHelper.ControlValue(txtPrice.ClientID));
            }

            DateTime Modifieddate = DateTime.Now;


            new InstituteCourceController().Add(InstituteID, CourceID, MetaDescription, MetaKeyword, StartDate, EndDate, IsPublished, HomeWorkEnable, AttendanceEnable, QuestionAnswerEnable, SelfRegistrationEnable, IsFree, Price, Modifieddate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been added Successfully", "Course");
            Response.Redirect("~/College/Ajaxer/InstituteCourceInfoView.aspx");
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

            int InstituteCourceID = ID;

            int InstituteID = new UserAuthontication().InstituteID;

            int CourceID; if (false) { throw new Exception(""); } CourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            string MetaKeyword; if (false) { throw new Exception(""); } MetaKeyword = HtmlHelper.ControlValue(txtMetaKeyword.ClientID);

            DateTime StartDate; if (false) { throw new Exception(""); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (false) { throw new Exception(""); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));


            bool IsPublished = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkIsPublished.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsPublished.ClientID) == "on")
                    IsPublished = true;

            bool HomeWorkEnable = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkHomeWorkEnable.ClientID) != "")
                if (HtmlHelper.ControlValue(chkHomeWorkEnable.ClientID) == "on")
                    HomeWorkEnable = true;

            bool AttendanceEnable = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkAttendanceEnable.ClientID) != "")
                if (HtmlHelper.ControlValue(chkAttendanceEnable.ClientID) == "on")
                    AttendanceEnable = true;

            bool QuestionAnswerEnable = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkQuestionAnswerEnable.ClientID) != "")
                if (HtmlHelper.ControlValue(chkQuestionAnswerEnable.ClientID) == "on")
                    QuestionAnswerEnable = true;

            bool SelfRegistrationEnable = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkSelfRegistrationEnable.ClientID) != "")
                if (HtmlHelper.ControlValue(chkSelfRegistrationEnable.ClientID) == "on")
                    SelfRegistrationEnable = true;

            bool IsFree = false; if (false) { throw new Exception(""); }
            if (HtmlHelper.ControlValue(chkIsFree.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsFree.ClientID) == "on")
                    IsFree = true;

            decimal Price = 0;
            if (HtmlHelper.ControlValue(txtPrice.ClientID) != "")
            {
                Price = Convert.ToDecimal(HtmlHelper.ControlValue(txtPrice.ClientID));
            }
            DateTime Modifieddate = DateTime.Now;

            new InstituteCourceController().UpdateByInstituteCourceID(InstituteCourceID, InstituteID, CourceID, MetaDescription, MetaKeyword, StartDate, EndDate, IsPublished, HomeWorkEnable, AttendanceEnable, QuestionAnswerEnable, SelfRegistrationEnable, IsFree, Price, Modifieddate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been Updated Successfully", "Course");
            Response.Redirect("~/College/Ajaxer/InstituteCourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        lnkUpdateInstituteCource.Visible = true;
        var dataBunch = new InstituteCourceController().GetbyInstituteCourceID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            new CourceController().BindCource(ddCource, data.CourceID.ToString());


            txtMetaDescription.Text = data.MetaDescription;

            txtMetaKeyword.Text = data.MetaKeyword;

            txtStartDate.Text = data.StartDate.ToString();

            txtEndDate.Text = data.EndDate.ToString();

            chkIsPublished.Checked = Convert.ToBoolean(data.IsPublished);

            chkHomeWorkEnable.Checked = Convert.ToBoolean(data.HomeWorkEnable);

            chkAttendanceEnable.Checked = Convert.ToBoolean(data.AttendanceEnable);

            chkQuestionAnswerEnable.Checked = Convert.ToBoolean(data.QuestionAnswerEnable);

            chkSelfRegistrationEnable.Checked = Convert.ToBoolean(data.SelfRegistrationEnable);

            chkIsFree.Checked = Convert.ToBoolean(data.IsFree);



        }
    }

    private int ID
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
        JScripter.DatePicker objdate = new JScripter.DatePicker(this.Page, true);
        new JScripter.TinyMCE(this.Page).Create();
        objdate.DatePickerTextBox(txtStartDate);
        objdate.DatePickerTextBox(txtEndDate);
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
            BindData();
            lnkAddInstituteCource.Visible = false;
        }
        else
        {
            new CourceController().BindCource(ddCource);
            lnkUpdateInstituteCource.Visible = false;
        }
    }

}
