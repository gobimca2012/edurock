using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Controller;

public partial class Expired : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PortalSetting portalSetting = new PortalSetting();
        portalSetting= new PortalSettingHelper().Get();
        lnkUpgrade.NavigateUrl = string.Format("http://www.vt3soft.com/VT3Products/tabid/102/cpid/{0}/t/up/Default.aspx", portalSetting.CustomerProductID);
    }
}
