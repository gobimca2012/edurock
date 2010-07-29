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

public partial class User_AjaxControl_EducaonInfot : AjaxPage
{


    private void AddData()
    {
        try
        {



            int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

            string InstitueName; if (false) { throw new Exception(""); } InstitueName = HtmlHelper.ControlValue(txtInstitueName.ClientID);

            string SubjectName; if (false) { throw new Exception(""); } SubjectName = HtmlHelper.ControlValue(txtSubjectName.ClientID);

            string Year; if (false) { throw new Exception(""); } Year = HtmlHelper.ControlValue(txtYear.ClientID);

            DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;

            new UserEducationController().Add(LoginUserID, InstitueName, SubjectName, Year, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} hasbeen added Successfully", "Article", Title);
            Response.Redirect("~/User/AjaxControl/EducationView.aspx");
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



            int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

            string InstitueName; if (false) { throw new Exception(""); } InstitueName = HtmlHelper.ControlValue(txtInstitueName.ClientID);

            string SubjectName; if (false) { throw new Exception(""); } SubjectName = HtmlHelper.ControlValue(txtSubjectName.ClientID);

            string Year; if (false) { throw new Exception(""); } Year = HtmlHelper.ControlValue(txtYear.ClientID);

            DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;

            new UserEducationController().UpdateByUserEducationID(ID, LoginUserID, InstitueName, SubjectName, Year, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} hasbeen Updated Successfully", "Institute", InstitueName);
            Response.Redirect("~/User/AjaxControl/EducationView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new UserEducationController().GetbyUserEducationID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            
            txtInstitueName.Text = data.InstitueName;

            txtSubjectName.Text = data.SubjectName;

            txtYear.Text = data.Year;

            

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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["eid"] != null)
        {
            AjaxState["eid"] = Request.Params["eid"];
            lnkAddcource.Visible = false;
            BindData();
        }
        else
        {
            lnkUpdate.Visible = false;
        }
    }

}
