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
public partial class Modules_Login_LogOut : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        new UserAuthontication().LogOut();
        JScripter.Loader.RedirectPage(ResolveUrl("~/Logout.aspx"), this.Page);
        
    }
}
