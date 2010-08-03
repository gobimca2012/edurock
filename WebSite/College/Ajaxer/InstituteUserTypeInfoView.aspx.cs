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

public partial class College_Ajaxer_InstituteUserTypeInfoView : AjaxPage
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
                lnkPrevInstituteUserType.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 10;

    protected void Page_Load(object sender, EventArgs e)
    {

        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new InstituteUserTypeController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListInstituteUserType.DataSource = new InstituteUserTypeController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID, PageSize, PageNumber);
        ListInstituteUserType.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevInstituteUserType.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextInstituteUserType.Visible = false;
        }
        if (lnkNextInstituteUserType.Visible)
        {
            //lnkNextInstituteUserType.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevInstituteUserType.Visible)
        {
            //lnkPrevInstituteUserType.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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
            new InstituteUserTypeController().DeletebyInstituteUserTypeID(Convert.ToInt32(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListInstituteUserTypeOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ////ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        ////string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



}
