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

public partial class User_AjaxControl_Exam : AjaxPage
{

    private void BindData()
    {
        var dataBunch = new ExamController().GetbyExamID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            if (data.ExamID != null)

                lblExamID.InnerHtml = data.ExamID.ToString();

            if (data.ExamName != null)

                lblExamName.InnerHtml = data.ExamName.ToString();

            if (data.SubjectName != null)

                lblSubjectName.InnerHtml = data.SubjectName.ToString();

            if (data.InstituteCourceID != null)

                lblInstituteCourceID.InnerHtml = data.InstituteCourceID.ToString();

            if (data.InstituteSubjectID != null)

                lblInstituteSubjectID.InnerHtml = data.InstituteSubjectID.ToString();

            if (data.Description != null)

                lblDescription.InnerHtml = data.Description.ToString();

            if (data.LoginUserID != null)

                lblLoginUserID.InnerHtml = data.LoginUserID.ToString();

            if (data.ModifiedDate != null)

                lblModifiedDate.InnerHtml = data.ModifiedDate.ToString();

            if (data.ExamTime != null)

                lblExamTime.InnerHtml = data.ExamTime.ToString();

            if (data.IsActive != null)

                lblIsActive.InnerHtml = data.IsActive.ToString();

            if (data.RequirePecentage != null)

                lblRequirePecentage.InnerHtml = data.RequirePecentage.ToString();

            if (data.StartDate != null)

                lblStartDate.InnerHtml = data.StartDate.ToString();

            if (data.EndDate != null)

                lblEndDate.InnerHtml = data.EndDate.ToString();
        }

    }

    private int ID
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
        BindData();
        MakeLink();
    }
    private void MakeLink()
    {
        lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/ExamInfo.aspx") + "?eid=" + ID;
        lnkQuestion.NavigateUrl = ResolveUrl("~/User/AjaxControl/EXMQuestionList.aspx") + "?eid=" + ID;
    }

}
