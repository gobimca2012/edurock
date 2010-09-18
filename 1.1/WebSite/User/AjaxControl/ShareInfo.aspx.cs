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
using Common;

public partial class User_ShareInfo : AjaxPage
{
    private string QuestionID
    {
        get
        {
            return AjaxState["conid"];
        }
    }
    private int Type
    {
        get
        {
            return Convert.ToInt32(AjaxState["type"]);
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
        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.Collapspanel("#userboxtigger", "#userbox");
        objEffect.Collapspanel("#roleboxtrigger", "#rolebox");
        if (Request.Params["conid"] != null)
        {
            AjaxState["conid"] = Request.Params["conid"];
        }
        if (Request.Params["type"] != null)
        {
            AjaxState["type"] = Request.Params["type"];
        }
        //if (!this.IsAjaxPostBack)
        {
            if (Type != (int)ContentTypeEnum.InstituteCourse)
            {
                chkAddAllUser.Visible = false;
            }
            BindUserData();
            BindGroupData();
            BindAllUser();
        }
    }
    private void BindAllUser()
    {
        var data = new ShareController().Get(QuestionID.ToString(), Type);
        if (data.Count > 0)
        {
            if (data[0].EnableAllUseView != null)
                chkViewAllUser.Checked = (bool)data[0].EnableAllUseView;
            if (data[0].EnableAllUserAdd != null)
                chkAddAllUser.Checked = (bool)data[0].EnableAllUserAdd;
            if (data[0].EnableAllUserEdit != null)
                chkEditAllUser.Checked = (bool)data[0].EnableAllUserEdit;
        }
    }
    private void BindUserData()
    {
        var data = new ShareUserController().GetShareUser(Type, QuestionID.ToString());

        listUsers.DataSource = data;
        listUsers.DataBind();

    }
    private void BindUserData(string UserName)
    {
        var data = new ShareUserController().GetShareUser(Type, QuestionID.ToString(),UserName);
        listUsers.DataSource = data;
        listUsers.DataBind();

    }
    private void CreateBackLink()
    {
        if (Type == (int)ContentTypeEnum.Article)
            lnkBack.NavigateUrl = ResolveUrl("~/User/AjaxControl/Article.aspx") + "?arid=" + QuestionID.ToString();
        else if (Type == (int)ContentTypeEnum.Audio || Type == (int)ContentTypeEnum.Image || Type == (int)ContentTypeEnum.Video || Type == (int)ContentTypeEnum.Document)
            lnkBack.NavigateUrl = ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + QuestionID.ToString();
        else if (Type == (int)ContentTypeEnum.Event)
            lnkBack.NavigateUrl = ResolveUrl("~/User/AjaxControl/Event.aspx") + "?evid=" + QuestionID.ToString();
        else if (Type == (int)ContentTypeEnum.Exam)
            lnkBack.NavigateUrl = ResolveUrl("~/User/AjaxControl/Exam.aspx") + "?eid=" + QuestionID.ToString();
        else if (Type == (int)ContentTypeEnum.HomeWork)
            lnkBack.NavigateUrl = ResolveUrl("~/User/AjaxControl/HomeWork.aspx") + "?hwid=" + QuestionID.ToString();
        else if (Type == (int)ContentTypeEnum.Question)
            lnkBack.NavigateUrl = ResolveUrl("~/User/AjaxControl/Question.aspx") + "?qid=" + QuestionID.ToString();

    }

    private void BindGroupData()
    {
        CreateBackLink();
        var data = new ShareGroupController().GetShareGroup(Type, QuestionID.ToString());
        ListGroup.DataSource = data;
        ListGroup.DataBind();

    }

    protected void SaveAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        #region Edit Save

        
        //List<CheckBoxDoubleValue> EditValueAll = HtmlHelper.CheckBoxDoubleList("chkAllEdit");
        //if (EditValueAll.Count > 0)
        //    new ShareController().UpdateShareEditAllUser(Type, QuestionID.ToString(), Convert.ToBoolean(EditValueAll[0].FirstValue));

        List<CheckBoxDoubleValue> EditValue = HtmlHelper.CheckBoxDoubleList("chkEdit");
        for (int i = 0; i < EditValue.Count; i++)
        {
            new ShareUserController().UpdateEnableEdit(Convert.ToInt32(EditValue[i].SecondValue), QuestionID.ToString(), Type, Convert.ToBoolean(EditValue[i].FirstValue));
        }
        #endregion
        #region View Save

        
        //List<CheckBoxDoubleValue> ViewValueAll = HtmlHelper.CheckBoxDoubleList("chkAllView");
        //if (ViewValueAll.Count > 0)
        //    new ShareController().UpdateShareViewAllUser(Type, QuestionID.ToString(), Convert.ToBoolean(ViewValueAll[0].FirstValue));
        List<CheckBoxDoubleValue> ViewValue = HtmlHelper.CheckBoxDoubleList("chkView");
        for (int i = 0; i < ViewValue.Count; i++)
        {
            new ShareUserController().UpdateEnableView(Convert.ToInt32(ViewValue[i].SecondValue), QuestionID.ToString(), Type, Convert.ToBoolean(ViewValue[i].FirstValue));
        }

        #endregion
        //List<CheckBoxDoubleValue> AddValueAll = HtmlHelper.CheckBoxDoubleList("chkAllAdd");
        //if (AddValueAll.Count > 0)
        //    new ShareController().UpdateShareAddAllUser(Type, QuestionID.ToString(), Convert.ToBoolean(ViewValueAll[0].FirstValue));
        List<CheckBoxDoubleValue> AddValue = HtmlHelper.CheckBoxDoubleList("chkAdd");
        for (int i = 0; i < AddValue.Count; i++)
        {
            new ShareUserController().UpdateEnableAdd(Convert.ToInt32(AddValue[i].SecondValue), QuestionID.ToString(), Type, Convert.ToBoolean(AddValue[i].FirstValue));
        }
        List<CheckBoxDoubleValue> DeleteValue = HtmlHelper.CheckBoxDoubleList("chkDelete");
        for (int i = 0; i < DeleteValue.Count; i++)
        {
            new ShareUserController().UpdateEnableDelete(Convert.ToInt32(DeleteValue[i].SecondValue), QuestionID.ToString(), Type, Convert.ToBoolean(DeleteValue[i].FirstValue));
        }
        BindUserData();
        BindAllUser();

    }
    protected void SaveGroupAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        List<CheckBoxDoubleValue> EditValue = HtmlHelper.CheckBoxDoubleList("chkgEdit");
        for (int i = 0; i < EditValue.Count; i++)
        {
            new ShareGroupController().UpdateEnableEdit(Convert.ToInt32(EditValue[i].SecondValue), QuestionID.ToString(), Type, Convert.ToBoolean(EditValue[i].FirstValue));
        }
        List<CheckBoxDoubleValue> ViewValue = HtmlHelper.CheckBoxDoubleList("chkgView");
        for (int i = 0; i < ViewValue.Count; i++)
        {
            new ShareGroupController().UpdateEnableView(Convert.ToInt32(ViewValue[i].SecondValue), QuestionID.ToString(), Type, Convert.ToBoolean(ViewValue[i].FirstValue));
        }
        List<CheckBoxDoubleValue> AddValue = HtmlHelper.CheckBoxDoubleList("chkgAdd");
        for (int i = 0; i < AddValue.Count; i++)
        {
            new ShareGroupController().UpdateEnableAdd(Convert.ToInt32(AddValue[i].SecondValue), QuestionID.ToString(), Type, Convert.ToBoolean(AddValue[i].FirstValue));
        }
        List<CheckBoxDoubleValue> DeleteValue = HtmlHelper.CheckBoxDoubleList("chkgDelete");
        for (int i = 0; i < DeleteValue.Count; i++)
        {
            new ShareGroupController().UpdateEnableDelete(Convert.ToInt32(DeleteValue[i].SecondValue), QuestionID.ToString(), Type, Convert.ToBoolean(DeleteValue[i].FirstValue));
        }
        BindGroupData();
        BindAllUser();

    }
    protected void AjaxSearchUser(object sender, AjaxControl.AjaxEventArg e)
    {
        BindUserData(HtmlHelper.ControlValue(txtSearchUser.ClientID));
    }
    protected void LayoutCreated(object sender, EventArgs e)
    {
        HtmlTableCell tdcanadd=(HtmlTableCell) listUsers.FindControl("tdcanadd");
        if (tdcanadd != null)
        {
            if (Type == (int)ContentTypeEnum.InstituteCourse)
            {
                tdcanadd.Visible = false;
            }
        }
    }
    protected void GroupLayoutCreated(object sender, EventArgs e)
    {
        HtmlTableCell tdcanadd = (HtmlTableCell)listUsers.FindControl("tdcanadd");
        if (tdcanadd != null)
        {
            if (Type != (int)ContentTypeEnum.InstituteCourse)
            {
                tdcanadd.Visible = false;
            }
        }
    }
    protected void UserItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        HtmlTableCell tdcanadd = (HtmlTableCell)currentItem.FindControl("tdcanadd");
        if (tdcanadd != null)
        {
            if (Type != (int)ContentTypeEnum.InstituteCourse)
            {
                tdcanadd.Visible = false;
            }
        }
    }
    protected void GroupItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        HtmlTableCell tdcanadd = (HtmlTableCell)currentItem.FindControl("tdcanadd");
        if (tdcanadd != null)
        {
            if (Type != (int)ContentTypeEnum.InstituteCourse)
            {
                tdcanadd.Visible = false;
            }
        }
    }
    protected void UpdateAllAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        List<CheckBoxDoubleValue> EditValueAll = HtmlHelper.CheckBoxDoubleList("chkAllEdit");
        if (EditValueAll.Count > 0)
            new ShareController().UpdateShareEditAllUser(Type, QuestionID.ToString(), Convert.ToBoolean(EditValueAll[0].FirstValue));
        List<CheckBoxDoubleValue> ViewValueAll = HtmlHelper.CheckBoxDoubleList("chkAllView");
        if (ViewValueAll.Count > 0)
            new ShareController().UpdateShareViewAllUser(Type, QuestionID.ToString(), Convert.ToBoolean(ViewValueAll[0].FirstValue));
        List<CheckBoxDoubleValue> AddValueAll = HtmlHelper.CheckBoxDoubleList("chkAllAdd");
        if (AddValueAll.Count > 0)
            new ShareController().UpdateShareAddAllUser(Type, QuestionID.ToString(), Convert.ToBoolean(ViewValueAll[0].FirstValue));
    }
}
