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
using AjaxControl;

public partial class Modules_Login_Login : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LnkLoginAjaxClick(object sender, AjaxEventArg e)
    {
        if (txtUsername.value != "" && txtPassword.value != null)
        {
            UserAuthontication objNewAuth = new UserAuthontication();
            if (new UserAuthontication().ValidateUser(txtUsername.value, txtPassword.value))
            {
                JScripter.Loader.RedirectPage(ResolveUrl("~/Home.aspx"),this.Page);
            }
        }
    }
}
