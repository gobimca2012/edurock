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
        //JScripter.JScripter.IncludeJavascriptFile("file", ResolveUrl("~/Jscript/jquery.iframe-post-form.js"), this.Page);
        objLoader.LoadPage("#lander", ResolveUrl("~/User/AjaxControl/Lander.aspx")+"?usid="+Request.Params["usid"]);
    //    objLoader.LoadPage("#contentBox", ResolveUrl("~/User/AjaxControl/QuestionInfoView.aspx"));
        objLoader.LoadPage("#contentBox", ResolveUrl("~/User/AjaxControl/PublicUserInfoView.aspx")+"?usid="+Request.Params["usid"]);
    }
}
