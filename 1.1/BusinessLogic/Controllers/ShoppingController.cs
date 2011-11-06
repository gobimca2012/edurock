using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Web;
using DataEntity;

namespace BusinessLogic.Controllers
{
    public class ShoppingController
    {

        public CartDTO<ProductVersion> CartDto
        {
            get
            {
                if (HttpContext.Current.Session["UserCart"] != null)
                    return (CartDTO<ProductVersion>)HttpContext.Current.Session["UserCart"];
                else
                    return new CartDTO<ProductVersion>();
            }
            set
            {
                HttpContext.Current.Session["UserCart"] = value;
            }
        }
        public ShoppingController()
        {

        }

        public void UpdateOrderDetail(OrderDTO orderDetail)
        {
            CartDTO<ProductVersion> tempcart = getTempDto();
            if (tempcart.orderDetail == null)
            {
                tempcart.orderDetail = new OrderDTO();
            }
            tempcart.orderDetail = orderDetail;
            CartDto = tempcart;
        }


        public void AddCartItem(ProductVersion item)
        {
            CartDTO<ProductVersion> tempcart = getTempDto();
            if (tempcart.ProductVersion == null)
            {
                tempcart.ProductVersion = new List<ProductVersion>();
            }
            tempcart.ProductVersion.Add(item);
            CartDto = tempcart;
        }

        private CartDTO<ProductVersion> getTempDto()
        {
            CartDTO<ProductVersion> tempcart = new CartDTO<ProductVersion>();
            tempcart = CartDto;
            return tempcart;
        }
        public void RemoveCartItem(Guid ProductVersionID)
        {
            CartDTO<ProductVersion> tempcart = getTempDto();
            tempcart.ProductVersion.RemoveAll(p => p.ProductVersionID == ProductVersionID);
            CartDto = tempcart;
        }
        public Guid SaveCart(int loginUserID)
        {
            CustomerOrder order = new CustomerOrder();
            var data = new OrderController().GetbyProductIDAndLoginUserID(loginUserID, CartDto.ProductVersion[0].ProductID);
            if (data.Count > 0)
            {
                order = data[0];
                OrderItem orderItem = new OrderItem();
                orderItem.ItemDescription = CartDto.ProductVersion[0].Description;
                orderItem.ItemName = CartDto.ProductVersion[0].Name;
                orderItem.ModifiedDate = DateTime.Now;
                orderItem.OrderItemID = Guid.NewGuid();
                orderItem.Price = CartDto.ProductVersion[0].Price.Value;
                orderItem.ProductID = CartDto.ProductVersion[0].ProductID;
                orderItem.ProductVersionID = CartDto.ProductVersion[0].ProductVersionID;
                orderItem.Quantity = 1;
                orderItem.OrderID = order.OrderID;
                
                if (new OrderItemController().Add(orderItem))
                {
                    return order.OrderID;
                }
                else
                {
                    return Guid.Empty;
                }
            }
            else
            {
                order.Address1 = CartDto.orderDetail.BillingAddress1;
                order.Address2 = CartDto.orderDetail.BillingAddress2;
                order.City = CartDto.orderDetail.BillingCity;
                order.Country = CartDto.orderDetail.BillingCountry;
                order.Email = CartDto.orderDetail.BillingEmail;
                order.ExpireDate = DateTime.Now.AddMonths(CartDto.ProductVersion[0].RecurringPaymentTime.Value);
                order.Fax = CartDto.orderDetail.Fax;
                order.FirstName = CartDto.orderDetail.BillingFirstName;
                order.IsPaid = false;
                order.LastName = CartDto.orderDetail.BillingLastName;
                order.LoginUserID = loginUserID;
                order.ModifiedDate = DateTime.Now;
                order.OrderID = Guid.NewGuid();
                OrderItem orderItem = new OrderItem();
                orderItem.ItemDescription = CartDto.ProductVersion[0].Description;
                orderItem.ItemName = CartDto.ProductVersion[0].Name;
                orderItem.ModifiedDate = DateTime.Now;
                orderItem.OrderItemID = Guid.NewGuid();
                orderItem.Price = CartDto.ProductVersion[0].Price.Value;
                orderItem.ProductID = CartDto.ProductVersion[0].ProductID;
                orderItem.ProductVersionID = CartDto.ProductVersion[0].ProductVersionID;
                orderItem.Quantity = 1;
                order.OrderItems.Add(orderItem);
                order.PhoneNumber = CartDto.orderDetail.MobileNumber;
                order.State = CartDto.orderDetail.BillingStateProvince;
                order.ZipCode = "12345";/// CartDto.orderDetail.ZipCode;
                if (new OrderController().Add(order))
                {
                    return order.OrderID;
                }
                else
                {
                    return Guid.Empty;
                }
            }

            
        }

    }
}
