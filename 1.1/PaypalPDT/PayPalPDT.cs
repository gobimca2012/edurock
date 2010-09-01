using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Web;
using System.Net;
using System.IO;

namespace PaypalPDT
{
    public class PayPalStandardPaymentProcessor
    {
        #region Property
        private bool useSandBox = true;
        private string BusinessEmail;
        private string PDTId;
        #endregion
        public PayPalStandardPaymentProcessor()
        {
            useSandBox = true;// SettingManager.GetSettingValueBoolean("PaymentMethod.PaypalStandard.UseSandbox");
            BusinessEmail = "";// SettingManager.GetSettingValue("PaymentMethod.PaypalStandard.BusinessEmail");
            PDTId = "";// SettingManager.GetSettingValue("PaymentMethod.PaypalStandard.PTIIdentityToken");

            if (string.IsNullOrEmpty(BusinessEmail))
                throw new Exception("Paypal Standard business Email is empty");

            if (string.IsNullOrEmpty(PDTId))
                throw new Exception("Paypal Standard PTD Id is empty");
        }
        private string GetPaypalUrl()
        {
            return "https://www.sandbox.paypal.com/us/cgi-bin/webscr";
            //"https://www.paypal.com/us/cgi-bin/webscr";
        }
        public string PostProcessPayment(Order order)
        {
            StringBuilder builder = new StringBuilder();
            string returnURL = "BaseUrl" + "PaypalPDTHandler.aspx";
            string cancel_returnURL = "BaseUrl" + "PaypalCancel.aspx";
            builder.Append(GetPaypalUrl());
            builder.AppendFormat("?cmd=_xclick&business={0}", BusinessEmail);
            builder.AppendFormat("&item_name=Order Number {0}", order.OrderID.ToString());
            builder.AppendFormat("&custom={0}", order.OrderID.ToString());
            builder.AppendFormat("&amount={0}", order.OrderTotal.ToString("N", new CultureInfo("en-us")));
            builder.Append(string.Format("&no_note=1&currency_code={0}", order.PrimaryStoreCurrency));
            builder.AppendFormat("&invoice={0}", order.OrderID.ToString());
            builder.AppendFormat("&rm=2", new object[0]);
            builder.AppendFormat("&no_shipping=1", new object[0]);
            builder.AppendFormat("&return={0}&cancel_return={1}", returnURL, cancel_returnURL);
            builder.AppendFormat("&first_name={0}", order.BillingFirstName);
            builder.AppendFormat("&last_name={0}", order.BillingLastName);
            builder.AppendFormat("&address1={0}", order.BillingAddress1);
            builder.AppendFormat("&address2={0}", order.BillingAddress2);
            builder.AppendFormat("&city={0}", order.BillingCity);
            builder.AppendFormat("&state={0}", order.BillingStateProvince);
            builder.AppendFormat("&country={0}", order.BillingCountry);
            builder.AppendFormat("&Email={0}", order.BillingEmail);
            HttpContext.Current.Response.Redirect(builder.ToString());
            return string.Empty;
        }

        public bool GetPDTDetails(string tx, out Dictionary<string, string> values, out string response)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(GetPaypalUrl());
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            string formContent = string.Format("cmd=_notify-synch&at={0}&tx={1}", PDTId, tx);
            req.ContentLength = formContent.Length;

            using (StreamWriter sw = new StreamWriter(req.GetRequestStream(), Encoding.ASCII))
                sw.Write(formContent);

            response = null;
            using (StreamReader sr = new StreamReader(req.GetResponse().GetResponseStream()))
                response = HttpUtility.UrlDecode(sr.ReadToEnd());

            values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            bool firstLine = true, success = false;
            foreach (string l in response.Split('\n'))
            {
                string line = l.Trim();
                if (firstLine)
                {
                    success = line.Equals("SUCCESS", StringComparison.OrdinalIgnoreCase);
                    firstLine = false;
                }
                else
                {
                    int equalPox = line.IndexOf('=');
                    if (equalPox >= 0)
                        values.Add(line.Substring(0, equalPox), line.Substring(equalPox + 1));
                }
            }

            return success;
        }
    }
}
