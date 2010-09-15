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
            lilogout.Visible = false;
            objLoader.LoadPage("#registernew", ResolveUrl("~/All/Ajaxer/RegisterUser.aspx"));
            
        }
        else
        {
            lnkLogout.Visible = true;
            lilogout.Visible = true;
            liCreate.Visible = false;
            lnkLogin.Text =string.Format("<div class='btn'>Welcome {0}</div>", new UserAuthontication().LoggedInUserName);
            if (new UserAuthontication().LoggedInUserName.Trim().ToLower() == "admin")
            {
                ActionMenu.Controls.Add(CommonController.GetControl("~/LayoutControl/Menu/AdminNavigation.ascx"));

               
               
            }
            else if (new UserAuthontication().UserType == UserTypeEnum.College)
            {
                //ActionMenu.Controls.Add(CommonController.GetControl("~/LayoutControl/Menu/CollegeMenu.ascx"));
                //lnkAccountSetting.NavigateUrl = "~/College/Admin.aspx";
            }
            else if (new UserAuthontication().UserType == UserTypeEnum.Student)
            {
                //ActionMenu.Controls.Add(CommonController.GetControl("~/LayoutControl/Menu/UserMenu.ascx"));
               
               
              
            }
            
        }

    }

    protected void lnkLogout_Click(object sender, EventArgs e)
    {
        new UserAuthontication().LogOut();
        Response.Redirect("~/Home.aspx");
    }
}
