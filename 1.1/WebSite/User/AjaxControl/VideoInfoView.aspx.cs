﻿using System;
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

public partial class User_AjaxControl_VideoInfoView : AjaxPage
{

    public HtmlHelper _HtmlHelper = new HtmlHelper();
    private int PageNumber
    {
        get
        {
            if (Request.Params["pn"] != null)
                return Convert.ToInt32(Request.Params["pn"].ToString());
            else
            {
                lnkPrevDocument.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;
    private int _DocumentType
    {
        get
        {
            return Convert.ToInt16(AjaxState["dtype"]);
        }
    }
    private int _InstituteCourceID
    {
        get
        {
            if (AjaxState.ContainsKey("icid"))
            {
                return Convert.ToInt16(AjaxState["icid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
        }
        if (Request.Params["dtype"] != null)
        {
            AjaxState["dtype"] = Request.Params["dtype"];
        }
        hpAddDocument.NavigateUrl = ResolveUrl("~/User/AjaxControl/DocumentInfo.aspx") + "?dtype=" + _DocumentType.ToString();
        {
            BindList();
            
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        if (_InstituteCourceID > 0)
        {
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new DocumentController().GetByInstituetCourceID(_DocumentType, _InstituteCourceID).Count / PageSize));
            ListDocument.DataSource = new DocumentController().GetByInstituetCourceID(_DocumentType, _InstituteCourceID, PageSize, PageNumber);
        }
        else
        {
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new DocumentController().GetRecentDocument(_DocumentType, DateTime.Now.AddDays(-2)).Count / PageSize));
            ListDocument.DataSource = new DocumentController().GetRecentDocument(PageSize, PageNumber, _DocumentType, DateTime.Now.AddDays(-2));
        }
        ListDocument.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevDocument.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextDocument.Visible = false;
        }
        if (lnkNextDocument.Visible)
        {
            //lnkNextDocument.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevDocument.Visible)
        {
            //lnkPrevDocument.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
        }
    }
    protected void NextAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {

        BindList();
        PaggerLinkManager();
    }
    protected void PrevAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {

        BindList();
        PaggerLinkManager();
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
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListDocument.DataKeys[currentItem.DataItemIndex]["DocumentID"].ToString();
        //new DocumentController().DeletebyDocumentID(new Guid(CourceCatagoryID));



    }
	


}
