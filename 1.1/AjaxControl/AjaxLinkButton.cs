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
            string Url = ResolveUrl(this.PostBackUrl);
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
            Url += QuesryString;
            if (ResponseContainner == "")
            {
                ResponseContainner = RequestContainner;
            }
            new JScripter.Loader(this.Page, false).PostData(RequestContainner, ResponseContainner, Url, this);
            if (HttpContext.Current.Request.Params["k"] != null)
            {
                if (HttpContext.Current.Request.Params["k"] == this.ClientID)
                {
                    AjaxEventArg objArg = new AjaxEventArg();
                    if (HttpContext.Current.Request.QueryString["id"] != "")
                    {
                        objArg.Id = HttpContext.Current.Request.QueryString["id"];
                    }
                    if (HttpContext.Current.Request.Params["cmd"] != "")
                    {
                        objArg.AjaxCommand = HttpContext.Current.Request.QueryString["cmd"];
                    }
                    OnAjaxClick(objArg);
                }
            }
            //string HidentControl = string.Format("<input type=\"hidden\" name=\"_DIMMER\" id=\"_DIMMER\" value=\"{0}\" />",QuesryString);
            ////System.Web.UI.WebControls.HiddenField que = new System.Web.UI.WebControls.HiddenField();
            ////que.Value = QuesryString;
            ////que.ID = "dim";
            ////System.Web.UI.Page currentPage = (System.Web.UI.Page)HttpContext.Current.Handler;
            //HttpContext.Current.Response.Write(HidentControl);
            ////currentPage.Controls.Add(que);
            PostBackUrl = _Url;

        }






    }

}
