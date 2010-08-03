using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;
namespace RewriteModule
{
    public class RewriteModule : IHttpModule 
    {
        DateTime beginrequest;
        public void Init(HttpApplication app)
        {
            // register for events created by the pipeline
            app.BeginRequest += new EventHandler(this.OnBeginRequest);
            app.EndRequest += new EventHandler(this.OnEndRequest);
        }
        public void Dispose() { }
        public void OnBeginRequest(object o, EventArgs args)
        {
            // obtain the time of the current request
            bool isProfile = false;
            string newUrl = HttpContext.Current.Request.Path;
            string path = HttpContext.Current.Request.Path;            
            string withOutSlash = path.Replace("/", "");
            if (!withOutSlash.Contains(".aspx"))
            {
                try
                {
                    int IDNumber = Convert.ToInt32(withOutSlash);
                    isProfile = true;
                    //newUrl=ConfigurationSettings.AppSettings["SitePrefixUrl"]+"/"+"sitecore/content/Profile.aspx?UID="+IDNumber.ToString();
                    newUrl = "/Profile.aspx?UID=" + IDNumber.ToString();
                    HttpContext.Current.RewritePath(newUrl);
                }
                catch (System.FormatException noParse)
                {
                }
            }

            
        }
        public void OnEndRequest(object o, EventArgs args)
        {
            //// get the time elapsed for the request
            //TimeSpan elapsedtime = DateTime.Now - beginrequest;
            //// get access to application object and the context object
            //HttpApplication app = (HttpApplication)o;
            //HttpContext ctx = app.Context;
            //// add header to HTTP response
            //ctx.Response.AppendHeader("ElapsedTime", elapsedtime.ToString());
        }
    }
}
