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

public partial class College_Ajaxer_InstituteCourceUserInfoView : AjaxPage
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
                lnkPrevInstituteCourceUser.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;
    private int UID
    {
        get
        {
            return Convert.ToInt32(AjaxState["uid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["uid"] != null)
        {
            AjaxState["uid"] = Request.Params["uid"];
            hpAddInstituteCourceUser.NavigateUrl = ResolveUrl("~/College/Ajaxer/InstituteCourceUserInfo.aspx") + "?uid=" + UID.ToString();
        }
        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new InstituteCourceUserController().GetbyLoginUserID(UID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListInstituteCourceUser.DataSource = new InstituteCourceUserController().GetbyLoginUserID(UID, PageSize, PageNumber);
        ListInstituteCourceUser.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevInstituteCourceUser.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextInstituteCourceUser.Visible = false;
        }
        if (lnkNextInstituteCourceUser.Visible)
        {
            //lnkNextInstituteCourceUser.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevInstituteCourceUser.Visible)
        {
            //lnkPrevInstituteCourceUser.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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
            new InstituteCourceUserController().DeletebyInstituteCourceUserID(new Guid(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListInstituteCourceUserOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



}
