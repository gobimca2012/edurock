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

public partial class Admin_CourceCatagory : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        objLoader.LoadPage("#courcecatagory", ResolveUrl("~/Admin/Ajaxer/CourceCatagoryInfoView.aspx"));
        objLoader.LoadPage("#QuestionStatus", ResolveUrl("~/Admin/Ajaxer/QuestionStatusInfoView.aspx"));
        objLoader.LoadPage("#QuestionType", ResolveUrl("~/Admin/Ajaxer/QuestionTypeInfoView.aspx"));
    }
}
