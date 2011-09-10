using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Controllers;

public partial class ShoppingCart_AjaxControl_VersionAttributeInfo : AjaxPage
{


    private void AddData()
    {
        try
        {

            Guid VersionAttributeID; if (false) { throw new Exception(""); } VersionAttributeID = Guid.NewGuid();

            Guid ProductVersionID; if (false) { throw new Exception(""); } ProductVersionID = _ProductVersionID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Value; if (false) { throw new Exception(""); } Value = HtmlHelper.ControlValue(txtValue.ClientID);

            DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;

            new VersionAttributeController().Add(VersionAttributeID, ProductVersionID, Name, Value, ModifiedDate);
            Response.Redirect("~/ShoppingCart/AjaxControl/VersionAttributeInfoView.aspx?prvid=" + _ProductVersionID.ToString());
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

            Guid VersionAttributeID; if (false) { throw new Exception(""); } VersionAttributeID = ID;

            Guid ProductVersionID; if (false) { throw new Exception(""); } ProductVersionID = _ProductVersionID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Value; if (false) { throw new Exception(""); } Value = HtmlHelper.ControlValue(txtValue.ClientID);

            DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;

            new VersionAttributeController().UpdateByVersionAttributeID(VersionAttributeID, ProductVersionID, Name, Value, ModifiedDate);

            Response.Redirect("~/ShoppingCart/AjaxControl/VersionAttributeInfoView.aspx?prvid="+_ProductVersionID.ToString());
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new VersionAttributeController().GetbyVersionAttributeID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            
            txtName.Text = data.Name;

            txtValue.Text = data.Value;

            

        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["vaid"]);
        }
    }

    private Guid _ProductVersionID
    {
        get
        {
            return new Guid(AjaxState["prvid"]);
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
        if (Request.Params["vaid"] != null)
        {
            AjaxState["vaid"] = Request.Params["vaid"];
            BindData();
            lnkAddVersionAttribute.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateVersionAttribute.Visible = false;
        }
    }

    public void PreventData()
    {

       
        txtName.Text = HtmlHelper.ControlValue(txtName.ClientID);

        txtValue.Text = HtmlHelper.ControlValue(txtValue.ClientID);

       
    }
		
}