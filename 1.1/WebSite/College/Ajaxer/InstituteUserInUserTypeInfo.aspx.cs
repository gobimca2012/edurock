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

public partial class College_Ajaxer_InstituteUserInUserTypeInfo : AjaxPage
{
    public HtmlHelper _HtmlHelper = new HtmlHelper();
    private void FormValidation()
    {

        lnkP.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkP.ClientID);
        objValidate.DrowDownMendatory(ddRoles, "Please select role", this.Page, "0");

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        FormValidation();
        if (Request.Params["uid"] != null)
        {
            AjaxState["uid"] = Request.Params["uid"];
        }
        new InstituteUserTypeController().BindInstituteUserType(ddRoles);
        // if (!this.IsAjaxPostBack)
        {
            BindData();
        }
    }
    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["uid"]);
        }
    }
    private void BindData()
    {
        var data = new InstituteUserInUserTypeController().GetbyLoginUserID(ID);
        ListUserRoles.DataSource = data;
        ListUserRoles.DataBind();
    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        new InstituteUserInUserTypeController().Add(ID, new UserAuthontication().InstituteIDByLoginUserID(ID), Convert.ToInt32(HtmlHelper.ControlValue(ddRoles.ClientID)), DateTime.Now);
        Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been Updated Successfully", "User Role ");
        BindData();
    }
    //protected void ListInstituteSubjectOnItemDataBound(object sender, ListViewItemEventArgs e)
    //{
    //    ListViewDataItem currentItem = (ListViewDataItem)e.Item;
    //    string InstituteUserInUserTypeID = ListUserRoles.DataKeys[currentItem.DataItemIndex]["InstituteUserInUserTypeID"].ToString();


    //}
    protected override void OnAjaxListViewCommand(AjaxListViewCommandArg e)
    {
        if (e.Command == "delete")
        {

            new InstituteUserInUserTypeController().DeletebyInstituteUserInUserTypeID(Convert.ToInt32(e.Id));
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} has been deleted Successfully", "User Role ");
            BindData();
        }
        base.OnAjaxListViewCommand(e);
    }
}
