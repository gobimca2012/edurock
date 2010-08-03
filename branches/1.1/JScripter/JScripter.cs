using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace JScripter
{
    public class JScripter
    {
        
        

        public static void InjectScript(string Script, System.Web.UI.Page thisPage)
        {

            string script = Script;
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");

            aspxPage = thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, script,true);
            }

            //aspxPage.RegisterStartupScript("onload", script);
            //HttpContext.Current.Response.Write(script);

        }
        public static void TextBoxWaterMark(TextBox txtBox,string WaterMarkMessage, System.Web.UI.Page thisPage)
        {

            string script = string.Format("$('#{0}').textWaterMark('{1}');", txtBox.ClientID, WaterMarkMessage);
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");

            aspxPage = thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, script,true);
            }

            //aspxPage.RegisterStartupScript("onload", script);
            //HttpContext.Current.Response.Write(script);

        }
        public static void LoadPage(string id, string url, System.Web.UI.Page thisPage)
        {
            //string script = string.Format("<script type='text/javascript'>$('{0}').LoadPage('{1}');</script>", id, url);
            string script = string.Format("$('{0}').LoadPage('{1}');", id, url);
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");

            aspxPage = thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, script, true);
            }

            //aspxPage.RegisterStartupScript("onload", script);
            //HttpContext.Current.Response.Write(script);

        }
        public static void LoadPageNoReplace(string id, string url, System.Web.UI.Page thisPage)
        {
            //string script = string.Format("<script type='text/javascript'>$('{0}').LoadPage('{1}');</script>", id, url);
            string script = string.Format("$('{0}').LoadPageNoReplace('{1}');", id, url);
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");

            aspxPage = thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, script, true);
            }

            //aspxPage.RegisterStartupScript("onload", script);
            //HttpContext.Current.Response.Write(script);

        }
        public static void IncludeJavascriptFile(string scriptName, string url, System.Web.UI.Page thisPage)
        {
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = scriptName;

            aspxPage = thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsClientScriptIncludeRegistered(scriptName))
            {
                cs.RegisterClientScriptInclude(scriptName, url);
            }
        }
        public static void LoadPageClickEvent(string id, string url, LinkButton lnk)
        {
            lnk.Attributes["onclick"] = string.Format("$('{0}').LP('{0}','{1}');", id, url);
            lnk.Attributes["href"] = "javascript:void(0);";
        }
        
        public static void LoadPageSerializePostOnClick(string id, string url, LinkButton lnk)
        {
            //lnk.Attributes["onclick"] = string.Format("$('{0}').LPP('{1}');", id, url);
            lnk.Attributes["rel"] = string.Format("LPP|vt|{0}|vt|{1}", id, url);
            lnk.Attributes["href"] = "javascript:void(0);";
        }
        public static void PopUpAjax(string PopUpboxId, string url, LinkButton lnk)
        {
            lnk.Attributes["onclick"] = string.Format("$('popUpWin').PU('{0}');", url);
            lnk.Attributes["href"] = "javascript:void(0);";

        }
        public static void ToolTipUrl(string url, LinkButton lnk)
        {
            lnk.Attributes["onclick"] = string.Format("$('#tooltipcontainer').ToolTipURl('{0}');", url);
            lnk.Attributes["href"] = "javascript:void(0);";

        }
        
    }
}
