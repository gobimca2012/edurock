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
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkUpload_Click(object sender, EventArgs e)
    {
        new UserController().UpdateProfilePic(new UserAuthontication().LoggedInUserID, fileUploader);
    }
}
