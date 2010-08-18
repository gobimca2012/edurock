using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

using Common;
using System.Web.UI.WebControls;
using System.Web;

namespace BusinessLogic
{

    public class WidgetControl : AjaxPage
    {
        protected string GetWidgetBoxID(Guid WidgetID)
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
        protected Guid WidgetID
        {
            get
            {
                if (Request.Params["wid"] != null)
                {
                    AjaxState["wid"] = Request.Params["wid"];
                }
                return new Guid(AjaxState["wid"]);
            }
        }
        //private string _WidgetControlPrefix
        //{
        //    get
        //    {
        //        var data = new WidgetController().GetbyWidgetID(WidgetID);
        //        return data[0].WidgetColumn.ToString() + "_" + data[0].WidgetOrder.ToString();
        //    }
        //}

        private string _WidgetControlPrefix;

        protected override void OnInitComplete(EventArgs e)
        {
            var data = new WidgetController().GetbyWidgetID(WidgetID);
            _WidgetControlPrefix = data[0].WidgetColumn.ToString() + "_" + data[0].WidgetOrder.ToString();

            ControlPrefixLoop(this.Form);
            CloseButtonBuilder();
            base.OnInitComplete(e);
        }
        private bool ControlPrefixLoop(Control cl)
        {
            AddControlPrefix(cl);
            if (cl.Controls.Count > 0)
            {
                for (int i = 0; i < cl.Controls.Count; i++)
                {
                    Control innerCl = cl.Controls[i];
                    if (innerCl.ID != null)
                    {
                        AddControlPrefix(innerCl);
                        if (innerCl.Controls.Count > 0)
                        {
                            ControlPrefixLoop(innerCl);
                        }
                    }                   
                }               
                return true;
            }
            else
            {
                return true;
            }
        }
        private void AddControlPrefix(Control cl)
        {
            cl.ID = _WidgetControlPrefix + "_" + cl.ID;

        }
        private void CloseButtonBuilder()
        {
            HyperLink lnkClose = (HyperLink)this.Page.FindControl("lnkClose");
            if (lnkClose != null)
            {
                new JScripter.Widget(this.Page, false).DeleteLinkButton(CustomHelper.GetGuidString(WidgetID), ResolveUrl(""), lnkClose);
            }
        }

    }
}
