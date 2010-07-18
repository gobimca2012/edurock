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
using DataEntity;

public partial class User_AjaxControl_Upop : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["lid"] != null)
        {
            Binddata();
            lnkUserProfile.NavigateUrl = ResolveUrl("~/User/User.aspx") + "?usid=" + Request.Params["lid"];
        }
        string aaa = string.Format("$('#{0}').ajaxToolTipclose();", lnkclose.ClientID);
        JScripter.JScripter.InjectScript(aaa, this.Page);
    }
    private void Binddata()
    {
        var dataBunch = new UserController().GetbyLoginUserID(Convert.ToInt32(Request.Params["lid"]));
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            lblStatus.InnerText = data.Status;
            lblName.InnerHtml = data.FirstName + " " + data.LastName;
            propic.ImageUrl = ResolveUrl(data.PhotoPath);
            lblUserName.InnerText = data.StudentLogin.Username;
            var usergroup = new InstituteController().GetInstituteByLoginUserID(data.LoginUserID);
            string ugo = "";
            foreach (GetInstituteByLoginUserIDResult du in usergroup)
            {
                if (ugo != "")
                    ugo += ", " + du.InstituteName;
                else
                    ugo += " " + du.InstituteName;
            }
            lblGroup.InnerHtml = ugo;
            var userCource = new InstituteCourceUserController().GetbyLoginUserID(data.LoginUserID);
            ugo = "";
            foreach (InstituteCourceUser ucouce in userCource)
            {
                if (ugo != "")
                    ugo += ", " + new InstituteCourceController().GetInstituteCourceName(ucouce.InstituteCourceID);
                else
                    ugo += " " + new InstituteCourceController().GetInstituteCourceName(ucouce.InstituteCourceID);
            }
           
            lblCource.InnerHtml = ugo;

        }
    }
}
