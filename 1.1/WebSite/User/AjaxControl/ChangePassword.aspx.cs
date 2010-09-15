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

public partial class User_AjaxControl_ChangePassword :AjaxPage
{
    private void FormValidation()
    {
        btnChange.EnableValidation = true;

        JScripter.Validation objValidate = new JScripter.Validation(this.Page, btnChange.ClientID);
        objValidate.Medatory(txtConfirmPassword, "Please enter Confirm Password", this.Page);
        objValidate.Medatory(txtCurrentPassword, "Please enter Current Password", this.Page);
        objValidate.Medatory(txtNewPassword, "Please enter new Password", this.Page);
        objValidate.ComparttextBox(txtConfirmPassword, "Please enter same password in confirm password", this.Page,txtNewPassword );
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        FormValidation();
    }
    protected void AjaxChangePassword(object sender, AjaxControl.AjaxEventArg e)
    {
        try
        {
            string currentPassword = HtmlHelper.ControlValue(txtCurrentPassword.ClientID);
            string newPassword = HtmlHelper.ControlValue(txtNewPassword.ClientID);
            string confirPassword = HtmlHelper.ControlValue(txtConfirmPassword.ClientID);
            if (newPassword != confirPassword)
            {
                throw new Exception("Please enter same Password in new password and confirm password");
            }
            if (!new LoginUserController().ChangePassword(new UserAuthontication().LoggedInUserID, currentPassword, newPassword))
            {
                throw new Exception("system are not able to change password please correct your current password or please contact to administrator");
            }
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0}  has been added Successfully", "Password");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = string.Format("<div class='error'>{0}</div>", ex.Message);
        }

    }
}
