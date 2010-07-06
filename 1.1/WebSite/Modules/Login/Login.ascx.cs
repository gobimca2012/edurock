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
            LoginUser loginData = new UserAuthontication().ValidateUser(txtUsername.Text, txtPassword.Text);
            if (loginData!=null)
            {
                if (loginData.UserType == 1)
                {
                    JScripter.Loader.RedirectPage(ResolveUrl("~/User/DashBoard.aspx"), this.Page);
                  
                }
                else
                {
                    JScripter.Loader.RedirectPage(ResolveUrl("~/College/DashBoard.aspx"), this.Page);
                    
                }
                Response.Redirect("~/User/DashBoard.aspx");
            }
            
        }
    }
}
