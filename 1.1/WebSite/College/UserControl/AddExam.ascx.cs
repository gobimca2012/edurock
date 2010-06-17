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

public partial class College_UserControl_AddExam : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        JScripter.JScripter.IncludeJavascriptFile("tinyeditor", ResolveUrl("~/Jscript/tinymce/jscripts/tiny_mce/tiny_mce.js"),this.Page);
        if (!this.IsPostBack)
        {
            if (Request.QueryString["eid"] != null)
            {
                BindData(Convert.ToInt32(Request.QueryString["eid"]));
                lnkAdd.Visible = false;
                lnkSave.Visible = true;
            }
        }
    }
    protected void lnkAdd_Click(object sender, EventArgs e)
    {
        AddData();
    }
    private void AddData()
    {
        string ExamName; if (true) { ExamName = txtExamName.Text; }

        string SubjectName; if (true) { SubjectName = txtSubjectName.Text; }

        int LoginUserID; if (true) { LoginUserID = new UserAuthontication().LoggedInUserID; }

        DateTime ModifiedDate; if (true) { ModifiedDate = DateTime.Now; }

        new ExamController().Add(ExamName, SubjectName, LoginUserID,txtDescription.Text ,ModifiedDate);
        Response.Redirect("~/College/ListExam.aspx");
    }
    private void EditData(int ID)
    {


        int ExamID; if (true) { ExamID = ID; }

        string ExamName; if (true) { ExamName = txtExamName.Text; }

        string SubjectName; if (true) { SubjectName = txtSubjectName.Text; }

        new ExamController().UpdateByExamID(ExamID, ExamName, SubjectName,txtDescription.Text, new UserAuthontication().LoggedInUserID, DateTime.Now);
    }
    private void BindData(int ID)
    {
        var dataBunch = new ExamController().GetbyExamID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];


            txtExamName.Text = data.ExamName;

            txtSubjectName.Text = data.SubjectName;



        }
    }
    protected void lnkSave_Click(object sender, EventArgs e)
    {
        EditData(Convert.ToInt32(Request.QueryString["eid"]));
        Response.Redirect("~/College/ListExam.aspx");
    }
}