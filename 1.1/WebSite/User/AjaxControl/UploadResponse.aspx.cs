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

public partial class User_AjaxControl_UploadResponse : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            EnableAjaxState = false;
            img.ImageUrl = ResolveUrl(Session[SessionName.FileUploaderDefaultImage.ToString()].ToString());
            filePath.Value = Session[SessionName.FileUploader.ToString()].ToString();
            lblFileName.InnerText = Session[SessionName.FileUploaderFileName.ToString()].ToString();
            Session.Remove(SessionName.FileUploader.ToString());
        }
        catch
        {
        }
    }
}
