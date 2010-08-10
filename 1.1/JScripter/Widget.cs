using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JScripter
{
    public class Widget
    {
        System.Web.UI.Page _thisPage;

        public Widget(System.Web.UI.Page thisPage, bool IsLoad)
		{
			if (IsLoad)
			{
                JScripter.IncludeJavascriptFile("jquery-1.3.2.js", thisPage.ResolveUrl("~/Jscript/jquery-1.3.2.js"), thisPage);
                JScripter.IncludeJavascriptFile("jquery-ui.js", thisPage.ResolveUrl("~/Jscript/ui.core.js"), thisPage);
                JScripter.IncludeJavascriptFile("ui.dialog.js", thisPage.ResolveUrl("~/Jscript/ui.dialog.js"), thisPage);
                JScripter.IncludeJavascriptFile("encode", thisPage.ResolveUrl("~/JScript/encode.js"), thisPage);
                //JScripter.IncludeJavascriptFile("ajax", thisPage.ResolveUrl("~/JScript/ajax.js"), thisPage);
                JScripter.IncludeJavascriptFile("vtajax.js", thisPage.ResolveUrl("~/JScript/vtajax.js"), thisPage);
                JScripter.IncludeJavascriptFile("Widget.js", thisPage.ResolveUrl("~/JScript/Widget.js"), thisPage);
                

			}
			_thisPage = thisPage;
		}
        public void DeleteLinkButton(string WidgetID, string url, HyperLink lnk)
        {


            string Injectscript = string.Format("$('#{0}').DeleteWidget('{1}');", WidgetID, url);
            lnk.Attributes["href"] = "javascript:void(0);";
            lnk.Attributes["onclick"] = Injectscript;
            
        }
        public void AddWidget(string ColumnID,string WidgetID, string WidgetURL)
        {
            string Script = string.Format("$('{0}').AddWidget('{1}','{2}');", ColumnID,WidgetID,WidgetURL);
            InjectScript(Script);
        }
		public void InjectScript(string Script)
		{

			string script = Script;
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
            //if (!cs.IsClientScriptBlockRegistered(cstype, csname1))
            //{
            //    cs.RegisterClientScriptBlock(cstype, csname1, script, true);
            //}

			//aspxPage.RegisterStartupScript("onload", script);
			//HttpContext.Current.Response.Write(script);

		}
    }

}
