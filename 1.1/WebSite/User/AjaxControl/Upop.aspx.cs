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

public partial class User_AjaxControl_Upop : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["lid"] != null)
        {
            Binddata();
        }
    }
    private void Binddata()
    {
        var dataBunch = new UserController().GetbyLoginUserID(Convert.ToInt32(Request.Params["lid"]));
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            lblName.InnerText = data.StudentLogin.Username;
            propic.ImageUrl = ResolveUrl(data.PhotoPath);
        }
    }
}
