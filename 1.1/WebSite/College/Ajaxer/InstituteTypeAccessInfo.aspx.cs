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
            DateTime ModifiedDate = DateTime.Now;

            new InstituteUserTypeAccessController().Add(InstituteUserTypeID, CanAddExam, CanAddQuestion, CanAddUser, CanAddCource, CanAddSubject, ModifiedDate);
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

            DateTime ModifiedDate = DateTime.Now;

            new InstituteUserTypeAccessController().UpdateByInstituteUserTypeID(InstituteUserTypeID, CanAddExam, CanAddQuestion, CanAddUser, CanAddCource, CanAddSubject, ModifiedDate);

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


            chkCanAddExam.Checked = Convert.ToBoolean(data.CanAddExam.ToString());

            chkCanAddQuestion.Checked = data.CanAddQuestion;

            chkCanAddUser.Checked = data.CanAddUser;

            chkCanAddCource.Checked = data.CanAddCource;

            chkCanAddSubject.Checked = data.CanAddSubject;



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
