﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VT3.PayPal
{
    public class PayPalRequest
    {
        #region Property
        public Guid OrderID
        {
            get;
            set;
        }
        public decimal OrderTotal { get; set; }
        public string PrimaryStoreCurrency
        {
            get;
            set;
        }
        public string BillingEmail
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the billing first name
        /// </summary>
        public string BillingFirstName { get; set; }

        /// <summary>
        /// Gets or sets the billing last name
        /// </summary>
        public string BillingLastName { get; set; }
        /// <summary>
        /// Gets or sets the billing address 1
        /// </summary>
        public string BillingAddress1 { get; set; }

        /// <summary>
        /// Gets or sets the billing address 2
        /// </summary>
        public string BillingAddress2 { get; set; }

        /// <summary>
        /// Gets or sets the billing city
        /// </summary>
        public string BillingCity { get; set; }

        /// <summary>
        /// Gets or sets the billing state/province
        /// </summary>
        public string BillingStateProvince { get; set; }
        public string BillingCountry { get; set; }
        public int NoOfShipping { get; set; }

        public string Custom
        {
            get;
            set;
        }
        #endregion
    }
}