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
using BusinessLogic.Controller;
using BusinessLogic;

public partial class College_Ajaxer_PortalSetting : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsAjaxPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        Session.Remove(SessionName.PortalSetting.ToString());
        PortalSetting data = new PortalSettingHelper().Get();
        if (data != null)
        {
            txtCatagory.Text = data.SubjectHeader;
            txtSpace.Text = data.CourseHeader;
        }
    }
    protected void SaveAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        PortalSetting newposetting = new PortalSetting();
        newposetting= new PortalSettingHelper().Get();
        newposetting.CourseHeader = HtmlHelper.ControlValue(txtSpace.ClientID);
        newposetting.SubjectHeader = HtmlHelper.ControlValue(txtCatagory.ClientID);
        newposetting.IsSelfRegistrationAllow = false;
        new PortalSettingHelper().Add(newposetting);
        BindData();

    }
}
