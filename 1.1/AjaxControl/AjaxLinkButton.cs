using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;

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

    public class AjaxLinkButton : System.Web.UI.WebControls.HyperLink
    {
        private string _Url;
        public delegate void AjaxClickEventHandler(object sender, AjaxEventArg e);
        public event AjaxClickEventHandler AjaxClick;
        protected virtual void OnAjaxClick(AjaxEventArg e)
        {
            if (AjaxClick != null)
                AjaxClick(this, e);
        }
        public Dictionary<string, string> Parames
        {
            get;
            set;
        }
        public bool Increment
        {
            get;
            set;
        }
        public bool Pagger
        {
            get;
            set;
        }
        public string ExternameUrlParam
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
            Parames = new Dictionary<string, string>();
            base.OnLoad(e);
            string Url = ResolveUrl(this.NavigateUrl);
            string Questring = "", QueryStringStr = "";
            if (Url == "")
            {
                Questring = this.Page.Request.QueryString.ToString();
                if (Questring != "")
                {
                    string[] queryString = Questring.Split('&');
                    for (int i = 0; i < queryString.Length; i++)
                    {
                        string[] qstr = queryString[i].Split('=');
                        if (qstr[0] != "cmd" && qstr[0] != "k" && qstr[0] != "ac")
                        {
                            if (QueryStringStr == "")
                            {
                                QueryStringStr += queryString[i];
                            }
                            else
                            {
                                QueryStringStr += "&" + queryString[i];
                            }
                        }
                    }
                }
                if (Questring == "" && QueryStringStr == "")
                    Url = this.Page.Request.RawUrl;
                else
                {
                    if (QueryStringStr != "")
                    {
                        Url = this.Page.Request.UrlReferrer + "?" + QueryStringStr;
                    }

                }
            }
            string QuesryString = "";
            if (QID != "" && QID != null)
            {
                if (Url.Contains("?"))
                {
                    QuesryString += "&id=" + QID;
                }
                else
                {
                    QuesryString += "?id=" + QID;
                }
            }
            if (AjaxCommand != "")
            {
                if (Url.Contains("?"))
                {

                    QuesryString += "&cmd=" + AjaxCommand;
                }
                else
                {
                    QuesryString += "?cmd=" + AjaxCommand;
                }
            }
            if (Pagger)
            {
                if (Url.Contains("?") || QuesryString.Contains("?"))
                {
                    if (HttpContext.Current.Request.Params["pn"] != null)
                    {
                        if (Increment)
                            QuesryString += "&pn=" + (Convert.ToInt16(HttpContext.Current.Request.Params["pn"]) + 1).ToString();
                        else
                            QuesryString += "&pn=" + (Convert.ToInt16(HttpContext.Current.Request.Params["pn"]) - 1).ToString();
                    }
                    else
                    {
                        if (Increment)
                            QuesryString += "&pn=" + " 1";
                        else
                            QuesryString += "&pn=" + "0";
                    }
                }
                else
                {
                    QuesryString += "?cmd=" + AjaxCommand;
                }
            }
            Url += QuesryString;
            if (ResponseContainner == "")
            {
                ResponseContainner = RequestContainner;
            }

            if (HttpContext.Current.Request.Params["k"] != null)
            {
                if (HttpContext.Current.Request.Params["k"] == this.ClientID)
                {
                    AjaxEventArg objArg = new AjaxEventArg();
                    if (HttpContext.Current.Request.Params["id"] != "")
                    {
                        objArg.Id = HttpContext.Current.Request.Params["id"];
                    }
                    if (HttpContext.Current.Request.Params["cmd"] != "")
                    {
                        objArg.AjaxCommand = HttpContext.Current.Request.QueryString["cmd"];
                    }
                    OnAjaxClick(objArg);
                }
            }
            if (Parames != null)
            {
                List<string> Keylist = new List<string>(Parames.Keys);
                List<string> valuelist = new List<string>(Parames.Values);


                for (int i = 0; i < Parames.Keys.Count; i++)
                {
                    Url += string.Format("&{0}={1}", Keylist[i], valuelist[i]);
                }
            }
            new JScripter.Loader(this.Page, false).PostData(RequestContainner, ResponseContainner, Url + ExternameUrlParam, this);
            NavigateUrl = "";


        }






    }

}
