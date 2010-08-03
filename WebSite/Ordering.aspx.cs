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
public partial class Ordering : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.Count > 0)
        {
            string idpart1 = Request.Params.AllKeys[1].Replace("[]", "").Replace("foo_", "");
            string idpart2 = Request.QueryString[1];
            string[] id = idpart2.Split(',');
            for (int i = 0; i < id.Length; i++)
            {
               
                if (Request.QueryString["qui"] != null)
                    new EXM_QuestionController().UpdateByQuestionID(Convert.ToInt32(id[i]), i+1 );
                
            }
        }
    }
}
