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

public partial class College_Ajaxer_CourceCatagoryInfoView : AjaxPage
{
    public HtmlHelper _htmlHelper;
    protected void Page_Load(object sender, EventArgs e)
    {
        _htmlHelper = new HtmlHelper();
        TotalPage = new CourceCatagoryController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID).Count / PageSize;
        BindList();
    }
    private int PageNumber
    {
        get
        {
            if (Request.Params["pn"] != null)
                return Convert.ToInt32(Request.Params["pn"].ToString());
            else
            {
                lnkPrev.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 1;


    private void BindList()
    {
        ListCourceCatagory.DataSource = new CourceCatagoryController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID, PageSize, PageNumber);
        ListCourceCatagory.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrev.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNext.Visible = false;
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
    protected void ListCourceCatagoryOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();


    }
    protected void DeleteajaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        string aaa = "aa";
        string bb = aaa;
        new CourceCatagoryController().DeletebyCourceCatagoryID(Convert.ToInt32(e.Id));
        //BindList();
        Response.Redirect(this.Request.RawUrl);
    }
    protected override void OnAjaxListViewCommand(AjaxListViewCommandArg e)
    {
        if (e.Command == "delete")
        {
            new CourceCatagoryController().DeletebyCourceCatagoryID(Convert.ToInt32(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }



}
