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

public partial class College_UserControl_ListAnswer : System.Web.UI.UserControl
{
    public int _QuestionID
    {
        get;
        set;
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindList();
            lnkAddAnswer.NavigateUrl = ResolveUrl("~/College/QuestionWizard/Step2.aspx") + "?qid=" + _QuestionID;
        }

    }
    public void BindList()
    {
        ListEXM_Answer.DataSource = new EXM_AnswerController().GetbyEXM_QuestionID(_QuestionID);
        ListEXM_Answer.DataBind();
    }
    protected void ListAnswer_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        if (String.Equals(e.CommandName, "DeleteAnswer"))
        {
            ListViewDataItem dataItem = (ListViewDataItem)e.Item;
            string AnswerID =
              ListEXM_Answer.DataKeys[dataItem.DisplayIndex].Value.ToString();
            new EXM_AnswerController().DeletebyEXM_AnswerID(Convert.ToInt32(AnswerID));
            BindList();
        }
    }
}
