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

public partial class College_UserControl_AddInstituteInfo : System.Web.UI.UserControl
{
    private Institute Data
    {
        get;
        set;
    }
    private bool IsEdit
    {
        get
        {
            if (ViewState["IsEdit"] != null)
            {
                return Convert.ToBoolean(ViewState["IsEdit"].ToString());
            }
            else
            {
                return false;
            }
        }
        set
        {
            ViewState["IsEdit"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            InstituteController.BindCollegeTye(ddCollegeType);
            var dataBunch = new InstituteController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
            if (dataBunch.Count > 0)
            {
                Data = dataBunch[0];
                BindData();
                IsEdit = true;
            }
            else
            {
               
                IsEdit = false;
            }
        }
    }
    private void AddData()
    {
        try
        {           

            int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

            string Name; if (false) { throw new Exception(""); } Name = txtName.Text;

            string Address; if (false) { throw new Exception(""); } Address = txtAddress.Text;

            string CityName; if (false) { throw new Exception(""); } CityName = txtCityName.Text;

            string StateName; if (false) { throw new Exception(""); } StateName = txtStateName.Text;

            string CountryName; if (false) { throw new Exception(""); } CountryName = txtCountryName.Text;

            string TelePhone; if (false) { throw new Exception(""); } TelePhone = txtTelePhone.Text;

            string Fax; if (false) { throw new Exception(""); } Fax = txtFax.Text;

            string Email; if (false) { throw new Exception(""); } Email = txtEmail.Text;

            string WebSite; if (false) { throw new Exception(""); } WebSite = txtWebSite.Text;

            int CollegeType; if (false) { throw new Exception(""); } CollegeType = Convert.ToInt32(ddCollegeType.SelectedValue);

            string ShortName; if (false) { throw new Exception(""); } ShortName = txtShortName.Text;

            string Description; if (false) { throw new Exception(""); } Description = txtDescription.Text;

            DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;

            bool IsDeleted; if (false) { throw new Exception(""); } IsDeleted = false;

            new InstituteController().Add(LoginUserID, Name, Address, CityName, StateName, CountryName, TelePhone, Fax, Email, WebSite, CollegeType, ShortName, Description, ModifiedDate, IsDeleted,IsEdit);
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }


    private int InstituteID
    {
        get;
        set;
    }
    private void BindData()
    {
        //var dataBunch = new InstituteController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);
        //if (dataBunch.Count > 0)
        {
            var data = Data;

            InstituteID = data.InstituteID;            

            txtName.Text = data.Name;

            txtAddress.Text = data.Address;

            txtCityName.Text = data.CityName;

            txtStateName.Text = data.StateName;

            txtCountryName.Text = data.CountryName;

            txtTelePhone.Text = data.TelePhone;

            txtFax.Text = data.Fax;

            txtEmail.Text = data.Email;

            txtWebSite.Text = data.WebSite;

            ddCollegeType.SelectedValue = data.CollegeType.ToString();

            txtShortName.Text = data.ShortName;

            txtDescription.Text = data.Description;

           

        }
    }



    protected void lnkAdd_Click(object sender, EventArgs e)
    {
        AddData();
    }
}
