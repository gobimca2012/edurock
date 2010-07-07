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

public partial class User_AjaxControl_HomeWorkInfoView : AjaxPage
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
                lnkPrevHomeWork.Visible = false;
                return 0;
            }
        }


    }
    private int _InstituteCourceID
    {
        get
        {
            return Convert.ToInt32(AjaxState["icid"]);
        }
    }
    private int TotalPage;
    private int PageSize = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
        }
        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new HomeWorkController().GetbyInstituteCourceID(_InstituteCourceID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListHomeWork.DataSource = new HomeWorkController().GetbyInstituteCourceID(_InstituteCourceID, PageSize, PageNumber);
        ListHomeWork.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevHomeWork.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextHomeWork.Visible = false;
        }
        if (lnkNextHomeWork.Visible)
        {
            //lnkNextHomeWork.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevHomeWork.Visible)
        {
            //lnkPrevHomeWork.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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

            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListHomeWorkOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



}
