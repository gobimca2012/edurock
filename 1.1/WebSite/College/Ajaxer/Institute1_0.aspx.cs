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

public partial class College_Ajaxer_Institute1_0 : AjaxPage
{
    public int _InstituteID
    {
        get
        {
            return Convert.ToInt32(Request.Params["iid"]);
        }

    }
    protected override void OnLoad(EventArgs e)
    {
        this.IsLogginMandatory = false;
        BindData();
        base.OnLoad(e);
    }
    private void BindData()
    {
        var data = new InstituteController().GetbyInstituteID(_InstituteID);
        if (data.Count > 0)
        {
            lblDescription.InnerHtml = data[0].Description;
        }
    }
}
