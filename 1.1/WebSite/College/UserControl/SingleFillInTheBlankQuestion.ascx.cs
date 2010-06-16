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
using DataEntity;

public partial class College_UserControl_SingleFillInTheBlankQuestion : System.Web.UI.UserControl
{
    public EXM_Question _Question
    {
        get;
        set;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack)
        {
            if (_Question != null)
            {
                string[] Questions=_Question.Question.Split(';');
                lblPrefixText.InnerText = Questions[0];
                sufixText.InnerText = Questions[1];
                lblMarks.InnerText = _Question.Marks.ToString();
                BindQuestionOption();
            }
        }
    }
    private void BindQuestionOption()
    {

        
        ddAnswer.DataSource = _Question.EXM_Answers;
        ddAnswer.DataTextField = "Answer";
        ddAnswer.DataValueField = "EXM_AnswerID";
        ddAnswer.DataBind();
        ListItem noneItem = new ListItem();
        noneItem.Text = "Select";
        noneItem.Value = "0";
        ddAnswer.Items.Insert(0, noneItem);

    }
}
