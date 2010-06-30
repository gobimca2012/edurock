using System;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class AjaxListViewCommandArg
    {
        public string Id
        {
            get;
            set;
        }
        public string Command
        {
            get;
            set;
        }

    }
    public class AjaxPage : System.Web.UI.Page
    {
        public JScripter.Loader objLoader;
        public int LoginUserID
        {
            get
            {
                if (Request.QueryString["ui"] != null)
                {
                    return Convert.ToInt32(Request.QueryString["ui"]);
                }
                else
                {
                    return 0;
                }
            }
        }
        public string ClickedControl
        {
            get
            {
                if (Request.QueryString["k"] != null)
                {
                    return Request.QueryString["k"];
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        protected Dictionary<string, string> AjaxParam
        {
            get;
            set;
        }
        public delegate void AjaxClickEventHandler(object sender, AjaxListViewCommandArg e);
        public event AjaxClickEventHandler AjaxListViewCommand;
        protected bool IsAjaxPostBack
        {
            get
            {
                if (Request.Params["ac"] != null)
                {
                    if (Request.Params["ac"] == "p")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        protected virtual void OnAjaxListViewCommand(AjaxListViewCommandArg e)
        {
            if (AjaxListViewCommand != null)
                AjaxListViewCommand(this, e);
        }
        protected override void OnInitComplete(EventArgs e)
        {
            base.OnInitComplete(e);
            base.LoadViewState(Request.Params["__VIEWSTATE"]);
        }
        protected override void OnLoad(EventArgs e)
        {
            objLoader = new JScripter.Loader(this.Page, false);
            this.Page.Header.Visible = false;
            base.OnLoad(e);
            
            if (Request.QueryString["cmd"] != null)
            {
                AjaxListViewCommandArg objcommandevent = new AjaxListViewCommandArg();
                objcommandevent.Command = Request.QueryString["cmd"];
                objcommandevent.Id = Request.QueryString["id"];
                OnAjaxListViewCommand(objcommandevent);
            }
            
            
            
        }
        
        private string GetStringFromDictionary()
        {
            string dataString = "";
            foreach (KeyValuePair<string, string> kvp in AjaxParam)
            {
                if (dataString != "")
                {
                    dataString += "&" + kvp.Key + ";" + kvp.Value;
                }
                else
                {
                    dataString += kvp.Key + ";" + kvp.Value;
                }
            }
            return dataString;
        }
        protected override void LoadViewState(object savedState)
        {
            
            base.LoadViewState(savedState);
        }

        protected override void Render(HtmlTextWriter writer)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            System.IO.StringWriter sw = new System.IO.StringWriter(sb);

            HtmlTextWriter htmlWriter = new HtmlTextWriter(sw);

            base.Render(htmlWriter);



            //  //The HTML output is stored in the string object. Use it the way you want.

            string s = sb.ToString();

            s = Regex.Replace(s, @"<!.*?>", string.Empty, RegexOptions.Compiled |
                  RegexOptions.Multiline);
            s = Regex.Replace(s, @"<input.*_EVENTTARGET.*/>", string.Empty, RegexOptions.Compiled |
                              RegexOptions.Multiline);
            s = Regex.Replace(s, @"<input.*VIEWSTATE.*/>", string.Empty, RegexOptions.Compiled |
            RegexOptions.Multiline);
            s = Regex.Replace(s, @"<input.*EVENTARGUMENT.*/>", string.Empty, RegexOptions.Compiled |
            RegexOptions.Multiline);
            s = Regex.Replace(s, @"<input.*EVENTVALIDATION.*/>", string.Empty, RegexOptions.Compiled |
            RegexOptions.Multiline);
            string injscript = Regex.Match(s, "[<script type=\"text/javascript\" id=\"externalScript\">].*?</script>").Value;
            s = Regex.Replace(s, @"<meta.*?>", string.Empty, RegexOptions.Compiled |
                              RegexOptions.Multiline);
            s = Regex.Replace(s, @"<link.*?>", string.Empty, RegexOptions.Compiled |
                              RegexOptions.Multiline);
            s = Regex.Replace(s, @"<form.*?>", string.Empty, RegexOptions.Compiled |
                              RegexOptions.Multiline);
            s = s.Replace("</form>", "");
            s = Regex.Replace(s, @"<html.*>", string.Empty, RegexOptions.Compiled |
                              RegexOptions.Multiline);
            s = s.Replace("</html>", "");
            s = Regex.Replace(s, @"<title>.*?title>", string.Empty, RegexOptions.Compiled |
                              RegexOptions.Multiline);
            s = s.Replace("<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.01 Transitional//EN' >", "");
            s = Regex.Replace(s, "^\\s*", string.Empty, RegexOptions.Compiled |
          RegexOptions.Multiline);
            //s = Regex.Replace(s, "\\r\\n", string.Empty, RegexOptions.Compiled |
            //                           RegexOptions.Multiline);
            //<script\stype(.*\n)*(</script>).
            //s = Regex.Replace(s, "<script\\stype(.*\n)*(</script>).", string.Empty, RegexOptions.Compiled |
          //RegexOptions.Multiline);
            s = Regex.Replace(s, "var\\stheForm.*;(.*\n)*theForm.*(?<submit>)\n.*\n.*", string.Empty, RegexOptions.Compiled |
            RegexOptions.Multiline);
            s = Regex.Replace(s, "<!--*.*?-->", string.Empty, RegexOptions.Compiled |
                              RegexOptions.Multiline);
            s = s.Replace("<head>", "");
            s = s.Replace("</head>", "");
            s = s.Replace("<body>", "");
            s = s.Replace("</body>", "");
            writer.Write(s);

        }

    
    }
}
