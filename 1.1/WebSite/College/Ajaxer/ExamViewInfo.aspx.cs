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

public partial class College_Ajaxer_ExamViewInfo : AjaxPage
{


    private void AddData()
    {
        try
        {

            

            string ExamName; if (false) { throw new Exception(""); } ExamName = HtmlHelper.ControlValue(txtExamName.ClientID);

            string SubjectName; if (false) { throw new Exception(""); } SubjectName = HtmlHelper.ControlValue(txtSubjectName.ClientID);

            int InstituteCourceID; if (false) { throw new Exception(""); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID));

            int InstituteSubjectID; if (false) { throw new Exception(""); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteSubject.ClientID));

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            DateTime ModifiedDate = DateTime.Now;

            string ExamTime; if (false) { throw new Exception(""); } ExamTime = HtmlHelper.ControlValue(txtExamTime.ClientID);

            bool IsActive = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsActive.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsActive.ClientID) == "on")
                    IsActive = true;


            int RequirePecentage; if (false) { throw new Exception(""); } RequirePecentage = Convert.ToInt32(HtmlHelper.ControlValue(txtRequirePecentage.ClientID));

            DateTime StartDate; if (false) { throw new Exception(""); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (false) { throw new Exception(""); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));

            new ExamController().Add( ExamName, SubjectName, InstituteCourceID, InstituteSubjectID, Description, LoginUserID, ModifiedDate, ExamTime, IsActive, RequirePecentage, StartDate, EndDate);
            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void EditData()
    {
        try
        {

            int ExamID = ID;

            string ExamName; if (false) { throw new Exception(""); } ExamName = HtmlHelper.ControlValue(txtExamName.ClientID);

            string SubjectName; if (false) { throw new Exception(""); } SubjectName = HtmlHelper.ControlValue(txtSubjectName.ClientID);

            int InstituteCourceID; if (false) { throw new Exception(""); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteCource.ClientID));

            int InstituteSubjectID; if (false) { throw new Exception(""); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstituteSubject.ClientID));

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            DateTime ModifiedDate = DateTime.Now;

            string ExamTime; if (false) { throw new Exception(""); } ExamTime = HtmlHelper.ControlValue(txtExamTime.ClientID);

            bool IsActive = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsActive.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsActive.ClientID) == "on")
                    IsActive = true;


            int RequirePecentage; if (false) { throw new Exception(""); } RequirePecentage = Convert.ToInt32(HtmlHelper.ControlValue(txtRequirePecentage.ClientID));

            DateTime StartDate; if (false) { throw new Exception(""); } StartDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtStartDate.ClientID));

            DateTime EndDate; if (false) { throw new Exception(""); } EndDate = Convert.ToDateTime(HtmlHelper.ControlValue(txtEndDate.ClientID));

            new ExamController().UpdateByExamID(ExamID, ExamName, SubjectName, InstituteCourceID, InstituteSubjectID, Description, LoginUserID, ModifiedDate, ExamTime, IsActive, RequirePecentage, StartDate, EndDate);

            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new ExamController().GetbyExamID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            

            txtExamName.Text = data.ExamName;

            txtSubjectName.Text = data.SubjectName;

            new InstituteCourceController().BindInstituteCource(ddInstituteCource, data.InstituteCourceID.ToString());
            new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject,data.InstituteSubjectID.ToString());
            
            txtDescription.Text = data.Description;

            

            txtExamTime.Text = data.ExamTime;

            chkIsActive.Checked = (bool) data.IsActive;

            txtRequirePecentage.Text = data.RequirePecentage.ToString();

            txtStartDate.Text = data.StartDate.ToString();

            txtEndDate.Text = data.EndDate.ToString();

        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["eid"]);
        }
    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();

    }
    protected void UpdateAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        EditData();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["eid"] != null)
        {
            AjaxState["eid"] = Request.Params["eid"];
            BindData();
            lnkAddExam.Visible = false;
        }
        else
        {
            new InstituteCourceController().BindInstituteCource(ddInstituteCource);
            new InstituteSubjectController().BindInstituteSubject(ddInstituteSubject);
            
            lnkUpdateExam.Visible = false;
        }
    }

}
