using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Web;
using DataEntity;

namespace BusinessLogic
{
    public abstract class WidgetContainner:AjaxPage
    {
        WidgetHelper widgetData;
        protected string LeftColumnID
        {
            get;
            set;
        }
        protected string RightColumnID
        {
            get;
            set;
        }
        protected bool IsEditable
        {
            get
            {
                if (Request.Params["ed"] != null)
                {
                    HttpContext.Current.Session[SessionName.WidgetEditMode.ToString()] = "1";
                    return true;
                }
                else
                {
                    HttpContext.Current.Session[SessionName.WidgetEditMode.ToString()] = "0";
                    return false;
                }
            }
        }
        protected abstract void GetWidgetsPageData(out WidgetHelper widgetData);
        protected abstract void CreateControls(Guid pageID);
        protected void LoadWidget(string ColumnID,Guid WidgetID,string WidgetUrl)
        {
            string _WidUrl = WidgetUrl;
            if (_WidUrl.Contains("?"))
            {
                _WidUrl+="&wid="+ CustomHelper.GetGuidString(WidgetID);
            }
            else
            {
                   _WidUrl+="?wid="+ CustomHelper.GetGuidString(WidgetID);
            }
            if(IsEditable)
            {
                _WidUrl+="&ed=e";
            }
            objWidgetScript.AddWidget(ColumnID, GetWidgetBoxID(WidgetID), _WidUrl);
        }
        protected string GetWidgetBoxID(Guid WidgetID)
        {
            string ID = string.Format("foo_{0}", WidgetID.ToString().Replace("-", ""));
            return ID;
        }
        JScripter.Widget objWidgetScript;
        protected override void OnInit(EventArgs e)
        {
            objWidgetScript = new JScripter.Widget(this.Page, false);
            base.OnInit(e);
        }
        protected  virtual void GenerateWidgetPage(WidgetHelper widgetData)
        {
            JScripter.Widget objWidgetScript = new JScripter.Widget(this.Page, false);
            foreach (Widget wd in widgetData.LeftColumn)
            {
                if (wd.ContentType == (int)WidgetTypeEnum.HTMLWidget)
                    LoadWidget(LeftColumnID, wd.WidgetID, ResolveUrl("~/User/Widget/html.aspx"));
                if (wd.ContentType == (int)WidgetTypeEnum.Content)
                    objWidgetScript.AddWidget(LeftColumnID, GetWidgetBoxID(wd.WidgetID), ResolveUrl("~/User/Widget/AllContent.aspx") + "?wid=" + CustomHelper.GetGuidString(wd.WidgetID));
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
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            GetWidgetsPageData(out widgetData);
            GenerateWidgetPage(widgetData);
            CreateControls(widgetData.PageID);
            base.OnLoad(e);
        }
    }
}
