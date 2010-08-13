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
    private int LoginUserID
    {
        get
        {
            return Convert.ToInt32(Request.Params["usid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lnkProfile.NavigateUrl = ResolveUrl("~/User/User.aspx") + "?usid=" + new UserAuthontication().LoggedInUserID.ToString();
        LeftColumnID = "#widgetLeft";
        RightColumnID = "#widgetright";
        WidgetHelper widgetData=new WidgetHelper();
        if(Request.Params["usid"]!=null)
        widgetData.GetPage(LoginUserID, PageTypeEnum.ProfilePage);
        objLoader.LoadPage("#widgetmanager", ResolveUrl("~/User/WidgetManager.aspx")+"?wpid="+widgetData.PageID.ToString());
        JScripter.Widget objWidgetScript=new JScripter.Widget(this.Page,false);
        foreach(Widget wd in widgetData.LeftColumn)
        {
            if(wd.ContentType==(int)WidgetTypeEnum.HTMLWidget)
                objWidgetScript.AddWidget(LeftColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/html.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
            if (wd.ContentType == (int)WidgetTypeEnum.Content)
                objWidgetScript.AddWidget(LeftColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/AllContent.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
            if (wd.ContentType == (int)WidgetTypeEnum.UserInfo)
                objWidgetScript.AddWidget(LeftColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/PublicUserInfoView.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
        }
        foreach (Widget wd in widgetData.RightColumn)
        {
            if (wd.ContentType == (int)WidgetTypeEnum.HTMLWidget)
                objWidgetScript.AddWidget(RightColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/html.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
            if (wd.ContentType == (int)WidgetTypeEnum.Content)
                objWidgetScript.AddWidget(RightColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/AllContent.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
            if (wd.ContentType == (int)WidgetTypeEnum.UserInfo)
                objWidgetScript.AddWidget(RightColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/PublicUserInfoView.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
        }
        JScripter.DragNDrop DragNDropScripter = new JScripter.DragNDrop(this.Page, false);
        DragNDropScripter.MakeColumnDragNDrop(LeftColumnID, "dl", ResolveUrl("~/User/Action.aspx"));
        DragNDropScripter.MakeColumnDragNDrop(RightColumnID, "dl", ResolveUrl("~/User/Action.aspx"));
    }
}
