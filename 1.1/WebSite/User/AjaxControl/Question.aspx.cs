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
            return new Guid(Request.Params["qid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
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

        if (data.QuestionID != null)

            lblQuestionID.InnerHtml = data.QuestionID.ToString();

        if (data.QuestionText != null)

            lblQuestionText.InnerHtml = data.QuestionText.ToString();

        if (data.Description != null)

            lblDescription.InnerHtml = data.Description.ToString();

        if (data.LoginUserID != null)

            lblLoginUserID.InnerHtml = data.LoginUserID.ToString();

        if (data.QuestionTypeID != null)

            lblQuestionTypeID.InnerHtml = data.QuestionTypeID.ToString();

        if (data.QuestionStatusID != null)

            lblQuestionStatusID.InnerHtml = data.QuestionStatusID.ToString();

        if (data.ModifiedDate != null)

            lblModifiedDate.InnerHtml = data.ModifiedDate.ToString();

    }

}
