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
using DataEntity;
using System.Collections.Generic;

public partial class User_AjaxControl_EventInfoView : AjaxPage
{
    public HtmlHelper _HtmlHelper = new HtmlHelper();

    private int _DocumentType
    {
        get
        {
            return Convert.ToInt16(AjaxState["dtype"]);
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
    protected void AjaxSearch(object sender, AjaxControl.AjaxEventArg e)
    {

        BindList();
      
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        JScripter.DatePicker objdate = new JScripter.DatePicker(this.Page);
        objdate.DatePickerTextBox(txtEnddate);
        objdate.DatePickerTextBox(txtstartDate);
        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.VisibleOnMouseHover(".dasbo");
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
            header.InnerHtml = "Events in " + new InstituteCourceController().GetInstituteCourceName(_InstituteCourceID);
        }
        if (Request.Params["dtype"] != null)
        {
            AjaxState["dtype"] = Request.Params["dtype"];
        }
        if (!IsAjaxPostBack)
        {
            Session.Remove(SessionName.EventEndDate.ToString());
            Session.Remove(SessionName.EventStartDate.ToString());
            BindList();
         
        }

    }
    private string Keywork
    {
        get
        {
            string value = HtmlHelper.ControlValue(txtKeyword.ClientID);
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
                if (Session[SessionName.EventStartDate.ToString()] != null)
                {
                    return Convert.ToDateTime(Session[SessionName.EventStartDate.ToString()].ToString());
                }
                else
                {
                    Session[SessionName.EventStartDate.ToString()] = DateTime.Now;
                    return DateTime.Now;
                }
            }
        }
        set
        {
            Session[SessionName.EventStartDate.ToString()] = value;
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
                if (Session[SessionName.EventEndDate.ToString()] != null)
                {
                    return Convert.ToDateTime(Session[SessionName.EventEndDate.ToString()].ToString());
                }
                else
                {
                    Session[SessionName.EventEndDate.ToString()] = DateTime.Now;
                    return DateTime.Now;
                }
            }
        }
        set
        {

            Session[SessionName.EventEndDate.ToString()] = value;

        }

    }
    private void BindList()
    {

        data = new UserController().GetUserRelatedContentSearch(_LoginUserID, _InstituteCourceID, _InstituteSubjectID, (int)ContentTypeEnum.Event, new UserAuthontication().LoggedInUserID, Keywork, StartDate, EndDate);
       
        ListDocument.DataSource = data;
        ListDocument.DataBind();

    }
    private List<GetUserRelatedContentSearchResult> data
    {
        get;
        set;
    }
 
   
    protected override void OnAjaxListViewCommand(AjaxListViewCommandArg e)
    {
        if (e.Command.Contains("delete"))
        {
            new EventController().DeletebyEventID(new Guid(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListDocumentOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListDocument.DataKeys[currentItem.DataItemIndex]["ID"].ToString();
        //new DocumentController().DeletebyDocumentID(new Guid(CourceCatagoryID));
        //BindList();


    }

    protected void CalDayRender(object sender, DayRenderEventArgs e)
    {
        if (data != null)
        {
            int SelectedMonth = DateTime.Now.Month;
            var dateEvent = (from p in data where p.ModifiedDate.Value.Day == e.Day.Date.Day && p.ModifiedDate.Value.Month == e.Day.Date.Month && p.ModifiedDate.Value.Year == e.Day.Date.Year select p).ToList();
            HtmlGenericControl div = new HtmlGenericControl("div");
            if (dateEvent.Count > 0)
            {
                for (int i = 0; i < dateEvent.Count; i++)
                {
                    HtmlGenericControl divItem = new HtmlGenericControl("div");
                    HyperLink fullViewLink = new HyperLink();
                    fullViewLink.ID = "fullview_" + i.ToString();
                    string ContainnerID = "#contentBox";
                    string url = ResolveUrl("~/User/AjaxControl/Event.aspx") + "?evid=" + dateEvent[i].ID.ToString();
                    fullViewLink.Text = dateEvent[i].Title;
                    fullViewLink.Attributes["href"] = "javascript:void(0);";
                    //new JScripter.Loader(this.Page, false).PostData(ContainnerID, ContainnerID, ResolveUrl(this.NavigateUrl), this.ClientID);
                    new JScripter.Loader(this.Page, false).AjaxRedirect(ContainnerID, ContainnerID, url, fullViewLink.ClientID);
                    fullViewLink.NavigateUrl = "";
                    divItem.Controls.Add(fullViewLink);
                    div.Controls.Add(divItem);
                }

                e.Cell.Controls.Add(div);
                e.Cell.CssClass = "eventcal";
                e.Cell.ToolTip = dateEvent[0].Title;
            }
        }
    }
    
    protected void PrevMonthAjax(object sender, AjaxControl.AjaxEventArg e)
    {
        StartDate = StartDate.AddMonths(-1);
        Calendar1.VisibleDate = StartDate;
        BindList();
    }
    protected void NextMonthAjax(object sender, AjaxControl.AjaxEventArg e)
    {
        StartDate = StartDate.AddMonths(1);
        Calendar1.VisibleDate = StartDate;
        BindList();
    }
    private ShareContent UserAccess
    {
        get;
        set;

    }
    private void SetUserAccess()
    {
        if ((bool)new ButtonVisibilityHelper(new UserAuthontication().LoggedInUserID).Access.CanAddEvent)
            if (_InstituteCourceID > 0)
            {
                UserAccess = new ShareController().GetSpaceAccess(AjaxState["icid"], (int)ContentTypeEnum.InstituteCourse, new UserAuthontication().LoggedInUserID);
                if (!UserAccess.IsAddable)
                {
                    hpAddDocument.Visible = false;
                }
            }
            else
            {
                hpAddDocument.Visible = false;
            }
        else
        {
            hpAddDocument.Visible = false;
        }
    }
    protected override void OnPreRender(EventArgs e)
    {
        SetUserAccess();
        base.OnPreRender(e);
    }
}
