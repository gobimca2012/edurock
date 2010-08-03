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

public partial class User_UserControl_AccountSetting_Education : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            var data = new UserEducationController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
            if (data.Count > 0)
            {
                BindData();
            }
        }
    }
    private void AddData()
    {
        try
        {           

            int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

            string InstitueName; if (false) { throw new Exception(""); } InstitueName = txtInstitueName.Text;

            string SubjectName; if (false) { throw new Exception(""); } SubjectName = txtSubjectName.Text;

            string Year; if (false) { throw new Exception(""); } Year = txtYear.Text;

            DateTime ModifiedDate; if (false) { throw new Exception(""); } Convert.ToDateTime(ModifiedDate = DateTime.Now);

            new UserEducationController().Add( LoginUserID, InstitueName, SubjectName, Year);
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

   

    private void BindData()
    {
        var dataBunch = new UserEducationController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            txtInstitueName.Text = data.InstitueName;

            txtSubjectName.Text = data.SubjectName;

            txtYear.Text = data.Year;

            

        }
    }
    protected void lnkAdd_Click(object sender, EventArgs e)
    {
        AddData();
    }
}
