using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Controllers;

public partial class ShoppingCart_AjaxControl_VersionAttributeInfoView : AjaxPage
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
                lnkPrevVersionAttribute.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["prvid"] != null)
        {
            AjaxState["prvid"] = Request.Params["prvid"];
        }
        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new VersionAttributeController().Get().Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListVersionAttribute.DataSource = new VersionAttributeController().GetbyProductVersionID(_ProductVersionID, PageSize, PageNumber);
        ListVersionAttribute.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevVersionAttribute.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextVersionAttribute.Visible = false;
        }
        if (lnkNextVersionAttribute.Visible)
        {
            //lnkNextVersionAttribute.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevVersionAttribute.Visible)
        {
            //lnkPrevVersionAttribute.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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
            new VersionAttributeController().DeletebyVersionAttributeID(new Guid(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListVersionAttributeOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string CourceCatagoryID = ListVersionAttribute.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }
    private Guid _ProductVersionID
    {
        get
        {
            return new Guid(AjaxState["prvid"]);
        }
    }
    


}