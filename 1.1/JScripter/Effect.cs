using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JScripter
{
    public class Effect
    {
        Page _thisPage;
        public Effect(Page thisPage, bool IsScriptFileLoadNeed)
        {
            if (IsScriptFileLoadNeed)
            {
                //JScripter.IncludeJavascriptFile("Jquery1.3", thisPage.ResolveUrl("~/MusesterScript/jquery-1.3.2.js"), thisPage);
                //JScripter.IncludeJavascriptFile("JqueryUI", thisPage.ResolveUrl("~/MusesterScript/ui.core.js"), thisPage);                
            }
            _thisPage = thisPage;
        }

        public void ShowonClick(LinkButton Lnk, string ContainerId)
        {
            Lnk.Attributes["onclick"] = string.Format("$('{0}').show('slow');",  ContainerId);
            Lnk.Attributes["href"] = "javascript:void(0);";
        }
        public void HideOnClick(LinkButton Lnk, string ContainerId)
        {
            Lnk.Attributes["onclick"] = string.Format("$('{0}').hide('slow');", ContainerId);
            Lnk.Attributes["href"] = "javascript:void(0);";
        }


        public void CollSpan(string H3ID)
        {
            JScripter.IncludeJavascriptFile("VTEffect", _thisPage.ResolveUrl("~/MusesterScript/VTEffect.js"), _thisPage);       
            String Script = string.Format("$('{0}').Collapspanel();", H3ID);
            InjectScript(Script, _thisPage);
        }
        public void ToolTiponHover(string HoverID,string Message)
        {
            string ToolTipOutBox =  Message; ;
            String Script = string.Format("$('#{0}').TipMouseHover('{1}');", HoverID, ToolTipOutBox);
            InjectScript(Script, _thisPage);
        }
        public string getCollSpanScript(string H3ID)
        {
            JScripter.IncludeJavascriptFile("VTEffect", _thisPage.ResolveUrl("~/MusesterScript/VTEffect.js"), _thisPage);
            String Script = string.Format("$('{0}').Collapspanel();", H3ID);
            return Script;
        }
        public string getCollSpanScript(string H3ID,string SelectedID)
        {
            JScripter.IncludeJavascriptFile("VTEffect", _thisPage.ResolveUrl("~/MusesterScript/VTEffect.js"), _thisPage);
            String Script = string.Format("$('{0}').Collapspanel('{1}');", H3ID, SelectedID);
            return Script;
        }
        private void InjectScript(string Script, System.Web.UI.Page thisPage)
        {
            string script = Script;
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");
            aspxPage = thisPage;
            Type cstype = aspxPage.GetType();
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, script, true);
            }

        }
    }
}
