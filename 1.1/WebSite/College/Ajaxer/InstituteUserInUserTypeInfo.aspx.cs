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

public partial class College_Ajaxer_InstituteUserInUserTypeInfo : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        new InstituteUserTypeController().BindInstituteUserType(ddRoles);
       // if (!this.IsAjaxPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        var data = new InstituteUserController().GetbyInstituteID(new UserAuthontication().InstituteID);
        ListUser.DataSource = data;
        ListUser.DataBind();
    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        string aaa = "";
        string bb = aaa;
    }
}
