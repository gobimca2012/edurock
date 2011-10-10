using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using BusinessLogic.Controllers;
using PayPal;

public partial class PaymentCompleted : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.CacheControl = "private";
        Response.Expires = 0;
        Response.AddHeader("pragma", "no-cache");
        string status = Request.QueryString["st"];
        string amount = Request.QueryString["amt"];
        string currency = Request.QueryString["cc"];
        string custom = Request.QueryString["cm"];
        string itemNumber=Request.QueryString["item_number"];
        string transactionNumber = Request.QueryString["tx"];
        if (!this.IsPostBack)
        {
            if (transactionNumber != null && transactionNumber != string.Empty)
            {
                PayPalStandardPaymentProcessor processor = new PayPalStandardPaymentProcessor();
                Dictionary<string, string> values;
                string response;
                if (processor.GetPDTDetails(transactionNumber, out values, out response))
                {
                    decimal total = decimal.Parse(values["mc_gross"], new CultureInfo("en-US"));
                    string orderNumber = values["custom"];
                    PayPalRequest order = null;// OrderManager.GetOrderByID(Convert.ToInt32(orderNumber));
                    if (order != null)
                    {
                        string AVS = string.Empty;
                        values.TryGetValue("payer_status", out AVS);
                        string CVV = string.Empty;
                        values.TryGetValue("payment_status", out CVV);
                        string mc_currency = string.Empty;
                        values.TryGetValue("mc_currency", out mc_currency);
                        string txn_id = string.Empty;
                        values.TryGetValue("txn_id", out txn_id);
                        string payment_type = string.Empty;
                        values.TryGetValue("payment_type", out payment_type);
                        string payer_id = string.Empty;
                        values.TryGetValue("payer_id", out payer_id);
                        string receiver_id = string.Empty;
                        values.TryGetValue("receiver_id", out receiver_id);
                        string invoice = string.Empty;
                        values.TryGetValue("invoice", out invoice);
                        string payment_fee = string.Empty;
                        values.TryGetValue("payment_fee", out payment_fee);

                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Paypal PDT:");
                        sb.AppendLine("total: " + total);
                        sb.AppendLine("CVV: " + AVS);
                        sb.AppendLine("mc_currency: " + mc_currency);
                        sb.AppendLine("txn_id: " + txn_id);
                        sb.AppendLine("payment_type: " + payment_type);
                        sb.AppendLine("payer_id: " + payer_id);
                        sb.AppendLine("receiver_id: " + receiver_id);
                        sb.AppendLine("invoice: " + invoice);
                        sb.AppendLine("payment_fee: " + payment_fee);

                        new OrderController().UpdateByOrderID(order.OrderID, true);
                        
                    }
                    Response.Redirect("~/CheckoutCompleted.aspx");
                }
                else
                {
                    string orderNumber = values["custom"];
                    //Order order = OrderManager.GetOrderByID(Convert.ToInt32(orderNumber));
                    //if (order != null)
                    //{
                    //    OrderManager.InsertOrderNote(order.OrderID, "PayPal PDT failed. " + response, DateTime.Now);
                    //}
                    Response.Redirect("~/Home.aspx");
                    //Exception exc = new Exception("PayPal PDT failed");
                    //exc.Data.Add("response", response);
                    //throw exc;
                }
            }
        }


    }
}