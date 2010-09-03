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
using BusinessLogic.ShoppingCartController;
using Common;

public partial class ShoppingCart_AjaxControl_ItemInfo : AjaxPage
{



    private void AddData()
    {
        try
        {

            

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);


            Decimal Price; if (false) { throw new Exception(""); } Price =Convert.ToDecimal(HtmlHelper.ControlValue(txtPrice.ClientID));


            string ApplicationURL; if (false) { throw new Exception(""); } ApplicationURL = HtmlHelper.ControlValue(txtApplicationURL.ClientID);

            DateTime ModifiedDate=DateTime.Now;

            new ItemController().Add(Name,(int) ShoppingCartItemTypeEnum.Product, Price, ApplicationURL, ModifiedDate);
            Response.Redirect("~/ShoppingCart/AjaxControl/ItemInfoView.aspx");
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

            int ItemID = ID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            int ItemType = (int)ShoppingCartItemTypeEnum.Product;

            Decimal Price; if (false) { throw new Exception(""); } Price = Convert.ToDecimal(HtmlHelper.ControlValue(txtApplicationURL.ClientID));

            string ApplicationURL; if (false) { throw new Exception(""); } ApplicationURL = HtmlHelper.ControlValue(txtApplicationURL.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new ItemController().UpdateByItemID(ItemID, Name, ItemType, Price, ApplicationURL, ModifiedDate);

            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new ItemController().GetbyItemID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];



            txtName.Text = data.Name;


            txtPrice.Text = data.Price.ToString("0.00");


            txtApplicationURL.Text = data.ApplicationURL;



        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["itid"]);
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
        if (Request.Params["itid"] != null)
        {
            AjaxState["itid"] = Request.Params["itid"];
            BindData();
            lnkAddItem.Visible = false;
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
            lnkUpdateItem.Visible = false;
        }
    }

    public void PreventData()
    {

       

        txtName.Text = HtmlHelper.ControlValue(txtName.ClientID);



        txtPrice.Text = HtmlHelper.ControlValue(txtPrice.ClientID);

        txtApplicationURL.Text = HtmlHelper.ControlValue(txtApplicationURL.ClientID);

       

    }



}
