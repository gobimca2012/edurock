using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using BusinessLogic;
public partial class MasterPage_StaticSite : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkBuilding();
    }

    private void LinkBuilding()
    {
        if(new UserAuthontication().IsLoggedIn)
        {
            if (ConfigurationSettings.AppSettings["AdminUser"] == new UserAuthontication().LoggedInUserName)
            {
                lnkAdmin.Visible = true;
            }
        }
    }
}
