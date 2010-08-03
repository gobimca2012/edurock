using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace JScripter
{
    public class Player
    {
        Page _thisPage;
        public Player(Page thisPage)
        {
            JScripter.IncludeJavascriptFile("swfobject.js", thisPage.ResolveUrl("~/VideoFile/swfobject.js"), thisPage);
            _thisPage = thisPage;
        }
        public void CreatePlayer(string VideoPath,string PlayerContainnerID)
        {
            string script = string.Format("CreateVideoPlayer('{0}','{1}','{2}');", VideoPath, PlayerContainnerID,_thisPage.ResolveUrl("~/VideoFile/player.swf"));            
            System.Web.UI.Page aspxPage = new System.Web.UI.Page();
            String csname1 = Guid.NewGuid().ToString().Replace("-", "");
            aspxPage = _thisPage;
            Type cstype = aspxPage.GetType();
            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = aspxPage.ClientScript;
            if (!cs.IsStartupScriptRegistered(cstype, csname1))
            {
                cs.RegisterStartupScript(cstype, csname1, script, true);
            }
        }
    }
}
