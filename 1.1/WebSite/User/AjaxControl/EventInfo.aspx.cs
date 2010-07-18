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


    private void AddData()
    {
        try
        {

            Guid EventID = Guid.NewGuid();

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string Title; if (false) { throw new Exception(""); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            DateTime StartDate; if (false) { throw new Exception(""); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (false) { throw new Exception(""); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));

            int InstituteCourceID; if (false) { throw new Exception(""); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            int InstituteSubjectID; if (false) { throw new Exception(""); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddSubject.ClientID));

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            string ContactPerson; if (false) { throw new Exception(""); } ContactPerson = HtmlHelper.ControlValue(txtContactPerson.ClientID);

            string ContactEmail; if (false) { throw new Exception(""); } ContactEmail = HtmlHelper.ControlValue(txtContactEmail.ClientID);

            string ContactPhone; if (false) { throw new Exception(""); } ContactPhone = HtmlHelper.ControlValue(txtContactPhone.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new EventController().Add(EventID, LoginUserID, Title, Description, MetaDescription, StartDate, EndDate, InstituteCourceID, InstituteSubjectID, Tag, ContactPerson, ContactEmail, ContactPhone, ModifiedDate);
            Response.Redirect("~/User/AjaxControl/Event.aspx?evid=" + EventID.ToString());
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

            Guid EventID = ID;

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string Title; if (false) { throw new Exception(""); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            DateTime StartDate; if (false) { throw new Exception(""); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (false) { throw new Exception(""); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));

            int InstituteCourceID; if (false) { throw new Exception(""); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            int InstituteSubjectID; if (false) { throw new Exception(""); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddSubject.ClientID));

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            string ContactPerson; if (false) { throw new Exception(""); } ContactPerson = HtmlHelper.ControlValue(txtContactPerson.ClientID);

            string ContactEmail; if (false) { throw new Exception(""); } ContactEmail = HtmlHelper.ControlValue(txtContactEmail.ClientID);

            string ContactPhone; if (false) { throw new Exception(""); } ContactPhone = HtmlHelper.ControlValue(txtContactPhone.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new EventController().UpdateByEventID(EventID, LoginUserID, Title, Description, MetaDescription, StartDate, EndDate, InstituteCourceID, InstituteSubjectID, Tag, ContactPerson, ContactEmail, ContactPhone, ModifiedDate);

            Response.Redirect("~/User/AjaxControl/Event.aspx?evid=" + EventID.ToString());
        }
        catch (Exception ex)
        {
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
        if (Request.Params["evid"] != null)
        {
            AjaxState["evid"] = Request.Params["evid"];
            BindData(ID);
            lnkAddEvent.Visible = false;
        }
        else
        {
            new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID);
            lnkUpdateEvent.Visible = false;
        }
        JScripter.DatePicker objDate = new JScripter.DatePicker(this.Page);
        objDate.DatePickerTextBox(txtStartDate);
        objDate.DatePickerTextBox(txtEndDate);


        ddCource.Attributes["onchange"] = string.Format("ddChange('#{0}','#{1}','{2}');", ddCource.ClientID, "ddrep", (ResolveUrl("~/User/Service.aspx") + "?icid="));
    }

}
