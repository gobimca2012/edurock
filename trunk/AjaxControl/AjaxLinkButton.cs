using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace AjaxControl
{
    public class AjaxEventArg
    {
        public string Id
        {
            get;
            set;
        }
        public string AjaxCommand
        {
            get;
            set;
        }

    }
    public class AjaxLinkButton : System.Web.UI.WebControls.LinkButton
    {
        private string _Url;
        public delegate void AjaxClickEventHandler(object sender, AjaxEventArg e);
        public event AjaxClickEventHandler AjaxClick;
        protected virtual void OnAjaxClick(AjaxEventArg e)
        {
            if (AjaxClick != null)
                AjaxClick(this, e);
        }

        public string Url
        {
            get
            {
                if (_Url != "")
                {
                    return _Url;
                }
                else
                {
                    return "";
                }
            }           
            set
            {
                _Url = value;
            }
        }
        public string RequestContainner
        {
            get;
            set;
        }
        public string QID
        {
            get;
            set;
        }
        public string AjaxCommand
        {
            get;
            set;
        }
        public string ResponseContainner
        {
            get;
            set;
        }
        protected override void OnInit(EventArgs e)
        {
            this.EnableViewState = false;
            base.OnInit(e);
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string Url =ResolveUrl(this.PostBackUrl);
            if (QID != "")
            {
                if (Url.Contains("?"))
                {
                    Url += "&id=" + QID;
                }
                else
                {
                    Url += "?id=" + QID;
                }
            }
            if (AjaxCommand != "")
            {
                if (Url.Contains("?"))
                {
                    Url += "&cmd=" + AjaxCommand;
                }
                else
                {
                    Url += "?cmd=" + AjaxCommand;
                }
            }
            if (ResponseContainner == "")
            {
                ResponseContainner = RequestContainner;
            }
            new JScripter.Loader(this.Page, false).PostData(RequestContainner, ResponseContainner,Url, this);
            if (HttpContext.Current.Request.QueryString["k"] != null)
            {
                if (HttpContext.Current.Request.QueryString["k"] == this.ClientID)
                {
                    AjaxEventArg objArg = new AjaxEventArg();
                    if(HttpContext.Current.Request.QueryString["id"]!="")
                    {
                        objArg.Id = HttpContext.Current.Request.QueryString["id"];
                    }
                    if (HttpContext.Current.Request.QueryString["cmd"] != "")
                    {
                        objArg.AjaxCommand = HttpContext.Current.Request.QueryString["cmd"];
                    }
                    OnAjaxClick(objArg);
                }
            }
            PostBackUrl = _Url;
          
        }


    }
}
