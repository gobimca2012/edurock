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
using Common;

public partial class College_Ajaxer_InstituteCourceUserInfo : AjaxPage
{
    private void FormValidation()
    {
        lnkAddInstituteCourceUser.EnableValidation = true;
        lnkUpdateInstituteCourceUser.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddInstituteCourceUser.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateInstituteCourceUser.ClientID);
        //objValidate.Medatory(txtCatagoryName, "Please Catagory Name", this.Page);
        objValidate.DrowDownMendatory(ddCource, "Please Select Cource", this.Page, "0");
        



    }
    private int UserID
    {
        get
        {
            //if (AjaxState.ContainsKey("uid"))
            {
                return Convert.ToInt32(AjaxState["uid"]);
            }
        }
    }

    private void AddData()
    {
        try
        {

            Guid InstituteCourceUserID = Guid.NewGuid();

            int InstituteCourceID; if (false) { throw new Exception(""); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            int UID = UserID;
            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int Type = (int)InstituteCourceUserEnum.Normal;

            DateTime Modifieddate = DateTime.Now;

            new InstituteCourceUserController().Add(InstituteCourceUserID, InstituteCourceID,UID, LoginUserID, Type, Modifieddate);
            Response.Redirect("~/College/Ajaxer/InstituteCourceUserInfoView.aspx?uid=" + UserID.ToString());
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

            Guid InstituteCourceUserID = ID;

            int InstituteCourceID; if (false) { throw new Exception(""); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            int UID = UserID;
            int LoginUserID = new UserAuthontication().LoggedInUserID;


            int Type = (int)InstituteCourceUserEnum.Normal;

            DateTime Modifieddate = DateTime.Now;

            new InstituteCourceUserController().UpdateByInstituteCourceUserID(InstituteCourceUserID, InstituteCourceID,UID, LoginUserID, Type, Modifieddate);

            Response.Redirect("~/College/Ajaxer/InstituteCourceUserInfoView.aspx?uid=" + UserID.ToString());
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new InstituteCourceUserController().GetbyInstituteCourceUserID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            AjaxState["uid"] = data.LoginUserID.ToString();
            new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID, data.InstituteCourceID.ToString());


        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["icuid"]);
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
        if (Request.Params["uid"] != null)
        {
            AjaxState["uid"] = Request.Params["uid"];
        }
        if (Request.Params["icuid"] != null)
        {
            AjaxState["icuid"] = Request.Params["icuid"];
            BindData();
            lnkAddInstituteCourceUser.Visible = false;
        }
        else
        {
            new InstituteCourceController().BindInstituteCourceByLoginUserID(ddCource, new UserAuthontication().UserInstituteID,new UserAuthontication().LoggedInUserID);
            lnkUpdateInstituteCourceUser.Visible = false;
        }
    }

}
