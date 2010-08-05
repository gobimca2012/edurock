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
    private int PageSize = 100;
    private int _LoginUserID
    {
        get
        {
            if (AjaxState.ContainsKey("usid"))
            {
                return Convert.ToInt32(AjaxState["usid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    private int _InstituteCourceID
    {
        get
        {
            if (AjaxState.ContainsKey("icid"))
            {
                return Convert.ToInt32(AjaxState["icid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    private int _InstituteSubjectID
    {
        get
        {
            if (AjaxState.ContainsKey("isid"))
            {
                return Convert.ToInt32(AjaxState["isid"]);
            }
            else
            {
                return 0;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        hpAddExam.Visible = (bool)new ButtonVisibilityHelper(new UserAuthontication().LoggedInUserID).Access.CanAddExam;
        if (Request.Params["isid"] != null)
        {
            AjaxState["isid"] = Request.Params["isid"];
        }
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
           
        }
        if (Request.Params["usid"] != null)
        {
            AjaxState["usid"] = Request.Params["usid"];
        }
        if (_InstituteCourceID > 0)
        {
            header.InnerHtml = "Examinations in " + new InstituteCourceController().GetInstituteCourceName(_InstituteCourceID);
        }
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];
            hpAddExam.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfo.aspx") + "?icid=" + _InstituteCourceID;
        }
        else
        {
            hpAddExam.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfo.aspx");
        }

        {
            BindList();
            
            PaggerLinkManager();
        }

    }
    private void BindList()
    {
        TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new UserController().GetContent(_LoginUserID, _InstituteCourceID, _InstituteSubjectID, (int)ContentTypeEnum.Exam).Count / PageSize));
        ListExam.DataSource = new UserController().GetContent(_LoginUserID, _InstituteCourceID, _InstituteSubjectID, (int)ContentTypeEnum.Exam, PageSize, PageNumber);
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
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string IsActive = ListExam.DataKeys[currentItem.DataItemIndex]["Param1"].ToString();
        HtmlGenericControl IsActiveCtr = (HtmlGenericControl)currentItem.FindControl("IsActive");
        if (IsActiveCtr != null)
        {
            if (IsActive == "1")
            {
                IsActiveCtr.Visible = true;
            }
            else
            {
                IsActiveCtr.Visible = false;
            }
        }



    }





}