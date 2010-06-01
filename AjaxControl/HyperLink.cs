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
            new JScripter.Loader(this.Page, false).PostData(ContainnerID, ContainnerID, ResolveUrl(this.NavigateUrl), this);
            this.NavigateUrl = "";
            base.OnLoad(e);
        }
    }
}
