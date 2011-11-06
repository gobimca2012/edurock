using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;
using System.Data.Linq;
using System.Diagnostics;

namespace DataAccess.PaymentDB
{
    public class DataProvider
    {
        Logger.TimeLog objLogger;



        #region Order

        public void OrderAdd(Guid OrderID, int LoginUserID, string FirstName, string LastName, string PhoneNumber, string Email, string Fax, string Address1, string Address2, string City, string State, string Country, string ZipCode, bool IsPaid, DateTime ExpireDate, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                CustomerOrder ObjOrder = new CustomerOrder();

                ObjOrder.OrderID = OrderID;

                ObjOrder.LoginUserID = LoginUserID;

                ObjOrder.FirstName = FirstName;

                ObjOrder.LastName = LastName;

                ObjOrder.PhoneNumber = PhoneNumber;

                ObjOrder.Email = Email;

                ObjOrder.Fax = Fax;

                ObjOrder.Address1 = Address1;

                ObjOrder.Address2 = Address2;

                ObjOrder.City = City;

                ObjOrder.State = State;

                ObjOrder.Country = Country;

                ObjOrder.ZipCode = ZipCode;

                ObjOrder.IsPaid = IsPaid;

                ObjOrder.ExpireDate = ExpireDate;

                ObjOrder.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.CustomerOrders.InsertOnSubmit(ObjOrder);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderAdd(CustomerOrder order)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                CustomerOrder ObjOrder = new CustomerOrder();

                ObjOrder = order;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.CustomerOrders.InsertOnSubmit(ObjOrder);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public Guid OrderAdd(int LoginUserID, string FirstName, string LastName, string PhoneNumber, string Email, string Fax, string Address1, string Address2, string City, string State, string Country, string ZipCode, bool IsPaid, DateTime ExpireDate, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                CustomerOrder ObjOrder = new CustomerOrder();



                ObjOrder.LoginUserID = LoginUserID;


                ObjOrder.FirstName = FirstName;


                ObjOrder.LastName = LastName;


                ObjOrder.PhoneNumber = PhoneNumber;


                ObjOrder.Email = Email;


                ObjOrder.Fax = Fax;


                ObjOrder.Address1 = Address1;


                ObjOrder.Address2 = Address2;


                ObjOrder.City = City;


                ObjOrder.State = State;


                ObjOrder.Country = Country;


                ObjOrder.ZipCode = ZipCode;


                ObjOrder.IsPaid = IsPaid;


                ObjOrder.ExpireDate = ExpireDate;


                ObjOrder.ModifiedDate = ModifiedDate;



                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.CustomerOrders.InsertOnSubmit(ObjOrder);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return ObjOrder.OrderID;
            }
        }



