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

public partial class User_AjaxControl_EXMQuestionList : AjaxPage
{
    public HtmlHelper _HtmlHelper=new HtmlHelper();
    private int _ExamID
    {
        get
        {
            return Convert.ToInt32(AjaxState["eid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["eid"] != null)
        {
            AjaxState["eid"] = Request.Params["eid"];
        }
        BindList();
        MakeLink();
    }
    private void BindList()
    {
        ListEXM_Question.DataSource = new EXM_QuestionController().GetbyExamID(_ExamID);
        ListEXM_Question.DataBind();
    }
    private void MakeLink()
    {
        lnkAddnew.NavigateUrl = ResolveUrl("~/User/AjaxControl/SelectQuestionType.aspx") + "?eid=" + _ExamID;
    }
    protected override void OnAjaxListViewCommand(AjaxListViewCommandArg e)
    {
        if (e.Command == "delete")
        {
            new EXM_QuestionController().DeletebyEXM_QuestionID(Convert.ToInt32(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }
    protected void ItemdataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string Q_Type = ListEXM_Question.DataKeys[currentItem.DataItemIndex]["Q_Type"].ToString();
        string EXM_QuestionID = ListEXM_Question.DataKeys[currentItem.DataItemIndex]["EXM_QuestionID"].ToString();
        AjaxControl.HyperLink lnkEdit = (AjaxControl.HyperLink)currentItem.FindControl("lnkEdit");
        if (lnkEdit != null)
        {
            if (Q_Type == "1")
            {
                lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/SingleChoiceInfo.aspx") + "?qid=" + EXM_QuestionID;
            }
            else if (Q_Type == "2")
            {
                lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/MultiChoiceInfo.aspx") + "?qid=" + EXM_QuestionID;
            }
            else if (Q_Type == "3")
            {
                lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/SingleFillIntheBlankInfo.aspx") + "?qid=" + EXM_QuestionID;
            }
            else if (Q_Type == "1")
            {
                lnkEdit.NavigateUrl = ResolveUrl("") + "?qid=" + EXM_QuestionID;
            }
        }
    }
}
