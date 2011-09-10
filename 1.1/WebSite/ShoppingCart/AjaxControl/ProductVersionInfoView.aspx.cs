using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Controllers;

public partial class ShoppingCart_AjaxControl_ProductVersionInfoView :AjaxPage
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
                lnkPrevProductVersion.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;
    private Guid _ProductID
    {
        get
        {
            return new Guid(AjaxState["prid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["prid"] != null)
        {
            AjaxState["prid"] = Request.Params["prid"];
        }
        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new ProductVersionController().Get().Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListProductVersion.DataSource = new ProductVersionController().GetbyProductID(_ProductID, PageSize, PageNumber);
        ListProductVersion.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevProductVersion.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextProductVersion.Visible = false;
        }
        if (lnkNextProductVersion.Visible)
        {
            //lnkNextProductVersion.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevProductVersion.Visible)
        {
            //lnkPrevProductVersion.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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
            new ProductVersionController().DeletebyProductVersionID(new Guid(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListProductVersionOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string CourceCatagoryID = ListProductVersion.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }
	


}