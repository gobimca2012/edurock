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

public partial class College_Ajaxer_InstituteCourceUser : AjaxPage
{
    public int _InstituteID
    {
        get
        {
            return Convert.ToInt32(Request.Params["iid"]);
        }

    }
    public int _InstituteCourceID
    {
        get
        {
            return Convert.ToInt32(Request.Params["icid"]);
        }

    }
    protected override void OnLoad(EventArgs e)
    {
        IsLogginMandatory = false;
        Binddata();
        base.OnLoad(e);
    }

    private void Binddata()
    {

        var data = new UserController().GetUser(_InstituteCourceID, _InstituteID);
        ListUser.DataSource = data;
        ListUser.DataBind();
    }
}
