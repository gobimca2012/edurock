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

public partial class User_AjaxControl_Article : AjaxPage
{
    private void ControlManager(int LoginUserID)
    {
        if (new UserAuthontication().IsOwn(LoginUserID))
        {
            //lnkDelete.Visible = true;
            lnkShare.Visible = UserAccess.IsEditablable;

        }
        lnkEdit.Visible = UserAccess.IsEditablable;
    }

    private void BindData()
    {
        var dataBunch = new ArticleController().GetbyArticleID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            if (data.LoginUserID != null)
            {
                UserAccess = new ShareController().GetAccess(ID.ToString(), (int)ContentTypeEnum.Article, new UserAuthontication().LoggedInUserID, data.LoginUserID);
                if (!UserAccess.IsViewable)
                {
                    Response.Redirect("~/Status/NoAccess.aspx");
                }
                FullViewSideInfo1.LoginUserID = data.LoginUserID;
                FullViewSideInfo1.ModifiedDate = data.ModifiedDate;
                FullViewSideInfo1.CourceID = data.InstituteCourceID;
                FullViewSideInfo1.SubjectID = (int)data.InstituteSubjectID;
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
    ShareContent UserAccess;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["arid"] != null)
        {
            AjaxState["arid"] = Request.Params["arid"];
        }
        
        BindData();
        ControlManager(new UserAuthontication().LoggedInUserID);
        objLoader.LoadPage("#comment", ResolveUrl("~/User/AjaxControl/CommentInfoView.aspx") + "?conid=" + ID.ToString() + "&ctype=" + ((int)ContentTypeEnum.Article).ToString());
        lnkShare.NavigateUrl = ResolveUrl("~/User/AjaxControl/ShareInfo.aspx") + "?conid=" + ID.ToString() + "&type=" + ((int)ContentTypeEnum.Article).ToString();
    }

}
