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

public partial class User_AjaxControl_Ratting : AjaxPage
{
    private int ContentType
    {
        get
        {
            return Convert.ToInt16(Request.Params["ctype"]);
        }
    }
    private string ContentID
    {
        get
        {
            return Request.Params["cid"];
        }
    }
    private int Rate
    {
        get
        {
            return Convert.ToInt16(Request.Params["rt"]);

        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        RattingController objnewRatting = new RattingController();
        if (Request.Params["rt"] != null)
        {
            
            objnewRatting.UpdateByRattingID(Rate, ContentType, ContentID);
        }
        var data = objnewRatting.GetbyContentID(ContentID,ContentType);
        if (data.Count > 0)
        {
            lblrate.InnerText = data[0].Rating.ToString();
        }
        else
        {
            lblrate.InnerText = "Yet not ratted";
        }
        
    }
}
