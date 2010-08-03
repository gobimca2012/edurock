using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using BusinessLogic;

public partial class MasterPage_OutSideUser : System.Web.UI.MasterPage
{
    private int LoginUserID
    {
        get
        {
            if (Request.Params["usid"] != null)
            {
                return Convert.ToInt32(Request.Params["usid"]);
            }
            else
            {
                return new UserAuthontication().LoggedInUserID;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        var data = new InstituteController().Get();
        if (data.Count > 0)
            if (data[0].Logo != null)
                imgLogo.ImageUrl = ResolveUrl(data[0].Logo);


    }
}
