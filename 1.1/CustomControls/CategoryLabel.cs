using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.HtmlControls;
using BusinessLogic.Controller;
using System.Web.UI.WebControls;

namespace CustomControls
{
    public class CategoryLabel:Label
    {
        protected override void OnInit(EventArgs e)
        {
            var data = new PortalSettingHelper().Get();
            this.Text = data.SubjectHeader;
            base.OnInit(e);
        }
    }
}
