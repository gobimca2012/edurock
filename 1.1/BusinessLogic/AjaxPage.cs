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
        public string customId1
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
        protected Dictionary<string, string> AjaxState = new Dictionary<string, string>();
        public delegate void AjaxClickEventHandler(object sender, AjaxListViewCommandArg e);
        public event AjaxClickEventHandler AjaxListViewCommand;        
        protected virtual void OnAjaxListViewCommand(AjaxListViewCommandArg e)
        {
            if (AjaxListViewCommand != null)
                AjaxListViewCommand(this, e);
        }
        public string AjaxStateName="__AjaxState";
        protected override void OnInit(EventArgs e)
        {
            if (Request.Params[AjaxStateName] != null && Request.Params[AjaxStateName] != "")
            {
                string AjaxStateValues = Request.Params[AjaxStateName].ToString();
                
                string[] AjaxStatePart = AjaxStateValues.Split('&');
                
                {
                    for (int i = 0; i < AjaxStatePart.Length; i++)
                    {
                        string[] AjaxStatePartPart = AjaxStatePart[i].Split('=');
                        if (AjaxStatePartPart.Length > 1)
                        {
                            //AjaxState.Add(AjaxStatePartPart[0], AjaxStatePartPart[1]);
                            AjaxState[AjaxStatePartPart[0]] = AjaxStatePartPart[1];
                        }
                    }
                }
            }
            base.OnInit(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            objLoader = new JScripter.Loader(this.Page, false);
            this.Page.Header.Visible = false;
            base.OnLoad(e);

            if (Request.Params["lcmd"] != null)
            {
                AjaxListViewCommandArg objcommandevent = new AjaxListViewCommandArg();
                objcommandevent.Command = Request.Params["lcmd"];
                objcommandevent.Id = Request.Params["lid"];
                if (Request.Params["lid1"] != null)
                {
                    objcommandevent.customId1 = Request.Params["lid1"];
                }
                OnAjaxListViewCommand(objcommandevent);
            }



        }
        protected override void OnLoadComplete(EventArgs e)
        {
            //System.Web.UI.WebControls.HiddenField AjaxStateControl=(System.Web.UI.WebControls.HiddenField)FindControl("_AjaxState");
            System.Web.UI.WebControls.HiddenField AjaxStateControl = new System.Web.UI.WebControls.HiddenField();

            if (AjaxStateControl != null)
            {
                string AjaxStateString = "";
                List<string> Keylist = new List<string>(AjaxState.Keys);
                List<string> valuelist = new List<string>(AjaxState.Values);

                
                for (int i = 0; i < AjaxState.Keys.Count; i++)
                {
                    if (i > 1)
                    {
                        AjaxStateString += string.Format("&{0}={1}", Keylist[i], valuelist[i]);
                    }
                    else
                    {
                        AjaxStateString += string.Format("{0}={1}", Keylist[i], valuelist[i]);
                    }
                }
                AjaxStateControl.Value = AjaxStateString;
                AjaxStateControl.ID = AjaxStateName;
                this.Page.Form.Controls.Add(AjaxStateControl);
            }
            
            base.OnLoadComplete(e);
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
