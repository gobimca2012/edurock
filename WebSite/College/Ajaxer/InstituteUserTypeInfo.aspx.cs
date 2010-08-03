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

public partial class College_Ajaxer_InstituteUserTypeInfo : AjaxPage
{
    private void FormValidation()
    {
        lnkUpdateInstituteUserType.EnableValidation = true;
        lnkAddInstituteUserType.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddInstituteUserType.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateInstituteUserType.ClientID);
        objValidate.Medatory(txtName, "Please enter Role Name", this.Page);
        

    }

    private void AddData()
    {
        try
        {



            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int InstituteID = new UserAuthontication().InstituteID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new InstituteUserTypeController().Add( LoginUserID, InstituteID, Name, Description, ModifiedDate);
            Response.Redirect("~/College/Ajaxer/InstituteUserTypeInfoView.aspx");
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

            int InstituteUserTypeID = ID;

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int InstituteID = new UserAuthontication().InstituteID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new InstituteUserTypeController().UpdateByInstituteUserTypeID(InstituteUserTypeID, LoginUserID, InstituteID, Name, Description, ModifiedDate);

            Response.Redirect("~/College/Ajaxer/InstituteUserTypeInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new InstituteUserTypeController().GetbyInstituteUserTypeID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            

            txtName.Text = data.Name;

            txtDescription.Text = data.Description;

           

        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["iuid"]);
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
        if (Request.Params["iuid"] != null)
        {
            AjaxState["iuid"] = Request.Params["iuid"];
            BindData();
            lnkAddInstituteUserType.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateInstituteUserType.Visible = false;
        }
    }

}
