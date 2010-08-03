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

        public void OrderAdd(Guid OrderID, int LoginUserID, string FirstName, string LastName, string PhoneNumber, string Email, string Fax, string Address1, string Address2, string City, string State, string Country, string ZipCode, DateTime ModifiedDate)
        {
            Order ObjOrder = new Order();

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

            ObjOrder.ModifiedDate = ModifiedDate;

            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Orders.InsertOnSubmit(ObjOrder);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public Guid OrderAdd(int LoginUserID, string FirstName, string LastName, string PhoneNumber, string Email, string Fax, string Address1, string Address2, string City, string State, string Country, string ZipCode, DateTime ModifiedDate)
        {
            Order ObjOrder = new Order();



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


            ObjOrder.ModifiedDate = ModifiedDate;

            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Orders.InsertOnSubmit(ObjOrder);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjOrder.OrderID;
        }



        public List<Order> OrderGet(int PageSize, int PageNumber)
        {
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Orders select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Orders select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Order> OrderGetbyOrderID(Guid OrderID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.OrderID == OrderID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyFirstName(string FirstName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.FirstName == FirstName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyLastName(string LastName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.LastName == LastName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyPhoneNumber(string PhoneNumber, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.PhoneNumber == PhoneNumber select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyEmail(string Email, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Email == Email select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyFax(string Fax, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Fax == Fax select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyAddress1(string Address1, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Address1 == Address1 select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyAddress2(string Address2, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Address2 == Address2 select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyCity(string City, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.City == City select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyState(string State, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.State == State select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyCountry(string Country, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Country == Country select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyZipCode(string ZipCode, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.ZipCode == ZipCode select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Order> OrderGetbyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.OrderID == OrderID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyFirstName(string FirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.FirstName == FirstName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyLastName(string LastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.LastName == LastName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyPhoneNumber(string PhoneNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.PhoneNumber == PhoneNumber select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyEmail(string Email)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Email == Email select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Fax == Fax select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyAddress1(string Address1)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Address1 == Address1 select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyAddress2(string Address2)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Address2 == Address2 select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyCity(string City)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.City == City select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyState(string State)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.State == State select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyCountry(string Country)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Country == Country select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyZipCode(string ZipCode)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.ZipCode == ZipCode select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Order> OrderGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void OrderDeletebyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.OrderID == OrderID select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.LoginUserID == LoginUserID select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyFirstName(string FirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.FirstName == FirstName select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyLastName(string LastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.LastName == LastName select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyPhoneNumber(string PhoneNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.PhoneNumber == PhoneNumber select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyEmail(string Email)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Email == Email select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Fax == Fax select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyAddress1(string Address1)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Address1 == Address1 select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyAddress2(string Address2)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Address2 == Address2 select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyCity(string City)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.City == City select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyState(string State)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.State == State select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyCountry(string Country)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.Country == Country select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyZipCode(string ZipCode)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.ZipCode == ZipCode select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Orders where p.ModifiedDate == ModifiedDate select p);
            db.Orders.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void OrderUpdateByOrderID(Guid OrderID, int LoginUserID, string FirstName, string LastName, string PhoneNumber, string Email, string Fax, string Address1, string Address2, string City, string State, string Country, string ZipCode, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            Order data = db.Orders.Single(p => p.OrderID == OrderID);
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
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomOrder
        #endregion


        #region Payment

        public void PaymentAdd(Guid PaymentID, Guid OrderID, int PaymentStatus, decimal Amount, string PaymentCurrency, int PaymentType, DateTime PaymentDate, DateTime ExpireDate, DateTime ModifiedDate)
        {
            Payment ObjPayment = new Payment();

            ObjPayment.PaymentID = PaymentID;

            ObjPayment.OrderID = OrderID;

            ObjPayment.PaymentStatus = PaymentStatus;

            ObjPayment.Amount = Amount;

            ObjPayment.PaymentCurrency = PaymentCurrency;

            ObjPayment.PaymentType = PaymentType;

            ObjPayment.PaymentDate = PaymentDate;

            ObjPayment.ExpireDate = ExpireDate;

            ObjPayment.ModifiedDate = ModifiedDate;

            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Payments.InsertOnSubmit(ObjPayment);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public Guid PaymentAdd(Guid OrderID, int PaymentStatus, decimal Amount, string PaymentCurrency, int PaymentType, DateTime PaymentDate, DateTime ExpireDate, DateTime ModifiedDate)
        {
            Payment ObjPayment = new Payment();



            ObjPayment.OrderID = OrderID;


            ObjPayment.PaymentStatus = PaymentStatus;


            ObjPayment.Amount = Amount;


            ObjPayment.PaymentCurrency = PaymentCurrency;


            ObjPayment.PaymentType = PaymentType;


            ObjPayment.PaymentDate = PaymentDate;


            ObjPayment.ExpireDate = ExpireDate;


            ObjPayment.ModifiedDate = ModifiedDate;

            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Payments.InsertOnSubmit(ObjPayment);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjPayment.PaymentID;
        }



        public List<Payment> PaymentGet(int PageSize, int PageNumber)
        {
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Payments select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Payments select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Payment> PaymentGetbyPaymentID(Guid PaymentID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentID == PaymentID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyOrderID(Guid OrderID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.OrderID == OrderID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyPaymentStatus(int PaymentStatus, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentStatus == PaymentStatus select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyAmount(decimal Amount, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.Amount == Amount select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyPaymentCurrency(string PaymentCurrency, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentCurrency == PaymentCurrency select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyPaymentType(int PaymentType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentType == PaymentType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyPaymentDate(DateTime PaymentDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentDate == PaymentDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyExpireDate(DateTime ExpireDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.ExpireDate == ExpireDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Payment> PaymentGetbyPaymentID(Guid PaymentID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentID == PaymentID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.OrderID == OrderID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyPaymentStatus(int PaymentStatus)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentStatus == PaymentStatus select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyAmount(decimal Amount)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.Amount == Amount select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyPaymentCurrency(string PaymentCurrency)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentCurrency == PaymentCurrency select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyPaymentType(int PaymentType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentType == PaymentType select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyPaymentDate(DateTime PaymentDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentDate == PaymentDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyExpireDate(DateTime ExpireDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.ExpireDate == ExpireDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Payment> PaymentGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void PaymentDeletebyPaymentID(Guid PaymentID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentID == PaymentID select p);
            db.Payments.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void PaymentDeletebyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.OrderID == OrderID select p);
            db.Payments.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void PaymentDeletebyPaymentStatus(int PaymentStatus)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentStatus == PaymentStatus select p);
            db.Payments.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void PaymentDeletebyAmount(decimal Amount)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.Amount == Amount select p);
            db.Payments.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void PaymentDeletebyPaymentCurrency(string PaymentCurrency)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentCurrency == PaymentCurrency select p);
            db.Payments.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void PaymentDeletebyPaymentType(int PaymentType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentType == PaymentType select p);
            db.Payments.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void PaymentDeletebyPaymentDate(DateTime PaymentDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.PaymentDate == PaymentDate select p);
            db.Payments.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void PaymentDeletebyExpireDate(DateTime ExpireDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.ExpireDate == ExpireDate select p);
            db.Payments.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void PaymentDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Payments where p.ModifiedDate == ModifiedDate select p);
            db.Payments.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void PaymentUpdateByPaymentID(Guid PaymentID, Guid OrderID, int PaymentStatus, decimal Amount, string PaymentCurrency, int PaymentType, DateTime PaymentDate, DateTime ExpireDate, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            Payment data = db.Payments.Single(p => p.PaymentID == PaymentID);
            data.OrderID = OrderID;
            data.PaymentStatus = PaymentStatus;
            data.Amount = Amount;
            data.PaymentCurrency = PaymentCurrency;
            data.PaymentType = PaymentType;
            data.PaymentDate = PaymentDate;
            data.ExpireDate = ExpireDate;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomPayment
        #endregion


        #region OrderItem

        public void OrderItemAdd(Guid OrderItemID, Guid OrderID, string ItemName, string ItemDescription, int Quantity, decimal Price, DateTime ModifiedDate)
        {
            OrderItem ObjOrderItem = new OrderItem();

            ObjOrderItem.OrderItemID = OrderItemID;

            ObjOrderItem.OrderID = OrderID;

            ObjOrderItem.ItemName = ItemName;

            ObjOrderItem.ItemDescription = ItemDescription;

            ObjOrderItem.Quantity = Quantity;

            ObjOrderItem.Price = Price;

            ObjOrderItem.ModifiedDate = ModifiedDate;

            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.OrderItems.InsertOnSubmit(ObjOrderItem);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public Guid OrderItemAdd(Guid OrderID, string ItemName, string ItemDescription, int Quantity, decimal Price, DateTime ModifiedDate)
        {
            OrderItem ObjOrderItem = new OrderItem();



            ObjOrderItem.OrderID = OrderID;


            ObjOrderItem.ItemName = ItemName;


            ObjOrderItem.ItemDescription = ItemDescription;


            ObjOrderItem.Quantity = Quantity;


            ObjOrderItem.Price = Price;


            ObjOrderItem.ModifiedDate = ModifiedDate;

            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.OrderItems.InsertOnSubmit(ObjOrderItem);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjOrderItem.OrderItemID;
        }



        public List<OrderItem> OrderItemGet(int PageSize, int PageNumber)
        {
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.OrderItems select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.OrderItems select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<OrderItem> OrderItemGetbyOrderItemID(Guid OrderItemID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.OrderItemID == OrderItemID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyOrderID(Guid OrderID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.OrderID == OrderID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyItemName(string ItemName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.ItemName == ItemName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyItemDescription(string ItemDescription, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.ItemDescription == ItemDescription select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyQuantity(int Quantity, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.Quantity == Quantity select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyPrice(decimal Price, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.Price == Price select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<OrderItem> OrderItemGetbyOrderItemID(Guid OrderItemID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.OrderItemID == OrderItemID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.OrderID == OrderID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyItemName(string ItemName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.ItemName == ItemName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyItemDescription(string ItemDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.ItemDescription == ItemDescription select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyQuantity(int Quantity)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.Quantity == Quantity select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.Price == Price select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<OrderItem> OrderItemGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void OrderItemDeletebyOrderItemID(Guid OrderItemID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.OrderItemID == OrderItemID select p);
            db.OrderItems.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderItemDeletebyOrderID(Guid OrderID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.OrderID == OrderID select p);
            db.OrderItems.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderItemDeletebyItemName(string ItemName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.ItemName == ItemName select p);
            db.OrderItems.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderItemDeletebyItemDescription(string ItemDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.ItemDescription == ItemDescription select p);
            db.OrderItems.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderItemDeletebyQuantity(int Quantity)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.Quantity == Quantity select p);
            db.OrderItems.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderItemDeletebyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.Price == Price select p);
            db.OrderItems.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void OrderItemDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.OrderItems where p.ModifiedDate == ModifiedDate select p);
            db.OrderItems.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void OrderItemUpdateByOrderItemID(Guid OrderItemID, Guid OrderID, string ItemName, string ItemDescription, int Quantity, decimal Price, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OrderPaymentDataContext db = new OrderPaymentDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            OrderItem data = db.OrderItems.Single(p => p.OrderItemID == OrderItemID);
            data.OrderID = OrderID;
            data.ItemName = ItemName;
            data.ItemDescription = ItemDescription;
            data.Quantity = Quantity;
            data.Price = Price;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomOrderItem
        #endregion
	
	
    }
}
