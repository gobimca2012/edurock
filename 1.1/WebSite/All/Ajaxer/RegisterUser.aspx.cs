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

public partial class All_Ajaxer_RegisterUser : AjaxPage
{
    private void FormValidation()
    {
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkRegisterNewUser.ClientID);
        objValidate.Medatory(txtUsername, "Please enter Username", this.Page);
        objValidate.Medatory(txtPassword, "Please enter Password", this.Page);
        objValidate.Medatory(txtUseremail, "Please enter Email Address", this.Page);
        objValidate.ComparttextBox(txtPassword, "Please enter password does not match", this.Page, txtConfirm);
        objValidate.DrowDownMendatory(ddCource, "Please select cource", this.Page, "0");
        objValidate.DrowDownMendatory(ddInstitute, "Please select Institute", this.Page, "0");
    }
    protected override void OnLoad(EventArgs e)
    {
        FormValidation();
        IsLogginMandatory = false;
        new InstituteController().BindInstitute(ddInstitute);
        ddInstitute.Attributes["onchange"] = string.Format("ddChange('#{0}','#{1}','{2}');", ddInstitute.ClientID, "ddrep", (ResolveUrl("~/User/Service.aspx") + "?iid="));
        base.OnLoad(e);
    }

    private void AddUser()
    {
        string UserName;
        UserName = HtmlHelper.ControlValue(txtUsername.ClientID);
        string Password;
        Password = HtmlHelper.ControlValue(txtPassword.ClientID);
        string Email;
        Email = HtmlHelper.ControlValue(txtUseremail.ClientID);
        string FirstName;
        FirstName = HtmlHelper.ControlValue(txtFirstName.ClientID);
        string Lastname;
        Lastname = HtmlHelper.ControlValue(txtLastName.ClientID);
        int InstituteID = 0;
        InstituteID = Convert.ToInt32(HtmlHelper.ControlValue(ddInstitute.ClientID));
        int InstituteCourceID = 0;
        InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));
        Dictionary<string, string> status = new LoginUserController().CreateUser(UserName, Password,FirstName,Lastname,ConfigurationSettings.AppSettings["UserAvtar"].ToString(),  Email, (int)UserTypeEnum.Student, InstituteID, InstituteCourceID);
        if (status["status"].Contains("success"))
        {
            divMessage.InnerHtml = "<div class='success'>User created</div>";
        }
        else
        {
            divMessage.InnerHtml = "<div class='error'>not created</div>";
        }
        Session[SessionName.StatusMessage.ToString()] = "User SuccessFully Created";

        Response.Redirect("~/Success.aspx");
    }
    protected void RegisterAjax(object sender, AjaxControl.AjaxEventArg e)
    {
        AddUser();
    }
}
