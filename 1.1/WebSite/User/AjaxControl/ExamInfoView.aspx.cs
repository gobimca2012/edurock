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

public partial class College_Ajaxer_ExamInfoView : AjaxPage
{

    public HtmlHelper _HtmlHelper = new HtmlHelper();
    private int PageNumber
    {
        get
        {
            if (Request.Params["pn"] != null)
                return Convert.ToInt32(Request.Params["pn"].ToString());
            else
            {
                lnkPrevExam.Visible = false;
                return 0;
            }
        }


    }

    private int TotalPage;
    private int PageSize = 1;
    private int _InstituteCourceID
    {
        get
        {
            return Convert.ToInt32(AjaxState["icid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
            hpAddExam.NavigateUrl =ResolveUrl( "~/User/AjaxControl/ExamInfo.aspx")+"?icid="+_InstituteCourceID;
        }

        {
            BindList();
            TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new ExamController().GetbyInstituteCourceID(_InstituteCourceID).Count / PageSize));
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        ListExam.DataSource = new ExamController().GetbyInstituteCourceID(_InstituteCourceID, PageSize, PageNumber);
        ListExam.DataBind();
    }
    private void PaggerLinkManager()
    {


        if (PageNumber == 0)
        {
            lnkPrevExam.Visible = false;
        }
        if (TotalPage - 1 == PageNumber || TotalPage == 0)
        {
            lnkNextExam.Visible = false;
        }
        if (lnkNextExam.Visible)
        {
            //lnkNextExam.ExternameUrlParam += "&pn=" + (PageNumber + 1).ToString();
        }

        if (lnkPrevExam.Visible)
        {
            //lnkPrevExam.ExternameUrlParam += "&pn=" + (PageNumber - 1).ToString();
        }
    }
    protected void NextAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {

        BindList();
        PaggerLinkManager();
    }
    protected void PrevAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {

        BindList();
        PaggerLinkManager();
    }
    protected override void OnAjaxListViewCommand(AjaxListViewCommandArg e)
    {
        if (e.Command.Contains("delete"))
        {
            new ExamController().DeletebyExamID(Convert.ToInt32(e.Id));
            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListExamOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        //string ExamID = ListExam.DataKeys[currentItem.DataItemIndex]["ExamID"].ToString();
        //new ExamController().de



    }

    



}