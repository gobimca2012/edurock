using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PayPal;

namespace DTO
{
    public class Translator
    {
        public static OrderDTO GetByRegisterCustomerDTO(RegisterCustomerDTO registerCustomerdto)
        {
            OrderDTO orderDto = new OrderDTO();
            orderDto.BillingAddress1 = registerCustomerdto.Address1;
            orderDto.BillingAddress2 = registerCustomerdto.Address2;
            orderDto.BillingCity = registerCustomerdto.City;
            orderDto.BillingCountry = registerCustomerdto.Country;
            orderDto.BillingEmail = registerCustomerdto.Email;
            orderDto.BillingFirstName = registerCustomerdto.FirstName;
            orderDto.BillingLastName = registerCustomerdto.LastName;
            orderDto.BillingStateProvince = registerCustomerdto.State;
            orderDto.Fax = registerCustomerdto.FaxNumber;
            orderDto.MobileNumber = registerCustomerdto.MobileNumber;
            orderDto.LandlineNumber = registerCustomerdto.LandLineNumber;
            return orderDto;
        }

        public static PayPalRequest GetPayPalRequest(OrderDTO orderDto)
        {
            PayPalRequest paypaldto = new PayPalRequest();
            paypaldto.BillingAddress1 = orderDto.BillingAddress1;
            paypaldto.BillingAddress2 = orderDto.BillingAddress2;
            paypaldto.BillingCity = orderDto.BillingCity;
            paypaldto.BillingCountry = orderDto.BillingCountry;
            paypaldto.BillingEmail = orderDto.BillingEmail;
            paypaldto.BillingFirstName = orderDto.BillingFirstName;
            paypaldto.BillingLastName = orderDto.BillingLastName;
            paypaldto.BillingStateProvince = orderDto.BillingStateProvince;
            paypaldto.Custom = orderDto.Custom;
            paypaldto.NoOfShipping = 1;
            paypaldto.OrderID=orderDto.OrderID;
            paypaldto.OrderTotal=1;
            paypaldto.PrimaryStoreCurrency="$";
            return paypaldto;
            
        }
    }
}
