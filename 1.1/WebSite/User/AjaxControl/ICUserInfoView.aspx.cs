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

public partial class User_AjaxControl_ICUserInfoView : AjaxPage
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
                lnkPrevUser.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;
    private int _LoginUserID
    {
        get
        {
            if (AjaxState.ContainsKey("usid"))
            {
                return Convert.ToInt32(AjaxState["usid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    private int _InstituteCourceID
    {
        get
        {
            if (AjaxState.ContainsKey("icid"))
            {
                return Convert.ToInt32(AjaxState["icid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    private int _InstituteSubjectID
    {
        get
        {
            if (AjaxState.ContainsKey("isid"))
            {
                return Convert.ToInt32(AjaxState["isid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    private int ICID
    {
        get
        {
            AjaxState["icid"] = Request.Params["icid"];
            return Convert.ToInt32(Request.Params["icid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["isid"] != null)
        {
            AjaxState["isid"] = Request.Params["isid"];
        }
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];

        }
        if (Request.Params["usid"] != null)
        {
            AjaxState["usid"] = Request.Params["usid"];
        }
        if (_InstituteCourceID > 0)
        {
            header.InnerHtml = "Users in " + new InstituteCourceController().GetInstituteCourceName(_InstituteCourceID);
        }
        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new UserController().GetUser(_InstituteCourceID,new UserAuthontication().InstituteID).Count / PageSize));
            PaggerLinkManager();
        }
        new JScripter.Effect(this.Page, false).VisibleOnMouseHover(".cbox");
    }
    private void BindList()
    {
        ListUser.DataSource = new UserController().GetUser(_InstituteCourceID,new UserAuthontication().UserInstituteID, PageSize, PageNumber);
        ListUser.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevUser.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextUser.Visible = false;
        }
        if (lnkNextUser.Visible)
        {
            //lnkNextUser.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevUser.Visible)
        {
            //lnkPrevUser.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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

    protected void ListUserOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



}
