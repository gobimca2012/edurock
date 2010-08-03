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

public partial class College_Ajaxer_InstituteTypeAccessInfo : AjaxPage
{
    private void FormValidation()
    {

        lnkAddInstituteTypeAccess.EnableValidation = true;
        lnkUpdateInstituteTypeAccess.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddInstituteTypeAccess.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateInstituteTypeAccess.ClientID);
      




    }
    private int _InstituteUserTypeID
    {
        get
        {
            return Convert.ToInt32(AjaxState["iutid"]);
        }
    }
    private void AddData()
    {
        try
        {



            int InstituteUserTypeID = _InstituteUserTypeID;

            bool CanAddExam = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddExam.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddExam.ClientID) == "on")
                    CanAddExam = true;


            bool CanAddQuestion = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddQuestion.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddQuestion.ClientID) == "on")
                    CanAddQuestion = true;


            bool CanAddUser = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddUser.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddUser.ClientID) == "on")
                    CanAddUser = true;


            bool CanAddCource = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddCource.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddCource.ClientID) == "on")
                    CanAddCource = true;


            bool CanAddSubject = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddSubject.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddSubject.ClientID) == "on")
                    CanAddSubject = true;

            bool CanAddAudio = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddAudio.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddAudio.ClientID) == "on")
                    CanAddAudio = true;


            bool CanAddImage = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddImage.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddImage.ClientID) == "on")
                    CanAddImage = true;


            bool CanAddDocument = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddDocument.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddDocument.ClientID) == "on")
                    CanAddDocument = true;


            bool CanAddVideo = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddVideo.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddVideo.ClientID) == "on")
                    CanAddVideo = true;


            bool CanAddHomeWork = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddHomeWork.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddHomeWork.ClientID) == "on")
                    CanAddHomeWork = true;


            bool CanAddEvent = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddEvent.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddEvent.ClientID) == "on")
                    CanAddEvent = true;


            bool CanAddArticle = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddArticle.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddArticle.ClientID) == "on")
                    CanAddArticle = true;
            DateTime ModifiedDate = DateTime.Now;

            new InstituteUserTypeAccessController().Add(InstituteUserTypeID, CanAddExam, CanAddQuestion, CanAddUser, CanAddCource, CanAddSubject, CanAddAudio, CanAddImage, CanAddDocument, CanAddVideo, CanAddHomeWork, CanAddEvent, CanAddArticle, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been updated Successfully", "Role Access ");
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

            //int InstituteUserTypeAccessID = ID;

            int InstituteUserTypeID = _InstituteUserTypeID;

            bool CanAddExam = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddExam.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddExam.ClientID) == "on")
                    CanAddExam = true;


            bool CanAddQuestion = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddQuestion.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddQuestion.ClientID) == "on")
                    CanAddQuestion = true;


            bool CanAddUser = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddUser.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddUser.ClientID) == "on")
                    CanAddUser = true;


            bool CanAddCource = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddCource.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddCource.ClientID) == "on")
                    CanAddCource = true;


            bool CanAddSubject = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddSubject.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddSubject.ClientID) == "on")
                    CanAddSubject = true;

            bool CanAddAudio = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddAudio.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddAudio.ClientID) == "on")
                    CanAddAudio = true;


            bool CanAddImage = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddImage.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddImage.ClientID) == "on")
                    CanAddImage = true;


            bool CanAddDocument = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddDocument.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddDocument.ClientID) == "on")
                    CanAddDocument = true;


            bool CanAddVideo = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddVideo.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddVideo.ClientID) == "on")
                    CanAddVideo = true;


            bool CanAddHomeWork = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddHomeWork.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddHomeWork.ClientID) == "on")
                    CanAddHomeWork = true;


            bool CanAddEvent = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddEvent.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddEvent.ClientID) == "on")
                    CanAddEvent = true;


            bool CanAddArticle = false; if (false) { throw new Exception(""); } if (HtmlHelper.ControlValue(chkCanAddArticle.ClientID) != "")
                if (HtmlHelper.ControlValue(chkCanAddArticle.ClientID) == "on")
                    CanAddArticle = true;

            DateTime ModifiedDate = DateTime.Now;

            new InstituteUserTypeAccessController().UpdateByInstituteUserTypeID(InstituteUserTypeID, CanAddExam, CanAddQuestion, CanAddUser, CanAddCource, CanAddSubject, CanAddAudio, CanAddImage, CanAddDocument, CanAddVideo, CanAddHomeWork, CanAddEvent, CanAddArticle, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been updated Successfully", "Role Access ");
            Response.Redirect("~/College/Ajaxer/InstituteUserTypeInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new InstituteUserTypeAccessController().GetbyInstituteUserTypeID(_InstituteUserTypeID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            if (data.CanAddExam != null)
                chkCanAddExam.Checked = Convert.ToBoolean(data.CanAddExam.ToString());
            if (data.CanAddQuestion != null)
                chkCanAddQuestion.Checked = data.CanAddQuestion;
            if (data.CanAddUser != null)
                chkCanAddUser.Checked = data.CanAddUser;
            if (data.CanAddCource != null)
                chkCanAddCource.Checked = data.CanAddCource;
            if (data.CanAddSubject != null)
                chkCanAddSubject.Checked = data.CanAddSubject;
            if (data.CanAddAudio != null)
                chkCanAddAudio.Checked = (bool)data.CanAddAudio;
            if (data.CanAddImage != null)
                chkCanAddImage.Checked = (bool)data.CanAddImage;
            if (data.CanAddDocument != null)
                chkCanAddDocument.Checked = (bool)data.CanAddDocument;
            if (data.CanAddVideo != null)
                chkCanAddVideo.Checked = (bool)data.CanAddVideo;
            if (data.CanAddHomeWork != null)
                chkCanAddHomeWork.Checked = (bool)data.CanAddHomeWork;
            if (data.CanAddEvent != null)
                chkCanAddEvent.Checked = (bool)data.CanAddEvent;
            if (data.CanAddArticle != null)
                chkCanAddArticle.Checked = (bool)data.CanAddArticle;


        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["iutaid"]);
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
        if (Request.Params["iutaid"] != null)
        {
            AjaxState["iutaid"] = Request.Params["iutaid"];
            BindData();
            lnkAddInstituteTypeAccess.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateInstituteTypeAccess.Visible = false;
        }
        if (Request.Params["iutid"] != null)
        {
            AjaxState["iutid"] = Request.Params["iutid"];
            BindData();
            lnkAddInstituteTypeAccess.Visible = false;
            lnkUpdateInstituteTypeAccess.Visible = true;
        }
    }

}
