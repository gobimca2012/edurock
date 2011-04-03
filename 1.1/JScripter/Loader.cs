using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace JScripter
{
	public class Loader
	{
		System.Web.UI.Page _thisPage;
		
		public Loader(System.Web.UI.Page thisPage, bool IsLoad)
		{
			if (IsLoad)
			{
                JScripter.IncludeJavascriptFile("jquery-1.3.2.js", thisPage.ResolveUrl("~/Jscript/jquery-1.3.2.js"), thisPage);
                JScripter.IncludeJavascriptFile("jquery-ui.js", thisPage.ResolveUrl("~/Jscript/ui.core.js"), thisPage);
                JScripter.IncludeJavascriptFile("ui.dialog.js", thisPage.ResolveUrl("~/Jscript/ui.dialog.js"), thisPage);
                //JScripter.IncludeJavascriptFile("encode", thisPage.ResolveUrl("~/JScript/encode.js"), thisPage);
                //JScripter.IncludeJavascriptFile("ajax", thisPage.ResolveUrl("~/JScript/ajax.js"), thisPage);
                JScripter.IncludeJavascriptFile("vtajax.js", thisPage.ResolveUrl("~/JScript/vtajax.js"), thisPage);
                

			}
			_thisPage = thisPage;
		}
		public void InjectScript(string Script, System.Web.UI.Page thisPage)
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
                cs.RegisterStartupScript(cstype, csname1, script, true);
            }
            //if (!cs.IsClientScriptBlockRegistered(cstype, csname1))
            //{
            //    cs.RegisterClientScriptBlock(cstype, csname1, script, true);
            //}

			//aspxPage.RegisterStartupScript("onload", script);
			//HttpContext.Current.Response.Write(script);

		}
		public void LoadPage(string ContainerID, string url)
		{			
			string script = string.Format("$('{0}').LoadPage('{1}');", ContainerID, url);
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

			//aspxPage.RegisterStartupScript("onload", script);
			//HttpContext.Current.Response.Write(script);

		}
        public void ClearArea(string ContainerID)
        {
            string script = string.Format("$('{0}').html('');", ContainerID);
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

            //aspxPage.RegisterStartupScript("onload", script);
            //HttpContext.Current.Response.Write(script);

        }
		public string LoadPageScript(string ContainerID, string url)
		{
			//string script = string.Format("<script type='text/javascript'>$('{0}').LoadPage('{1}');</script>", id, url);
			string script = string.Format("$('{0}').LoadPage('{1}');", ContainerID, url);
			return script;
		
		}
		public void BuildLink(string ContainnerID)
		{

			string script = string.Format("BuildLinks('{0}');", ContainnerID);
			System.Web.UI.Page aspxPage = new System.Web.UI.Page();
			String csname1 = Guid.NewGuid().ToString().Replace("-", "");

			aspxPage = _thisPage;
			Type cstype = aspxPage.GetType();
			// Get a ClientScriptManager reference from the Page class.
			ClientScriptManager cs = aspxPage.ClientScript;
			if (!cs.IsClientScriptBlockRegistered(cstype, csname1))
			{
				cs.RegisterClientScriptBlock(cstype, csname1, script);
			}

			//aspxPage.RegisterStartupScript("onload", script);
			//HttpContext.Current.Response.Write(script);

		}
		public void OnClick(string ContainerID, string url, LinkButton lnk)
		{
			//lnk.Attributes["onclick"] = string.Format("$('{0}').clickLoad('{1}','{2}');", lnk.ClientID, url, ContainerID);
			lnk.Attributes["href"] = "javascript:void(0);";
			lnk.Attributes["rel"]=url+ContainerID;			
			lnk.CssClass="ckh";
		}
        public void OnClick(string ContainerID, string url, HyperLink lnk)
        {
            //lnk.Attributes["onclick"] = string.Format("$('{0}').clickLoad('{1}','{2}');", lnk.ClientID, url, ContainerID);
            lnk.Attributes["href"] = "javascript:void(0);";
            lnk.Attributes["rel"] = url + ContainerID;
            lnk.CssClass = "ckh";
        }
		public void PostData(string ContainerID, string PostContainnerID, string url, LinkButton lnk)
		{
            if (url.Contains("?"))
            {
                url += "&ac=p";                
            }
            else
            {
                url += "?ac=p";
            }
            url += "&k=" + lnk.ClientID;

			string Injectscript = string.Format("$('#{0}').LinkPostH('{1}','{2}','{3}');", lnk.ClientID, url, PostContainnerID, ContainerID);
			lnk.Attributes["href"] = "javascript:void(0);";
			InjectScript(Injectscript, _thisPage);
		}
        public void PostData(string ContainerID, string PostContainnerID, string url, string lnkID)
        {
            if (url.Contains("?"))
            {
                url += "&ac=p";
            }
            else
            {
                url += "?ac=p";
            }
            url += "&k=" + lnkID;

            string Injectscript = string.Format("$('#{0}').LinkPostH('{1}','{2}','{3}');", lnkID, url, PostContainnerID, ContainerID);
            //lnk.Attributes["href"] = "javascript:void(0);";
            InjectScript(Injectscript, _thisPage);
        }
        public void AjaxRedirect(string ContainerID, string PostContainnerID, string url, string lnkID)
        {
            if (url.Contains("?"))
            {
                url += "&ac=r";
            }
            else
            {
                url += "?ac=r";
            }
            url += "&k=" + lnkID;

            string Injectscript = string.Format("$('#{0}').LinkPostH('{1}','{2}','{3}');", lnkID, url, PostContainnerID, ContainerID);
            //lnk.Attributes["href"] = "javascript:void(0);";
            InjectScript(Injectscript, _thisPage);
        }
        public void PostData(string ContainerID, string PostContainnerID, string url, HyperLink lnk)
        {
            if (url.Contains("?"))
            {
                url += "&ac=p";
            }
            else
            {
                url += "?ac=p";
            }
            url += "&k=" + lnk.ClientID;

            string Injectscript = string.Format("$('#{0}').LinkPostH('{1}','{2}','{3}');", lnk.ClientID, url, PostContainnerID, ContainerID);
            lnk.Attributes["href"] = "javascript:void(0);";
            InjectScript(Injectscript, _thisPage);
        }
        public void PostDataWithValidation(string ContainerID, string PostContainnerID, string url, HyperLink lnk)
        {
            if (url.Contains("?"))
            {
                url += "&ac=p";
            }
            else
            {
                url += "?ac=p";
            }
            url += "&k=" + lnk.ClientID;

            string Injectscript = string.Format("$('#{0}').LinkPostHV('{1}','{2}','{3}','true');", lnk.ClientID, url, PostContainnerID, ContainerID);
            lnk.Attributes["href"] = "javascript:void(0);";
            InjectScript(Injectscript, _thisPage);
        }
		public void LoadPageOnClick(string ContainerID, string url, LinkButton lnk)
		{
			string Injectscript = string.Format("$('{0}').LinkLoadPage('{1}','{2}');", lnk.ClientID, url, ContainerID);
			lnk.Attributes["href"] = "javascript:void(0);";
			InjectScript(Injectscript, _thisPage);
		}
		public static void RedirectPage(string url, System.Web.UI.Page thisPage)
		{

			string script = "window.location=";
			script += "'" + url + "';";
			System.Web.UI.Page aspxPage = new System.Web.UI.Page();
			String csname1 = Guid.NewGuid().ToString().Replace("-", "");

			aspxPage = thisPage;
			Type cstype = aspxPage.GetType();
			// Get a ClientScriptManager reference from the Page class.
			ClientScriptManager cs = aspxPage.ClientScript;
			if (!cs.IsClientScriptBlockRegistered(cstype, csname1))
			{
				cs.RegisterClientScriptBlock(cstype, csname1, script,true);
			}

			//aspxPage.RegisterStartupScript("onload", script);
			//HttpContext.Current.Response.Write(script);

		}
		public void ClickRedirect(string url,LinkButton lnk)
		{

			string script = "window.location=";
			script += "'" + url + "';";
			lnk.Attributes["onclick"]=script;
			//aspxPage.RegisterStartupScript("onload", script);
			//HttpContext.Current.Response.Write(script);

		}
        public void RedirectPage(string url)
        {

            string script = "window.location=";
            script += "'" + url + "';";
            InjectScript(script, _thisPage);
            //aspxPage.RegisterStartupScript("onload", script);
            //HttpContext.Current.Response.Write(script);

        }
	}
}
