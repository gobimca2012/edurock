﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MasterPage_Default : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        new JScripter.Loader(this.Page, true).LoadPage("#icource", ResolveUrl("~/User/AjaxControl/InstituteCourceInfoView.aspx"));
        new JScripter.Loader(this.Page, true).LoadPage("#st", ResolveUrl("~/User/AjaxControl/Status.aspx"));
        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.Collapspanel("#questiontrg", "#questiontrgbox");
        objEffect.Collapspanel("#messageHead", "#messagepn");
        objEffect.Collapspanel("#tut", "#tutbox");
        objEffect.Collapspanel("#courcel", "#icource");

    }
}
