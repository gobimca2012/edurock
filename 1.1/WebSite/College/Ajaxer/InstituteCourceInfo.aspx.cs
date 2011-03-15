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
       
        objValidate.Medatory(txtCourceName, "Please enter Course Name", this.Page);
        objValidate.DrowDownMendatory(ddCatagory, "Please select Category", this.Page,"0");
       
        


    }
    private void AddData()
    {
        try
        {



            int InstituteID = new UserAuthontication().InstituteID;

          //  int CourceID; if (false) { throw new Exception(""); } CourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            string MetaKeyword; if (false) { throw new Exception(""); } MetaKeyword = HtmlHelper.ControlValue(txtMetaKeyword.ClientID);

           

            DateTime Modifieddate = DateTime.Now;
            string CourseName = HtmlHelper.ControlValue(txtCourceName.ClientID);
            int CourceCategoryID = Convert.ToInt32(HtmlHelper.ControlValue(ddCatagory.ClientID));

            int InstituteCourseID=new InstituteCourceController().Add(InstituteID, CourceCategoryID,CourseName, MetaDescription, MetaKeyword, Modifieddate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} has been added Successfully", "Course");
            new JScripter.Loader(this.Page, true).LoadPage("#icource", ResolveUrl("~/User/AjaxControl/InstituteCourceInfoView.aspx") + "?usid=" + new UserAuthontication().LoggedInUserID.ToString());
            Response.Redirect("~/College/Widget/CourseWidgetPage.aspx?icid=" + InstituteCourseID.ToString());
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

            //int CourceID; if (false) { throw new Exception(""); } CourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            string MetaKeyword; if (false) { throw new Exception(""); } MetaKeyword = HtmlHelper.ControlValue(txtMetaKeyword.ClientID);

           
            DateTime Modifieddate = DateTime.Now;
            string CourseName = HtmlHelper.ControlValue(txtCourceName.ClientID);
            int CourceCategoryID = Convert.ToInt32(HtmlHelper.ControlValue(ddCatagory.ClientID));
            new InstituteCourceController().UpdateByInstituteCourceID(InstituteCourceID, CourceCategoryID, CourseName, MetaDescription, MetaKeyword, Modifieddate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} has been Updated Successfully", "Course");
            Response.Redirect("~/College/Widget/CourseWidgetPage.aspx?icid=" + InstituteCourceID.ToString());
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

           // new CourceController().BindCource(ddCource, data.CourceID.ToString());

            txtCourceName.Text = data.Cource.CourceName;
            new CourceCatagoryController().BindCourceCatagory(ddCatagory, data.Cource.CourceCatagoryID.ToString());
            txtMetaDescription.Text = data.MetaDescription;

            txtMetaKeyword.Text = data.MetaKeyword;





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
       
        new JScripter.TinyMCE(this.Page,true).Create();
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
            BindData();
            lnkAddInstituteCource.Visible = false;
        }
        else
        {
           // new CourceController().BindCource(ddCource);
            new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateInstituteCource.Visible = false;
        }
    }

}
