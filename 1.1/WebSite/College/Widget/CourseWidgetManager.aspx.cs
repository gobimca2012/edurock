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

public partial class Collage_WidgetManager : WidgetManager
{


    private int InstituteCourseID
    {
        get
        {
            if (Request.Params["icid"] != null)
            {
                return Convert.ToInt32(Request.Params["icid"]);

            }
            else
            {
                return -1;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        LeftColumnID = "#widgetLeft";
        RightColumnID = "#widgetright";
    }
    protected void AddAjaxWidget(object sender, AjaxControl.AjaxEventArg e)
    {
        Guid WidgetID = new WidgetHelper().AddHTMLWidget(WidgetPageID, WidgetTypeEnum.HTMLWidget, (int)WidgetColumnEnum.LeftColumn);
        AddWidgetScript(LeftColumnID, WidgetID, ResolveUrl("~/User/Widget/html.aspx"));
    }
    protected void AddContentWidget(object sender, AjaxControl.AjaxEventArg e)
    {
        Guid WidgetID = new WidgetHelper().AddWidget(WidgetPageID, WidgetTypeEnum.Content, new UserAuthontication().LoggedInUserID.ToString(), (int)WidgetColumnEnum.LeftColumn);
        JScripter.Widget widgetScriper = new JScripter.Widget(this.Page, false);
        widgetScriper.AddWidget(LeftColumnID, GetWidgetContainnerID(WidgetID), ResolveUrl("~/User/Widget/AllContent.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID)+string.Format("&icid={0}",InstituteCourseID.ToString()));
    }
    protected void AddProfileWidget(object sender, AjaxControl.AjaxEventArg e)
    {
        Guid WidgetID = new WidgetHelper().AddWidget(WidgetPageID, WidgetTypeEnum.InstituteInfo, new UserAuthontication().LoggedInUserID.ToString(), "ProfileInfo", (int)WidgetColumnEnum.LeftColumn);
        JScripter.Widget widgetScriper = new JScripter.Widget(this.Page, false);
        widgetScriper.AddWidget(LeftColumnID, GetWidgetContainnerID(WidgetID), ResolveUrl("~/College/Widget/AboutInstitute.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID));
    }
    protected void AddRightHtml(object sender, AjaxControl.AjaxEventArg e)
    {
        Guid WidgetID = new WidgetHelper().AddHTMLWidget(WidgetPageID, WidgetTypeEnum.HTMLWidget, (int)WidgetColumnEnum.RightColumn);
        JScripter.Widget widgetScriper = new JScripter.Widget(this.Page, false);
        widgetScriper.AddWidget(RightColumnID, GetWidgetContainnerID(WidgetID), ResolveUrl("~/User/Widget/html.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID));
    }
    protected void AddRightShout(object sender, AjaxControl.AjaxEventArg e)
    {
        Guid WidgetID = new WidgetHelper().AddShoutLWidget(WidgetPageID, WidgetTypeEnum.ShoutWidget, (int)WidgetColumnEnum.RightColumn);
        JScripter.Widget widgetScriper = new JScripter.Widget(this.Page, false);
        widgetScriper.AddWidget(RightColumnID, GetWidgetContainnerID(WidgetID), ResolveUrl("~/User/Widget/Shout.aspx") + string.Format("?icid={0}", InstituteCourseID.ToString()) + "&wid=" + CustomHelper.GetGuidString(WidgetID));
    }
}
