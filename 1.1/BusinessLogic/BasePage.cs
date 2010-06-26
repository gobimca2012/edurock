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
			MikeCompression.WhiteSpaceCompression objCom = new MikeCompression.WhiteSpaceCompression();
			objCom.Compress();
			this.Title = "Musester";
		}
        protected override void OnLoad(EventArgs e)
        {
            
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
