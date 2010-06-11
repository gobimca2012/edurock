using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AjaxControl
{
    public class Panel:System.Web.UI.WebControls.Panel
    {
        public string LoadUrl
        {
            get;
            set;
        }
        public string ContentID
        {
            get;
            set;
        }
        protected override void OnLoad(EventArgs e)
        {
           
            this.EnableViewState = false;
            JScripter.Loader objLoader = new JScripter.Loader((Page)HttpContext.Current.Handler, false);
            objLoader.LoadPage("#" + CreateContentDiv(), ResolveUrl(LoadUrl));
            CloseScript();
            base.OnLoad(e);
        }
        private void CloseScript()
        {
            HtmlGenericControl closeDive = new HtmlGenericControl();
            closeDive.ID = "closediv";
            LinkButton lnkClose = new LinkButton();
            lnkClose.ID = "lnkClose";
            lnkClose.Text = "Close";
            lnkClose.OnClientClick = string.Format("$('#{0}').hide()", this.ClientID);
            closeDive.Controls.Add(lnkClose);
            this.Controls.Add(closeDive);
        }
        private string CreateContentDiv()
        {
            HtmlGenericControl ContentDiv = new HtmlGenericControl();
            ContentDiv.ID = ContentID;            
            this.Controls.Add(ContentDiv);            
            return ContentDiv.ClientID;
        }
        
    }
}
