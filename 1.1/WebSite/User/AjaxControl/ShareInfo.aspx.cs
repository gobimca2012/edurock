﻿using System;
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
            return Convert.ToInt32( AjaxState["type"]);
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
            BindUserData();
            BindGroupData();
        }
    }
    private void BindUserData()
    {
        var data = new ShareUserController().GetShareUser(Type,QuestionID.ToString());
       
        listUsers.DataSource = data;
        listUsers.DataBind();

    }

    private void BindGroupData()
    {
        var data = new ShareGroupController().GetShareGroup(Type, QuestionID.ToString());

        ListGroup.DataSource = data;
        ListGroup.DataBind();

    }
    
    protected void SaveAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        List<CheckBoxDoubleValue> EditValue = HtmlHelper.CheckBoxDoubleList("chkEdit");
        for (int i = 0; i < EditValue.Count; i++)
        {
            new ShareUserController().UpdateEnableEdit(Convert.ToInt32(EditValue[i].SecondValue), QuestionID.ToString(),Type,  Convert.ToBoolean(EditValue[i].FirstValue));
        }
        List<CheckBoxDoubleValue> ViewValue = HtmlHelper.CheckBoxDoubleList("chkView");
        for (int i = 0; i < ViewValue.Count; i++)
        {
            new ShareUserController().UpdateEnableView(Convert.ToInt32(ViewValue[i].SecondValue), QuestionID.ToString(), Type, Convert.ToBoolean(ViewValue[i].FirstValue));
        }
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


    }
}
