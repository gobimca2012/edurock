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

public partial class User_AjaxControl_AllContent : WidgetControl
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
                lnkPrevQuestion.Visible = false;
                return 0;
            }
        }


    }
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
                return new UserAuthontication().LoggedInUserID;
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
    private int TotalPage;
    private int PageSize = 20;

    protected void Page_Load(object sender, EventArgs e)
    {
        new JScripter.Widget(this.Page, false).DeleteLinkButton(CustomHelper.GetGuidString(WidgetID), ResolveUrl("~/User/Widget/WidgetAction.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID), lnkClose);
        JScripter.DatePicker objdate = new JScripter.DatePicker(this.Page);
        objdate.DatePickerTextBox(txtEnddate);
        objdate.DatePickerTextBox(txtstartDate);
        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.Collapspanel("#searchboxtrigger", "#searchbox");
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
            objLoader.LoadPage("#sidewidget", ResolveUrl("~/User/AjaxControl/AboutWidget.aspx") + "?icid=" + _InstituteCourceID.ToString());
        }
        else if (_LoginUserID > 0)
        {
           // objLoader.LoadPage("#sidewidget", ResolveUrl("~/User/AjaxControl/PublicUserInfoView.aspx") + "?usid=" + _LoginUserID.ToString());
        }
        else
        {
            objLoader.LoadPage("#sidewidget", ResolveUrl("~/User/AjaxControl/AboutWidget.aspx"));
        }
        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new UserController().GetContent(_LoginUserID, _InstituteCourceID, _InstituteSubjectID, (int)ContentTypeEnum.All).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListQuestion.DataSource = new UserController().GetUserRelatedContentSearch(_LoginUserID, _InstituteCourceID, _InstituteSubjectID, (int)ContentTypeEnum.All, new UserAuthontication().LoggedInUserID, Keywork, StartDate, EndDate, PageSize, PageNumber);
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
    public string GetCSSClass(string ContentType)
    {
        string CssClass = "";

        if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Question)
        {
            CssClass = "ques";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Document)
        {
            CssClass = "doc";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Image)
        {
            CssClass = "img";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Video)
        {
            CssClass = "vid";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Audio)
        {
            CssClass = "aud";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.HomeWork)
        {
            CssClass = "howo";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Exam)
        {
            CssClass = "exm";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Event)
        {
            CssClass = "evt";
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Article)
        {
            CssClass = "art";
        }
        return CssClass;
    }
    public string getURL(string ContentType, string ID)
    {
        string URL = "";

        if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Question)
        {
            URL = ResolveUrl("~/User/AjaxControl/Question.aspx") + "?qid=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Document)
        {
            URL = ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Image)
        {
            URL = ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Video)
        {
            URL = ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Audio)
        {
            URL = ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.HomeWork)
        {
            URL = ResolveUrl("~/User/AjaxControl/HomeWork.aspx") + "?hwid=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Exam)
        {
            URL = ResolveUrl("~/User/AjaxControl/exam.aspx") + "?eid=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Article)
        {
            URL = ResolveUrl("~/User/AjaxControl/Article.aspx") + "?arid=" + ID;
        }
        else if (Convert.ToInt32(ContentType) == (int)ContentTypeEnum.Event)
        {
            URL = ResolveUrl("~/User/AjaxControl/Event.aspx") + "?evid=" + ID;
        }
        return URL;
    }
    protected void ListQuestionOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string ID = ListQuestion.DataKeys[currentItem.DataItemIndex]["ID"].ToString();
        string ContentType = ListQuestion.DataKeys[currentItem.DataItemIndex]["ContentType"].ToString();
        AjaxControl.HyperLink lnkFull = (AjaxControl.HyperLink)currentItem.FindControl("lnkFull");
        if (lnkFull != null)
        {

        }



    }

    private string Keywork
    {
        get
        {
            string value=HtmlHelper.ControlValue(txtKeyword.ClientID);
            txtKeyword.Text = value;
            return value; ;
        }
    }
    private DateTime StartDate
    {
        get
        {
            if (HtmlHelper.ControlValue(txtstartDate.ClientID) != null && HtmlHelper.ControlValue(txtstartDate.ClientID) != "")
            {
                txtstartDate.Text = HtmlHelper.ControlValue(txtstartDate.ClientID);
                return Convert.ToDateTime(HtmlHelper.ControlValue(txtstartDate.ClientID));
            }
            else
            {
                return new DateTime(1800, 1, 1);
            }
        }
    }
    private DateTime EndDate
    {
        get
        {
            if (HtmlHelper.ControlValue(txtEnddate.ClientID) != null && HtmlHelper.ControlValue(txtEnddate.ClientID) != "")
            {
                txtEnddate.Text = HtmlHelper.ControlValue(txtEnddate.ClientID);
                return Convert.ToDateTime(HtmlHelper.ControlValue(txtEnddate.ClientID));
            }
            else
            {
                return DateTime.Now;
            }
        }
    }

    protected void AjaxSearch(object sender, AjaxControl.AjaxEventArg e)
    {

        BindList();
        PaggerLinkManager();
    }
}
