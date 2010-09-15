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

public partial class User_AjaxControl_MyLander : AjaxPage
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
           
            {
                return new UserAuthontication().LoggedInUserID;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
            lnkMyQuestion.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfoView.aspx") + "?icid=" + ICID.ToString()+"&usid="+LoginUserID.ToString();
            lnkMyArticle.NavigateUrl = ResolveUrl("~/User/AjaxControl/ArticleInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyAll.NavigateUrl = ResolveUrl("~/User/AjaxControl/AllContent.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            //lnkMyAll.NavigateUrl= ResolveUrl("~/User/WidgetPage.aspx") + "?usid=" + Request.Params["usid"];
            //lnktut.NavigateUrl = ResolveUrl("~/All/Ajaxer/TutorialInfoView.aspx") + "?icid=" + ICID.ToString();
            lnkMyExam.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyHomeWork.NavigateUrl = ResolveUrl("~/User/AjaxControl/HomeWorkInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyImage.NavigateUrl = ResolveUrl("~/User/AjaxControl/ImageInfoView.aspx") + "?dtype=1&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyDocument.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfoView.aspx") + "?dtype=4&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyAudio.NavigateUrl = ResolveUrl("~/User/AjaxControl/AudioInfoView.aspx") + "?dtype=3&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyVideo.NavigateUrl = ResolveUrl("~/User/AjaxControl/VideoInfoView.aspx") + "?dtype=2&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyResult.NavigateUrl = ResolveUrl("~/User/AjaxControl/UserExamResult.aspx");
            
            
    }
}
