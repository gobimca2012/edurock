﻿using System;
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
//        if (ICID > 0)
        {
            lnkMyQuestion.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfoView.aspx") + "?icid=" + ICID.ToString()+"&usid="+LoginUserID.ToString();
            lnkMyAll.NavigateUrl = ResolveUrl("~/User/AjaxControl/AllContent.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            //lnktut.NavigateUrl = ResolveUrl("~/All/Ajaxer/TutorialInfoView.aspx") + "?icid=" + ICID.ToString();
            lnkMyExam.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyHomeWork.NavigateUrl = ResolveUrl("~/User/AjaxControl/HomeWorkInfoView.aspx") + "?icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyImage.NavigateUrl = ResolveUrl("~/User/AjaxControl/ImageInfoView.aspx") + "?dtype=1&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyDocument.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfoView.aspx") + "?dtype=4&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyAudio.NavigateUrl = ResolveUrl("~/User/AjaxControl/AudioInfoView.aspx") + "?dtype=3&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            lnkMyVideo.NavigateUrl = ResolveUrl("~/User/AjaxControl/VideoInfoView.aspx") + "?dtype=2&icid=" + ICID.ToString() + "&usid=" + LoginUserID.ToString();
            //string Script = "$('#contentBox').html('');";
            //JScripter.JScripter.InjectScript(Script, this.Page);



        }
        //else
        //{
        //    lnkAll.NavigateUrl = ResolveUrl("~/User/AjaxControl/AllContent.aspx");
        //    lnkQ.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfoView.aspx");
        //    //lnktut.NavigateUrl = ResolveUrl("~/All/Ajaxer/TutorialInfoView.aspx");
        //    lnkExam.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfoView.aspx");
        //    lnkHomeWork.NavigateUrl = ResolveUrl("~/User/AjaxControl/HomeWorkInfoView.aspx");
        //    lnkImage.NavigateUrl = ResolveUrl("~/User/AjaxControl/ImageInfoView.aspx") + "?dtype=1";
        //    lnkDocument.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfoView.aspx") + "?dtype=4";
        //    lnkAudio.NavigateUrl = ResolveUrl("~/User/AjaxControl/AudioInfoView.aspx") + "?dtype=3";
        //    lnkVideo.NavigateUrl = ResolveUrl("~/User/AjaxControl/VideoInfoView.aspx") + "?dtype=2";
        //    //new JScripter.Loader(this.Page, false).LoadPage("contentBox", ResolveUrl("~/User/AjaxControl/QuestionInfoView.aspx"));
        //}
        //lnkAll.NavigateUrl = ResolveUrl("~/User/AjaxControl/AllContent.aspx") + "?icid=" + ICID.ToString();
        //new JScripter.Loader(this.Page, false).LoadPage("#contentBox", ResolveUrl("~/User/AjaxControl/AllContent.aspx") + "?icid=" + ICID.ToString()+"&usid="+LoginUserID.ToString());

    }
}
