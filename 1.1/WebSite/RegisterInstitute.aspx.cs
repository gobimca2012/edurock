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

public partial class RegisterInstitute : BasePage
{
    protected override void OnLoad(EventArgs e)
    {
        IsLogginMandatory = false;
        //objLoader.LoadPage("#contentBox", ResolveUrl("~/All/Ajaxer/RegisterInstitute.aspx"));
        base.OnLoad(e);
    }
    
}
