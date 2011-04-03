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
        Logger.TimeLog.ErrorWrite("Call save from  zoho", "Call save from  zoho", "");
        HttpPostedFile httpPostedFile=null;
        string filename="";
        foreach (string aa in Request.Params.AllKeys)
        {
            Logger.TimeLog.ErrorWrite("zoho retrun values", aa, Request.Params[aa].ToString());
            

        }
        if (Request.Files["content"] != null)
        {
            Logger.TimeLog.ErrorWrite("Call save from  zoho", "Get content from zoho", "");
            httpPostedFile = Request.Files["content"];
        }
        if (Request.QueryString["filename"] != null)
        {
            Logger.TimeLog.ErrorWrite("Call save from  zoho", "Get filename from zoho", "");
            filename = Request.QueryString["filename"];
        }
        if (Request.Params["id"] != null)
        {
            var docdata = new DocumentController().GetbyDocumentID(new Guid(Request.Params["id"]));
            if (docdata.Count > 0)
            {
                
                try
                {
                    var data = docdata[0];
                    Request.Files["content"].SaveAs(Server.MapPath(data.FilePath));
                    //Request.Files["content"].SaveAs(Server.MapPath("~/Repository/Document/vt3soft/DailySprintBacklogV1 0.xls"));
                    //new CommonController().UploadDocument(httpPostedFile, filename);
                    Logger.TimeLog.ErrorWrite("Call save from  zoho", "save success fully", "");
                }
                catch (Exception ex)
                {
                    Logger.TimeLog.ErrorWrite("Get error when save from zoho", ex.Message, "");
                }
            }
        }
        try
        {
            Request.Files["content"].SaveAs(Server.MapPath("~/Repository/Document/vt3soft/DailySprintBacklogV1 0.xls"));
            //new CommonController().UploadDocument(httpPostedFile, filename);
            Logger.TimeLog.ErrorWrite("Call save from  zoho", "save success fully", "");
        }
        catch (Exception ex)
        {
            Logger.TimeLog.ErrorWrite("Get error when save from zoho", ex.Message, "");
        }
    }
}