using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Controllers;

public partial class ShoppingCart_AjaxControl_CompleteOrder : AjaxPage
{
    private Guid OrderID
    {
        get
        {
            return Guid.Empty;
        }
    }
    protected override void OnInit(EventArgs e)
    {
        IsLogginMandatory = false;
        base.OnInit(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        new OrderController().UpdateByOrderID(OrderID, true);
    }
}