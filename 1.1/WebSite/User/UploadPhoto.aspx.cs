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

public partial class User_UploadPhoto : BasePage
{
    private int UploadType
    {
        get
        {
            return Convert.ToInt16(Request.Params["uptype"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkUpload_Click(object sender, EventArgs e)
    {
        if (UploadType == 0)
        {
            new UserController().UpdateProfilePic(new UserAuthontication().LoggedInUserID, fileUploader);
        }
        else if (UploadType == (int)DocumentTypeEnum.Image)
        {
            if (FileInformation.IsImage(FileInformation.getFileExtention(fileUploader.FileName)))
            {
                string Path = new CommonController().UploadImage(fileUploader);
                Session[SessionName.FileUploader.ToString()] = Path;
                Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
                injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
            }
            else
            {
                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
            }
        }
        else if (UploadType == (int)DocumentTypeEnum.Document)
        {
            if (FileInformation.IsDocument(FileInformation.getFileExtention(fileUploader.FileName)))
            {
                string Path = new CommonController().UploadImage(fileUploader);
                Session[SessionName.FileUploader.ToString()] = Path;
                Session[SessionName.FileUploaderDefaultImage.ToString()] = ConfigurationSettings.AppSettings["AudioIcon"].ToLower();
                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Document;
                injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
            }
            else
            {
                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
            }
        }
        else if (UploadType == (int)DocumentTypeEnum.Audio)
        {
            if (FileInformation.IsAudio(FileInformation.getFileExtention(fileUploader.FileName)))
            {
                string Path = new CommonController().UploadAudio(fileUploader);
                Session[SessionName.FileUploader.ToString()] = Path;
                Session[SessionName.FileUploaderDefaultImage.ToString()] = ConfigurationSettings.AppSettings["AudioIcon"].ToLower();
                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Audio;
                injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
            }
            else
            {
                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
            }
        }
        else if (UploadType == (int)DocumentTypeEnum.Video)
        {
            if (FileInformation.IsVideo(FileInformation.getFileExtention(fileUploader.FileName)))
            {
                string Path = new CommonController().UploadImage(fileUploader);
                Session[SessionName.FileUploader.ToString()] = Path;
                Session[SessionName.FileUploaderDefaultImage.ToString()] = ConfigurationSettings.AppSettings["VideoIcon"].ToLower();
                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Video;
                injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
            }
            else
            {
                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
            }
        }
    }
}
