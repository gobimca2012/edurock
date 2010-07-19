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

public partial class MasterPage_Default : System.Web.UI.MasterPage
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
        new JScripter.Loader(this.Page, true).LoadPage("#icource", ResolveUrl("~/User/AjaxControl/InstituteCourceInfoView.aspx"));
        new JScripter.Loader(this.Page, true).LoadPage("#st", ResolveUrl("~/User/AjaxControl/Status.aspx"));
        new JScripter.Loader(this.Page, true).LoadPage("#mylander", ResolveUrl("~/User/AjaxControl/MyLander.aspx"));
        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.Collapspanel("#questiontrg", "#questiontrgbox");
        objEffect.Collapspanel("#messageHead", "#messagepn");
        objEffect.Collapspanel("#tut", "#tutbox");
        objEffect.Collapspanel("#mymenu", "#mymenupanel");
        objEffect.Collapspanel("#courcel", "#icource");
        if (new UserAuthontication().IsLoggedIn)
        {
            var UserData = new UserController().GetbyLoginUserID(LoginUserID);
            if (UserData.Count > 0)
            {
                if (UserData[0].PhotoPath != null)
                    img.ImageUrl = ResolveUrl(UserData[0].PhotoPath);
            }
            if (new UserAuthontication().UserType == UserTypeEnum.College)
            {
                divAdmin.Visible = true;
            }
        }
        if (this.Request.Url.AbsolutePath.Contains("DashBoard"))
        {
            dash.Attributes["class"] = "gsad";
        }
        else if (this.Request.Url.AbsolutePath.Contains("AccountSetting"))
        {
            acc.Attributes["class"] = "gsad";
        }
        else if (this.Request.Url.AbsolutePath.Contains("Admin"))
        {
            divAdmin.Attributes["class"] = "gsad";
        }

    }
}
