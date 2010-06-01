using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Web;
namespace AjaxControl
{
    public class TextBox:System.Web.UI.WebControls.TextBox
    {
       
        public string value
        {
            get
            {
                if (HttpContext.Current.Request.Params[this.ClientID] != null)
                {
                    return HttpContext.Current.Request.Params[this.ClientID];
                }
                else
                {
                    return string.Empty;
                }

            }
        }
        protected override void OnInit(EventArgs e)
        {
            this.EnableViewState = false;
            base.OnInit(e);
        }
        
    }
}
