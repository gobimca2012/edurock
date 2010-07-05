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

public partial class College_Ajaxer_InstituteUserInfoView : AjaxPage
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
                lnkPrevInstituteUser.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 10;
    private string _Keyword
    {
        get
        {
            return HtmlHelper.ControlValue(txtKeyword.ClientID);
        }
    }
    private int _Type
    {
        get
        {
            if (HtmlHelper.ControlValue(ddType.ClientID) != "" && HtmlHelper.ControlValue(ddType.ClientID) != "0")
            {
                return Convert.ToInt32(HtmlHelper.ControlValue(ddType.ClientID));
            }
            else
            {
                return -1;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        {
            new InstituteUserTypeController().BindInstituteUserType(ddType);
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new InstituteUserController().Search(_Keyword,_Type, new UserAuthontication().InstituteID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListInstituteUser.DataSource = new InstituteUserController().Search(_Keyword,_Type, new UserAuthontication().InstituteID, PageSize, PageNumber);
        ListInstituteUser.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevInstituteUser.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextInstituteUser.Visible = false;
        }
        if (lnkNextInstituteUser.Visible)
        {
            //lnkNextInstituteUser.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevInstituteUser.Visible)
        {
            //lnkPrevInstituteUser.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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
    protected void SearchAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {

        // BindList();
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

    protected void ListInstituteUserOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



}
