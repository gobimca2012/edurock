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

    private void BindData()
    {
        var dataBunch = new DocumentController().GetbyDocumentID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            //if (data.DocumentID != null)

            //    lblDocumentID.InnerHtml = data.DocumentID.ToString();

            if (data.Name != null)

                lblName.InnerHtml = data.Name.ToString();

            if (data.Description != null)

                lblDescription.InnerHtml = data.Description.ToString();

            if (data.MetaDescription != null)

                lblMetaDescription.InnerHtml = data.MetaDescription.ToString();

            if (data.Tag != null)

                lblTag.InnerHtml = data.Tag.ToString();

            if (data.LoginUserID != null)
            {
//                lblLoginUserID.InnerHtml = data.LoginUserID.ToString(); var dataUser = new UserController().GetbyLoginUserID(data.LoginUserID);
                var dataUser = new UserController().GetbyLoginUserID(data.LoginUserID);
                if (dataUser.Count > 0)
                {
                    lnkTool.Text = dataUser[0].FirstName + " " + dataUser[0].LastName;
                    new JScripter.ToolTip(this.Page).AjaxToolTip(lnkTool, ResolveUrl("~/User/AjaxControl/Upop.aspx") + "?lid=" + data.LoginUserID.ToString(), "acont");
                }
            }

            if (data.Rating != null)

                lblRating.InnerHtml = data.Rating.ToString();

            if (data.FilePath != null)
            {
                if (data.DocumentType == (int)DocumentTypeEnum.Image)
                {
                    img.Visible = true;
                    img.ImageUrl = ResolveUrl(data.FilePath.ToString());
                }
                else if (data.DocumentType == (int)DocumentTypeEnum.Document)
                {
                    lblFilePath.InnerHtml = data.FilePath.ToString();
                }
                else if (data.DocumentType == (int)DocumentTypeEnum.Audio || data.DocumentType == (int)DocumentTypeEnum.Video)
                {
                    //lblFilePath.InnerHtml = data.FilePath.ToString();
                    new JScripter.Player(this.Page).CreatePlayer(ResolveUrl(data.FilePath.ToString()), "videoPlayer");
                }
                
            }
            if (data.DocumentType != null)
            {
                //lblDocumentType.InnerHtml = data.DocumentType.ToString();
                lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfo.aspx") + "?did=" + ID.ToString()+"&dtype="+data.DocumentType.ToString();
            }

            if (data.ModifiedDate != null)

                lblModifiedDate.InnerHtml =CommonController.GetDate(Convert.ToDateTime( data.ModifiedDate.ToString()));
        }

    }

    private Guid ID
    {
        get
        {
            return new Guid(Request.Params["did"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        BindData();
    }

}
