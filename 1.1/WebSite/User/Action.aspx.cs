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

public partial class User_Action :AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.Params["ch"]!=null)
            Response.Cookies[CookieName.FullMode.ToString()].Value = Request.Params["ch"];
    }
}
