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

public partial class User_UserControl_Ratting : System.Web.UI.UserControl
{
    public int ContentType
    {
        get;
        set;
    }
    public string ContentID
    {
        get;
        set;
    }

    
    protected override void OnPreRender(EventArgs e)
    {
        if (ContentID != null && ContentID != "" && ContentType > 0)
        {
            JScripter.Loader objLoader = new JScripter.Loader(this.Page, false);
            objLoader.LoadPage("#rattingbox", ResolveUrl("~/User/AjaxControl/Ratting.aspx") + "?cid=" + ContentID + "&ctype=" + ContentType.ToString());
            lnkDownrate.NavigateUrl = ResolveUrl("~/User/AjaxControl/Ratting.aspx") + "?rt=-1&cid=" + ContentID + "&ctype=" + ContentType.ToString();
            lnkUprate.NavigateUrl = ResolveUrl("~/User/AjaxControl/Ratting.aspx") + "?rt=1&cid=" + ContentID + "&ctype=" + ContentType.ToString();
        }
        base.OnPreRender(e);
    }
}
