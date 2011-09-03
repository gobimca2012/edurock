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

public partial class College_Ajaxer_ExamViewInfo : AjaxPage
{
    private void FormValidation()
    {
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddExam.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateExam.ClientID);
        objValidate.DrowDownMendatory(ddInstituteCource, "Please select Cource ", this.Page, "0");
        //objValidate.DrowDownMendatory(ddInstituteSubject, "Please select Subject ", this.Page, "0");
        objValidate.Medatory(txtExamTime, "Please enter Title", this.Page);
        objValidate.Medatory(txtEndDate, "Please enter End Date", this.Page);
        objValidate.Medatory(txtExamTime, "Please enter Examination Time", this.Page);
        objValidate.Medatory(txtRequirePecentage, "Please enter Required Percentage", this.Page);
        objValidate.Medatory(txtStartDate, "Please enter Start Date", this.Page);
        objValidate.Medatory(txtSubjectName, "Please enter Subject name", this.Page);
        objValidate.DigitOnly(txtRequirePecentage, "Please enter Number only", this.Page);
        objValidate.DigitOnly(txtExamTime, "Please enter Number only", this.Page);
        




    }

    private void AddData()
    {
        try
        {



            string ExamName; if (HtmlHelper.ControlValue(txtExamName.ClientID)=="") { throw new Exception("Please enter Exam Name"); } ExamName = HtmlHelper.ControlValue(txtExamName.ClientID);

            string SubjectName; if (HtmlHelper.ControlValue(txtSubjectName.ClientID)=="") { throw new Exception("Please enter Subject Name"); } SubjectName = HtmlHelper.ControlValue(txtSubjectName.ClientID);

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddInstituteCource.ClientID) == "" || HtmlHelper.ControlValue(ddInstituteCource.ClientID)=="0") { throw new Exception("Please enter Cource"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID));

            //int InstituteSubjectID; if (HtmlHelper.ControlValue(ddInstituteSubject.ClientID) == "" || HtmlHelper.ControlValue(ddInstituteSubject.ClientID)=="0") { throw new Exception("Please enter Subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteSubject.ClientID));

            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID)=="") { throw new Exception("Please enter description"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            DateTime ModifiedDate = DateTime.Now;

            string ExamTime; if (false) { throw new Exception(""); } ExamTime = HtmlHelper.ControlValue(txtExamTime.ClientID);

            bool IsActive = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsActive.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsActive.ClientID) == "on")
                    IsActive = true;


            int RequirePecentage; if (HtmlHelper.ControlValue(txtRequirePecentage.ClientID)=="") { throw new Exception("Please enter require percentage"); } RequirePecentage = Convert.ToInt32(HtmlHelper.ControlValue(txtRequirePecentage.ClientID));

            DateTime StartDate; if (HtmlHelper.ControlValue(txtStartDate.ClientID)=="") { throw new Exception("Please enter Start date"); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (HtmlHelper.ControlValue(txtEndDate.ClientID)=="") { throw new Exception("Please enter end date"); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));

            int ExamID = new ExamController().Add(ExamName, SubjectName, InstituteCourceID, Description, LoginUserID, ModifiedDate, ExamTime, IsActive, RequirePecentage, StartDate, EndDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0}  hasbeen Added Successfully", "Exam", ExamName);
            Response.Redirect("~/User/AjaxControl/Exam.aspx?eid=" + ExamID.ToString());
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    public void PreventData()
    {


        txtExamName.Text = HtmlHelper.ControlValue(txtExamName.ClientID);

        txtSubjectName.Text = HtmlHelper.ControlValue(txtSubjectName.ClientID);

        //new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject, Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID)), HtmlHelper.ControlValue(ddInstituteSubject.ClientID));
        new InstituteCourceController().BindInstituteCource(ddInstituteCource, new UserAuthontication().UserInstituteID, HtmlHelper.ControlValue(ddInstituteCource.ClientID));
        txtDescription.Text = HtmlHelper.ControlValue(txtDescription.ClientID);



        txtExamTime.Text = HtmlHelper.ControlValue(txtExamTime.ClientID);

        chkIsActive.Checked = Convert.ToBoolean( HtmlHelper.ControlValue(chkIsActive.ClientID));

        txtRequirePecentage.Text = HtmlHelper.ControlValue(txtRequirePecentage.ClientID);
        txtStartDate.Text = HtmlHelper.ControlValue(txtStartDate.ClientID);

        txtEndDate.Text = HtmlHelper.ControlValue(txtEndDate.ClientID);

    }
    private void EditData()
    {
        try
        {

            int ExamID = ID;

            string ExamName; if (HtmlHelper.ControlValue(txtExamName.ClientID) == "") { throw new Exception("Please enter Exam Name"); } ExamName = HtmlHelper.ControlValue(txtExamName.ClientID);

            string SubjectName; if (HtmlHelper.ControlValue(txtSubjectName.ClientID) == "") { throw new Exception("Please enter Subject Name"); } SubjectName = HtmlHelper.ControlValue(txtSubjectName.ClientID);

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddInstituteCource.ClientID) == "" || HtmlHelper.ControlValue(ddInstituteCource.ClientID) == "0") { throw new Exception("Please enter Cource"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID));

            //int InstituteSubjectID; if (HtmlHelper.ControlValue(ddInstituteSubject.ClientID) == "" || HtmlHelper.ControlValue(ddInstituteSubject.ClientID) == "0") { throw new Exception("Please enter Subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteSubject.ClientID));

            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID) == "") { throw new Exception("Please enter description"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            DateTime ModifiedDate = DateTime.Now;

            string ExamTime; if (false) { throw new Exception(""); } ExamTime = HtmlHelper.ControlValue(txtExamTime.ClientID);

            bool IsActive = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsActive.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsActive.ClientID) == "on")
                    IsActive = true;


            int RequirePecentage; if (HtmlHelper.ControlValue(txtRequirePecentage.ClientID) == "") { throw new Exception("Please enter require percentage"); } RequirePecentage = Convert.ToInt32(HtmlHelper.ControlValue(txtRequirePecentage.ClientID));

            DateTime StartDate; if (HtmlHelper.ControlValue(txtStartDate.ClientID) == "") { throw new Exception("Please enter Start date"); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (HtmlHelper.ControlValue(txtEndDate.ClientID) == "") { throw new Exception("Please enter end date"); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));

            new ExamController().UpdateByExamID(ExamID, ExamName, SubjectName, InstituteCourceID, Description, LoginUserID, ModifiedDate, ExamTime, IsActive, RequirePecentage, StartDate, EndDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} hasbeen Updated Successfully", "Exam", ExamName);
            Response.Redirect("~/User/AjaxControl/Exam.aspx?eid=" + ExamID.ToString());
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new ExamController().GetbyExamID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];



            txtExamName.Text = data.ExamName;

            txtSubjectName.Text = data.SubjectName;

            new InstituteCourceController().BindInstituteCource(ddInstituteCource, new UserAuthontication().UserInstituteID, data.InstituteCourceID.ToString());
           // new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject, data.InstituteSubjectID.ToString());

            txtDescription.Text = data.Description;



            txtExamTime.Text = data.ExamTime;

            chkIsActive.Checked = (bool)data.IsActive;

            txtRequirePecentage.Text = data.RequirePecentage.ToString();

            txtStartDate.Text = data.StartDate.ToString();

            txtEndDate.Text = data.EndDate.ToString();

        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["eid"]);
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
    private int _InstituteCourceID
    {
        get
        {
            return Convert.ToInt32(AjaxState["icid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //JScripter.JScripter.IncludeJavascriptFile("tinyeditor", ResolveUrl("~/Jscript/tinymce/jscripts/tiny_mce/tiny_mce.js"), this.Page);
        //new JScripter.TinyMCE(this.Page).Create();
        FormValidation();
        JScripter.DatePicker objDatePicker = new JScripter.DatePicker(this.Page, true);
        objDatePicker.DatePickerTextBox(txtStartDate);
        objDatePicker.DatePickerTextBox(txtEndDate);
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
        }
        if (Request.Params["eid"] != null)
        {
            AjaxState["eid"] = Request.Params["eid"];
            BindData();
            lnkAddExam.Visible = false;
        }
        else
        {

            if (Request.Params["ddp"] != null)
            {
                if (Request.Params["ddp"] == ddInstituteCource.ClientID)
                {

                    //new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject, Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID)));
                    new InstituteCourceController().BindInstituteCource(ddInstituteCource, new UserAuthontication().UserInstituteID, HtmlHelper.ControlValue(ddInstituteCource.ClientID));
                }
            }
            else
            {
                //new InstituteCourceController().BindInstituteCourceByLoginUserID(ddInstituteCource, new UserAuthontication().UserInstituteID,new UserAuthontication().LoggedInUserID);
                new InstituteCourceController().BindInstituteCource(ddInstituteCource);


                //new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject);
            }
            //ddInstituteCource.Attributes["onchange"] = string.Format("$('#{0}').dropdownPostback('{1}','{2}','{3}','{4}');", ddInstituteCource.ClientID, this.Request.Url.AbsolutePath, "#ddin", "#contentBox", "#SubjectDrop");
            this.DropDownPostBack(ddInstituteCource, "#ddin", "#SubjectDrop");
            lnkUpdateExam.Visible = false;
        }
    }

}
