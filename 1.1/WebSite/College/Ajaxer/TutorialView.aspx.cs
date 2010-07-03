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

public partial class College_Ajaxer_TutorialView : AjaxPage
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
    private int PageSize =20;

    protected void Page_Load(object sender, EventArgs e)
    {

        {
            JScripter.PopUp objPopup = new JScripter.PopUp(this.Page, false);
            objPopup.IframePopUp(lnkAdd, ResolveUrl("~/College/TutorialInfo.aspx"), "tutpop", "500", "500", ResolveUrl("~/College/Ajaxer/TutorialView.aspx"),"#tutorial");
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new TutorialController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListTutorial.DataSource = new TutorialController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID,  PageSize, PageNumber);
        ListTutorial.DataBind();
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
            new TutorialController().DeletebyTutorialID(Convert.ToInt32( e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListTutorialOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string CourceCatagoryID = ListTutorial.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }
	


}
