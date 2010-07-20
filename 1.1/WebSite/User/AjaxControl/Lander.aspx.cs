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

public partial class User_AjaxControl_Lander : AjaxPage
{
    private int ICID
    {
        get
        {
            if (Request.Params["icid"] != null)
            {
                return Convert.ToInt32(Request.Params["icid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    private int ISID
    {
        get
        {
            if (Request.Params["isid"] != null)
            {
                return Convert.ToInt32(Request.Params["isid"]);
            }
            else
            {
                return 0;
            }
        }
    }
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
                return 0;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lnkQ.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkEvent.NavigateUrl = ResolveUrl("~/User/AjaxControl/EventInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkArticle.NavigateUrl = ResolveUrl("~/User/AjaxControl/ArticleInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkAll.NavigateUrl = ResolveUrl("~/User/AjaxControl/AllContent.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        //lnktut.NavigateUrl = ResolveUrl("~/All/Ajaxer/TutorialInfoView.aspx") + "?icid=" + ICID.ToString();
        lnkExam.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkHomeWork.NavigateUrl = ResolveUrl("~/User/AjaxControl/HomeWorkInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkImage.NavigateUrl = ResolveUrl("~/User/AjaxControl/ImageInfoView.aspx") + "?dtype=1&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkDocument.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfoView.aspx") + "?dtype=4&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkAudio.NavigateUrl = ResolveUrl("~/User/AjaxControl/AudioInfoView.aspx") + "?dtype=3&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkVideo.NavigateUrl = ResolveUrl("~/User/AjaxControl/VideoInfoView.aspx") + "?dtype=2&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkUsers.NavigateUrl = ResolveUrl("~/User/AjaxControl/ICUserInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        if (LoginUserID > 0)
        {
        }
        else
        {
            new JScripter.Loader(this.Page, false).LoadPage("#contentBox", ResolveUrl("~/User/AjaxControl/AllContent.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString());
        }

    }
}
