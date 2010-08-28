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
public partial class Home_Institute : BasePage
{
    protected override void OnInit(EventArgs e)
    {
        IsLogginMandatory = false;
        base.OnInit(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        new JScripter.Widget(this.Page, true);
        new JScripter.DragNDrop(this.Page, true);
        JScripter.JScripter.IncludeJavascriptFile("tinyeditor", ResolveUrl("~/Jscript/tinymce/jscripts/tiny_mce/tiny_mce.js"), this.Page);
        var data = new InstituteController().Get();
        if (data.Count > 0)
        {
            //objLoader.LoadPage("#inheader", ResolveUrl("~/College/Ajaxer/AboutInstitute.aspx") + "?iid=" + data[0].InstituteID.ToString());
            objLoader.LoadPage("#incource", ResolveUrl("~/College/Ajaxer/InstituteCourceList.aspx") + "?iid=" + data[0].InstituteID.ToString());
            //objLoader.LoadPage("#indesc", ResolveUrl("~/College/Ajaxer/Institute1_0.aspx") + "?iid=" + data[0].InstituteID.ToString());
            //objLoader.LoadPage("#iuser", ResolveUrl("~/College/Ajaxer/InstituteUser.aspx") + "?iid=" + data[0].InstituteID.ToString());
            objLoader.LoadPage("#contentBox", ResolveUrl("~/college/widget/WidgetPage.aspx")) ;
        }
    }
}
