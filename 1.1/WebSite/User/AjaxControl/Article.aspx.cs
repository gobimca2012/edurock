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

public partial class User_AjaxControl_Article : AjaxPage
{

    private void BindData()
    {
        var dataBunch = new ArticleController().GetbyArticleID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            if (data.LoginUserID != null)
            {
                
                FullViewSideInfo1.LoginUserID = data.LoginUserID;
                FullViewSideInfo1.ModifiedDate = data.ModifiedDate;
                FullViewSideInfo1.CourceID = data.InstituteCourceID;
                FullViewSideInfo1.SubjectID =(int) data.InstituteSubjectID;
            }

            if (data.Title != null)

                lblTitle.InnerHtml = data.Title.ToString();

            if (data.Description != null)

                lblDescription.InnerHtml = data.Description.ToString();

            if (data.MetaDescription != null)

                lblMetaDescription.InnerHtml = data.MetaDescription.ToString();

            
            if (data.Tag != null)

                lblTag.InnerHtml = data.Tag.ToString();

            if (data.Rating != null)

                lblRating.InnerHtml = data.Rating.ToString();

            lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/ArticleInfo.aspx") + "?arid=" + data.ArticleID.ToString();
        }

    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["arid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["arid"] != null)
        {
            AjaxState["arid"] = Request.Params["arid"];
        }
        BindData();
    }

}
