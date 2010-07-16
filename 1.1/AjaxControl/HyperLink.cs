using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
namespace AjaxControl
{
    public class HyperLink:System.Web.UI.WebControls.HyperLink
    {
        public string ContainnerID
        {
            get;
            set;
        }
        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
            
        }
        protected override void OnPreRender(EventArgs e)
        {
            this.Attributes["href"] = "javascript:void(0);";
            new JScripter.Loader(this.Page, false).PostData(ContainnerID, ContainnerID, ResolveUrl(this.NavigateUrl), this.ClientID);
            this.NavigateUrl = "";
            
            base.OnPreRender(e);
        }
    }
}
