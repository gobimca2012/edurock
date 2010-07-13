using BusinessLogic;
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

public partial class College_Ajaxer_CourceInfoView : AjaxPage
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
                lnkPrevx.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;

    protected void Page_Load(object sender, EventArgs e)
    {

        {
            BindList();
            TotalPage = new InstituteController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID).Count / PageSize;
        }

    }
    private void BindList()
    {
        ListCource.DataSource = new InstituteController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID,PageSize, PageNumber);
        ListCource.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevx.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextx.Visible = false;
        }
        if (lnkNextx.Visible)
        {
            //lnkNextx.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevx.Visible)
        {
            //lnkPrevx.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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
            new CourceController().DeletebyCourceID(Convert.ToInt32(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListCourceOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string CourceCatagoryID = ListCource.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



}
