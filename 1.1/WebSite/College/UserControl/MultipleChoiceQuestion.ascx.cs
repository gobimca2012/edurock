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

public partial class College_UserControl_MultipleChoiceQuestion : System.Web.UI.UserControl
{
    public EXM_Question _Question
    {
        get;
        set;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindQuestionOption();
    }
    private void BindQuestionOption()
    {

        lblQuestion.InnerText = _Question.Question;
        lblMarks.InnerText = _Question.Marks.ToString();
        listOption.DataSource = _Question.EXM_Answers;
        listOption.DataBind();

    }
}
