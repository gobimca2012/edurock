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

public partial class College_Widget_CourseWidgetPage : WidgetContainner
{
    private int LoginUserID
    {
        get;
        set;
    }

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
    protected override void OnLoad(EventArgs e)
    {
        LeftColumnID = "#widgetLeft";
        RightColumnID = "#widgetright";
        lnkShare.NavigateUrl = ResolveUrl("~/User/AjaxControl/ShareInfo.aspx") + "?conid=" + InstituteCourseID.ToString() + "&type=" + ((int)ContentTypeEnum.InstituteCourse).ToString();
        base.OnLoad(e);
    }
    protected override void GetWidgetsPageData(out WidgetHelper widgetData)
    {
        widgetData = new WidgetHelper();
        widgetData.GetPage(InstituteCourseID.ToString(), PageTypeEnum.InsituteCoursePage);
        LoginUserID = widgetData.LoginUserID;
    }
    protected override void GenerateWidgetPage(WidgetHelper widgetData)
    {
        JScripter.Widget objWidgetScript = new JScripter.Widget(this.Page, false);
        foreach (Widget wd in widgetData.LeftColumn)
        {
            if (wd.ContentType == (int)WidgetTypeEnum.HTMLWidget)
                LoadWidget(LeftColumnID, wd.WidgetID, ResolveUrl("~/User/Widget/html.aspx"));
            if (wd.ContentType == (int)WidgetTypeEnum.Content)
                objWidgetScript.AddWidget(LeftColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/AllContent.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID) + string.Format("&icid={0}", InstituteCourseID.ToString()));
            if (wd.ContentType == (int)WidgetTypeEnum.UserInfo)
                objWidgetScript.AddWidget(LeftColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/PublicUserInfoView.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
            if (wd.ContentType == (int)WidgetTypeEnum.InstituteInfo)
                objWidgetScript.AddWidget(LeftColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/college/Widget/AboutInstitute.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
        }
        foreach (Widget wd in widgetData.RightColumn)
        {
            if (wd.ContentType == (int)WidgetTypeEnum.HTMLWidget)
                LoadWidget(RightColumnID, wd.WidgetID, ResolveUrl("~/User/Widget/html.aspx"));
            if (wd.ContentType == (int)WidgetTypeEnum.Content)
                objWidgetScript.AddWidget(RightColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/AllContent.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
            if (wd.ContentType == (int)WidgetTypeEnum.UserInfo)
                objWidgetScript.AddWidget(RightColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/PublicUserInfoView.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
            if (wd.ContentType == (int)WidgetTypeEnum.ShoutWidget)
                objWidgetScript.AddWidget(RightColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/shout.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID) + string.Format("&icid={0}", InstituteCourseID.ToString()));
        }
    }
    protected override void CreateControls(Guid pageID)
    {
        if (!new UserAuthontication().IsOwn(LoginUserID))
        {
            lnkEdit.Visible = false;
            divEdit.Visible = false;
            divwidmanager.Visible = false;
            lnkShare.Visible = false;
            lnkEditContent.Visible=false;
        }
        if (new ShareController().GetItemEditAccessByLoginUserID(InstituteCourseID.ToString(), (int)ContentTypeEnum.InstituteCourse, new UserAuthontication().LoggedInUserID))
        {
            lnkEdit.Visible = true;
            lnkEditContent.Visible=true;
            divEdit.Visible = true;
            divwidmanager.Visible = true;
        }
        if (lnkEdit.Visible)
        {
            lnkEdit.NavigateUrl = ResolveUrl("~/college/widget/CourseWidgetPage.aspx") + "?icid=" + InstituteCourseID.ToString() + "&ed=e";

        }
        if (lnkEditContent.Visible)
        {
            lnkEditContent.NavigateUrl = ResolveUrl("~/College/Ajaxer/InstituteCourceInfo.aspx") + "?icid=" + InstituteCourseID.ToString();
        }
        if (IsEditable)
        {
            JScripter.DragNDrop DragNDropScripter = new JScripter.DragNDrop(this.Page, false);
            DragNDropScripter.MakeColumnDragNDrop(LeftColumnID, "dl", ResolveUrl("~/User/Action.aspx"));
            DragNDropScripter.MakeColumnDragNDrop(RightColumnID, "dl", ResolveUrl("~/User/Action.aspx"));
            objLoader.LoadPage("#widgetmanager", ResolveUrl("~/college/widget/CourseWidgetManager.aspx") + "?wpid=" + pageID.ToString() + string.Format("&icid={0}", InstituteCourseID.ToString()));
            if (lnkEdit.Visible)
            {
                lnkEdit.NavigateUrl = ResolveUrl("~/college/widget/CourseWidgetPage.aspx") + "?icid=" + InstituteCourseID.ToString();
                lnkEdit.Text = "Priview";
            }
        }
    }
}
