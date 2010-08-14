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
        private string WidgetControlPrefix
        {
            get
            {
                var data = new WidgetController().GetbyWidgetID(WidgetID);
                return data[0].WidgetColumn.ToString() + "_" + data[0].WidgetOrder.ToString();
            }
        }

        protected override void OnInitComplete(EventArgs e)
        {


            foreach (Control cl in this.Form.Controls)
            {
                if (cl.ID != null)
                {
                    cl.ID = WidgetControlPrefix + "_" + cl.ID;
                    foreach (Control innerCl in cl.Controls)
                    {
                        if (innerCl.ID != null)
                            innerCl.ID = WidgetControlPrefix + "_" + innerCl.ID;
                    }
                }
            }
            CloseButtonBuilder();
            base.OnInitComplete(e);
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
