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

public partial class User_DashBoard : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        new JScripter.Widget(this.Page, true);
        new JScripter.DragNDrop(this.Page, true);
        objLoader.LoadPage("#lander", ResolveUrl("~/User/AjaxControl/Lander.aspx") + "?usid=" + Request.Params["usid"] + "&ptype=u");
        JScripter.JScripter.IncludeJavascriptFile("tinyeditor", ResolveUrl("~/Jscript/tinymce/jscripts/tiny_mce/tiny_mce.js"), this.Page);
        objLoader.LoadPage("#contentBox", ResolveUrl("~/User/WidgetPage.aspx") + "?usid=" + Request.Params["usid"] );


    }
}
