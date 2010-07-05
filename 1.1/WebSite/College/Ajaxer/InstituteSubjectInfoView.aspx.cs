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

public partial class College_Ajaxer_InstituteSubjectController : AjaxPage
{
    private int _InstituteCourceID
    {
        get
        {
            if (Request.Params["icid"] != null)
            {
                AjaxState["icid"] = Request.Params["icid"];
                return Convert.ToInt32(Request.Params["icid"]);
            }
            else
            {
                return Convert.ToInt32(AjaxState["icid"]);
            }
        }
    }
    public HtmlHelper _HtmlHelper = new HtmlHelper();
    private int PageNumber
    {
        get
        {
            if (Request.Params["pn"] != null)
                return Convert.ToInt32(Request.Params["pn"].ToString());
            else
            {
                lnkPrevInstituteSubject.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;

    protected void Page_Load(object sender, EventArgs e)
    {
        hpAddInstituteSubject.NavigateUrl = ResolveUrl("~/College/Ajaxer/InstituteSubjectInfo.aspx") + "?icid=" + _InstituteCourceID;
        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new InstituteSubjectController().GetbyInstituteCourceID(_InstituteCourceID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListInstituteSubject.DataSource = new InstituteSubjectController().GetbyInstituteCourceID(_InstituteCourceID, PageSize, PageNumber);
        ListInstituteSubject.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevInstituteSubject.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextInstituteSubject.Visible = false;
        }
        if (lnkNextInstituteSubject.Visible)
        {
            //lnkNextInstituteSubject.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevInstituteSubject.Visible)
        {
            //lnkPrevInstituteSubject.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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

    protected void ListInstituteSubjectOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



}
