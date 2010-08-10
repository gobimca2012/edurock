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
    protected void Page_Load(object sender, EventArgs e)
    {

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
                throw new Exception("system are not able to change password please contact to administrator");
            }
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0}  has been added Successfully", "Password");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = string.Format("<div class='error'>{0}</div>", ex.Message);
        }

    }
}
