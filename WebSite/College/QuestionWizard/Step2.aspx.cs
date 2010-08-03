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
using System.Collections.Generic;
public partial class College_QuestionWizard_Step2 : BasePage
{
    private int _QuestionID
    {
        get
        {
            return Convert.ToInt32(Request.QueryString["qid"]);
        }
    }
    
    private Dictionary<string, string> Status;
    private int AnswerCounter
    {
        get
        {
            return Convert.ToInt32(ViewState["AnswerCounter"]);
        }
        set
        {
            ViewState["AnswerCounter"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {

        }
    }
    private void ClearForm()
    {
        txtAnswer.Text = "";
        chkIsRight.Checked = false;
    }
    protected void lnkAdd_Click(object sender, EventArgs e)
    {
        AddData();
    }
    private void AddData()
    {
        int EXM_QuestionID; if (true) { EXM_QuestionID = _QuestionID; }

        string Answer; if (true) { Answer = txtAnswer.Text; }

        bool IsRight; if (true) { IsRight = Convert.ToBoolean(chkIsRight.Checked); }

        DateTime ModifiedDate; if (true) { ModifiedDate = DateTime.Now; }

        Status = new EXM_AnswerController().Add(EXM_QuestionID, Answer, IsRight, ModifiedDate);
        if (Status["Error"] != "")
        {
            divError.InnerHtml = Status["Error"].ToString();
        }
        else
        {
            Response.Redirect("~/College/QuestionWizard/Step1.aspx?qid=" + EXM_QuestionID.ToString());
        }
        
        AnswerCounter++;
        ClearForm();

    }

}
