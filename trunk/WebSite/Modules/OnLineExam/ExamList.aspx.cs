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
using BusinessLogin;
using AjaxControl;

public partial class Modules_OnLineExam_ExamList : AjaxPage
{
    bool bindOnUnload = false;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }
    private void BindData()
    {
        var data = new ExamController().Get();
        
        ListExam.DataSource = data;
        ListExam.DataBind();
    }
    protected void Delete_AjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        if (e.Id != "")
        {
           new ExamController().DeletebyExamID(Convert.ToInt32(e.Id));
            bindOnUnload = true;
            //BindData();
        }
    }
    protected override void OnAjaxListViewCommand(AjaxListViewCommandArg e)
    {
        if (e.Command == "delete")
        {
            new ExamController().DeletebyExamID(Convert.ToInt32(e.Id));
            BindData();
        }
        base.OnAjaxListViewCommand(e);
    }
    protected override void OnUnload(EventArgs e)
    {
        BindData();
        base.OnUnload(e);
    }
    
}
