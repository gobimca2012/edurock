using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JScripter
{
    public class DatePicker
    {
        Page _thisPage;
        public DatePicker(Page thisPage)
        {
            JScripter.IncludeJavascriptFile("ui.datepicker.js", thisPage.ResolveUrl("~/Jscript/ui.datepicker.js"), thisPage);
            _thisPage = thisPage;
        }
        public DatePicker(Page thisPage,bool IsScripRequer)
        {
            if (IsScripRequer)
            {
                JScripter.IncludeJavascriptFile("ui.datepicker.js", thisPage.ResolveUrl("~/Jscript/ui.datepicker.js"), thisPage);
            }
            _thisPage = thisPage;
        }
        public void DatePickerTextBox(TextBox txtbox)
        {
            string script = "$('#"+txtbox.ClientID+"').datepicker(    {       dateFormat : 'mm/dd/yy',       minDate:new Date()    }    );";
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
        public void DateTextBoxValidator(string TextBox1ID, string TextBox2ID)
        {
            JScripter.IncludeJavascriptFile("Validation", _thisPage.ResolveUrl("~/MusesterScript/Validation1.3.js"), _thisPage);
            string Script = string.Format("DatePickerValidate('{0}','{1}');", TextBox1ID, TextBox2ID);
            InjectScript(Script, _thisPage);
        }
        public void DatePickerTextBox(TextBox txtbox,string DateFormat)
        {
            string script = string.Format("$('#{0}').datepicker({1});", txtbox.ClientID, "{dateFormat : '"+DateFormat+"'}");
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");
            aspxPage = _thisPage;
            Type cstype = aspxPage.GetType();            
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, script, true);
            }
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
