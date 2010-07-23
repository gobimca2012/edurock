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

public partial class College_Ajaxer_InstituteUserInfo : AjaxPage
{
    private void FormValidation()
    {

        lnkUserAdd.EnableValidation = true;

        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkUserAdd.ClientID);
        objValidate.Medatory(txtEmail, "Please enter Email", this.Page);
        objValidate.Medatory(txtPassword, "Please enter Password", this.Page);
        objValidate.Medatory(txtUsername, "Please enter Username", this.Page);
        objValidate.DrowDownMendatory(ddUserType, "Please select UserType", this.Page, "0");





    }
    protected void Page_Load(object sender, EventArgs e)
    {
        FormValidation();
        new InstituteUserTypeController().BindInstituteUserType(ddUserType);
    }
    private void AddData()
    {


        string Username; if (true) { Username = HtmlHelper.ControlValue(txtUsername.ClientID); }

        string Password; if (true) { Password = HtmlHelper.ControlValue(txtPassword.ClientID); }
        string FirstName;
        FirstName = HtmlHelper.ControlValue(txtFirstName.ClientID);
        string Lastname;
        Lastname = HtmlHelper.ControlValue(txtLastName.ClientID);
       
        int UserType; if (true) { UserType = 1; }
        int InstituteUserType = Convert.ToInt32(HtmlHelper.ControlValue(ddUserType.ClientID));

        new LoginUserController().CreateUser(Username, Password,FirstName,Lastname,ConfigurationSettings.AppSettings["UserAvatar"].ToString(), txtEmail.Text, UserType, InstituteUserType);
        Response.Redirect("~/College/Ajaxer/InstituteUserInfoView.aspx");

    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();
    }
}
