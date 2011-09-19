using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CartDTO<T>
    {
        public List<T> ProductVersion
        {
            get;
            set;
        }

        public bool IsLoggedIn
        {
            get;
            set;
        }

        public OrderDTO orderDetail
        {
            get;
            set;
        }
    }
}
