using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace JScripter
{
    public class Validation
    {
        public Validation(Page thisPage,LinkButton lnkSubmitButton)
        {
            JScripter.IncludeJavascriptFile("Validation",thisPage.ResolveUrl("~/MusesterScript/Validation1.3.js"), thisPage);
            string Script = string.Format("$('#{0}').ValidateButton();", lnkSubmitButton.ClientID);
            InjectScript(Script, thisPage);
        }
        public Validation(Page thisPage, LinkButton lnkSubmitButton,bool IsloadScript)
        {
            if (IsloadScript)
            {
                JScripter.IncludeJavascriptFile("Validation", thisPage.ResolveUrl("~/MusesterScript/Validation1.3.js"), thisPage);
            }
            string Script = string.Format("$('#{0}').ValidateButton();", lnkSubmitButton.ClientID);
            InjectScript(Script, thisPage);
        }
        public Validation(Page thisPage, Button btnSubmitButton)
        {
            JScripter.IncludeJavascriptFile("Validation", thisPage.ResolveUrl("~/MusesterScript/Validation1.3.js"), thisPage);
            string Script = string.Format("$('#{0}').ValidateButton();", btnSubmitButton.ClientID);
            InjectScript(Script, thisPage);
        }
        public void Medatory(TextBox txt, string Message,Page thisPage)
        {
            string Script = string.Format("$('#{0}').Mendatory('{1}');", txt.ClientID, Message);
            InjectScript(Script, thisPage);
        }
        public void DigitOnly(TextBox txt, string Message, Page thisPage)
        {
            string Script = string.Format("$('#{0}').DigitOnly('{1}');", txt.ClientID, Message);
            InjectScript(Script, thisPage);
        }
        public void NoSpecialCharactor(TextBox txt, string Message, Page thisPage)
        {
            string Script = string.Format("$('#{0}').NoSpecialChar('{1}');", txt.ClientID, Message);
            InjectScript(Script, thisPage);
        }
        public void Email(TextBox txt, string Message, Page thisPage)
        {
            string Script = string.Format("$('#{0}').Email('{1}');", txt.ClientID, Message);
            InjectScript(Script, thisPage);
        }
        public void AlphabetOnly(TextBox txt, string Message, Page thisPage)
        {
            string Script = string.Format("$('#{0}').AlphabetOnly('{1}');", txt.ClientID, Message);
            InjectScript(Script, thisPage);
        }
        public void WebSite(TextBox txt, string Message, Page thisPage)
        {
            string Script = string.Format("$('#{0}').WebSite('{1}');", txt.ClientID, Message);
            InjectScript(Script, thisPage);
        }
        public void MaximumLength(TextBox txt, string Message, Page thisPage,string MaxLenth)
        {
            string Script = string.Format("$('#{0}').MaximumLength('{1}','{2}');", txt.ClientID,MaxLenth,Message);
            InjectScript(Script, thisPage);
        }
        public void ComparttextBox(TextBox txt, string Message, Page thisPage, TextBox CompartTxt)
        {
            string Script = string.Format("$('#{0}').CompartTextBox('{1}','{2}');", txt.ClientID, CompartTxt.ClientID, Message);
            InjectScript(Script, thisPage);
        }
        public void MinimumLength(TextBox txt, string Message, Page thisPage, string MinLenth)
        {
            string Script = string.Format("$('#{0}').MinLength('{1}','{2}');", txt.ClientID, MinLenth, Message);
            InjectScript(Script, thisPage);
        }
        public void DrowDownMendatory(DropDownList dd, string Message, Page thisPage, string bangSelected)
        {
            string Script = string.Format("$('#{0}').dropdownMandatory('{1}','{2}');", dd.ClientID,  Message,bangSelected);
            InjectScript(Script, thisPage);
        }
        public void DrowDownMendatory(DropDownList dd,DropDownList dd2,DropDownList dd3, string Message, Page thisPage)
        {
            string Script = string.Format("$('#{0}').birthdayDropdownMandatory('{1}','{2}','{3}');",dd.ClientID,Message,dd2.ClientID,dd3.ClientID);
            InjectScript(Script, thisPage);
        }
        
        private  void InjectScript(string Script, System.Web.UI.Page thisPage)
        {

            string script = Script;
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");

            aspxPage = thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsClientScriptBlockRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, script,true);
            }

            //aspxPage.RegisterStartupScript("onload", script);
            //HttpContext.Current.Response.Write(script);


        }
    }
}
