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

public partial class College_Ajaxer_InstituteSubjectInfo : AjaxPage
{
    private void FormValidation()
    {
        lnkAddInstituteSubject.EnableValidation = true;
        lnkUpdateInstituteSubject.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddInstituteSubject.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateInstituteSubject.ClientID);
        objValidate.Medatory(txtSubjectText, "Please enter Subject Title", this.Page);
        



    }
    private int _InstituteCourceID
    {
        get
        {
            if (Request.Params["icid"] != null)
            {
                AjaxState["icid"] = Request.Params["icid"];
                return Convert.ToInt32(Request.Params["icid"]);
            }
            else
            {
                return Convert.ToInt32(AjaxState["icid"]);
            }
        }
        set
        {
            AjaxState["icid"] = value.ToString();
        }
    }
    private void AddData()
    {
        try
        {


            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string SubjectText; if (false) { throw new Exception(""); } SubjectText = HtmlHelper.ControlValue(txtSubjectText.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int InstituteCourceID = _InstituteCourceID;

            DateTime ModifiedDate = DateTime.Now;

            new InstituteSubjectController().Add(LoginUserID, SubjectText, Description, InstituteCourceID, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been added Successfully", "Subject ",SubjectText);
            Response.Redirect("~/College/Ajaxer/InstituteSubjectInfoView.aspx?icid="+_InstituteCourceID.ToString());
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

            int InstituteSubjectID = ID;

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string SubjectText; if (false) { throw new Exception(""); } SubjectText = HtmlHelper.ControlValue(txtSubjectText.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int InstituteCourceID = _InstituteCourceID;

            DateTime ModifiedDate = DateTime.Now;

            new InstituteSubjectController().UpdateByInstituteSubjectID(InstituteSubjectID, LoginUserID, SubjectText, Description, InstituteCourceID, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been updated Successfully", "Subject ", SubjectText);
            Response.Redirect("~/College/Ajaxer/InstituteSubjectInfoView.aspx?icid=" + _InstituteCourceID.ToString());
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new InstituteSubjectController().GetbyInstituteSubjectID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            
            txtSubjectText.Text = data.SubjectText;

            txtDescription.Text = data.Description;

            _InstituteCourceID = data.InstituteCourceID;
        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["isid"]);
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
        if (Request.Params["isid"] != null)
        {
            AjaxState["isid"] = Request.Params["isid"];
            BindData();
            lnkAddInstituteSubject.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateInstituteSubject.Visible = false;
        }
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
        }
    }

}
