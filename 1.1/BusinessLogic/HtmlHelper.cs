using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BusinessLogic
{
    public class HtmlHelper
    {
        int ListViewID = 0;
        public HtmlHelper()
        {

        }
        public static List<string> CheckBox(string ClientID)
        {
            List<string> ItemValues = new List<string>();
            for (int i = 0; i < HttpContext.Current.Request.Params.Keys.Count; i++)
            {
                if (HttpContext.Current.Request.Params.Keys[i] != null)
                {
                    if (HttpContext.Current.Request.Params.Keys[i].Contains(ClientID))
                    {
                        string[] ValueSplit = HttpContext.Current.Request.Params.Keys[i].Split('$');
                        ItemValues.Add(ValueSplit[1]);
                    }
                }
            }
            return ItemValues;
        }

        public static string ControlValue(string ClientID)
        {
            if (HttpContext.Current.Request.Params[ClientID] != null)
            {
                return HttpContext.Current.Request.Params[ClientID].ToString();
            }
            else if (HttpContext.Current.Request.Params[ClientID.Replace('_', '$')] != null)
            {
                return HttpContext.Current.Request.Params[ClientID.Replace('_', '$')].ToString();
            }
            else
            {
                return "";
            }
        }
        public string ListViewLinkButton(string ControlID, string Command, string ParameterID, string RequestContainner, string ResponseContainner)
        {
            ListViewID++;
            string CID=ControlID+"_"+ListViewID.ToString();
            string Url = HttpContext.Current.Request.Url.AbsoluteUri;
            if (!Url.Contains("?"))
            {
                Url += "?lcmd=" + Command;
            }
            else
            {
                Url += "&lcmd=" + Command;
            }
            Url += "&lid=" + ParameterID;
            new JScripter.Loader((System.Web.UI.Page)HttpContext.Current.Handler, false).PostData(RequestContainner, ResponseContainner, Url, CID);
            return string.Format("<a href='javascript:void(0);' id='{0}'>Delete</a>",CID);
        }
        public string ListViewLinkButton(string ControlID,string ControlLabel, string Command, string ParameterID, string RequestContainner, string ResponseContainner)
        {
            ListViewID++;
            string CID = ControlID + "_" + ListViewID.ToString();
            string Url = HttpContext.Current.Request.Url.AbsoluteUri;
            if (!Url.Contains("?"))
            {
                Url += "?lcmd=" + Command;
            }
            else
            {
                Url += "&lcmd=" + Command;
            }
            Url += "&lid=" + ParameterID;
            new JScripter.Loader((System.Web.UI.Page)HttpContext.Current.Handler, false).PostData(RequestContainner, ResponseContainner, Url, CID);
            return string.Format("<a href='javascript:void(0);' id='{0}'>{1}</a>", CID, ControlLabel);
        }
        public string ListViewLinkButton(string ControlID, string ControlLabel, string Command, string ParameterID, string ParameterID1, string RequestContainner, string ResponseContainner)
        {
            ListViewID++;
            string CID = ControlID + "_" + ListViewID.ToString();
            string Url = HttpContext.Current.Request.Url.AbsoluteUri;
            if (!Url.Contains("?"))
            {
                Url += "?lcmd=" + Command;
            }
            else
            {
                Url += "&lcmd=" + Command;
            }
            Url += "&lid=" + ParameterID;
            Url += "&lid1=" + ParameterID1;
            new JScripter.Loader((System.Web.UI.Page)HttpContext.Current.Handler, false).PostData(RequestContainner, ResponseContainner, Url, CID);
            return string.Format("<a href='javascript:void(0);' id='{0}'>{1}</a>", CID, ControlLabel);
        }
    }
}
