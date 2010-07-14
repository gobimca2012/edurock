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
        var data = new QuestionController().GetQuestionByQuestionID(ID,-1,-1);
        if (data.Count > 0)
        {
            BindData(data[0]);
        }
        objLoader = new JScripter.Loader(this.Page, false);
        objLoader.LoadPage("#Answer", ResolveUrl("~/User/AjaxControl/AnswerInfoView.aspx")+"?qid="+ID.ToString());
    }

    private void BindData(GetQuestionByQuestionIDResult data)
    {


        if (data.QuestionText != null)

            lblQuestionText.InnerHtml = data.QuestionText.ToString();

        if (data.Description != null)

            lblDescription.InnerHtml = data.Description.ToString();

        if (data.FirstName != null)

            user.InnerHtml = data.FirstName.ToString();

        if (data.QuestionType != null)

            lblQuestionTypeID.InnerHtml = data.QuestionType.ToString();

        if (data.QuestionStatus != null)

            lblQuestionStatusID.InnerHtml = data.QuestionStatus.ToString();

        if (data.ModifiedDate != null)

            lblModifiedDate.InnerHtml = data.ModifiedDate.ToString();

    }
    private void MakeLinks()
    {
        lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfo.aspx") + "?icid="+_InstituteCourceID.ToString()+"&qid=" + ID.ToString();
        lnkShare.NavigateUrl = ResolveUrl("~/User/AjaxControl/ShareInfo.aspx")  + "?qid=" + ID.ToString();
    }


}
