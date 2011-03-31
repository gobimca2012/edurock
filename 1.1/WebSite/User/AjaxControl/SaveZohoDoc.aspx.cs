using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class User_AjaxControl_SaveZohoDoc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpPostedFile httpPostedFile;
        string filename;
        httpPostedFile = Request.Files["content"];
        filename = Request.QueryString["filename"];
        Request.Files["content"].SaveAs("" + filename);
        new CommonController().UploadDocument(httpPostedFile, filename);
    }
}