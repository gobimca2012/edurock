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
using DataEntity;
using Common;

public partial class User_AjaxControl_Question : AjaxPage
{
    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["qid"]);
        }
    }
    private int _InstituteCourceID
    {
        get
        {
            return Convert.ToInt32(AjaxState["icid"]);
        }
    }ShareContent UserAccess;
    private void ControlManager(int LoginUserID)
    {
        if (new UserAuthontication().IsOwn(LoginUserID))
        {

            lnkShare.Visible = true;

        }


        lnkEdit.Visible = UserAccess.IsEditablable;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
        }
        if (Request.Params["qid"] != null)
        {
            AjaxState["qid"] = Request.Params["qid"];
            MakeLinks();
        }
        var data = new QuestionController().GetbyQuestionID(ID);
        if (data.Count > 0)
        {
            BindData(data[0]);
        }
        objLoader = new JScripter.Loader(this.Page, false);
        objLoader.LoadPage("#Answer", ResolveUrl("~/User/AjaxControl/AnswerInfoView.aspx")+"?qid="+ID.ToString());
    }

    private void BindData(Question data)
    {


        if (data.QuestionText != null)

            lblQuestionText.InnerHtml = data.QuestionText.ToString();

        if (data.Description != null)

            lblDescription.InnerHtml = data.Description.ToString();

        
        if (data.QuestionType != null)

            lblQuestionTypeID.InnerHtml = data.QuestionType.ToString();

        

            lblQuestionStatusID.InnerHtml = new QuestionController().GetQuestionStatus(data.QuestionStatusID);

        if (data.ModifiedDate != null)
        {
//            lblModifiedDate.InnerHtml = data.ModifiedDate.ToString();
        }
        UserAccess = new ShareController().GetAccess(ID.ToString(), (int)ContentTypeEnum.Question, new UserAuthontication().LoggedInUserID, data.LoginUserID);
        if (!UserAccess.IsViewable)
        {
            Response.Redirect("~/Status/NoAccess.aspx");
        }
        FullViewSideInfo1.LoginUserID = data.LoginUserID;
        FullViewSideInfo1.ModifiedDate = data.ModifiedDate;
        FullViewSideInfo1.CourceID = (int)data.InstituteCourceID;
        FullViewSideInfo1.SubjectID = (int)data.InstituteSubjectID;
        FullViewSideInfo1.ContentType = (int)ContentTypeEnum.Question;
        FullViewSideInfo1.ContentID = data.QuestionID.ToString();
        ControlManager(data.LoginUserID);

    }
    private void MakeLinks()
    {
        //lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfo.aspx") + "?icid="+_InstituteCourceID.ToString()+"&qid=" + ID.ToString();
        lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfo.aspx") + "?qid=" + ID.ToString();
        lnkShare.NavigateUrl = ResolveUrl("~/User/AjaxControl/ShareInfo.aspx")  + "?conid=" + ID.ToString()+"&type="+((int)ContentTypeEnum.Question).ToString();
    }


}
