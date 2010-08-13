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

public partial class User_Action : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["ch"] != null)
            Response.Cookies[CookieName.FullMode.ToString()].Value = Request.Params["ch"];
        if (Request.QueryString["wid"] != null && Request.QueryString["wid"] == "ser")
        {

            string idpart2 = Request.QueryString[1];
            string[] AllWidgets = idpart2.Split(',');
            for (int wo = 0; wo < AllWidgets.Length; wo++)
            {
                new WidgetHelper().UpdateWidgetOrder(new Guid(AllWidgets[wo]), wo + 1);
            }




        }
    }
}
