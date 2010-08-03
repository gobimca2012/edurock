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

public partial class User_AccountSetting : BasePage
{
    private User UserData
    {
        get;
        set;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //JScripter.Tab objTab = new JScripter.Tab(this.Page,true);
        //objTab.TabUl("#tabs");
        objLoader.LoadPage("#lander", ResolveUrl("~/User/AjaxControl/AccountSettingMenu.aspx"));
        //objLoader.LoadPage("#education", ResolveUrl("~/User/AjaxControl/EducationView.aspx"));
        
    }
   
}
