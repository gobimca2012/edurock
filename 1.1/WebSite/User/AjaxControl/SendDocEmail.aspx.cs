using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class User_AjaxControl_SendDocEmail : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string aaa = string.Format("$('#{0}').ajaxToolTipclose();", lnkclose.ClientID);
        JScripter.JScripter.InjectScript(aaa, this.Page);
    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {

    }
}