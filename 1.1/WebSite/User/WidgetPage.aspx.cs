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
using Common;

public partial class User_WidgetPage : WidgetContainner
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WidgetHelper widgetData=new WidgetHelper();
        widgetData.GetPage(new UserAuthontication().LoggedInUserID, PageTypeEnum.ProfilePage);
        objLoader.LoadPage("#widgetmanager", ResolveUrl("~/User/WidgetManager.aspx")+"?wpid="+widgetData.PageID.ToString());
        JScripter.Widget objWidgetScript=new JScripter.Widget(this.Page,false);
        foreach(Widget wd in widgetData.LeftColumn)
        {
            if(wd.ContentType==(int)WidgetTypeEnum.HTMLWidget)
                objWidgetScript.AddWidget("#widgetbox", CustomHelper.GetGuidString(wd.WidgetID), ResolveUrl("~/User/Widget/html.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
        }
    }
}
