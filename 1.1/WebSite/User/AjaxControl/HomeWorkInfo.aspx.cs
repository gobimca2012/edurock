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


    private void AddData()
    {
        try
        {



            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string Title; if (false) { throw new Exception(""); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string ShortDescription; if (false) { throw new Exception(""); } ShortDescription = HtmlHelper.ControlValue(txtShortDescription.ClientID);

            int InstituteCourceID; if (false) { throw new Exception(""); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID));

            int InstituteSubjectID; if (false) { throw new Exception(""); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteSubject.ClientID));

            DateTime ModifiedDate = DateTime.Now;

            int HomeworkID=new HomeWorkController().Add(LoginUserID, Title, Description, ShortDescription, InstituteCourceID, InstituteSubjectID, ModifiedDate);
            Response.Redirect("~/User/AjaxControl/HomeWork.aspx?hwid=" + HomeworkID.ToString());
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



            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string Title; if (false) { throw new Exception(""); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string ShortDescription; if (false) { throw new Exception(""); } ShortDescription = HtmlHelper.ControlValue(txtShortDescription.ClientID);

            int InstituteCourceID; if (false) { throw new Exception(""); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID));

            int InstituteSubjectID; if (false) { throw new Exception(""); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteSubject.ClientID));

            DateTime ModifiedDate = DateTime.Now;

            new HomeWorkController().UpdateByHomeWorkID(ID, LoginUserID, Title, Description, ShortDescription, InstituteCourceID, InstituteSubjectID, ModifiedDate);

            Response.Redirect("~/User/AjaxControl/HomeWork.aspx?hwid="+ID.ToString() );
        }
        catch (Exception ex)
        {
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

            new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject,Convert.ToInt32( data.InstituteCourceID.ToString()),data.InstituteSubjectID.ToString());
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
