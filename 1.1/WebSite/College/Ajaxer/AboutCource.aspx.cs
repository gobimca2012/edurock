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

public partial class College_Ajaxer_AboutCource : AjaxPage
{
    public int _InstituteID
    {
        get
        {
            return Convert.ToInt32(Request.Params["iid"]);
        }

    }
    private int _InstituteCourceID
    {
        get
        {
            return Convert.ToInt32(Request.Params["icid"]);
        }
    }
    protected override void OnLoad(EventArgs e)
    {
        IsLogginMandatory = false;
        BindData();
        objLoader.ClearArea("#inheader");
        objLoader.ClearArea("#iuser");
        objLoader.ClearArea("#indesc");
        base.OnLoad(e);
    }
    
    private void BindData()
    {
        var data = new InstituteCourceController().GetbyInstituteCourceID(_InstituteCourceID);
        if (data.Count > 0)
        {
            if (data[0].MetaDescription != null)
            {
                lblDescription.InnerHtml = data[0].MetaDescription;
            }
            if (data[0].IsFree != null)
            {
                if ((bool)data[0].IsFree)
                    lblprice.InnerHtml = "Free Cource you can Join this Cource";
            }
            if (data[0].Price != null)
            {
                lblprice.InnerText = "price of Cource :" + data[0].Price.ToString();
            }
            if (data[0].StartDate.Value != null && data[0].EndDate.Value!=null)
            {
                lblDuration.InnerText = "Cource Start From " + CommonController.GetDate(data[0].StartDate.Value) + " to " + CommonController.GetDate(data[0].EndDate.Value);
            }
            if (data[0].InstituteSubjects != null)
            {
                listSubject.DataSource = data[0].InstituteSubjects;
                listSubject.DataBind();
            }
            var dataUser = new UserController().GetUser(_InstituteCourceID, _InstituteID);
            ListCourceUser.DataSource = dataUser;
            ListCourceUser.DataBind();
        }
    }
}
