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

public partial class User_AjaxControl_SelectQuestionType : AjaxPage
{
    private int _ExamID
    {
        get
        {
            return Convert.ToInt32(AjaxState["eid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["eid"] != null)
        {
            AjaxState["eid"] = Request.Params["eid"];
        }
//        this.DropDownPostBack(ddQuestionType,"#contentBox","#contentBox");
        MakeLink();
    }
    private void MakeLink()
    {
        lnkSingleChoice.NavigateUrl = ResolveUrl("~/User/AjaxControl/SingleChoiceInfo.aspx") + "?eid=" + _ExamID.ToString();
        lnkMultiChoice.NavigateUrl = ResolveUrl("~/User/AjaxControl/MultiChoiceInfo.aspx") + "?eid=" + _ExamID.ToString();
        lnksingleFillinTheBlank.NavigateUrl = ResolveUrl("~/User/AjaxControl/SingleFillIntheBlankInfo.aspx") + "?eid=" + _ExamID.ToString();
    }
    protected override void OnAjaxDropDownChange(string e)
    {
        if (HtmlHelper.ControlValue(ddQuestionType.ClientID) == "1")
        {
            Response.Redirect("~/User/AjaxControl/SingleChoiceInfo.aspx" + "?eid=" + _ExamID.ToString());
        }
        else if (HtmlHelper.ControlValue(ddQuestionType.ClientID) == "2")
        {
        }
        else if (HtmlHelper.ControlValue(ddQuestionType.ClientID) == "3")
        {
        }
        else if (HtmlHelper.ControlValue(ddQuestionType.ClientID) == "4")
        {
        }
        else if (HtmlHelper.ControlValue(ddQuestionType.ClientID) == "5")
        {
        }
        base.OnAjaxDropDownChange(e);
    }
    
}