        public List<CustomerOrder> OrderGet(int PageSize, int PageNumber)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.CustomerOrders select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.CustomerOrders select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<CustomerOrder> OrderGetbyOrderID(Guid OrderID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.OrderID == OrderID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyFirstName(string FirstName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.FirstName == FirstName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyLastName(string LastName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.LastName == LastName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyPhoneNumber(string PhoneNumber, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.PhoneNumber == PhoneNumber select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyEmail(string Email, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Email == Email select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyFax(string Fax, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Fax == Fax select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyAddress1(string Address1, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Address1 == Address1 select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyAddress2(string Address2, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Address2 == Address2 select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyCity(string City, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.City == City select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyState(string State, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.State == State select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyCountry(string Country, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Country == Country select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyZipCode(string ZipCode, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.ZipCode == ZipCode select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyIsPaid(bool IsPaid, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.IsPaid == IsPaid select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyExpireDate(DateTime ExpireDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.ExpireDate == ExpireDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerOrder> OrderGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<CustomerOrder> OrderGetbyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.OrderID == OrderID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                DataLoadOptions option = new DataLoadOptions();
                option.LoadWith<CustomerOrder>(p => p.OrderItems);
                db.LoadOptions = option;
                var data = (from p in db.CustomerOrders where p.LoginUserID == LoginUserID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyFirstName(string FirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.FirstName == FirstName select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyLastName(string LastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.LastName == LastName select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyPhoneNumber(string PhoneNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.PhoneNumber == PhoneNumber select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyEmail(string Email)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Email == Email select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Fax == Fax select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyAddress1(string Address1)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Address1 == Address1 select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyAddress2(string Address2)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Address2 == Address2 select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyCity(string City)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.City == City select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyState(string State)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.State == State select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyCountry(string Country)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Country == Country select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyZipCode(string ZipCode)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.ZipCode == ZipCode select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyIsPaid(bool IsPaid)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.IsPaid == IsPaid select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyExpireDate(DateTime ExpireDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.ExpireDate == ExpireDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerOrder> OrderGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void OrderDeletebyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.OrderID == OrderID select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.LoginUserID == LoginUserID select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyFirstName(string FirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.FirstName == FirstName select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyLastName(string LastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.LastName == LastName select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyPhoneNumber(string PhoneNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.PhoneNumber == PhoneNumber select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyEmail(string Email)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Email == Email select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Fax == Fax select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyAddress1(string Address1)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Address1 == Address1 select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyAddress2(string Address2)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Address2 == Address2 select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyCity(string City)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.City == City select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyState(string State)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.State == State select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyCountry(string Country)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.Country == Country select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyZipCode(string ZipCode)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.ZipCode == ZipCode select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyIsPaid(bool IsPaid)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.IsPaid == IsPaid select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyExpireDate(DateTime ExpireDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.ExpireDate == ExpireDate select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerOrders where p.ModifiedDate == ModifiedDate select p);
                db.CustomerOrders.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }



        public void OrderUpdateByOrderID(Guid OrderID, int LoginUserID, string FirstName, string LastName, string PhoneNumber, string Email, string Fax, string Address1, string Address2, string City, string State, string Country, string ZipCode, bool IsPaid, DateTime ExpireDate, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                CustomerOrder data = db.CustomerOrders.Single(p => p.OrderID == OrderID);
                data.LoginUserID = LoginUserID;
                data.FirstName = FirstName;
                data.LastName = LastName;
                data.PhoneNumber = PhoneNumber;
                data.Email = Email;
                data.Fax = Fax;
                data.Address1 = Address1;
                data.Address2 = Address2;
                data.City = City;
                data.State = State;
                data.Country = Country;
                data.ZipCode = ZipCode;
                data.IsPaid = IsPaid;
                data.ExpireDate = ExpireDate;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }







        #endregion
        #region CustomOrder
        public void OrderUpdateByOrderID(Guid OrderID, bool IsPaid)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                CustomerOrder data = db.CustomerOrders.Single(p => p.OrderID == OrderID);
                data.IsPaid = IsPaid;
                data.ModifiedDate = DateTime.Now;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        public List<CustomerOrder> OrderGetbyProductIDAndLoginUserID(int LoginUserID,Guid? ProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.CustomerOrders where p.LoginUserID==LoginUserID && (from q in p.OrderItems where q.ProductID.Value==ProductID.Value select q).ToList().Count>0 select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }
        #endregion





        #region Payment

        public void PaymentAdd(Guid PaymentID, Guid OrderID, int PaymentStatus, decimal Amount, string PaymentCurrency, int PaymentType, DateTime PaymentDate, string PaymentException, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                Payment ObjPayment = new Payment();

                ObjPayment.PaymentID = PaymentID;

                ObjPayment.OrderID = OrderID;

                ObjPayment.PaymentStatus = PaymentStatus;

                ObjPayment.Amount = Amount;

                ObjPayment.PaymentCurrency = PaymentCurrency;

                ObjPayment.PaymentType = PaymentType;

                ObjPayment.PaymentDate = PaymentDate;

                ObjPayment.PaymentException = PaymentException;

                ObjPayment.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.Payments.InsertOnSubmit(ObjPayment);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void PaymentAdd(Payment payment)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                Payment ObjPayment = new Payment();

                ObjPayment = payment;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.Payments.InsertOnSubmit(ObjPayment);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public Guid PaymentAdd(Guid OrderID, int PaymentStatus, decimal Amount, string PaymentCurrency, int PaymentType, DateTime PaymentDate, string PaymentException, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                Payment ObjPayment = new Payment();



                ObjPayment.OrderID = OrderID;


                ObjPayment.PaymentStatus = PaymentStatus;


                ObjPayment.Amount = Amount;


                ObjPayment.PaymentCurrency = PaymentCurrency;


                ObjPayment.PaymentType = PaymentType;


                ObjPayment.PaymentDate = PaymentDate;


                ObjPayment.PaymentException = PaymentException;


                ObjPayment.ModifiedDate = ModifiedDate;



                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.Payments.InsertOnSubmit(ObjPayment);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return ObjPayment.PaymentID;
            }
        }



        public List<Payment> PaymentGet(int PageSize, int PageNumber)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.Payments select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Payment> PaymentGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.Payments select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<Payment> PaymentGetbyPaymentID(Guid PaymentID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentID == PaymentID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Payment> PaymentGetbyOrderID(Guid OrderID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.OrderID == OrderID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Payment> PaymentGetbyPaymentStatus(int PaymentStatus, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentStatus == PaymentStatus select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Payment> PaymentGetbyAmount(decimal Amount, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.Amount == Amount select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Payment> PaymentGetbyPaymentCurrency(string PaymentCurrency, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentCurrency == PaymentCurrency select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Payment> PaymentGetbyPaymentType(int PaymentType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentType == PaymentType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Payment> PaymentGetbyPaymentDate(DateTime PaymentDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentDate == PaymentDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Payment> PaymentGetbyPaymentException(string PaymentException, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentException == PaymentException select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Payment> PaymentGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<Payment> PaymentGetbyPaymentID(Guid PaymentID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentID == PaymentID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Payment> PaymentGetbyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.OrderID == OrderID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Payment> PaymentGetbyPaymentStatus(int PaymentStatus)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentStatus == PaymentStatus select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Payment> PaymentGetbyAmount(decimal Amount)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.Amount == Amount select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Payment> PaymentGetbyPaymentCurrency(string PaymentCurrency)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentCurrency == PaymentCurrency select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Payment> PaymentGetbyPaymentType(int PaymentType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentType == PaymentType select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Payment> PaymentGetbyPaymentDate(DateTime PaymentDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentDate == PaymentDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Payment> PaymentGetbyPaymentException(string PaymentException)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentException == PaymentException select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Payment> PaymentGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void PaymentDeletebyPaymentID(Guid PaymentID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentID == PaymentID select p);
                db.Payments.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void PaymentDeletebyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.OrderID == OrderID select p);
                db.Payments.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void PaymentDeletebyPaymentStatus(int PaymentStatus)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentStatus == PaymentStatus select p);
                db.Payments.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void PaymentDeletebyAmount(decimal Amount)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.Amount == Amount select p);
                db.Payments.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void PaymentDeletebyPaymentCurrency(string PaymentCurrency)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentCurrency == PaymentCurrency select p);
                db.Payments.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void PaymentDeletebyPaymentType(int PaymentType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentType == PaymentType select p);
                db.Payments.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void PaymentDeletebyPaymentDate(DateTime PaymentDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentDate == PaymentDate select p);
                db.Payments.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void PaymentDeletebyPaymentException(string PaymentException)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.PaymentException == PaymentException select p);
                db.Payments.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void PaymentDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Payments where p.ModifiedDate == ModifiedDate select p);
                db.Payments.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }



        public void PaymentUpdateByPaymentID(Guid PaymentID, Guid OrderID, int PaymentStatus, decimal Amount, string PaymentCurrency, int PaymentType, DateTime PaymentDate, string PaymentException, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                Payment data = db.Payments.Single(p => p.PaymentID == PaymentID);
                data.OrderID = OrderID;
                data.PaymentStatus = PaymentStatus;
                data.Amount = Amount;
                data.PaymentCurrency = PaymentCurrency;
                data.PaymentType = PaymentType;
                data.PaymentDate = PaymentDate;
                data.PaymentException = PaymentException;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }







        #endregion
        #region CustomPayment
        #endregion
	
	



        #region OrderItem

        public void OrderItemAdd(Guid OrderItemID, Guid OrderID, Guid ProductVersionID, string ItemName, string ItemDescription, int Quantity, decimal Price, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                OrderItem ObjOrderItem = new OrderItem();

                ObjOrderItem.OrderItemID = OrderItemID;

                ObjOrderItem.OrderID = OrderID;

                ObjOrderItem.ProductVersionID = ProductVersionID;

                ObjOrderItem.ItemName = ItemName;

                ObjOrderItem.ItemDescription = ItemDescription;

                ObjOrderItem.Quantity = Quantity;

                ObjOrderItem.Price = Price;

                ObjOrderItem.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.OrderItems.InsertOnSubmit(ObjOrderItem);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderItemAdd(OrderItem orderitem)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                OrderItem ObjOrderItem = new OrderItem();

                ObjOrderItem = orderitem;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.OrderItems.InsertOnSubmit(ObjOrderItem);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public Guid OrderItemAdd(Guid OrderID, Guid ProductVersionID, string ItemName, string ItemDescription, int Quantity, decimal Price, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                OrderItem ObjOrderItem = new OrderItem();



                ObjOrderItem.OrderID = OrderID;


                ObjOrderItem.ProductVersionID = ProductVersionID;


                ObjOrderItem.ItemName = ItemName;


                ObjOrderItem.ItemDescription = ItemDescription;


                ObjOrderItem.Quantity = Quantity;


                ObjOrderItem.Price = Price;


                ObjOrderItem.ModifiedDate = ModifiedDate;



                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.OrderItems.InsertOnSubmit(ObjOrderItem);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return ObjOrderItem.OrderItemID;
            }
        }



        public List<OrderItem> OrderItemGet(int PageSize, int PageNumber)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.OrderItems select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<OrderItem> OrderItemGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.OrderItems select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<OrderItem> OrderItemGetbyOrderItemID(Guid OrderItemID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.OrderItemID == OrderItemID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<OrderItem> OrderItemGetbyOrderID(Guid OrderID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.OrderID == OrderID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<OrderItem> OrderItemGetbyProductVersionID(Guid ProductVersionID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ProductVersionID == ProductVersionID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<OrderItem> OrderItemGetbyItemName(string ItemName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ItemName == ItemName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<OrderItem> OrderItemGetbyItemDescription(string ItemDescription, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ItemDescription == ItemDescription select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<OrderItem> OrderItemGetbyQuantity(int Quantity, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.Quantity == Quantity select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<OrderItem> OrderItemGetbyPrice(decimal Price, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.Price == Price select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<OrderItem> OrderItemGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<OrderItem> OrderItemGetbyOrderItemID(Guid OrderItemID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.OrderItemID == OrderItemID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<OrderItem> OrderItemGetbyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.OrderID == OrderID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<OrderItem> OrderItemGetbyProductVersionID(Guid ProductVersionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ProductVersionID == ProductVersionID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<OrderItem> OrderItemGetbyItemName(string ItemName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ItemName == ItemName select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<OrderItem> OrderItemGetbyItemDescription(string ItemDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ItemDescription == ItemDescription select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<OrderItem> OrderItemGetbyQuantity(int Quantity)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.Quantity == Quantity select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<OrderItem> OrderItemGetbyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.Price == Price select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<OrderItem> OrderItemGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void OrderItemDeletebyOrderItemID(Guid OrderItemID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.OrderItemID == OrderItemID select p);
                db.OrderItems.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderItemDeletebyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.OrderID == OrderID select p);
                db.OrderItems.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderItemDeletebyProductVersionID(Guid ProductVersionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ProductVersionID == ProductVersionID select p);
                db.OrderItems.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderItemDeletebyItemName(string ItemName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ItemName == ItemName select p);
                db.OrderItems.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderItemDeletebyItemDescription(string ItemDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ItemDescription == ItemDescription select p);
                db.OrderItems.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderItemDeletebyQuantity(int Quantity)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.Quantity == Quantity select p);
                db.OrderItems.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderItemDeletebyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.Price == Price select p);
                db.OrderItems.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void OrderItemDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.OrderItems where p.ModifiedDate == ModifiedDate select p);
                db.OrderItems.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }



        public void OrderItemUpdateByOrderItemID(Guid OrderItemID, Guid OrderID, Guid ProductVersionID, string ItemName, string ItemDescription, int Quantity, decimal Price, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                OrderItem data = db.OrderItems.Single(p => p.OrderItemID == OrderItemID);
                data.OrderID = OrderID;
                data.ProductVersionID = ProductVersionID;
                data.ItemName = ItemName;
                data.ItemDescription = ItemDescription;
                data.Quantity = Quantity;
                data.Price = Price;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }







        #endregion
        #region CustomOrderItem
        #endregion
	
	

        #region Product

        public void ProductAdd(Guid ProductID, string Name, string Description, string ShortDescription, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                Product ObjProduct = new Product();

                ObjProduct.ProductID = ProductID;

                ObjProduct.Name = Name;

                ObjProduct.Description = Description;

                ObjProduct.ShortDescription = ShortDescription;

                ObjProduct.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.Products.InsertOnSubmit(ObjProduct);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public Guid ProductAdd(string Name, string Description, string ShortDescription, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                Product ObjProduct = new Product();



                ObjProduct.Name = Name;


                ObjProduct.Description = Description;


                ObjProduct.ShortDescription = ShortDescription;


                ObjProduct.ModifiedDate = ModifiedDate;



                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.Products.InsertOnSubmit(ObjProduct);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return ObjProduct.ProductID;
            }
        }



        public List<Product> ProductGet(int PageSize, int PageNumber)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.Products select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.Products select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<Product> ProductGetbyProductID(Guid ProductID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ProductID == ProductID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyName(string Name, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyShortDescription(string ShortDescription, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ShortDescription == ShortDescription select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<Product> ProductGetbyProductID(Guid ProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ProductID == ProductID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Name == Name select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Description == Description select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyShortDescription(string ShortDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ShortDescription == ShortDescription select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void ProductDeletebyProductID(Guid ProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ProductID == ProductID select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Name == Name select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Description == Description select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyShortDescription(string ShortDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ShortDescription == ShortDescription select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ModifiedDate == ModifiedDate select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }



        public void ProductUpdateByProductID(Guid ProductID, string Name, string Description, string ShortDescription, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                Product data = db.Products.Single(p => p.ProductID == ProductID);
                data.Name = Name;
                data.Description = Description;
                data.ShortDescription = ShortDescription;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }







        #endregion
        #region CustomProduct
        #endregion



        #region ProductVersion

        public void ProductVersionAdd(Guid ProductVersionID, Guid ProductID, string Name, string Description, string ShortDescription, bool IsRecuringPrice, int RecurringPaymentTime, string QuantityIn, decimal Price, decimal Discount, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                ProductVersion ObjProductVersion = new ProductVersion();

                ObjProductVersion.ProductVersionID = ProductVersionID;

                ObjProductVersion.ProductID = ProductID;

                ObjProductVersion.Name = Name;

                ObjProductVersion.Description = Description;

                ObjProductVersion.ShortDescription = ShortDescription;

                ObjProductVersion.IsRecuringPrice = IsRecuringPrice;

                ObjProductVersion.RecurringPaymentTime = RecurringPaymentTime;

                ObjProductVersion.QuantityIn = QuantityIn;

                ObjProductVersion.Price = Price;

                ObjProductVersion.Discount = Discount;

                ObjProductVersion.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ProductVersions.InsertOnSubmit(ObjProductVersion);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionAdd(ProductVersion productversion)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                ProductVersion ObjProductVersion = new ProductVersion();

                ObjProductVersion = productversion;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ProductVersions.InsertOnSubmit(ObjProductVersion);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public Guid ProductVersionAdd(Guid ProductID, string Name, string Description, string ShortDescription, bool IsRecuringPrice, int RecurringPaymentTime, string QuantityIn, decimal Price, decimal Discount, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                ProductVersion ObjProductVersion = new ProductVersion();



                ObjProductVersion.ProductID = ProductID;


                ObjProductVersion.Name = Name;


                ObjProductVersion.Description = Description;


                ObjProductVersion.ShortDescription = ShortDescription;


                ObjProductVersion.IsRecuringPrice = IsRecuringPrice;


                ObjProductVersion.RecurringPaymentTime = RecurringPaymentTime;


                ObjProductVersion.QuantityIn = QuantityIn;


                ObjProductVersion.Price = Price;


                ObjProductVersion.Discount = Discount;


                ObjProductVersion.ModifiedDate = ModifiedDate;



                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ProductVersions.InsertOnSubmit(ObjProductVersion);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return ObjProductVersion.ProductVersionID;
            }
        }



        public List<ProductVersion> ProductVersionGet(int PageSize, int PageNumber)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.ProductVersions select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.ProductVersions select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<ProductVersion> ProductVersionGetbyProductVersionID(Guid ProductVersionID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ProductVersionID == ProductVersionID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyProductID(Guid ProductID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ProductID == ProductID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyName(string Name, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyShortDescription(string ShortDescription, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ShortDescription == ShortDescription select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyIsRecuringPrice(bool IsRecuringPrice, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.IsRecuringPrice == IsRecuringPrice select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyRecurringPaymentTime(int RecurringPaymentTime, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.RecurringPaymentTime == RecurringPaymentTime select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyQuantityIn(string QuantityIn, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.QuantityIn == QuantityIn select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyPrice(decimal Price, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Price == Price select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyDiscount(decimal Discount, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Discount == Discount select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<ProductVersion> ProductVersionGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<ProductVersion> ProductVersionGetbyProductVersionID(Guid ProductVersionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = true;
                db.DeferredLoadingEnabled = true;

                DataLoadOptions option = new DataLoadOptions();
                option.LoadWith<ProductVersion>(p => p.Product);
                option.LoadWith<ProductVersion>(p => p.VersionAttributes);
                db.LoadOptions = option;
                var data = (from p in db.ProductVersions where p.ProductVersionID == ProductVersionID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyProductID(Guid ProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ProductID == ProductID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Name == Name select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Description == Description select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyShortDescription(string ShortDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ShortDescription == ShortDescription select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyIsRecuringPrice(bool IsRecuringPrice)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.IsRecuringPrice == IsRecuringPrice select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyRecurringPaymentTime(int RecurringPaymentTime)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.RecurringPaymentTime == RecurringPaymentTime select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyQuantityIn(string QuantityIn)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.QuantityIn == QuantityIn select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Price == Price select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyDiscount(decimal Discount)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Discount == Discount select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<ProductVersion> ProductVersionGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void ProductVersionDeletebyProductVersionID(Guid ProductVersionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ProductVersionID == ProductVersionID select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyProductID(Guid ProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ProductID == ProductID select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Name == Name select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Description == Description select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyShortDescription(string ShortDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ShortDescription == ShortDescription select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyIsRecuringPrice(bool IsRecuringPrice)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.IsRecuringPrice == IsRecuringPrice select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyRecurringPaymentTime(int RecurringPaymentTime)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.RecurringPaymentTime == RecurringPaymentTime select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyQuantityIn(string QuantityIn)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.QuantityIn == QuantityIn select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Price == Price select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyDiscount(decimal Discount)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.Discount == Discount select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductVersionDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.ProductVersions where p.ModifiedDate == ModifiedDate select p);
                db.ProductVersions.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }




        public void ProductVersionUpdateByProductVersionID(Guid ProductVersionID, Guid ProductID, string Name, string Description, string ShortDescription, bool IsRecuringPrice, int RecurringPaymentTime, string QuantityIn, decimal Price, decimal Discount, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                ProductVersion data = db.ProductVersions.Single(p => p.ProductVersionID == ProductVersionID);
                data.ProductID = ProductID;
                data.Name = Name;
                data.Description = Description;
                data.ShortDescription = ShortDescription;
                data.IsRecuringPrice = IsRecuringPrice;
                data.RecurringPaymentTime = RecurringPaymentTime;
                data.QuantityIn = QuantityIn;
                data.Price = Price;
                data.Discount = Discount;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }








        #endregion
        #region CustomProductVersion
        #endregion
	
	


        #region VersionAttribute

        public void VersionAttributeAdd(Guid VersionAttributeID, Guid ProductVersionID, string Name, string Value, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                VersionAttribute ObjVersionAttribute = new VersionAttribute();

                ObjVersionAttribute.VersionAttributeID = VersionAttributeID;

                ObjVersionAttribute.ProductVersionID = ProductVersionID;

                ObjVersionAttribute.Name = Name;

                ObjVersionAttribute.Value = Value;

                ObjVersionAttribute.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.VersionAttributes.InsertOnSubmit(ObjVersionAttribute);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public Guid VersionAttributeAdd(Guid ProductVersionID, string Name, string Value, DateTime ModifiedDate)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                VersionAttribute ObjVersionAttribute = new VersionAttribute();



                ObjVersionAttribute.ProductVersionID = ProductVersionID;


                ObjVersionAttribute.Name = Name;


                ObjVersionAttribute.Value = Value;


                ObjVersionAttribute.ModifiedDate = ModifiedDate;



                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.VersionAttributes.InsertOnSubmit(ObjVersionAttribute);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return ObjVersionAttribute.VersionAttributeID;
            }
        }



        public List<VersionAttribute> VersionAttributeGet(int PageSize, int PageNumber)
        {
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.VersionAttributes select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<VersionAttribute> VersionAttributeGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.VersionAttributes select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<VersionAttribute> VersionAttributeGetbyVersionAttributeID(Guid VersionAttributeID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.VersionAttributeID == VersionAttributeID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<VersionAttribute> VersionAttributeGetbyProductVersionID(Guid ProductVersionID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.ProductVersionID == ProductVersionID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<VersionAttribute> VersionAttributeGetbyName(string Name, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<VersionAttribute> VersionAttributeGetbyValue(string Value, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.Value == Value select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<VersionAttribute> VersionAttributeGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<VersionAttribute> VersionAttributeGetbyVersionAttributeID(Guid VersionAttributeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.VersionAttributeID == VersionAttributeID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<VersionAttribute> VersionAttributeGetbyProductVersionID(Guid ProductVersionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.ProductVersionID == ProductVersionID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<VersionAttribute> VersionAttributeGetbyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.Name == Name select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<VersionAttribute> VersionAttributeGetbyValue(string Value)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.Value == Value select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<VersionAttribute> VersionAttributeGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void VersionAttributeDeletebyVersionAttributeID(Guid VersionAttributeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.VersionAttributeID == VersionAttributeID select p);
                db.VersionAttributes.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void VersionAttributeDeletebyProductVersionID(Guid ProductVersionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.ProductVersionID == ProductVersionID select p);
                db.VersionAttributes.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void VersionAttributeDeletebyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.Name == Name select p);
                db.VersionAttributes.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void VersionAttributeDeletebyValue(string Value)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.Value == Value select p);
                db.VersionAttributes.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void VersionAttributeDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.VersionAttributes where p.ModifiedDate == ModifiedDate select p);
                db.VersionAttributes.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }



        public void VersionAttributeUpdateByVersionAttributeID(Guid VersionAttributeID, Guid ProductVersionID, string Name, string Value, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (OrderPaymentDataContext db = new OrderPaymentDataContext())
            {
                db.DeferredLoadingEnabled = false;
                VersionAttribute data = db.VersionAttributes.Single(p => p.VersionAttributeID == VersionAttributeID);
                data.ProductVersionID = ProductVersionID;
                data.Name = Name;
                data.Value = Value;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }







        #endregion
        #region CustomVersionAttribute
        #endregion






    }
}
