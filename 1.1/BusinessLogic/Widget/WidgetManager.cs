using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Web;

namespace BusinessLogic
{
    public class WidgetManager : AjaxPage
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
        protected Guid WidgetPageID
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
        protected string GetWidgetContainnerID(Guid WidgetID)
        {
            string ID = string.Format("foo_{0}", WidgetID.ToString().Replace("-", ""));
            return ID;
        }
        protected bool IsEditable
        {
            get
            {
                if (HttpContext.Current.Session[SessionName.WidgetEditMode.ToString()] != null)
                {
                    if (HttpContext.Current.Session[SessionName.WidgetEditMode.ToString()].ToString() == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        JScripter.Widget widgetScriper;
        public void AddWidgetScript(string ColumnID, Guid WidgetID,string URL)
        {
            if (URL.Contains("?"))
            {
                URL += "&wid=" + CustomHelper.GetGuidString(WidgetID);
            }
            else
            {
                URL += "?wid=" + CustomHelper.GetGuidString(WidgetID);
            }
            //URL += "&ed=e";
            widgetScriper.AddWidget(ColumnID, GetWidgetContainnerID(WidgetID),URL);
        }
        protected override void OnInit(EventArgs e)
        {
            widgetScriper = new JScripter.Widget(this.Page, false);
            base.OnPreLoad(e);
            base.OnInit(e);
        }

    }
}
