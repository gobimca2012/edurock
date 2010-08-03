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

public partial class User_AjaxControl_ExamAttender : AjaxPage
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
                lnkPrevExam.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 100;
    private int _ExamID
    {
        get
        {
            if (AjaxState.ContainsKey("eid"))
            {
                return Convert.ToInt32(AjaxState["eid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["eid"] != null)
        {
            AjaxState["eid"] = Request.Params["eid"];
        }
        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new UserExamController().ExamUserByExamID(_ExamID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListUserExam.DataSource = new UserExamController().ExamUserByExamID(_ExamID, PageSize, PageNumber);
        ListUserExam.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevExam.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextExam.Visible = false;
        }
        if (lnkNextExam.Visible)
        {
            //lnkNextExam.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevExam.Visible)
        {
            //lnkPrevExam.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
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

    protected void ListExamOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();



    }



}
