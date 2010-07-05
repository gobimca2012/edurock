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

public partial class User_AjaxControl_QuestionInfoView : AjaxPage
{

    public HtmlHelper _HtmlHelper = new HtmlHelper();
    private int ICID
    {
        get
        {
            AjaxState["icid"] = Request.Params["icid"];
            return Convert.ToInt32(Request.Params["icid"]);
        }
    }
    private int QuestionStatusID
    {
        get
        {
            string data = HtmlHelper.ControlValue(ddQuestionStatus.ClientID);
            if (data == "0" || data=="")
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(data);
            }
        }
    }
    private int QuestionTypeID
    {
        get
        {
            string data = HtmlHelper.ControlValue(ddQuestionType.ClientID);
            if (data == "0" || data == "")
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(data);
            }
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
                lnkPrevQuestion.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 10;

    protected void Page_Load(object sender, EventArgs e)
    {
        hpAddQuestion.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfo.aspx") + "?icid=" + ICID;
        {
            BindList();
            new QuestionTypeController().BindQuestionType(ddQuestionType);
            new QuestionStatusController().BindQuestionStatus(ddQuestionStatus);
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new QuestionController().GetQuestion(HtmlHelper.ControlValue(txtKeyword.ClientID),QuestionTypeID ,QuestionStatusID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListQuestion.DataSource = new QuestionController().GetQuestion(HtmlHelper.ControlValue(txtKeyword.ClientID),QuestionTypeID ,QuestionStatusID,PageSize, PageNumber);
        ListQuestion.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevQuestion.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextQuestion.Visible = false;
        }
        if (lnkNextQuestion.Visible)
        {
            //lnkNextQuestion.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevQuestion.Visible)
        {
            //lnkPrevQuestion.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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

    protected void ListQuestionOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



    protected void SearchAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {

    }
}
