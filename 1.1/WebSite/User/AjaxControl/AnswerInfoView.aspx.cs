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

public partial class User_AjaxControl_AnswerInfoView : AjaxPage
{

    public HtmlHelper _HtmlHelper = new HtmlHelper();
    private Guid _QuestionID
    {
        get
        {
            if (Request.Params["qid"] != null)
            {
                AjaxState["qid"] = Request.Params["qid"];
                return new Guid(Request.Params["qid"]);
            }
            else
            {
                return new Guid(AjaxState["qid"]);
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
                lnkPrevAnswer.Visible = false;
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
            hpAddAnswer.NavigateUrl = ResolveUrl("~/User/AjaxControl/AnswerInfo.aspx") + "?qid=" + _QuestionID.ToString();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new AnswerController().GetAnswerByQuestionID(_QuestionID, -1).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListAnswer.DataSource = new AnswerController().GetAnswerByQuestionID(_QuestionID, -1, PageSize, PageNumber);
        ListAnswer.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevAnswer.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextAnswer.Visible = false;
        }
        if (lnkNextAnswer.Visible)
        {
            //lnkNextAnswer.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevAnswer.Visible)
        {
            //lnkPrevAnswer.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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
            new AnswerController().DeletebyAnswerID(new Guid(e.Id));
            BindList();
        }
        else if (e.Command.Contains("accept"))
        {
            new AnswerController().UpdateAnswerStateByAnswerID(new Guid(e.Id), Convert.ToInt32(HtmlHelper.ControlValue(e.customId1)));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListAnswerOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string LoginUserID = ListAnswer.DataKeys[currentItem.DataItemIndex]["LoginUserID"].ToString();
        string AnswerID = ListAnswer.DataKeys[currentItem.DataItemIndex]["AnswerID"].ToString();
        HtmlGenericControl divUser = (HtmlGenericControl)currentItem.FindControl("UserAction");
        HtmlGenericControl acceptAnswer = (HtmlGenericControl)currentItem.FindControl("acceptAnswer");
        
        DropDownList ddState = (DropDownList)currentItem.FindControl("ddState");
        if (ddState != null)
        {
            new AnswerStateController().BindAnswerState(ddState);
        }
        if (acceptAnswer != null)
        {
            acceptAnswer.InnerHtml = _HtmlHelper.ListViewLinkButton("lnkd", "accept Answer", "accept", AnswerID, ddState.ClientID, "#Answer", "#Answer");
        }
        if (divUser != null)
        {
            if (new UserAuthontication().IsOwn(Convert.ToInt32(LoginUserID)))
            {
                divUser.Visible = true;
            }
            else
            {
                divUser.Visible = false;
            }
        }



    }



}
