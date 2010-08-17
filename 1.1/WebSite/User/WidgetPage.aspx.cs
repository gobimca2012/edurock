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
            if (Request.Params["usid"] != null)
                return Convert.ToInt32(Request.Params["usid"]);
            else
                return new UserAuthontication().LoggedInUserID;
        }
    }
    private void CreateControls(Guid pageID)
    {
       
        if (!new UserAuthontication().IsOwn(LoginUserID))
        {
            lnkEdit.Visible = false;
            divEdit.Visible = false;
            divwidmanager.Visible = false;

        }
        else
        {
            lnkEdit.NavigateUrl = ResolveUrl("~/User/WidgetPage.aspx") + "?usid=" + new UserAuthontication().LoggedInUserID.ToString() + "&ed=e";
        }
        if (IsEditable)
        {
            JScripter.DragNDrop DragNDropScripter = new JScripter.DragNDrop(this.Page, false);
            DragNDropScripter.MakeColumnDragNDrop(LeftColumnID, "dl", ResolveUrl("~/User/Action.aspx"));
            DragNDropScripter.MakeColumnDragNDrop(RightColumnID, "dl", ResolveUrl("~/User/Action.aspx"));
            objLoader.LoadPage("#widgetmanager", ResolveUrl("~/User/WidgetManager.aspx") + "?wpid=" + pageID.ToString());
            if (lnkEdit.Visible)
            {
                lnkEdit.NavigateUrl = ResolveUrl("~/User/WidgetPage.aspx") + "?usid=" + new UserAuthontication().LoggedInUserID.ToString() ;
                lnkEdit.Text = "Priview";
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        LeftColumnID = "#widgetLeft";
        RightColumnID = "#widgetright";
        WidgetHelper widgetData=new WidgetHelper();        
        widgetData.GetPage(LoginUserID, PageTypeEnum.ProfilePage);        
        JScripter.Widget objWidgetScript=new JScripter.Widget(this.Page,false);
        foreach(Widget wd in widgetData.LeftColumn)
        {
            if (wd.ContentType == (int)WidgetTypeEnum.HTMLWidget)
                LoadWidget(LeftColumnID, wd.WidgetID, ResolveUrl("~/User/Widget/html.aspx"));                
            if (wd.ContentType == (int)WidgetTypeEnum.Content)
                objWidgetScript.AddWidget(LeftColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/AllContent.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
            if (wd.ContentType == (int)WidgetTypeEnum.UserInfo)
                objWidgetScript.AddWidget(LeftColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/PublicUserInfoView.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
        }
        foreach (Widget wd in widgetData.RightColumn)
        {
            if (wd.ContentType == (int)WidgetTypeEnum.HTMLWidget)
                LoadWidget(RightColumnID, wd.WidgetID, ResolveUrl("~/User/Widget/html.aspx"));
            if (wd.ContentType == (int)WidgetTypeEnum.Content)
                objWidgetScript.AddWidget(RightColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/AllContent.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
            if (wd.ContentType == (int)WidgetTypeEnum.UserInfo)
                objWidgetScript.AddWidget(RightColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/PublicUserInfoView.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
        }
        CreateControls(widgetData.PageID);
        
    }
}
