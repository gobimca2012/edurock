using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace JScripter
{
    public class DragNDrop
    {
        Page _thisPage;
        public DragNDrop(Page thisPage, bool IsScriptRequire)
        {
            if (IsScriptRequire)
                JScripter.IncludeJavascriptFile("ui.sortable.js", thisPage.ResolveUrl("~/Jscript/ui.sortable.js"), thisPage);
            _thisPage = thisPage;
        }
        public DragNDrop(Page thisPage)
        {            
            _thisPage = thisPage;
        }
        public void MakeColumnDragNDrop(string ColumnID, string WidgetDomElement, string UpdateURL)
        {

            string Script = string.Format("$('{0}').CreateColumn('{1}','{2}');", ColumnID, WidgetDomElement, UpdateURL);
            JScripter.InjectScript(Script, _thisPage);
        }
        public void MakeColumnDragNDrop(string ColumnID, string WidgetDomElement, string UpdateURL,string ConnectedDomElement)
        {

            string Script = string.Format("$('{0}').CreateConnectedColumn('{1}','{2}','{3}');", ColumnID, WidgetDomElement, UpdateURL, ConnectedDomElement);
            JScripter.InjectScript(Script, _thisPage);
        }

    }
}

