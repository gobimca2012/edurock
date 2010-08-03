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

public partial class User_AjaxControl_CommentInfoView :AjaxPage
{
    private string _ContentID
    {
        get
        {
            return AjaxState["conid"];
        }
    }
    private int _ContentType
    {
        get
        {
            return Convert.ToInt32(AjaxState["ctype"]);
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
                lnkPrevComment.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["ctype"] != null)
        {
            AjaxState["ctype"] = Request.Params["ctype"];
        }
        if (Request.Params["conid"] != null)
        {
            AjaxState["conid"] = Request.Params["conid"];
        }
        {
            BindList();
            //TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new CommentController().Get(_ContentID, _ContentType).Count / PageSize));
            PaggerLinkManager();
        }
        objLoader.LoadPage("#newcommentbox", ResolveUrl("~/User/AjaxControl/CommentInfo.aspx") + "?conid=" + _ContentID + "&ctype=" + _ContentType.ToString());
    }
    private void BindList()
    {
        ListComment.DataSource = new CommentController().Get(_ContentID,_ContentType);
        ListComment.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevComment.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextComment.Visible = false;
        }
        if (lnkNextComment.Visible)
        {
            //lnkNextComment.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevComment.Visible)
        {
            //lnkPrevComment.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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
            new CommentController().DeletebyCommentID(new Guid(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListCommentOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }
	


}
