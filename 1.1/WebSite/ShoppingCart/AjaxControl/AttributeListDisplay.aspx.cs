using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Controllers;
using BusinessLogic;

public partial class ShoppingCart_AjaxControl_AttributeListDisplay : AjaxPage
{
    protected override void OnInit(EventArgs e)
    {
        IsLogginMandatory = false;
        base.OnInit(e);
    }
    public Guid ProductVersionID
    {
        get
        {
            if (Request.QueryString["prvid"] != null)
            {                
                AjaxState["prvid"]=Request.QueryString["prvid"];
                return new Guid(Request.QueryString["prvid"]);
            }
            else if (AjaxState["prvid"] != null)
            {
                return new Guid(AjaxState["prvid"]);
            }
            else
            {
                return Guid.Empty;
            }
        }
        
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindList();
    }
    private void BindList()
    {
        if (ProductVersionID != Guid.Empty)
        {
            var productVersion= new ProductVersionController().GetbyProductVersionID(ProductVersionID);
            ListVersionAttribute.DataSource = productVersion[0].VersionAttributes; //new VersionAttributeController().GetbyProductVersionID(ProductVersionID);
            ListVersionAttribute.DataBind();
            
            divTitle.InnerHtml = productVersion[0].Name;
            divDescription.InnerHtml = productVersion[0].Description;
            divPrice.InnerHtml = productVersion[0].Price.ToString() + "$";
            divSubTotal.InnerHtml = productVersion[0].Price.ToString() + "$";
            divTotalDue.InnerHtml = productVersion[0].Price.ToString() + "$";
            string recurringTimeText="";
            if(productVersion[0].RecurringPaymentTime==1)
            {
                recurringTimeText="Monthly";
            }
            else if(productVersion[0].RecurringPaymentTime==12)
            {
                recurringTimeText="Yearly";
            }
            divTotalRecurring.InnerHtml = productVersion[0].Price.ToString() + "$" + " " + recurringTimeText;
        }
    }
    protected void Order_Click(object sender, AjaxControl.AjaxEventArg e)
    {
        new ShoppingController().AddCartItem(new ProductVersionController().GetbyProductVersionID(ProductVersionID)[0]);
        Response.Redirect("~/ShoppingCart/AjaxControl/AccountInfo.aspx");

        
    }
}