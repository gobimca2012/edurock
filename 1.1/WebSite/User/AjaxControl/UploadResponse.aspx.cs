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

public partial class User_AjaxControl_UploadResponse : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        EnableAjaxState = false;
        img.ImageUrl = ResolveUrl(Session[SessionName.FileUploader.ToString()].ToString());
        filePath.Value = Session[SessionName.FileUploader.ToString()].ToString();
        Session.Remove(SessionName.FileUploader.ToString());
    }
}
