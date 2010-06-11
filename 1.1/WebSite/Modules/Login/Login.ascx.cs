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

public partial class Modules_Login_Login : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkLogin_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text != "" && txtPassword.Text != null)
        {
            UserAuthontication objNewAuth = new UserAuthontication();
            if (new UserAuthontication().ValidateUser(txtUsername.Text, txtPassword.Text))
            {
                JScripter.Loader.RedirectPage(ResolveUrl("~/Home.aspx"), this.Page);
            }
            Response.Redirect("~/Home.aspx");
        }
    }
}
