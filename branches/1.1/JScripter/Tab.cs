using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace JScripter
{
    public class Tab
    {
        Page _thisPage;
        public Tab(Page thisPage)
        {
            JScripter.IncludeJavascriptFile("tab", thisPage.ResolveUrl("~/Jscript/ui.tabs.js"), thisPage);
            _thisPage = thisPage;
        }
        public Tab(Page thisPage, bool IsScripRequer)
        {
            if (IsScripRequer)
            {
                JScripter.IncludeJavascriptFile("ui", thisPage.ResolveUrl("~/Jscript/jquery-ui.js"), thisPage);
                JScripter.IncludeJavascriptFile("tab", thisPage.ResolveUrl("~/Jscript/ui.tabs.js"), thisPage);
            }
            _thisPage = thisPage;
        }
        public void TabUl(string ContainnerID)
        {
            //string script = "$('#" + txtbox.ClientID + "').datepicker(    {       dateFormat : 'mm/dd/yy',       minDate:new Date()    }    );";
            string script = string.Format("$('{0}').tabs();", ContainnerID);
            //string script = string.Format("$('#{0}').datepicker({1});", txtbox.ClientID,"{dateFormat : 'mm/dd/yy'}");
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");

            aspxPage = _thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, script, true);
            }
        }
    }
}
