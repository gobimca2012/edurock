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
public partial class College_ListExam : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindList();
        }
    }
    private void BindList()
    {
        var data = new ExamController().Get();
        ListExam.DataSource = data;
        ListExam.DataBind();
    }
    protected void List_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        if (String.Equals(e.CommandName, "Deletedata"))
        {
            // Verify that the employee ID is not already in the list. If not, add the
            // employee to the list.
            ListViewDataItem dataItem = (ListViewDataItem)e.Item;
            string ExamId =
              ListExam.DataKeys[dataItem.DisplayIndex].Value.ToString();
            new ExamController().DeletebyExamID(Convert.ToInt32(ExamId));
            BindList();
        }


    }
}
