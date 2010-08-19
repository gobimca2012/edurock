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
using BusinessLogic.Controllers;
using DataEntity;
using System.Collections.Generic;

public partial class User_AjaxControl_DocumentInfoView : AjaxPage
{

    public HtmlHelper _HtmlHelper = new HtmlHelper();

    private int _DocumentType
    {
        get
        {
            return Convert.ToInt16(AjaxState["dtype"]);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        Session.Remove(SessionName.DocumentHistory.ToString());
        BindList();


    }

    private string ContentID
    {
        get
        {
            if (Request.Params["conid"] != null)
            {
                AjaxState["conid"] = Request.Params["conid"];
            }
            return AjaxState["conid"];
        }
    }
    private List<Document> HistoryData
    {
        get
        {
            var data = new ContentHistoryController().GetDocumentHistory(ContentID);
            Session[SessionName.DocumentHistory.ToString()] = data;
            return data;
        }
    }
    private void BindList()
    {
        ListDocument.DataSource = HistoryData;
        ListDocument.DataBind();
    }


    protected override void OnAjaxListViewCommand(AjaxListViewCommandArg e)
    {
        if (e.Command.Contains("delete"))
        {
            new DocumentController().DeletebyDocumentID(new Guid(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListDocumentOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        AjaxControl.HyperLink lnkFullView = (AjaxControl.HyperLink)currentItem.FindControl("lnkFull");
        if (lnkFullView != null)
        {
            lnkFullView.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentHistory.aspx")+"?index="+currentItem.DataItemIndex.ToString();
        }
        
        


    }



}
