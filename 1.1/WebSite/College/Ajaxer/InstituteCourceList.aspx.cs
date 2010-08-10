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

public partial class College_Ajaxer_InstituteCourceList : AjaxPage
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
        BindCource();
        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.Collapspanel("#courseboxtrigger", "#coursebox");
        base.OnLoad(e);
    }
    private void BindCource()
    {
        var data = new InstituteCourceController().GetbyInstituteID(_InstituteID);
        listCource.DataSource = data;
        listCource.DataBind();
    }
}
