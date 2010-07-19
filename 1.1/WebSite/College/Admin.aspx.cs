﻿using System;
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

public partial class College_Admin : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        objLoader.LoadPage("#lander", ResolveUrl("~/College/Ajaxer/AdminLander.aspx"));
        JScripter.JScripter.IncludeJavascriptFile("tinyeditor", ResolveUrl("~/Jscript/tinymce/jscripts/tiny_mce/tiny_mce.js"), this.Page);
    }
}
