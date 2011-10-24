using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Controllers;
using DataEntity;

public partial class User_AjaxControl_UserOrderDetail : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listUserOrder.DataSource = GetOrders();
        listUserOrder.DataBind();
    }
    private List<OrderItem> GetOrders()
    {
        var data=new OrderController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID);        
        return data[0].OrderItems.ToList();
    }
}