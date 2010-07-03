using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using BusinessLogic;

public partial class MasterPage_Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        JScripter.Loader objLoader = new JScripter.Loader(this.Page, false);
        if (!new UserAuthontication().IsLoggedIn)
        {
            lilogout.Visible = false;
            liAccountsetting.Visible = false;
        }
        else
        {
            lnkLogout.Visible = true;
            lilogout.Visible = false;
            liCreate.Visible = false;
            lnkLogin.Text = new UserAuthontication().LoggedInUserName;
            

        }
    }
    protected void lnkLogout_Click(object sender, EventArgs e)
    {
        new UserAuthontication().LogOut();
        Response.Redirect("~/Home.aspx");
    }
}
