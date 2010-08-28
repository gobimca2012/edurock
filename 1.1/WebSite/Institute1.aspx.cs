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

public partial class Institute : BasePage
{
    protected override void OnLoad(EventArgs e)
    {


        this.IsLogginMandatory = false;
        var data = new InstituteController().Get();
        if (data.Count > 0)
        {
            objLoader.LoadPage("#inheader", ResolveUrl("~/College/Ajaxer/AboutInstitute.aspx") + "?iid=" + data[0].InstituteID.ToString());
            objLoader.LoadPage("#incource", ResolveUrl("~/College/Ajaxer/InstituteCourceList.aspx") + "?iid=" + data[0].InstituteID.ToString());
            objLoader.LoadPage("#indesc", ResolveUrl("~/College/Ajaxer/Institute1_0.aspx") + "?iid=" + data[0].InstituteID.ToString());
            //objLoader.LoadPage("#incon", ResolveUrl("~/College/Ajaxer/InstituteContactInfo.aspx") + "?iid=" + data[0].InstituteID.ToString());
        }
        base.OnLoad(e);
    }
}
