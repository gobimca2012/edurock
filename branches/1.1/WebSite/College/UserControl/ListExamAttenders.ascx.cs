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

public partial class College_UserControl_ListExamAttenders : System.Web.UI.UserControl
{
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
    private int ExamId
    {
        get
        {
            return Convert.ToInt32(Request.QueryString["eid"]);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindList();
            TotalPage = new UserExamController().ExamUserByExamID(ExamId).Count / PageSize;
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListUserExam.DataSource = new UserExamController().ExamUserByExamID(ExamId, PageSize, PageNumber);
        ListUserExam.DataBind();
    }
    private void PaggerLinkManager()
    {        
        if (PageNumber==0)
        {
            lnkPrev.Visible = false;            
        }
        if (TotalPage - 1 == PageNumber || TotalPage==0)
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
}
