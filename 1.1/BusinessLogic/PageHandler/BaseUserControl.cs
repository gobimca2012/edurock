using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class BaseUserControl:System.Web.UI.UserControl
    {
        
        public Dictionary<string, string> CallStatus;
        protected override void OnInit(EventArgs e)
        {
            CallStatus = new Dictionary<string, string>();
            base.OnInit(e);
        
        }
        
    }
}
