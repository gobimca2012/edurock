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
using Common;
using DataEntity;

public partial class User_Widget_html : WidgetControl
{
    private HTMLWidget Data
    {
        get
        {
            var data = new HTMLWidgetController().GetbyWidgetID(WidgetID);
            if (data.Count > 0)
            {
                return data[0];
            }
            else
            {
                return null;
            }
        }
    }
    private bool IsEdit
    {
        get;
        set;


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        MakeLinks();
        new JScripter.TinyMCE(this.Page).Create();
        new JScripter.Widget(this.Page, false).DeleteLinkButton(CustomHelper.GetGuidString(WidgetID), ResolveUrl("~/User/Widget/WidgetAction.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID), lnkClose);
        if (!IsAjaxPostBack)
        {
            if (Data == null)
            {
                BindEditData();
            }
            else
            {
                BindPriviewData();
            }
        }
    }
    private void BindPriviewData()
    {
        if (Data != null)
            divHtml.InnerHtml = Data.HTMLDATA;
        divEditBox.Visible = false;
    }
    private void BindEditData()
    {
        if (Data != null)
        {
            txtEditor.Text = Data.HTMLDATA;

        }
        divPreviewBox.Visible = false;
    }
    private void VisibleControl()
    {
    }
    protected void AjaxDeleteWidget(object sender, AjaxControl.AjaxEventArg e)
    {
        new WidgetController().DeletebyWidgetID(WidgetID);
    }
    protected void AjaxUpdate(object sender, AjaxControl.AjaxEventArg e)
    {
        if (Data!= null)
        {
            string htmldata = HtmlHelper.ControlValue(txtEditor.ClientID);
            new HTMLWidgetController().UpdateByHTMLWidgetID(Data.HTMLWidgetID, htmldata, DateTime.Now);
        }
        BindPriviewData();
    }
    protected void AjaxEdit(object sender, AjaxControl.AjaxEventArg e)
    {
       
        BindEditData();
    }
    private void MakeLinks()
    {
        lnkEdit.RequestContainner = "#" + CustomHelper.GetGuidString(WidgetID);
        lnkEdit.ResponseContainner = "#" + CustomHelper.GetGuidString(WidgetID);
        lnkUpdate.RequestContainner = "#" + CustomHelper.GetGuidString(WidgetID);
        lnkUpdate.ResponseContainner = "#" + CustomHelper.GetGuidString(WidgetID);
    }
}