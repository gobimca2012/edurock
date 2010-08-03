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
using Common;

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
        lnkImage.NavigateUrl = ResolveUrl("~/User/AjaxControl/ImageInfoView.aspx") + "?dtype=" + (int)ContentTypeEnum.Image + "&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkDocument.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfoView.aspx") + "?dtype="+(int)ContentTypeEnum.Document+"&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkAudio.NavigateUrl = ResolveUrl("~/User/AjaxControl/AudioInfoView.aspx") + "?dtype="+(int)ContentTypeEnum.Audio+"&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkVideo.NavigateUrl = ResolveUrl("~/User/AjaxControl/VideoInfoView.aspx") + "?dtype="+(int)ContentTypeEnum.Video+"&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
        lnkUsers.NavigateUrl = ResolveUrl("~/User/AjaxControl/ICUserInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
      
        {
            new JScripter.Loader(this.Page, false).LoadPage("#contentBox", ResolveUrl("~/User/AjaxControl/AllContent.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString());
        }
        string Script = "";
        if (ICID > 0 && LoginUserID > 0)
        {
            string CourceName = new InstituteCourceController().GetInstituteCourceName(ICID);
            var data = new UserController().GetbyLoginUserID(LoginUserID);
            Script = string.Format("$('#headingBox').html('{0}');",">> "+ CourceName+" >> "+data[0].FirstName+" "+data[0].LastName);
        }
        else if (ICID>0)
        {
            string CourceName=new InstituteCourceController().GetInstituteCourceName(ICID);
            Script = string.Format("$('#headingBox').html('{0}');", ">> " + CourceName);
        }
        else if (LoginUserID > 0)
        {
            var data = new UserController().GetbyLoginUserID(LoginUserID);
            Script = string.Format("$('#headingBox').html('{0}');", ">> " + data[0].FirstName + " " + data[0].LastName);
        }
        else
        {
            var data = new InstituteController().GetbyInstituteID(new UserAuthontication().UserInstituteID);
            Script = string.Format("$('#headingBox').html('{0}');", ">> " + data[0].Name);
        }
        
        objLoader.InjectScript(Script, this.Page);
    }
}
