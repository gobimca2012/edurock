using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JScripter;
using System.Web.UI;
namespace BusinessLogic
{
    public class BasePage : System.Web.UI.Page
	{
        protected JScripter.Loader objLoader;
        public Dictionary<string, string> CallStatus;
        protected bool IsLogginMandatory = true;
        
		protected override void OnInit(EventArgs e)
		{            
            CallStatus = new Dictionary<string, string>();
			base.OnInit(e);
            objLoader = new Loader(this.Page, true);
            //MikeCompression.WhiteSpaceCompression objCom = new MikeCompression.WhiteSpaceCompression();
            //objCom.Compress();
			this.Title = "Cram Easy: Collaboration Knowledge Management System";
		}
        protected override void OnLoad(EventArgs e)
        {
            JScripter.JScripter.IncludeJavascriptFile("Validation", ResolveUrl("~/Jscript/Validation1.3Ajax.js"), this.Page);
            JScripter.JScripter.IncludeJavascriptFile("VTEffect.js", ResolveUrl("~/Jscript/VTEffect.js"), this.Page);
            if (IsLogginMandatory && !new UserAuthontication().IsLoggedIn)
            {
                Response.Redirect("~/Home.aspx");
            }
            base.OnLoad(e);
         
        }
        protected void AjaxLoad(string ContainnerID, string Url)
        {
            objLoader.LoadPage(ContainnerID, Url);
        }

        #region IPostBackDataHandler Members

        public bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
        {
            throw new NotImplementedException();
        }

        public void RaisePostDataChangedEvent()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
