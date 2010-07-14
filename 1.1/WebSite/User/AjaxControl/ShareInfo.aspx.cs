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

public partial class User_ShareInfo : AjaxPage
{
    private Guid QuestionID
    {
        get
        {
            return new Guid(AjaxState["qid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["qid"] != null)
        {
            AjaxState["qid"] = Request.Params["qid"];
        }
        BindData();
    }
    private void BindData()
    {
        var data = new ShareUserController().GetShareUser((int)ObjectEnum.Question,QuestionID.ToString());
        listUsers.DataSource = data;
        listUsers.DataBind();

    }
    protected void SaveAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        List<string> EditValue = HtmlHelper.CheckBoxList("chkEdit");
    }
}
