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

public partial class User_AjaxControl_Document : AjaxPage
{
    private void ControlManager(int LoginUserID)
    {

        if (new UserAuthontication().IsOwn(LoginUserID))
        {
            //lnkDelete.Visible = true;
            lnkShare.Visible = UserAccess.IsEditablable;
            lnkHistory.Visible = true;

        }
        lnkEdit.Visible = UserAccess.IsEditablable;
    }
    private int _ContentType
    {
        get;
        set;
    }
    private void BindData()
    {
        var dataBunch = new DocumentController().GetbyDocumentID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
         
            if (data.Name != null)

                lblName.InnerHtml = data.Name.ToString();

            if (data.Description != null)

                lblDescription.InnerHtml = data.Description.ToString();

            if (data.MetaDescription != null)

                lblMetaDescription.InnerHtml = data.MetaDescription.ToString();

            if (data.Tag != null)

                lblTag.InnerHtml = data.Tag.ToString();
            _ContentType = data.DocumentType;
            if (data.LoginUserID != null)
            {
                UserAccess = new ShareController().GetItemAccess(ID.ToString(), _ContentType, new UserAuthontication().LoggedInUserID, data.LoginUserID);
                if (!UserAccess.IsViewable)
                {
                    Response.Redirect("~/Status/NoAccess.aspx");
                }
                ControlManager(data.LoginUserID);

            }

            if (data.Rating != null)

                lblRating.InnerHtml = data.Rating.ToString();

            if (data.FilePath != null)
            {

                if (data.DocumentType == (int)DocumentTypeEnum.Image)
                {
                    img.Visible = true;
                    img.ImageUrl = ResolveUrl(data.FilePath.ToString());
                    lnkViewDoc.HRef = "http://docs.google.com/viewer?url=" +CommonController.GetSiteName()+ResolveUrl(data.FilePath.ToString());
                }
                else if (data.DocumentType == (int)DocumentTypeEnum.Document)
                {
                    lblFilePath.HRef = ResolveUrl(data.FilePath.ToString());
                    lnkViewDoc.HRef = "http://docs.google.com/viewer?url=" + CommonController.GetSiteName() + ResolveUrl(data.FilePath.ToString());
                }
                else if (data.DocumentType == (int)ContentTypeEnum.BookMark)
                {
                    //lblFilePath.HRef = ResolveUrl(data.Name);
                    lnkViewDoc.HRef = "http://docs.google.com/viewer?url=" + CommonController.GetSiteName() + ResolveUrl(data.FilePath.ToString());
                    lnkViewDoc.Visible = false;
                    lblFilePath.Visible = false;
                    lblName.InnerHtml = string.Format("<a href='{0}' target='_blank'>{0}</a>",data.Name);
                }
                else if (data.DocumentType == (int)DocumentTypeEnum.Audio || data.DocumentType == (int)DocumentTypeEnum.Video)
                {
                    //lblFilePath.InnerHtml = data.FilePath.ToString();
                    new JScripter.Player(this.Page).CreatePlayer(ResolveUrl(data.FilePath.ToString()), "videoPlayer");
                }

            }
            if (data.DocumentType != null)
            {
                if (data.DocumentType == (int)ContentTypeEnum.BookMark)
                {
                    lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/BookMarkInfo.aspx") + "?did=" + ID.ToString() + "&dtype=" + data.DocumentType.ToString();
                }
                else
                {
                    lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfo.aspx") + "?did=" + ID.ToString() + "&dtype=" + data.DocumentType.ToString();
                }
            }
            if (data.DocumentCources.Count > 0)
            {
                FullViewSideInfo1.CourceID = data.DocumentCources[0].InstituteCourceID;
                FullViewSideInfo1.SubjectID = (int)data.DocumentCources[0].SubjectID;
                FullViewSideInfo1.LoginUserID = data.LoginUserID;
                FullViewSideInfo1.ModifiedDate = data.ModifiedDate;
                FullViewSideInfo1.ContentType = _ContentType;
                FullViewSideInfo1.ContentID = data.DocumentID.ToString();
            }
            //if (data.ModifiedDate != null)

            //    lblModifiedDate.InnerHtml =CommonController.GetDate(Convert.ToDateTime( data.ModifiedDate.ToString()));
        }

    }

    private Guid ID
    {
        get
        {
            return new Guid(Request.Params["did"]);
        }
    }
    ShareContent UserAccess;
    protected void Page_Load(object sender, EventArgs e)
    {

        //if (UserAccess.IsViewable)
        {
            BindData();
            objLoader.LoadPage("#comment", ResolveUrl("~/User/AjaxControl/CommentInfoView.aspx") + "?conid=" + ID.ToString() + "&ctype=" + (_ContentType).ToString());
            lnkShare.NavigateUrl = ResolveUrl("~/User/AjaxControl/ShareInfo.aspx") + "?conid=" + ID.ToString() + "&type=" + (_ContentType).ToString();
            lnkHistory.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentHistoryView.aspx") + "?conid=" + ID.ToString();
        }

    }

}
