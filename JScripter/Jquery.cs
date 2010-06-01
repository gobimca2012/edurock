using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JScripter
{
    public class Jquery
    {
        Page _thisPage;
        public Jquery(Page thisPage)
        {
            JScripter.IncludeJavascriptFile("Jquery1.3", thisPage.ResolveUrl("~/MusesterScript/jquery-1.3.2.js"), thisPage);
            _thisPage = thisPage;
        }
        public string GetAttrReplace(string attrName,string attrValue, string ControlId)
        {
            string Script = string.Format("$('#{0}').attr('{1}','{2}');", ControlId, attrName, attrValue);
            return Script;
        }

    }
}
