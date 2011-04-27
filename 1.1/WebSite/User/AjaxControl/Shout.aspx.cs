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
using System.IO;

public partial class User_AjaxControl_Shout : AjaxPage
{
    private void ControlManager(int LoginUserID)
    {

        if (new UserAuthontication().IsOwn(LoginUserID))
        {
            //lnkDelete.Visible = true
           

        }
      
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

           

            if (data.Description != null)

                lblDescription.InnerHtml = data.Description.ToString();

           

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

               
               
                DisplayFileInforation(data.FilePath);

            }
            if (data.DocumentType != null)
            {
               
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
    private void DisplayFileInforation(string filePath)
    {
        try
        {
            FileInfo fileInfo = FileInformation.GetFileInfo(Server.MapPath(filePath));
            
        }
        catch
        {
           
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
            
        }

    }

}
