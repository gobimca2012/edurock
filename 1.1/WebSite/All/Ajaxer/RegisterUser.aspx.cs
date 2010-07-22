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

public partial class All_Ajaxer_RegisterUser :AjaxPage
{
    protected override void OnLoad(EventArgs e)
    {
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkRegister.ClientID);
        objValidate.Medatory(txtUsername, "Please enter", this.Page);
        IsLogginMandatory = false;
        new InstituteController().BindInstitute(ddInstitute);
        ddInstitute.Attributes["onchange"] = string.Format("ddChange('#{0}','#{1}','{2}');", ddInstitute.ClientID, "ddrep", (ResolveUrl("~/User/Service.aspx") + "?iid="));
        base.OnLoad(e);
    }
    
    private int AddUser()
    {
        string UserName;
        UserName = HtmlHelper.ControlValue(txtUsername.ClientID);
        string Password;
        Password = HtmlHelper.ControlValue(txtPassword.ClientID);
        string Email;
        Email = HtmlHelper.ControlValue(txtUseremail.ClientID);
        int InstituteID = 0;
        InstituteID=Convert.ToInt32(HtmlHelper.ControlValue(ddInstitute.ClientID));
        int InstituteCourceID=0;
        InstituteCourceID=Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));
        Dictionary<string,string> status= new LoginUserController().CreateUser(UserName,Password,Email,(int)UserTypeEnum.Student,InstituteID,InstituteCourceID);
        if (status["status"].Contains("success"))
        {
            divMessage.InnerHtml = "<div class='success'>User created</div>";
        }
        else
        {
            divMessage.InnerHtml = "<div class='error'>not created</div>";
        }
        return 0;
    }
    protected void RegisterAjax(object sender, AjaxControl.AjaxEventArg e)
    {
        AddUser();
    }
}
