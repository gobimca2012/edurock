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
using DataEntity;

public partial class User_AccountSetting : BasePage
{
    private User UserData
    {
        get;
        set;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        JScripter.Tab objTab = new JScripter.Tab(this.Page,true);
        objTab.TabUl("#tabs");
        if (!this.IsPostBack)
        {
            var data=new UserController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
            if (data.Count > 0)
            {
                BindData();
                lnkAdd.Visible = false;
                lnkUpdate.Visible = true;
            }
            else
            {
                CommonController.BindDay(ddDay);
                CommonController.BindMonth(ddMonth);
                CommonController.BindYear(ddYear);
                lnkAdd.Visible = true;
                lnkUpdate.Visible = false;
            }
        }
    }
    protected void lnkUpdate_Click(object sender, EventArgs e)
    {
        EditData();
    }
    private void EditData()
    {              

        string FirstName; if (false) { throw new Exception(""); } FirstName = txtFirstName.Text;

        string LastName; if (false) { throw new Exception(""); } LastName = txtLastName.Text;

        string MiddleName; if (false) { throw new Exception(""); } MiddleName = txtMiddleName.Text;

        DateTime BirthDate; if (ddYear.SelectedValue == "0" || ddMonth.SelectedValue == "0" || ddDay.SelectedValue == "0") { throw new Exception("Please Enter your BirthDate"); } BirthDate = CommonController.GetDate(Convert.ToInt32(ddDay.SelectedValue), Convert.ToInt32(ddMonth.SelectedValue), Convert.ToInt32(ddYear.SelectedValue));

        string Address1; if (false) { throw new Exception(""); } Address1 = txtAddress1.Text;

        string Address2; if (false) { throw new Exception(""); } Address2 = txtAddress2.Text;

        string City; if (false) { throw new Exception(""); } City = txtCity.Text;

        string State; if (false) { throw new Exception(""); } State = txtState.Text;

        string Country; if (false) { throw new Exception(""); } Country = txtCountry.Text;

        string WebSite; if (false) { throw new Exception(""); } WebSite = txtWebSite.Text;

        new UserController().Add(new UserAuthontication().LoggedInUserID, FirstName, LastName, MiddleName, BirthDate, Address1, Address2, City, State, Country, WebSite);
    }
		
    private void AddData()
    {
        try
        {

            int LoginUserID; LoginUserID = new UserAuthontication().LoggedInUserID;

            string FirstName; if (txtFirstName.Text == "") { throw new Exception("First Name Mandatory"); } FirstName = txtFirstName.Text;

            string LastName; if (txtLastName.Text == "") { throw new Exception("Last Name Mandatory"); } LastName = txtLastName.Text;

            string MiddleName; if (txtMiddleName.Text == "") { throw new Exception("Middle Name Mandatory"); } MiddleName = txtMiddleName.Text;

            DateTime BirthDate; if (ddYear.SelectedValue == "0" || ddMonth.SelectedValue == "0" || ddDay.SelectedValue == "0") { throw new Exception("Please Enter your BirthDate"); } BirthDate = CommonController.GetDate(Convert.ToInt32(ddDay.SelectedValue), Convert.ToInt32(ddMonth.SelectedValue), Convert.ToInt32(ddYear.SelectedValue));

            string Address1; Address1 = txtAddress1.Text;

            string Address2; Address2 = txtAddress2.Text;

            string City; if (false) { throw new Exception(""); } City = txtCity.Text;

            string State; if (false) { throw new Exception(""); } State = txtState.Text;

            string Country; if (false) { throw new Exception(""); } Country = txtCountry.Text;

            string WebSite; if (false) { throw new Exception(""); } WebSite = txtWebSite.Text;

            DateTime ModifiedDate; if (false) { throw new Exception(""); } Convert.ToDateTime(ModifiedDate = DateTime.Now);

            new UserController().Add(LoginUserID, FirstName, LastName, MiddleName, BirthDate, Address1, Address2, City, State, Country, WebSite, ModifiedDate);
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    private void BindData()
    {
        var dataBunch = new UserController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            txtFirstName.Text = data.FirstName;

            txtLastName.Text = data.LastName;

            txtMiddleName.Text = data.MiddleName;

            ddDay.SelectedValue = data.BirthDate.Value.Day.ToString();
            ddMonth.SelectedValue = data.BirthDate.Value.Month.ToString();
            ddYear.SelectedValue = data.BirthDate.Value.Year.ToString();

            txtAddress1.Text = data.Address1;

            txtAddress2.Text = data.Address2;

            txtCity.Text = data.City;

            txtState.Text = data.State;

            txtCountry.Text = data.Country;

            txtWebSite.Text = data.WebSite;



        }
    }
    protected void lnkAdd_Click(object sender, EventArgs e)
    {
        AddData();
    }
}
