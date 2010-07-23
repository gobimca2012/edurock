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

public partial class User_AjaxControl_HomeWorkInfo : AjaxPage
{
    private void FormValidation()
    {
        lnkAddHomeWork.EnableValidation = true;
        lnkUpdateHomeWork.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddHomeWork.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateHomeWork.ClientID);
        objValidate.Medatory(txtTitle, "Please enter Title", this.Page);
        objValidate.Medatory(txtDescription, "Please enter Description", this.Page);
        objValidate.DrowDownMendatory(ddInstituteCource, "Please select Cource", this.Page,"0");
        objValidate.DrowDownMendatory(ddInstituteSubject, "Please select Subject", this.Page,"0");

    }

    private void AddData()
    {
        try
        {



            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string Title; if (HtmlHelper.ControlValue(txtTitle.ClientID) == "") { throw new Exception("Please enter title"); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID) == "") { throw new Exception("Please enter description"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string ShortDescription; if (HtmlHelper.ControlValue(txtShortDescription.ClientID) == "") { throw new Exception("Please enter Short description"); } ShortDescription = HtmlHelper.ControlValue(txtShortDescription.ClientID);

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddInstituteCource.ClientID) == "" || HtmlHelper.ControlValue(ddInstituteCource.ClientID) == "0") { throw new Exception("Please select cource"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID));

            int InstituteSubjectID; if (HtmlHelper.ControlValue(ddInstituteSubject.ClientID) == "" || HtmlHelper.ControlValue(ddInstituteSubject.ClientID) == "0") { throw new Exception("Please enter subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteSubject.ClientID));

            DateTime ModifiedDate = DateTime.Now;

            int HomeworkID = new HomeWorkController().Add(LoginUserID, Title, Description, ShortDescription, InstituteCourceID, InstituteSubjectID, ModifiedDate);
            Response.Redirect("~/User/AjaxControl/HomeWork.aspx?hwid=" + HomeworkID.ToString());
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

        txtShortDescription.Text = HtmlHelper.ControlValue(txtShortDescription.ClientID);

        new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject, Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID)), HtmlHelper.ControlValue(ddInstituteSubject.ClientID));
        new InstituteCourceController().BindInstituteCource(ddInstituteCource, new UserAuthontication().UserInstituteID, HtmlHelper.ControlValue(ddInstituteCource.ClientID));


    }
    private void EditData()
    {
        try
        {



            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string Title; if (HtmlHelper.ControlValue(txtTitle.ClientID) == "") { throw new Exception("Please enter title"); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID) == "") { throw new Exception("Please enter description"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string ShortDescription; if (HtmlHelper.ControlValue(txtShortDescription.ClientID) == "") { throw new Exception("Please enter Short description"); } ShortDescription = HtmlHelper.ControlValue(txtShortDescription.ClientID);

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddInstituteCource.ClientID) == "" || HtmlHelper.ControlValue(ddInstituteCource.ClientID) == "0") { throw new Exception("Please select cource"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID));

            int InstituteSubjectID; if (HtmlHelper.ControlValue(ddInstituteSubject.ClientID) == "" || HtmlHelper.ControlValue(ddInstituteSubject.ClientID) == "0") { throw new Exception("Please enter subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteSubject.ClientID));

            DateTime ModifiedDate = DateTime.Now;

            new HomeWorkController().UpdateByHomeWorkID(ID, LoginUserID, Title, Description, ShortDescription, InstituteCourceID, InstituteSubjectID, ModifiedDate);

            Response.Redirect("~/User/AjaxControl/HomeWork.aspx?hwid=" + ID.ToString());
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new HomeWorkController().GetbyHomeWorkID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];



            txtTitle.Text = data.Title;

            txtDescription.Text = data.Description;

            txtShortDescription.Text = data.ShortDescription;

            new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject, Convert.ToInt32(data.InstituteCourceID.ToString()), data.InstituteSubjectID.ToString());
            new InstituteCourceController().BindInstituteCource(ddInstituteCource, new UserAuthontication().UserInstituteID, data.InstituteCourceID.ToString());


        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["hwid"]);
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
        FormValidation();
        if (!IsEventChange)
        {
            if (Request.Params["icid"] != null)
            {
                AjaxState["icid"] = Request.Params["icid"];
            }
            if (Request.Params["hwid"] != null)
            {
                AjaxState["hwid"] = Request.Params["hwid"];
                BindData();
                lnkAddHomeWork.Visible = false;
            }
            else
            {
                new InstituteCourceController().BindInstituteCource(ddInstituteCource, new UserAuthontication().UserInstituteID);

                lnkUpdateHomeWork.Visible = false;
            }

            this.DropDownPostBack(ddInstituteCource, "#ddInsti", "#ddSub");
        }

    }
    protected override void OnAjaxDropDownChange(string e)
    {
        new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject, Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID)));
        new InstituteCourceController().BindInstituteCource(ddInstituteCource, new UserAuthontication().UserInstituteID, HtmlHelper.ControlValue(ddInstituteCource.ClientID));
        base.OnAjaxDropDownChange(e);
    }

}
