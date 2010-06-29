using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace JScripter
{
    public class PopUp
    {
        Page _thisPage;
        public PopUp(Page thisPage, bool IsScriptFileLoadNeed)
        {
            if (IsScriptFileLoadNeed)
            {
                JScripter.IncludeJavascriptFile("jquery-1.3.2.js", thisPage.ResolveUrl("~/Jscript/jquery-1.3.2.js"), thisPage);
                JScripter.IncludeJavascriptFile("jquery-ui.js", thisPage.ResolveUrl("~/Jscript/ui.core.js"), thisPage);
                JScripter.IncludeJavascriptFile("ui.dialog.js", thisPage.ResolveUrl("~/Jscript/ui.dialog.js"), thisPage);
            }
            _thisPage = thisPage;
        }

        public void Alert(LinkButton Lnk, string Message)
        {

            Lnk.Attributes["onclick"] = string.Format("$('#{0}').Customalert('{1}');", Lnk.ClientID, Message);
            Lnk.Attributes["href"] = "javascript:void(0);";

        }
        public void IframePopUp(LinkButton lnk, string pageUrl, string popId)
        {
            lnk.Attributes["onclick"] = string.Format("$('#{0}').PUI('{1}');", popId, pageUrl);
            lnk.Attributes["href"] = "javascript:void(0);";
        }
        public void IframePopUp(HyperLink lnk, string pageUrl, string popId)
        {
            lnk.Attributes["onclick"] = string.Format("$('#{0}').PUI('{1}');", popId, pageUrl);
            lnk.Attributes["href"] = "javascript:void(0);";
        }
        public void IframePopUp(LinkButton lnk, string pageUrl, string popId, string width, string height)
        {
            lnk.Attributes["onclick"] = string.Format("$('#{0}').PUIW('{1}','{2}','{3}');", popId, pageUrl, width, height);
            lnk.Attributes["href"] = "javascript:void(0);";
        }
        public void IframePopUp(HyperLink lnk, string pageUrl, string popId, string width, string height)
        {
            lnk.Attributes["onclick"] = string.Format("$('#{0}').PUIW('{1}','{2}','{3}');", popId, pageUrl, width, height);
            lnk.Attributes["href"] = "javascript:void(0);";
        }
        public void ClosePopUp(LinkButton lnk, string InjectScript, string PopupId)
        {
            string script = InjectScript;
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");
            aspxPage = _thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            string PopUpCloseScript = string.Format("$('#{0}').dialog('close');$('#{0}').dialog('destroy');", PopupId);
            if (!cs.IsClientScriptBlockRegistered(cstype, csname1))
            {

                cs.RegisterClientScriptBlock(cstype, csname1, script+PopUpCloseScript, true);
                //cs.RegisterClientScriptBlock(cstype, csname1, PopUpCloseScript, true);
            }
        }
        public void ConfirmPopUp(LinkButton lnk,string TrueText )
        {
            string script = "";
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");
            aspxPage = _thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            string PopUpCloseScript = string.Format("$('#{0}').ConfirmBox('{1}');",lnk.ClientID,TrueText);
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {

                cs.RegisterStartupScript(cstype, csname1,  PopUpCloseScript, true);
                //cs.RegisterClientScriptBlock(cstype, csname1, PopUpCloseScript, true);
            }
        }
        public void PopUpOen(LinkButton lnk, string PopUpDivID,string url)
        {
            
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");
            aspxPage = _thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            string PopUpCloseScript = string.Format("$('#{0}').PopUps('{1}','{2}');", lnk.ClientID, PopUpDivID, url);
            if (!cs.IsClientScriptBlockRegistered(cstype, csname1))
            {

                cs.RegisterClientScriptBlock(cstype, csname1, PopUpCloseScript, true);
                //cs.RegisterClientScriptBlock(cstype, csname1, PopUpCloseScript, true);
            }
        }
        public void PopUpOpen(HyperLink lnk, string PopUpDivID, string url,string width,string height)
        {

            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");
            aspxPage = _thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            string PopUpCloseScript = string.Format("$('#{0}').PopUps('{1}','{2}','{3}','{4}');", lnk.ClientID, PopUpDivID, url,width,height);
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {

                cs.RegisterStartupScript(cstype, csname1, PopUpCloseScript, true);
                //cs.RegisterClientScriptBlock(cstype, csname1, PopUpCloseScript, true);
            }
        }

        public void PopUpClose(string PopUpDivID)
        {

            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");
            aspxPage = _thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            string PopUpCloseScript = string.Format("eval(alert('aa'));$('{0}).dialog('close');$('{0}).dialog('destroy');", PopUpDivID);
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {

                cs.RegisterStartupScript(cstype, csname1, PopUpCloseScript, true);
                //cs.RegisterClientScriptBlock(cstype, csname1, PopUpCloseScript, true);
            }
        }
    }
}
