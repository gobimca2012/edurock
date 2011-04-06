using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class CustomHelper
    {
        public static string GetGuidString(Guid ID)
        {
            return ID.ToString().Replace("-", "");
        }
        public static string ConvertMultitextToHtml(string Body)
        {
            return Body.Replace(System.Environment.NewLine, "<br />").Replace("\r\n", "<br/>").Replace("\n", "<br/>");
        }
    }
}
