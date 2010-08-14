using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Web;

namespace BusinessLogic
{
    public class WidgetContainner:AjaxPage
    {
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

    }
}
