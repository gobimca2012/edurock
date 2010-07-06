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

public partial class User_DashBoard : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        objLoader.LoadPage("#icource", ResolveUrl("~/User/AjaxControl/InstituteCourceInfoView.aspx"));
        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.Collapspanel("#questiontrg", "#questiontrgbox");
        objEffect.Collapspanel("#messageHead", "#messagepn");
        objEffect.Collapspanel("#tut", "#tutbox");
        objEffect.Collapspanel("#courcel", "#icource");
    }
}
