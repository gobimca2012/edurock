using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace JScripter
{
    public class TinyMCE
    {
        Page _thisPage;
        public TinyMCE(Page thisPage)
        {
           // JScripter.IncludeJavascriptFile("ui.datepicker.js", thisPage.ResolveUrl("~/Jscript/ui.datepicker.js"), thisPage);
            _thisPage = thisPage;

        }
        public void Create()
        {
            string Script = @"tinyMCE.init({
                                mode : 'textareas',
                                theme : 'advanced',
                                theme_advanced_buttons1: 'bold, italic,underline',
                                theme_advanced_buttons2:'',
                                theme_advanced_buttons3:'',
                                editor_selector : 'mceEditor'});";
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
