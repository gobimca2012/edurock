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
    protected void Page_Load(object sender, EventArgs e)
    {
        new InstituteUserTypeController().BindInstituteUserType(ddUserType);
    }
    private void AddData()
    {


        string Username; if (true) { Username = HtmlHelper.ControlValue(txtUsername.ClientID); }

        string Password; if (true) { Password = HtmlHelper.ControlValue(txtPassword.ClientID); }

        int UserType; if (true) { UserType = 1; }
        int InstituteUserType = Convert.ToInt32(HtmlHelper.ControlValue(ddUserType.ClientID));

        new LoginUserController().CreateUser(Username, Password, txtEmail.Text, UserType, InstituteUserType);
        Response.Redirect("~/College/Ajaxer/InstituteUserInfoView.aspx");

    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();
    }
}
