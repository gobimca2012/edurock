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
        else if (UploadType == 1)
        {
            string Path=new CommonController().UploadImage(fileUploader);
            Session[SessionName.FileUploader.ToString()] = Path;
            injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
        }
        else if (UploadType == 2)
        {
            string Path = new CommonController().UploadImage(fileUploader);
            Session[SessionName.FileUploader.ToString()] = Path;
            injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
        }
        else if (UploadType == 3)
        {
            string Path = new CommonController().UploadImage(fileUploader);
            Session[SessionName.FileUploader.ToString()] = Path;
            injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
        }
        else if (UploadType == 4)
        {
            string Path = new CommonController().UploadImage(fileUploader);
            Session[SessionName.FileUploader.ToString()] = Path;
            injectScript.Text = "<script type='text/javascript'>window.parent.closePop()</script>";
        }
    }
}
