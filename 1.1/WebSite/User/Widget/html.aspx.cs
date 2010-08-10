using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BusinessLogic;
using Common;

public partial class User_Widget_html : WidgetControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtEditor.Text = txtEditor.ID;
        new JScripter.Widget(this.Page, false).DeleteLinkButton(CustomHelper.GetGuidString(WidgetID), ResolveUrl("~/User/Widget/WidgetAction.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID), lnkClose);
    }
    protected void AjaxDeleteWidget(object sender, AjaxControl.AjaxEventArg e)
    {
        new WidgetController().DeletebyWidgetID(WidgetID);
    }
}
