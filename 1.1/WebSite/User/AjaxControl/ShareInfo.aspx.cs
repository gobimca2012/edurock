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
    private Guid ShareID
    {
        get
        {
            return new Guid(AjaxState["shareID"]);
        }
        set
        {
            AjaxState["shareID"] = value.ToString();
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
        List<CheckBoxDoubleValue> EditValue = HtmlHelper.CheckBoxDoubleList("chkEdit");
        for (int i = 0; i < EditValue.Count; i++)
        {
            new ShareUserController().UpdateEnableEdit(Convert.ToInt32(EditValue[i].SecondValue), QuestionID.ToString(),(int)ObjectEnum.Question,  Convert.ToBoolean(EditValue[i].FirstValue));
        }
        List<CheckBoxDoubleValue> ViewValue = HtmlHelper.CheckBoxDoubleList("chkView");
        for (int i = 0; i < ViewValue.Count; i++)
        {
            new ShareUserController().UpdateEnableView(Convert.ToInt32(ViewValue[i].SecondValue), QuestionID.ToString(), (int)ObjectEnum.Question, Convert.ToBoolean(ViewValue[i].FirstValue));
        }
        List<CheckBoxDoubleValue> AddValue = HtmlHelper.CheckBoxDoubleList("chkAdd");
        for (int i = 0; i < AddValue.Count; i++)
        {
            new ShareUserController().UpdateEnableAdd(Convert.ToInt32(AddValue[i].SecondValue), QuestionID.ToString(), (int)ObjectEnum.Question, Convert.ToBoolean(AddValue[i].FirstValue));
        }
        List<CheckBoxDoubleValue> DeleteValue = HtmlHelper.CheckBoxDoubleList("chkDelete");
        for (int i = 0; i < DeleteValue.Count; i++)
        {
            new ShareUserController().UpdateEnableDelete(Convert.ToInt32(DeleteValue[i].SecondValue), QuestionID.ToString(), (int)ObjectEnum.Question, Convert.ToBoolean(DeleteValue[i].FirstValue));
        }
        BindData();
      
        
    }
}
