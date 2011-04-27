using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using Common;

public partial class User_Widget_Shout : WidgetControl
{
    private int InstituteCourceID
    {
        get
        {
            return Convert.ToInt32(AjaxState["icid"]);
        }
    }
    private int MyLoginUserID
    {
        get
        {
            return new UserAuthontication().LoggedInUserID;
        }
    }
    private DateTime StartDate
    {
        get
        {
           
                return new DateTime(1800, 1, 1);
           
        }
    }
    private DateTime EndDate
    {
        get
        {
            
                return DateTime.Now;
            
        }
    }
    private void FormValidation()
    {
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkPost.ClientID);
        objValidate.MaximumLength(txtShout, "Only 140 charactor allow", this.Page, "140");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        txtShout.Attributes["onkeydown"] = string.Format("limitText('{0}','{1}',140);", txtShout.ClientID, txtCounter.ClientID);
        txtShout.Attributes["onkeyup"] = string.Format("limitText('{0}','{1}',140);", txtShout.ClientID, txtCounter.ClientID);
        FormValidation();
        Widgetheader.InnerText = "Shout here...";
        CreateControls();
        new JScripter.Widget(this.Page, false).DeleteLinkButton(GetWidgetBoxID(WidgetID), ResolveUrl("~/User/Widget/WidgetAction.aspx") + "?wid=" + CustomHelper.GetGuidString(WidgetID), lnkClose);
        if (Request.Params["icid"] != null)
        {
            AjaxState["icid"] = Request.Params["icid"];

        }
        //lnkPost.RequestContainner = "#" + GetWidgetBoxID(WidgetID);
       
        BindList();
    }
    protected void AjaxDeleteWidget(object sender, AjaxControl.AjaxEventArg e)
    {
        new WidgetController().DeletebyWidgetID(WidgetID);
    }
    protected void Shout(object sender, AjaxControl.AjaxEventArg e)
    {
        string shouttext = HtmlHelper.ControlValue(txtShout.ClientID);
        if (shouttext != null && shouttext != "")
        {
            new DocumentController().Add(Guid.NewGuid(), "", shouttext, "", "", MyLoginUserID, 0, "", (int)ContentTypeEnum.Shout, InstituteCourceID, 0, DateTime.Now);
        }
        BindList();
    }
    private void BindList()
    {
        //TotalPage = Convert.ToInt32(Math.Ceiling((decimal)new UserController().GetUserRelatedContentSearch(MyLoginUserID, InstituteCourceID, 0, (int)ContentTypeEnum.Shout, MyLoginUserID, "", StartDate, EndDate).Count / PageSize));
        ListDocument.DataSource=new DocumentController().GetByInstituetCourceID((int)ContentTypeEnum.Shout, InstituteCourceID);
        //ListDocument.DataSource = new UserController().GetUserRelatedContentSearch(MyLoginUserID, InstituteCourceID, 0, (int)ContentTypeEnum.Shout, new UserAuthontication().LoggedInUserID, "", StartDate, EndDate, 10, 1);
        ListDocument.DataBind();

    }
    private void CreateControls()
    {
        lnkPost.ResponseContainner = "#" + GetWidgetBoxID(WidgetID);
        lnkPost.RequestContainner = "#" + GetWidgetBoxID(WidgetID);
        if (!IsEditable)
        {
            
            lnkClose.Visible = false;
           

        }
        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.Collapspanel("#" + lnkExpand.ClientID, "#" + shoutbox.ClientID);
    }
}