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
public partial class College_QuestionWizard_ListQuestion : BasePage
{
    private int ExamID
    {
        get
        {
            return Convert.ToInt32(Request.QueryString["eid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        JScripter.JScripter.IncludeJavascriptFile("jquery", ResolveUrl("~/Jscript/jquery-1.3.2.js"), this.Page);
        JScripter.JScripter.IncludeJavascriptFile("jqueryui", ResolveUrl("~/Jscript/jquery-ui.js"), this.Page);
        //JScripter.JScripter.IncludeJavascriptFile("ajax", ResolveUrl("~/Jscript/ajax.js"), this.Page);
        JScripter.JScripter.IncludeJavascriptFile("vtajax", ResolveUrl("~/Jscript/vtAjax.js"), this.Page);
        JScripter.JScripter.IncludeJavascriptFile("sortable", ResolveUrl("~/Jscript/ui.sortable.js"), this.Page);
        if (!this.IsPostBack)
        {
            if (Request.QueryString["eid"] != null)
            {
                BindList();
                lnkAddQuestion.NavigateUrl = ResolveUrl("~/College/QuestionWizard/Step1.aspx") + "?eid=" + Request.QueryString["eid"];
            }
        }
    }
    private void BindList()
    {
        ListEXM_Question.DataSource = new EXM_QuestionController().GetbyExamID(ExamID);
        ListEXM_Question.DataBind();
    }

    
    protected void ListQuestion_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        if (String.Equals(e.CommandName, "DeleteQuestion"))
        {
            // Verify that the employee ID is not already in the list. If not, add the
            // employee to the list.
            ListViewDataItem dataItem = (ListViewDataItem)e.Item;
            string QuestionID =
              ListEXM_Question.DataKeys[dataItem.DisplayIndex].Value.ToString();
            new EXM_QuestionController().DeletebyEXM_QuestionID(Convert.ToInt32(QuestionID));
            BindList();
        }
    }
}
