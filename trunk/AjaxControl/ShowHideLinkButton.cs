using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web.UI.WebControls;
using System.Web;
using System.Web.UI;
namespace AjaxControl
{
    public class ShowHideLinkButton:LinkButton
    {
        public bool Show
        {
            get;
            set;
        }
        public string ContainnerID
        {
            get;
            set;
        }
        protected override void OnLoad(EventArgs e)
        {
            JScripter.Effect objEffect = new JScripter.Effect((Page)HttpContext.Current.Handler, false);
            if (Show)
                objEffect.ShowonClick(this, ContainnerID);
            else
                objEffect.HideOnClick(this, ContainnerID);
            base.OnLoad(e);
        }
    }
}
