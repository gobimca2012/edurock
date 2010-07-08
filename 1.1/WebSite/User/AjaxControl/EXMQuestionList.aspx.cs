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
}
