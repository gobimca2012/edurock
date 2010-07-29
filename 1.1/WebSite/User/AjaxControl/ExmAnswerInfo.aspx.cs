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

public partial class User_AjaxControl_ExmAnswerInfo : AjaxPage
{
    private void FormValidation()
    {
        lnkUpdateEXM_Answer.EnableValidation = true;
        lnkAddEXM_Answer.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddEXM_Answer.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateEXM_Answer.ClientID);
        objValidate.Medatory(txtAnswer, "Please enter Answer", this.Page);

    }

    private int _QuestionID
    {
        get
        {
            return Convert.ToInt32(AjaxState["qid"]);
        }
    }
    private void AddData()
    {
        try
        {


            int EXM_QuestionID = _QuestionID;

            string Answer; if (false) { throw new Exception(""); } Answer = HtmlHelper.ControlValue(txtAnswer.ClientID);

            bool IsRight = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsRight.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsRight.ClientID) == "on")
                    IsRight = true;


            DateTime ModifiedDate = DateTime.Now;

            //new EXM_AnswerController().Add(EXM_AnswerID, EXM_QuestionID, Answer, IsRight, Marks, ModifiedDate);
            Dictionary<string, string> Status = new Dictionary<string, string>();

            Status= new EXM_AnswerController().Add(EXM_QuestionID, Answer, IsRight, ModifiedDate);
            if (Status["Error"] != "")
            {
                divMessage.InnerHtml = Status["Error"].ToString();
            }
            else
            {
                Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} hasbeen Updated Successfully", "Exam Answer");
                Response.Redirect("~/User/AjaxControl/EXMAnswerInfoView.aspx?qid=" + _QuestionID.ToString());
            }
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

            int EXM_AnswerID = ID;

            int EXM_QuestionID = _QuestionID;

            string Answer; if (false) { throw new Exception(""); } Answer = HtmlHelper.ControlValue(txtAnswer.ClientID);

            bool IsRight = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkIsRight.ClientID) != "")
                if (HtmlHelper.ControlValue(chkIsRight.ClientID) == "on")
                    IsRight = true;




            DateTime ModifiedDate = DateTime.Now;

            //new EXM_AnswerController().UpdateByEXM_AnswerID(EXM_AnswerID, EXM_QuestionID, Answer, IsRight, Marks, ModifiedDate);

            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData(Guid ID)
    {
        
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["eaid"]);
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
        FormValidation();
        if (Request.Params["qid"] != null)
        {
            AjaxState["qid"] = Request.Params["qid"];
        }
        if (Request.Params["eaid"] != null)
        {
            AjaxState["eaid"] = Request.Params["eaid"];

            lnkAddEXM_Answer.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateEXM_Answer.Visible = false;
        }
    }

}
