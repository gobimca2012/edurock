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
using AjaxControl;

public partial class Modules_Login_Create : AjaxPage
{
    protected override void OnInit(EventArgs e)
    {        
        base.OnInit(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        AjaxLinkButton1.PostBackUrl = ResolveUrl("~/Modules/login/Create.aspx");
        AjaxLinkButton1.RequestContainner = "#creatediv";
        AjaxLinkButton1.ResponseContainner = "#creatediv";
        
    }
    protected void AjaxClick(object sender, AjaxEventArg e)
    {
        LoginUserController objLogin = new LoginUserController();
        int UserType =Convert.ToInt16(Request.Params[RdbType.ClientID]);
        objLogin.CreateUser(txtUsername.value, txtPassword.value, txtEmail.value,UserType);
       
        PanelSuccess.InnerHtml += "<div class='success'>Your account has been created";
    }

}
