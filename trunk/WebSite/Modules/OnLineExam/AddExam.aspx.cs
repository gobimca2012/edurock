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
public partial class Modules_OnLineExam_AddExam : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            BindEditData();
        }
    }
    private void BindEditData()
    {
        var data = new ExamController().GetbyExamID(Convert.ToInt32(Request.QueryString["id"]));
        if (data.Count > 0)
        {
            txtExamName.Text = data[0].ExamName;
            txtSubjectName.Text = data[0].SubjectName;
            lnkStep2.AjaxCommand = "edit";
            lnkStep2.ID = e.Id;
        }
    }
    protected void NextAjaxClick(object sender, AjaxEventArg e)
    {
        try
        {
            if (e.AjaxCommand == "edit")
            {
                if (txtExamName.value != "" && txtSubjectName.value != "")
                {
                    ExamController objexam = new ExamController();
                    objexam.UpdateByExamID(Convert.ToInt32(e.Id), txtExamName.value, txtSubjectName.value);
                    Response.Redirect("~/Modules/OnLineExam/ExamList.aspx");
                }
            }
            else
            {
                if (txtExamName.value != "" && txtSubjectName.value != "")
                {
                    ExamController objexam = new ExamController();
                    int examId = objexam.Add(txtExamName.value, txtSubjectName.value, new UserAuthontication().LoggedInUserID, DateTime.Now);
                    if (examId > 0)
                        objLoader.LoadPage("#addque", ResolveUrl("~/Modules/OnLineExam/AddQuestion.aspx") + "?eid=" + examId.ToString());
                    throw new Exception("System has some Internal problem please contact to Administrator");

                }
            }
        }
        catch (Exception ex)
        {
            ErrorMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    
}
