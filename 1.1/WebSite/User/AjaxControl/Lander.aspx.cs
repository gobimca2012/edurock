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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ICID > 0)
        {
            lnkQ.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfoView.aspx") + "?icid=" + ICID.ToString();
            lnktut.NavigateUrl = ResolveUrl("~/All/Ajaxer/TutorialInfoView.aspx") + "?icid=" + ICID.ToString();
            lnkExam.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfoView.aspx") + "?icid=" + ICID.ToString();
            lnkHomeWork.NavigateUrl = ResolveUrl("~/User/AjaxControl/HomeWorkInfoView.aspx") + "?icid=" + ICID.ToString();
            lnkImage.NavigateUrl = ResolveUrl("~/User/AjaxControl/ImageInfoView.aspx") + "?dtype=1&icid=" + ICID.ToString();
            lnkDocument.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfoView.aspx") + "?dtype=4&icid=" + ICID.ToString();
            lnkAudio.NavigateUrl = ResolveUrl("~/User/AjaxControl/AudioInfoView.aspx") + "?dtype=3&icid=" + ICID.ToString();
            lnkVideo.NavigateUrl = ResolveUrl("~/User/AjaxControl/VideoInfoView.aspx") + "?dtype=2&icid=" + ICID.ToString();
            string Script = "$('#contentBox').html('');";
            JScripter.JScripter.InjectScript(Script, this.Page);

        }
        else
        {
            lnkQ.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfoView.aspx");
            lnktut.NavigateUrl = ResolveUrl("~/All/Ajaxer/TutorialInfoView.aspx");
            lnkExam.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfoView.aspx");
            lnkHomeWork.NavigateUrl = ResolveUrl("~/User/AjaxControl/HomeWorkInfoView.aspx");
            lnkImage.NavigateUrl = ResolveUrl("~/User/AjaxControl/ImageInfoView.aspx") + "?dtype=1";
            lnkDocument.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfoView.aspx") + "?dtype=4";
            lnkAudio.NavigateUrl = ResolveUrl("~/User/AjaxControl/AudioInfoView.aspx") + "?dtype=3";
            lnkVideo.NavigateUrl = ResolveUrl("~/User/AjaxControl/VideoInfoView.aspx") + "?dtype=2";
        }
       
       
    }
}
