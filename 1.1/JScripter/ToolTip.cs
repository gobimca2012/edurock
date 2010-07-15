using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JScripter
{
    public class ToolTip
    {
         Page _thisPage;
        public ToolTip(Page thisPage)
        {
            //JScripter.IncludeJavascriptFile("ui.datepicker.js", thisPage.ResolveUrl("~/Jscript/ui.datepicker.js"), thisPage);
            _thisPage = thisPage;
        }
        public ToolTip(Page thisPage, bool IsScripRequer)
        {
            if (IsScripRequer)
            {
                //JScripter.IncludeJavascriptFile("ui.datepicker.js", thisPage.ResolveUrl("~/Jscript/ui.datepicker.js"), thisPage);
            }
            _thisPage = thisPage;
        }
        public void AjaxToolTip(HyperLink lnkTool,string Url,string ContainnerID)
        {
            string Script = string.Format("$('#{0}').ajaxToolTip('#{1}','{2}');", lnkTool.ClientID, ContainnerID, Url);
            //string script = string.Format("$('#{0}').datepicker({1});", txtbox.ClientID,"{dateFormat : 'mm/dd/yy'}");
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");

            aspxPage = _thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, Script, true);
            }
        }
    }
}
