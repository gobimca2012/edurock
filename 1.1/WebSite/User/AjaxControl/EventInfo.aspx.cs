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

public partial class User_AjaxControl_EventInfo : AjaxPage
{

    private void FormValidation()
    {
        lnkAddEvent.EnableValidation = true;
        lnkUpdateEvent.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddEvent.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateEvent.ClientID);
        objValidate.Medatory(txtTitle, "Please enter Title", this.Page);
        objValidate.Medatory(txtContactEmail, "Please enter Contact Email Address", this.Page);
        objValidate.Email(txtContactEmail, "Please enter Valid Contact Email Address", this.Page);
        objValidate.Medatory(txtContactPerson, "Please enter Contact Person", this.Page);
        objValidate.Medatory(txtContactPhone, "Please enter Contact Phone Number", this.Page);
        objValidate.DigitOnly(txtContactPhone, "Please enter Number Only", this.Page);
        objValidate.Medatory(txtEndDate, "Please enter End Date", this.Page);
        objValidate.Medatory(txtStartDate, "Please enter Start Date", this.Page);
        objValidate.DrowDownMendatory(ddCource, "Please select Course ", this.Page, "0");
        objValidate.DrowDownMendatory(ddSubject, "Please select Subject ", this.Page, "0");
        



    }
    private void AddData()
    {
        try
        {

            Guid EventID = Guid.NewGuid();

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string Title; if (HtmlHelper.ControlValue(txtTitle.ClientID)=="") { throw new Exception("Please enter title"); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID)=="") { throw new Exception("Please enter description"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            DateTime StartDate; if (HtmlHelper.ControlValue(txtStartDate.ClientID)=="") { throw new Exception("Please enter start date"); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (HtmlHelper.ControlValue(txtEndDate.ClientID)=="") { throw new Exception("Please enter end date"); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddCource.ClientID) == "" || HtmlHelper.ControlValue(ddCource.ClientID)=="0") { throw new Exception("Please enter course"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            int InstituteSubjectID; if (HtmlHelper.ControlValue(ddSubject.ClientID) == "" || HtmlHelper.ControlValue(ddSubject.ClientID)=="0") { throw new Exception("Please enter subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddSubject.ClientID));

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            string ContactPerson; if (false) { throw new Exception(""); } ContactPerson = HtmlHelper.ControlValue(txtContactPerson.ClientID);

            string ContactEmail; if (false) { throw new Exception(""); } ContactEmail = HtmlHelper.ControlValue(txtContactEmail.ClientID);

            string ContactPhone; if (false) { throw new Exception(""); } ContactPhone = HtmlHelper.ControlValue(txtContactPhone.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new EventController().Add(EventID, LoginUserID, Title, Description, MetaDescription, StartDate, EndDate, InstituteCourceID, InstituteSubjectID, Tag, ContactPerson, ContactEmail, ContactPhone, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been Added Successfully", "Event", Title);
            Response.Redirect("~/User/AjaxControl/Event.aspx?evid=" + EventID.ToString());
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    public void PreventData()
    {

        txtTitle.Text = HtmlHelper.ControlValue(txtTitle.ClientID);

        txtDescription.Text = HtmlHelper.ControlValue(txtDescription.ClientID);

        txtMetaDescription.Text = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

        txtStartDate.Text = HtmlHelper.ControlValue(txtStartDate.ClientID);

        txtEndDate.Text = HtmlHelper.ControlValue(txtEndDate.ClientID);

        new InstituteSubjectController().BindInstituteSubject(ddSubject, Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID)), HtmlHelper.ControlValue(ddSubject.ClientID));
        new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID, HtmlHelper.ControlValue(ddCource.ClientID));

        txtTag.Text = HtmlHelper.ControlValue(txtTag.ClientID);

        txtContactPerson.Text = HtmlHelper.ControlValue(txtContactPerson.ClientID);

        txtContactEmail.Text = HtmlHelper.ControlValue(txtContactEmail.ClientID);

        txtContactPhone.Text = HtmlHelper.ControlValue(txtContactPhone.ClientID);


    }
		
    private void EditData()
    {
        try
        {

            Guid EventID = ID;

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string Title; if (HtmlHelper.ControlValue(txtTitle.ClientID) == "") { throw new Exception("Please enter title"); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID) == "") { throw new Exception("Please enter description"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            DateTime StartDate; if (HtmlHelper.ControlValue(txtStartDate.ClientID) == "") { throw new Exception("Please enter start date"); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (HtmlHelper.ControlValue(txtEndDate.ClientID) == "") { throw new Exception("Please enter end date"); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddCource.ClientID) == "" || HtmlHelper.ControlValue(ddCource.ClientID) == "0") { throw new Exception("Please enter course"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            int InstituteSubjectID; if (HtmlHelper.ControlValue(ddSubject.ClientID) == "" || HtmlHelper.ControlValue(ddSubject.ClientID) == "0") { throw new Exception("Please enter subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddSubject.ClientID));

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            string ContactPerson; if (false) { throw new Exception(""); } ContactPerson = HtmlHelper.ControlValue(txtContactPerson.ClientID);

            string ContactEmail; if (false) { throw new Exception(""); } ContactEmail = HtmlHelper.ControlValue(txtContactEmail.ClientID);

            string ContactPhone; if (false) { throw new Exception(""); } ContactPhone = HtmlHelper.ControlValue(txtContactPhone.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new EventController().UpdateByEventID(EventID, LoginUserID, Title, Description, MetaDescription, StartDate, EndDate, InstituteCourceID, InstituteSubjectID, Tag, ContactPerson, ContactEmail, ContactPhone, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been Updated Successfully", "Event", Title);
            Response.Redirect("~/User/AjaxControl/Event.aspx?evid=" + EventID.ToString());
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData(Guid ID)
    {
        var dataBunch = new EventController().GetbyEventID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];


            txtTitle.Text = data.Title;

            txtDescription.Text = data.Description;

            txtMetaDescription.Text = data.MetaDescription;

            txtStartDate.Text = data.StartDate.ToString();

            txtEndDate.Text = data.EndDate.ToString();

            new InstituteSubjectController().BindInstituteSubject(ddSubject, Convert.ToInt32(data.InstituteCourceID.ToString()), data.InstituteSubjectID.ToString());
            new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID, data.InstituteCourceID.ToString());
            //ddInstituteCourceID.SelectedValue = data.InstituteCourceID.ToString();

            //ddInstituteSubjectID.SelectedValue = data.InstituteSubjectID.ToString();

            txtTag.Text = data.Tag;

            txtContactPerson.Text = data.ContactPerson;

            txtContactEmail.Text = data.ContactEmail;

            txtContactPhone.Text = data.ContactPhone;

          
        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["evid"]);
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
        if (Request.Params["evid"] != null)
        {
            AjaxState["evid"] = Request.Params["evid"];
            BindData(ID);
            lnkAddEvent.Visible = false;
        }
        else
        {
            new InstituteCourceController().BindInstituteCourceByLoginUserID(ddCource, new UserAuthontication().UserInstituteID,new UserAuthontication().LoggedInUserID);
            lnkUpdateEvent.Visible = false;
        }
        JScripter.DatePicker objDate = new JScripter.DatePicker(this.Page);
        objDate.DatePickerTextBox(txtStartDate);
        objDate.DatePickerTextBox(txtEndDate);


        ddCource.Attributes["onchange"] = string.Format("ddChange('#{0}','#{1}','{2}');", ddCource.ClientID, "ddrep", (ResolveUrl("~/User/Service.aspx") + "?icid="));
    }

}
