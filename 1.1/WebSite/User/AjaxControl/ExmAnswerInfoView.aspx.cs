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

public partial class User_AjaxControl_ExmAnswerInfoView : AjaxPage
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
                lnkPrevEXM_Answer.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;
    private int _QuestionID
    {
        get
        {
            return Convert.ToInt32(AjaxState["qid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["qid"] != null)
        {
            AjaxState["qid"] = Request.Params["qid"];
        }

        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new EXM_AnswerController().GetbyEXM_QuestionID(_QuestionID).Count / PageSize));
            PaggerLinkManager();
        }
        MakeLink();
    }
    private void BindList()
    {
        ListEXM_Answer.DataSource = new EXM_AnswerController().GetbyEXM_QuestionID(_QuestionID, PageSize, PageNumber);
        ListEXM_Answer.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevEXM_Answer.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextEXM_Answer.Visible = false;
        }
        if (lnkNextEXM_Answer.Visible)
        {
            //lnkNextEXM_Answer.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevEXM_Answer.Visible)
        {
            //lnkPrevEXM_Answer.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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
            new EXM_AnswerController().GetbyEXM_AnswerID(Convert.ToInt32(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListEXM_AnswerOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }
    private void MakeLink()
    {
        hpAddEXM_Answer.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExmAnswerInfo.aspx") + "?qid=" + _QuestionID.ToString();
    }


}
