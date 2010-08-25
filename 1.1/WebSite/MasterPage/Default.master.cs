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
using BusinessLogic.Controller;

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
                //return new UserAuthontication().LoggedInUserID;
                return 0;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        var data=new PortalSettingHelper().Get();
        lblSpace.InnerText = data.CourseHeader;
        if (Request.Cookies[CookieName.FullMode.ToString()] != null && Request.Cookies[CookieName.FullMode.ToString()].Value == "1")
        {
            //pagecon.Style.Add("width", "100%");
            pagecon.Attributes["class"] = "fpage";
            string script = string.Format("$('#{0}').fullMode('{1}','{2}','{3}');", lnkFullMode.ClientID, "#" + pagecon.ClientID, ResolveUrl("~/User/Action.aspx") + "?ch=0", "1000px");
            JScripter.JScripter.InjectScript(script, this.Page);
        }
        else
        {
            string script = string.Format("$('#{0}').fullMode('{1}','{2}','{3}');", lnkFullMode.ClientID, "#" + pagecon.ClientID, ResolveUrl("~/User/Action.aspx") + "?ch=1", "100%");
            JScripter.JScripter.InjectScript(script, this.Page);
            //pagecon.Style.Add("width", "1000px");
            pagecon.Attributes["class"] = "page";
        }
        new JScripter.Loader(this.Page, true).LoadPage("#st", ResolveUrl("~/User/AjaxControl/Status.aspx"));
        //if (!new UserAuthontication().IsOwn(LoginUserID))
        {
            new JScripter.Loader(this.Page, true).LoadPage("#icource", ResolveUrl("~/User/AjaxControl/InstituteCourceInfoView.aspx") + "?usid=" + LoginUserID.ToString());
        }
        //else
        //{
        //    new JScripter.Loader(this.Page, true).LoadPage("#icource", ResolveUrl("~/User/AjaxControl/InstituteCourceInfoView.aspx"));    
        //}

        new JScripter.Loader(this.Page, true).LoadPage("#mylander", ResolveUrl("~/User/AjaxControl/MyLander.aspx"));

        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.Collapspanel("#questiontrg", "#questiontrgbox");
        objEffect.Collapspanel("#messageHead", "#messagepn");
        objEffect.Collapspanel("#tut", "#tutbox");
        objEffect.Collapspanel("#mymenu", "#mymenupanel");
        objEffect.Collapspanel("#courcel", "#icource");
        if (new UserAuthontication().IsLoggedIn)
        {
            int ProfileLogginUserID = 0;
            if (LoginUserID > 0)
            {
                ProfileLogginUserID = LoginUserID;
            }
            else
            {
                ProfileLogginUserID = new UserAuthontication().LoggedInUserID;
            }
            var UserData = new UserController().GetbyLoginUserID(ProfileLogginUserID);
            if (UserData.Count > 0)
            {
                if (UserData[0].PhotoPath != null)
                {
                    img.ImageUrl = ResolveUrl(UserData[0].PhotoPath);
                }
                if (UserData[0].FirstName != null && UserData[0].LastName != null)
                {
                    lblName.InnerHtml = UserData[0].FirstName + "&nbsp; " + UserData[0].LastName;
                }
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
