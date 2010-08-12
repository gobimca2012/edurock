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
using Common;

public partial class User_WidgetManager : AjaxPage
{
    private Guid PageID
    {
        get
        {
            if (Request.Params["wpid"] != null)
            {
                AjaxState["wpid"] = Request.Params["wpid"];
            }
            return new Guid(AjaxState["wpid"]);
        }
        
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void AddAjaxWidget(object sender, AjaxControl.AjaxEventArg e)
    {
       Guid WidgetID= new WidgetHelper().AddHTMLWidget(PageID, WidgetTypeEnum.HTMLWidget);
        JScripter.Widget widgetScriper = new JScripter.Widget(this.Page, false);
        widgetScriper.AddWidget("#widgetbox", CustomHelper.GetGuidString(WidgetID), ResolveUrl("~/User/Widget/html.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID));
    }
    protected void AddContentWidget(object sender, AjaxControl.AjaxEventArg e)
    {
        Guid WidgetID = new WidgetHelper().AddWidget(PageID, WidgetTypeEnum.Content,new UserAuthontication().LoggedInUserID.ToString());
        JScripter.Widget widgetScriper = new JScripter.Widget(this.Page, false);
        widgetScriper.AddWidget("#widgetbox", CustomHelper.GetGuidString(WidgetID), ResolveUrl("~/User/Widget/AllContent.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID));
    }
    protected void AddProfileWidget(object sender, AjaxControl.AjaxEventArg e)
    {
        Guid WidgetID = new WidgetHelper().AddWidget(PageID, WidgetTypeEnum.UserInfo, new UserAuthontication().LoggedInUserID.ToString(),"ProfileInfo");
        JScripter.Widget widgetScriper = new JScripter.Widget(this.Page, false);
        widgetScriper.AddWidget("#widgetbox", CustomHelper.GetGuidString(WidgetID), ResolveUrl("~/User/Widget/PublicUserInfoView.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID));
    }
}
