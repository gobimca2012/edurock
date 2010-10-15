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

public partial class Home : BasePage
{
    protected override void OnInit(EventArgs e)
    {
        this.IsLogginMandatory = false;
        base.OnInit(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.RemoveAll();
        JScripter.PopUp objPopup = new JScripter.PopUp(this.Page, true);
        objPopup.PopUpOpen(lnkBrowser, "#browsersupport", this.ResolveUrl("~/BrowserSupport.aspx"), "600", "300");
    }
}
