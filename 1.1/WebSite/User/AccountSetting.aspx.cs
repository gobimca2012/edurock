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

public partial class User_AccountSetting : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            CommonController.BindDay(ddDay);
            CommonController.BindMonth(ddMonth);
            CommonController.BindYear(ddYear);
        }
    }
    protected void lnkUpdate_Click(object sender, EventArgs e)
    {

    }
    private void AddData()
    {
        try
        {
                        

            int LoginUserID; LoginUserID =new UserAuthontication().LoggedInUserID;

            string FirstName; if (txtFirstName.Text=="") { throw new Exception("First Name Mandatory"); } FirstName = txtFirstName.Text;

            string LastName; if (txtLastName.Text=="") { throw new Exception("Last Name Mandatory"); } LastName = txtLastName.Text;

            string MiddleName; if (txtMiddleName.Text=="") { throw new Exception("Middle Name Mandatory"); } MiddleName = txtMiddleName.Text;

            //DateTime BirthDate; if () { throw new Exception(""); } Convert.ToDateTime(BirthDate = txtBirthDate.Text);

            string Address1;  Address1 = txtAddress1.Text;

            string Address2; Address2 = txtAddress2.Text;

            string City; if (false) { throw new Exception(""); } City = txtCity.Text;

            string State; if (false) { throw new Exception(""); } State = txtState.Text;

            string Country; if (false) { throw new Exception(""); } Country = txtCountry.Text;

            string WebSite; if (false) { throw new Exception(""); } WebSite = txtWebSite.Text;

            DateTime ModifiedDate; if (false) { throw new Exception(""); } Convert.ToDateTime(ModifiedDate = DateTime.Now);

            new UserController().Add( LoginUserID, FirstName, LastName, MiddleName, BirthDate, Address1, Address2, City, State, Country, WebSite, ModifiedDate);
        }
        catch (Exception ex)
        {
            divMessage = "<div class='error'>" + ex.Message + "</div>";
        }
    }
}
