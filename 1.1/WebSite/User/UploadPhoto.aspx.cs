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
using BusinessLogic.Entity;
using System.Collections.Generic;

public partial class User_UploadPhoto : BasePage
{
    private int UploadType
    {
        get
        {
            return Convert.ToInt16(Request.Params["uptype"]);
        }
    }
    protected override void OnLoad(EventArgs e)
    {
        JScripter.Tab objTab = new JScripter.Tab(this.Page, true);
        objTab.TabUl("#tabs");
        if (!this.IsPostBack)
        {
            ListImage.DataSource = UserContentDirectoryHelper.GetAllUserImage(new UserAuthontication().LoggedInUserName);
            ListImage.DataBind();
            //ImageList.DataSource = UserContentDirectoryHelper.GetAllUserImage(new UserAuthontication().LoggedInUserName);
            //ImageList.DataBind();

        }
        base.OnLoad(e);
    }
    
    protected void lnkUpload_Click(object sender, EventArgs e)
    {
        if (UploadType == 0)
        {
            string Path = new UserController().UpdateProfilePic(new UserAuthontication().LoggedInUserID, fileUploader);
            Session[SessionName.FileUploader.ToString()] = Path;
            Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
            Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
            Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;            
            string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
            JScripter.JScripter.InjectScript(Script, this.Page);
            //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
        }
        else if (UploadType == (int)DocumentTypeEnum.UploadInstitutePic)
        {
            string Path = new InstituteController().UpdateByInstituteID(Convert.ToInt32(Request.Params["iid"]), new UserAuthontication().LoggedInUserID, fileUploader);
            Session[SessionName.FileUploader.ToString()] = Path;
            Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
            Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
            Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
            string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
            JScripter.JScripter.InjectScript(Script, this.Page);
            //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
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
                string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                JScripter.JScripter.InjectScript(Script, this.Page);
                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
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
                string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                JScripter.JScripter.InjectScript(Script, this.Page);
                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
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
                string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                JScripter.JScripter.InjectScript(Script, this.Page);
                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
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
                string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                JScripter.JScripter.InjectScript(Script, this.Page);
                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
            }
            else
            {
                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
            }
        }
        else if (UploadType == (int)DocumentTypeEnum.EditorPhoto)
        {
            if (FileInformation.IsImage(FileInformation.getFileExtention(fileUploader.FileName)))
            {
                string Path = new CommonController().UploadImage(fileUploader);
                Session[SessionName.FileUploader.ToString()] = Path;
                Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
                //string Script = "window.parent.closePop();";
                string Script = string.Format("window.parent.closeEditorPopUp('{0}');", ResolveUrl(Path));
                JScripter.JScripter.InjectScript(Script, this.Page);
            }
            else
            {
                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
            }
        }
    }
    protected void OnImageListItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "upload")
        {
            string FilePath = ListImage.DataKeys[e.Item.ItemIndex].ToString();
            if (UploadType == 0)
            {

                string Path = new UserController().UpdateProfilePic(new UserAuthontication().LoggedInUserID,FilePath);
                Session[SessionName.FileUploader.ToString()] = Path;
                Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
                string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                JScripter.JScripter.InjectScript(Script, this.Page);
                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
            }
            else if (UploadType == (int)DocumentTypeEnum.UploadInstitutePic)
            {
                string Path = new InstituteController().UpdateByInstituteID(Convert.ToInt32(Request.Params["iid"]), new UserAuthontication().LoggedInUserID, FilePath);
                Session[SessionName.FileUploader.ToString()] = Path;
                Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
                string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                JScripter.JScripter.InjectScript(Script, this.Page);
                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
            }
            else if (UploadType == (int)DocumentTypeEnum.Image)
            {
                if (FileInformation.IsImage(FileInformation.getFileExtention(FilePath)))
                {
                    string Path = FilePath;
                    Session[SessionName.FileUploader.ToString()] = Path;
                    Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
                    Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
                    Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
                    string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                    JScripter.JScripter.InjectScript(Script, this.Page);
                    //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
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
                    string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                    JScripter.JScripter.InjectScript(Script, this.Page);
                    //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
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
                    string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                    JScripter.JScripter.InjectScript(Script, this.Page);
                    //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
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
                    string Script = string.Format("window.parent.closePop('#{0}','{1}');",Request.Params["rid"],Request.Params["rurl"]);
                    JScripter.JScripter.InjectScript(Script, this.Page);
                    //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
                }
                else
                {
                    divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
                }
            }
            else if (UploadType == (int)DocumentTypeEnum.EditorPhoto)
            {
                if (FileInformation.IsImage(FileInformation.getFileExtention(fileUploader.FileName)))
                {
                    string Path = new CommonController().UploadImage(fileUploader);
                    Session[SessionName.FileUploader.ToString()] = Path;
                    Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
                    Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
                    Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
                    //string Script = "window.parent.closePop();";
                    string Script = string.Format("window.parent.closeEditorPopUp('{0}');", ResolveUrl(Path));
                    JScripter.JScripter.InjectScript(Script, this.Page);
                }
                else
                {
                    divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
                }
            }
        }
    }
   
    //protected void ImageListViewItemCommand(object sender, ListViewCommandEventArgs e)
    //{
    //    if (e.CommandName == "update")
    //    {
    //        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
    //        string FilePath = ImageList.DataKeys[currentItem.DataItemIndex].ToString();
    //        if (UploadType == 0)
    //        {

    //            string Path = new UserController().UpdateProfilePic(new UserAuthontication().LoggedInUserID, FilePath);
    //            Session[SessionName.FileUploader.ToString()] = Path;
    //            Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
    //            Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
    //            Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
    //            string Script = string.Format("window.parent.closePop('#{0}','{1}');", Request.Params["rid"], Request.Params["rurl"]);
    //            JScripter.JScripter.InjectScript(Script, this.Page);
    //            //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
    //        }
    //        else if (UploadType == (int)DocumentTypeEnum.UploadInstitutePic)
    //        {
    //            string Path = new InstituteController().UpdateByInstituteID(Convert.ToInt32(Request.Params["iid"]), new UserAuthontication().LoggedInUserID, FilePath);
    //            Session[SessionName.FileUploader.ToString()] = Path;
    //            Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
    //            Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
    //            Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
    //            string Script = string.Format("window.parent.closePop('#{0}','{1}');", Request.Params["rid"], Request.Params["rurl"]);
    //            JScripter.JScripter.InjectScript(Script, this.Page);
    //            //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
    //        }
    //        else if (UploadType == (int)DocumentTypeEnum.Image)
    //        {
    //            if (FileInformation.IsImage(FileInformation.getFileExtention(FilePath)))
    //            {
    //                string Path = FilePath;
    //                Session[SessionName.FileUploader.ToString()] = Path;
    //                Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
    //                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
    //                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
    //                string Script = string.Format("window.parent.closePop('#{0}','{1}');", Request.Params["rid"], Request.Params["rurl"]);
    //                JScripter.JScripter.InjectScript(Script, this.Page);
    //                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
    //            }
    //            else
    //            {
    //                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
    //            }
    //        }
    //        else if (UploadType == (int)DocumentTypeEnum.Document)
    //        {
    //            if (FileInformation.IsDocument(FileInformation.getFileExtention(fileUploader.FileName)))
    //            {
    //                string Path = new CommonController().UploadImage(fileUploader);
    //                Session[SessionName.FileUploader.ToString()] = Path;
    //                Session[SessionName.FileUploaderDefaultImage.ToString()] = ConfigurationSettings.AppSettings["AudioIcon"].ToLower();
    //                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
    //                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Document;
    //                string Script = string.Format("window.parent.closePop('#{0}','{1}');", Request.Params["rid"], Request.Params["rurl"]);
    //                JScripter.JScripter.InjectScript(Script, this.Page);
    //                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
    //            }
    //            else
    //            {
    //                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
    //            }
    //        }
    //        else if (UploadType == (int)DocumentTypeEnum.Audio)
    //        {
    //            if (FileInformation.IsAudio(FileInformation.getFileExtention(fileUploader.FileName)))
    //            {
    //                string Path = new CommonController().UploadAudio(fileUploader);
    //                Session[SessionName.FileUploader.ToString()] = Path;
    //                Session[SessionName.FileUploaderDefaultImage.ToString()] = ConfigurationSettings.AppSettings["AudioIcon"].ToLower();
    //                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
    //                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Audio;
    //                string Script = string.Format("window.parent.closePop('#{0}','{1}');", Request.Params["rid"], Request.Params["rurl"]);
    //                JScripter.JScripter.InjectScript(Script, this.Page);
    //                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
    //            }
    //            else
    //            {
    //                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
    //            }
    //        }
    //        else if (UploadType == (int)DocumentTypeEnum.Video)
    //        {
    //            if (FileInformation.IsVideo(FileInformation.getFileExtention(fileUploader.FileName)))
    //            {
    //                string Path = new CommonController().UploadImage(fileUploader);
    //                Session[SessionName.FileUploader.ToString()] = Path;
    //                Session[SessionName.FileUploaderDefaultImage.ToString()] = ConfigurationSettings.AppSettings["VideoIcon"].ToLower();
    //                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
    //                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Video;
    //                string Script = string.Format("window.parent.closePop('#{0}','{1}');", Request.Params["rid"], Request.Params["rurl"]);
    //                JScripter.JScripter.InjectScript(Script, this.Page);
    //                //injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
    //            }
    //            else
    //            {
    //                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
    //            }
    //        }
    //        else if (UploadType == (int)DocumentTypeEnum.EditorPhoto)
    //        {
    //            if (FileInformation.IsImage(FileInformation.getFileExtention(fileUploader.FileName)))
    //            {
    //                string Path = new CommonController().UploadImage(fileUploader);
    //                Session[SessionName.FileUploader.ToString()] = Path;
    //                Session[SessionName.FileUploaderDefaultImage.ToString()] = Path;
    //                Session[SessionName.FileUploaderFileName.ToString()] = fileUploader.FileName;
    //                Session[SessionName.FileUploaderType.ToString()] = (int)DocumentTypeEnum.Image;
    //                //string Script = "window.parent.closePop();";
    //                string Script = string.Format("window.parent.closeEditorPopUp('{0}');", ResolveUrl(Path));
    //                JScripter.JScripter.InjectScript(Script, this.Page);
    //            }
    //            else
    //            {
    //                divMessage.InnerHtml = "<div class='error'>Please upload right extention file</div>";
    //            }
    //        }
    //    }
    //}
}
