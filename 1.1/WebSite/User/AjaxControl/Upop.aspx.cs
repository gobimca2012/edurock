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
using System.Collections.Generic;
using Common;

public partial class User_AjaxControl_Upop : AjaxPage
{
    private int _LoginUserID
    {
        get
        {
            return Convert.ToInt32(Request.Params["lid"]);
        }
    }
    public string GetCSSClass(string ContentType)
    {
        string CssClass = "";

        if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Question)
        {
            CssClass = "ques";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Document)
        {
            CssClass = "doc";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Image)
        {
            CssClass = "img";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Video)
        {
            CssClass = "vid";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Audio)
        {
            CssClass = "aud";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.HomeWork)
        {
            CssClass = "howo";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Exam)
        {
            CssClass = "exm";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Event)
        {
            CssClass = "evt";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Article)
        {
            CssClass = "art";
        }
        return CssClass;
    }
    public string getURL(string ContentType, string ID)
    {
        string URL = "";

        if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Question)
        {
            URL = ResolveUrl("~/User/AjaxControl/Question.aspx") + "?qid=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Document)
        {
            URL = ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Image)
        {
            URL = ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Video)
        {
            URL = ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Audio)
        {
            URL = ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.HomeWork)
        {
            URL = ResolveUrl("~/User/AjaxControl/HomeWork.aspx") + "?hwid=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Exam)
        {
            URL = ResolveUrl("~/User/AjaxControl/exam.aspx") + "?eid=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Article)
        {
            URL = ResolveUrl("~/User/AjaxControl/Article.aspx") + "?arid=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Event)
        {
            URL = ResolveUrl("~/User/AjaxControl/Event.aspx") + "?evid=" + ID;
        }
        return URL;
    }
    protected void ListQuestionOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string ID = ListQuestion.DataKeys[currentItem.DataItemIndex]["ID"].ToString();
        string ContentType = ListQuestion.DataKeys[currentItem.DataItemIndex]["ContentType"].ToString();
        AjaxControl.HyperLink lnkFull = (AjaxControl.HyperLink)currentItem.FindControl("lnkFull");
        if (lnkFull != null)
        {

        }



    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["lid"] != null)
        {
            Binddata();
            lnkUserProfile.NavigateUrl = ResolveUrl("~/User/User.aspx") + "?usid=" + Request.Params["lid"];
            BindRecentContent();
        }
        string aaa = string.Format("$('#{0}').ajaxToolTipclose();", lnkclose.ClientID);
        JScripter.JScripter.InjectScript(aaa, this.Page);
    }
    private void BindRecentContent()
    {
        ListQuestion.DataSource = new UserController().GetContent(_LoginUserID, 0, 0, (int)ContentTypeEnum.All, 5, 0);
        ListQuestion.DataBind();
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

            var userInRoles = new InstituteUserInUserTypeController().GetbyLoginUserID(data.LoginUserID);

            ugo = "";
            foreach (InstituteUserInUserType urole in userInRoles)
            {
                if (ugo != "")
                    ugo += ", " + urole.InstituteUserType.Name;
                else
                    ugo += " " + urole.InstituteUserType.Name;
            }

            lblRole.InnerHtml = ugo;

        }
    }
}
