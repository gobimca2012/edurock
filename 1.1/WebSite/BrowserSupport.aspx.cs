using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class BrowserSupport : AjaxPage
{
    protected override void OnInit(EventArgs e)
    {
        this.IsLogginMandatory = false;
        base.OnInit(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        mz.Src=ResolveUrl("images/browser-mozilla-firefox.png");
        ch.Src = ResolveUrl("images/browser-google-chrome.png");
        op.Src=ResolveUrl("images/browser-opera.png");
        sf.Src = ResolveUrl("images/browser-apple-safari.png");
        ie.Src = ResolveUrl("images/browser-microsoft-ie.png");
    }
}
