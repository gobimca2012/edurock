﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net;
using BusinessLogic;
using System.IO;

public partial class User_AjaxControl_Default : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string did = Request.Params["did"];
        var dataBunch = new DocumentController().GetbyDocumentID(new Guid(did));
        string apikey1 = "0e2da066bd5df6cc0da9c0489d3895e0";
        string output1 = "editor";
        string filename1 = "Expense.xlsx";
        string id1 = "12345678";//dataBunch[0].DocumentID.ToString();
        string format1 = "xls";
        string saveurl1 = "www.crameasy.com/aspaa.aspx";
        string username1 = "rohan";
        string documentid1 = dataBunch[0].DocumentID.ToString();
        string skey1 = "3224dcb1293dec27177d2d136bc8067c";
        string documentPublicUrl = "http://www.crameasy.com///Repository/Document/vt3soft/Expense.xlsx";
        apikey.Value = apikey1;
        url.Value = documentPublicUrl;
        output.Value = output1;
        filename.Value = filename1;
        id.Value = id1;
        // documentid.Value = "3456783454";
        skey.Value = skey1;
        format.Value = format1;
        saveurl.Value = saveurl1;
        //zohoform.Action = "https://sheet.zoho.com/remotedoc.im";
    }
   
    private string getFormHtml()
    {
        string did = Request.Params["did"];
        var dataBunch = new DocumentController().GetbyDocumentID(new Guid(did));
        string apikey1 = "0e2da066bd5df6cc0da9c0489d3895e0";
        string output1 = "editor";
        string filename1 = "Expense.xlsx";
        string id1 = "12345678";//dataBunch[0].DocumentID.ToString();
        string format1 = "xls";
        string saveurl1 = "www.crameasy.com/aspaa.aspx";
        string username1 = "rohan";
        string documentid1 = dataBunch[0].DocumentID.ToString();
        string skey1 = "3224dcb1293dec27177d2d136bc8067c";
        string documentPublicUrl = "http://www.crameasy.com///Repository/Document/vt3soft/Expense.xlsx";

        string formHtml = @"<form method='POST' action='https://sheet.zoho.com/remotedoc.im' target='_blank'
    accept-charset='UTF-8' name='frmPP' id='frmPP'>
    <input type='hidden' name='url' value='{1}'
        >
    <input type='hidden' name='apikey' value='{2}'  />
    <input type='hidden' name='output' value='editor'  />
    <input type='hidden' name='mode' value='normaledit'>
    <input type='hidden' name='filename' value='{3}' />
    <input type='hidden' name='lang' value='[en/fr/de/ja/it...]'>
    <input type='hidden' name='skey' value='{4}' />
    <input type='hidden' name='id' value='12345678' />
    <input type='hidden' name='format' value='{5}' />
    <input type='hidden' name='saveurl' value='[{6}]'/>
    <input type='submit' name='submit' value='Open/Edit'>
   
    </form>";
        formHtml=string.Format(formHtml, "", documentPublicUrl, apikey1, filename1, skey1, format1, saveurl1);
        return formHtml;
      

    }
    private void PayPalPostScript(System.Web.UI.Page Page)
    {
        //This registers Javascript to the page which is used to post the PayPal Form details    
        StringBuilder strScript = new StringBuilder();
        strScript.Append("<script language='javascript'>");
        strScript.Append("var ctlForm = document.getElementById('frmPP');");
        strScript.Append("ctlForm.submit();");
        strScript.Append("</script>");
        ClientScript.RegisterClientScriptBlock(this.GetType(), "PPSubmit", strScript.ToString());
    }  
    private void Postdata()
    {
        string did = Request.Params["did"];
        var dataBunch = new DocumentController().GetbyDocumentID(new Guid(did));
        string apikey1 = "0e2da066bd5df6cc0da9c0489d3895e0";
        string output1 = "editor";
        string filename1 = "DailySprintBacklogV1 0.xls";
        string id1 = "12345678";//dataBunch[0].DocumentID.ToString();
        string format1 = "xls";
        string saveurl1 = "www.crameasy.com/aspaa.aspx";
        string username1 = "rohan";
        string documentid1 = dataBunch[0].DocumentID.ToString();
        string skey1 = "3224dcb1293dec27177d2d136bc8067c";
        string documentPublicUrl = "http://www.crameasy.com///Repository/Document/vt3soft/DailySprintBacklogV1 0.xls";
        HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(@"https://sheet.zoho.com/remotedoc.im");
        request.PreAuthenticate = true;
        request.AllowWriteStreamBuffering = true;

        string boundary = System.Guid.NewGuid().ToString();



        request.ContentType = string.Format("multipart/form-data; boundary={0}", boundary);
        request.Method = "POST";

        // Build Contents for Post
        string header = string.Format("--{0}", boundary);
        string footer = header + "--";

        StringBuilder contents = new StringBuilder();

        //// file
        //contents.AppendLine(header);
        //contents.AppendLine(string.Format("Content-Disposition: form-data; name=\"file\"; filename=\"{0}\"", filename));
        //contents.AppendLine("Content-Type: " + fileUploader.PostedFile.ContentType);
        //contents.AppendLine();
        //contents.AppendLine(Encoding.UTF8.GetString(file));
        //// action
        //contents.AppendLine(header);
        //contents.AppendLine("Content-Disposition: form-data; name=\"action\"");
        //contents.AppendLine();
        //contents.AppendLine("issuu.document.upload");
        // key
        contents.AppendLine(header);
        contents.AppendLine("Content-Disposition: form-data; name=\"url\"");
        contents.AppendLine();
        contents.AppendLine(documentPublicUrl);

        // name
        contents.AppendLine(header);
        contents.AppendLine("Content-Disposition: form-data; name=\"apikey\"");
        contents.AppendLine();
        contents.AppendLine(apikey1);

        // title
        contents.AppendLine(header);
        contents.AppendLine("Content-Disposition: form-data; name=\"output\"");
        contents.AppendLine();
        contents.AppendLine(output1);

        // signature
        contents.AppendLine(header);
        contents.AppendLine("Content-Disposition: form-data; name=\"mode\"");
        contents.AppendLine();
        contents.AppendLine("normaledit");

        // signature
        contents.AppendLine(header);
        contents.AppendLine("Content-Disposition: form-data; name=\"filename\"");
        contents.AppendLine();
        contents.AppendLine(filename1);

        // signature
        contents.AppendLine(header);
        contents.AppendLine("Content-Disposition: form-data; name=\"lang\"");
        contents.AppendLine();
        contents.AppendLine("[en/fr/de/ja/it...]");

        // signature
        contents.AppendLine(header);
        contents.AppendLine("Content-Disposition: form-data; name=\"skey\"");
        contents.AppendLine();
        contents.AppendLine(skey1);


        // signature
        contents.AppendLine(header);
        contents.AppendLine("Content-Disposition: form-data; name=\"format\"");
        contents.AppendLine();
        contents.AppendLine(format1);


        // signature
        contents.AppendLine(header);
        contents.AppendLine("Content-Disposition: form-data; name=\"saveurl\"");
        contents.AppendLine();
        contents.AppendLine(saveurl1);


        // Footer
        contents.AppendLine(footer);

        // This is sent to the Post
        byte[] bytes = Encoding.UTF8.GetBytes(contents.ToString());

        request.ContentLength = bytes.Length;

        using (Stream requestStream = request.GetRequestStream())
        {
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Flush();
            requestStream.Close();

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    // return reader.ReadToEnd();
                }

            }
        }

        // return null;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Postdata();
    }
}