using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

using Common;
using System.Web.UI.WebControls;

namespace BusinessLogic
{
    public class WidgetControl : AjaxPage
    {
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
                return data[0].WidgetColumn.ToString()+"_"+data[0].WidgetOrder.ToString();
            }
        }

        protected override void OnInitComplete(EventArgs e)
        {
            
            
            foreach (Control cl in this.Form.Controls)
            {
                if(cl.ID!=null)
                cl.ID=WidgetControlPrefix+"_"+cl.ID;
            }
            CloseButtonBuilder();
            base.OnInitComplete(e);
        }
        
        private void CloseButtonBuilder()
        {
            HyperLink lnkClose = (HyperLink)this.Page.FindControl("lnkClose");
            if (lnkClose != null)
            {
                new JScripter.Widget(this.Page, false).DeleteLinkButton(CustomHelper.GetGuidString(WidgetID),ResolveUrl("") ,lnkClose);
            }
        }
    }
}
