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

public partial class User_AjaxControl_AllContent : AjaxPage
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
    private int TotalPage;
    private int PageSize = 100;

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

        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new UserController().GetContent(_LoginUserID, _InstituteCourceID, _InstituteSubjectID, (int)ContentTypeEnum.All).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListQuestion.DataSource = new UserController().GetContent(_LoginUserID, _InstituteCourceID, _InstituteSubjectID,(int)ContentTypeEnum.All, PageSize, PageNumber);
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
            CssClass = "ques";
        }
        return CssClass;
    }
    public string getURL(string ContentType,string ID)
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



}
