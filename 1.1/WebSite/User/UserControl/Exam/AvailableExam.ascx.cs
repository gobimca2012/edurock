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

public partial class User_UserControl_Exam_AvailableExam : System.Web.UI.UserControl
{
    public string Url
    {
        get;
        set;
    }
    private int PageNumber
    {
        get
        {
            if (ViewState["PageNumber"] != null)
                return Convert.ToInt32(ViewState["PageNumber"].ToString());
            else
            {
                lnkPrev.Visible = false;
                return 0;
            }
        }
        set
        {
            ViewState["PageNumber"] = value;
        }
    }
    private int TotalPage
    {
        get
        {
            if (ViewState["TotalPage"] != null)
                return Convert.ToInt32(ViewState["TotalPage"].ToString());
            else
            {

                return 0;
            }
        }
        set
        {
            ViewState["TotalPage"] = value;
        }
    }
    private int PageSize = 20;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindList();
            TotalPage = new ExamController().Get().Count / PageSize;
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListExam.DataSource = new ExamController().Get(PageSize, PageNumber);
        ListExam.DataBind();
    }
    private void PaggerLinkManager()
    {
        if (PageNumber == 0)
        {
            lnkPrev.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNext.Visible = false;
        }
    }
    protected void Prev_Click(object sender, EventArgs e)
    {
        PageNumber = PageNumber - 1;
        BindList();
        PaggerLinkManager();
    }
    protected void Next_Click(object sender, EventArgs e)
    {
        PageNumber = PageNumber + 1;
        BindList();
        PaggerLinkManager();
    }
    protected void ListUserExamOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        if (e.Item.ItemType == ListViewItemType.DataItem)
        {
            
            {
                ListViewDataItem currentItem = (ListViewDataItem)e.Item;
                string ExamId = ListExam.DataKeys[currentItem.DataItemIndex]["ExamID"].ToString();

                HyperLink lnkExam = (HyperLink)currentItem.FindControl("lnkExam");
                if (lnkExam != null)
                {
                    lnkExam.Attributes["onclick"] = string.Format("window.open('{0}','mywindow','width=1000,height=600,toolbar=no,scrollbars=yes,copyhistory=no,menubar=no,status=no,directories=no')", ResolveUrl("~/College/ExamIntroduction.aspx") + "?eid=" + ExamId);
                }
                HyperLink lnkResult = (HyperLink)currentItem.FindControl("lnkResult");
                if (lnkResult != null)
                {
                    lnkResult.NavigateUrl = ResolveUrl("~/User/ExamResult.aspx") + "?eid=" + ExamId.ToString();
                }
            }
            //Do something   
        }


    }

}
