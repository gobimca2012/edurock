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

public partial class College_Ajaxer_InstituteTypeAccessInfoView : AjaxPage
{

    public HtmlHelper _HtmlHelper = new HtmlHelper();
    private int _InstituteUserTypeID
    {
        get
        {
            return Convert.ToInt32(AjaxState["iuyid"]);
        }
    }
    private int PageNumber
    {
        get
        {
            if (Request.Params["pn"] != null)
                return Convert.ToInt32(Request.Params["pn"].ToString());
            else
            {
                lnkPrevInstituteTypeAccess.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["iuyid"] != null)
        {
            AjaxState["iuyid"] = Request.Params["iuyid"];
        }
        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new InstituteUserTypeAccessController().GetbyInstituteUserTypeID(_InstituteUserTypeID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListInstituteTypeAccess.DataSource = new InstituteUserTypeAccessController().GetbyInstituteUserTypeID(_InstituteUserTypeID, PageSize, PageNumber);
        ListInstituteTypeAccess.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevInstituteTypeAccess.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextInstituteTypeAccess.Visible = false;
        }
        if (lnkNextInstituteTypeAccess.Visible)
        {
            //lnkNextInstituteTypeAccess.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevInstituteTypeAccess.Visible)
        {
            //lnkPrevInstituteTypeAccess.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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

    protected void ListInstituteTypeAccessOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



}
