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

public partial class LayoutControl_HeaderNavigation : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        JScripter.Loader objLoader = new JScripter.Loader(this.Page, false);
        if (!new UserAuthontication().IsLoggedIn)
        {
            lnkLogout.Visible = false;
            lnkAccountSetting.Visible = false;
        }
        else
        {
            lnkLogout.Visible = true;
            
            lnkCreate.Visible = false;
            lnkLogin.Text = new UserAuthontication().LoggedInUserName;
            if (new UserAuthontication().UserType == UserTypeEnum.College)
            {
                ActionMenu.Controls.Add(CommonController.GetControl("~/LayoutControl/Menu/CollegeMenu.ascx"));
            }
            if (new UserAuthontication().UserType == UserTypeEnum.Student)
            {
                ActionMenu.Controls.Add(CommonController.GetControl("~/LayoutControl/Menu/UserMenu.ascx"));
            }
            
        }

    }

    protected void lnkLogout_Click(object sender, EventArgs e)
    {
        new UserAuthontication().LogOut();
    }
}
