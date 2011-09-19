using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class RegisterCustomerDTO
    {
        public Guid MemberShipUserID
        {
            get;
            set;
        }
        public int UserType
        {
            get;
            set;
        }
        public int TotalUser
        {
            get;
            set;
        }

        public int ValidMonth
        {
            get;
            set;
        }
        public string InstituteName
        {
            get;
            set;
        }
        public string Username
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }
        public string MiddleName
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }

        public string Address1
        {
            get;
            set;
        }
        public string Address2
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

        public string State
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }

        public string MobileNumber
        {
            get;
            set;
        }

        public string LandLineNumber
        {
            get;
            set;
        }

        public string FaxNumber
        {
            get;
            set;
        }
    }
}
