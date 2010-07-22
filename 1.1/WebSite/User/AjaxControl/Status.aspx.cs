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

public partial class User_AjaxControl_Status : AjaxPage
{
    private int _UID
    {

        get
        {
            return Convert.ToInt32(AjaxState["uid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lblStatus.InnerText = new UserController().GetUserStatus(new UserAuthontication().LoggedInUserID);
    }
    protected void UpdateAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        string Status = HtmlHelper.ControlValue(txtStatus.ClientID);
        new UserController().UpdateUserStatus(new UserAuthontication().LoggedInUserID, Status);
        lblStatus.InnerText = new UserController().GetUserStatus(new UserAuthontication().LoggedInUserID);
    }
}
