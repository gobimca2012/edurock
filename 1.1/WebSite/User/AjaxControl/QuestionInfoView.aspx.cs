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
using Common;

public partial class User_AjaxControl_QuestionInfoView : AjaxPage
{

    public HtmlHelper _HtmlHelper = new HtmlHelper();
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
    private int QuestionStatusID
    {
        get
        {
            string data = HtmlHelper.ControlValue(ddQuestionStatus.ClientID);
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
            header.InnerHtml = "Questions in " + new InstituteCourceController().GetInstituteCourceName(_InstituteCourceID);
        }
        hpAddQuestion.NavigateUrl = ResolveUrl("~/User/AjaxControl/QuestionInfo.aspx") + "?icid=" + _InstituteCourceID;
        //hpAddQuestion.NavigateUrl = ResolveUrl("~/User/AjaxControl/MyQuestion.aspx") + "?icid=" + ICID;
        {
            BindList();
            new QuestionTypeController().BindQuestionType(ddQuestionType);
            new QuestionStatusController().BindQuestionStatus(ddQuestionStatus);
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new UserController().GetContent(_LoginUserID, _InstituteCourceID, _InstituteSubjectID, (int)ContentTypeEnum.Question).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListQuestion.DataSource = new UserController().GetContent(_LoginUserID, _InstituteCourceID, _InstituteSubjectID, (int)ContentTypeEnum.Question, PageSize, PageNumber);
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
            new QuestionController().DeletebyQuestionID(new Guid(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListQuestionOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string LoginUserID = ListQuestion.DataKeys[currentItem.DataItemIndex]["LoginUserID"].ToString();
        HyperLink lnkTool = (HyperLink)currentItem.FindControl("lnkTool");
        if (lnkTool != null)
        {
            string Script = string.Format("$('#{0}').ajaxToolTip('#{1}','{2}');", lnkTool.ClientID, "acont", ResolveUrl("~/User/AjaxControl/Upop.aspx") + "?lid=" + LoginUserID);
            JScripter.JScripter.InjectScript(Script, this.Page);
        }
        AjaxControl.HyperLink lnkQuestionFull = (AjaxControl.HyperLink)currentItem.FindControl("lnkQuestionFull");
        string QuestionID = ListQuestion.DataKeys[currentItem.DataItemIndex]["ID"].ToString();
        if (lnkQuestionFull != null)
        {
            lnkQuestionFull.NavigateUrl = ResolveUrl("~/User/AjaxControl/Question.aspx") + "?icid=" + _InstituteCourceID.ToString() + "&qid=" + QuestionID.ToString();
        }


    }



    protected void SearchAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {

    }
    private ShareContent UserAccess
    {
        get;
        set;

    }
    private void SetUserAccess()
    {
        if ((bool)new ButtonVisibilityHelper(new UserAuthontication().LoggedInUserID).Access.CanAddQuestion)
        {
            if (_InstituteCourceID > 0)
            {
                UserAccess = new ShareController().GetSpaceAccess(AjaxState["icid"], (int)ContentTypeEnum.InstituteCourse, new UserAuthontication().LoggedInUserID);
                if (!UserAccess.IsAddable)
                {
                    hpAddQuestion.Visible = false;
                }
            }
            else
            {
                hpAddQuestion.Visible = false;
            }
        }
        else
        {
            hpAddQuestion.Visible = false;
        }
    }
    protected override void OnPreRender(EventArgs e)
    {
        SetUserAccess();
        base.OnPreRender(e);
    }

}
