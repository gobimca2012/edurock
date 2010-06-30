using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BusinessLogic
{
    public class HtmlHelper
    {
        public static List<string> CheckBox(string ClientID)
        {
            List<string> ItemValues = new List<string>();
            for (int i = 0; i < HttpContext.Current.Request.Params.Keys.Count; i++)
            {
                if (HttpContext.Current.Request.Params.Keys[i]!=null)
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
            else
            {
                return "";
            }
        }
    }
}
