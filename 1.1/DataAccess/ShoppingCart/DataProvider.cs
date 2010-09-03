using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;
using System.Data.Linq;
using System.Diagnostics;
using Logger;
using System.Data;
using Common;
using System.Collections;
using System.Xml;
using System.Xml.Linq;

namespace DataAccess.ShoppingCart
{
    public class DataProvider
    {
        Logger.TimeLog objLogger;


        #region Item

        public void ItemAdd(int ItemID, string Name, int ItemType, decimal Price, string ApplicationURL, DateTime ModifiedDate)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                Item ObjItem = new Item();

                ObjItem.ItemID = ItemID;

                ObjItem.Name = Name;

                ObjItem.ItemType = ItemType;

                ObjItem.Price = Price;

                ObjItem.ApplicationURL = ApplicationURL;

                ObjItem.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.Items.InsertOnSubmit(ObjItem);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public int ItemAdd(string Name, int ItemType, decimal Price, string ApplicationURL, DateTime ModifiedDate)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                Item ObjItem = new Item();



                ObjItem.Name = Name;


                ObjItem.ItemType = ItemType;


                ObjItem.Price = Price;


                ObjItem.ApplicationURL = ApplicationURL;


                ObjItem.ModifiedDate = ModifiedDate;



                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.Items.InsertOnSubmit(ObjItem);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return ObjItem.ItemID;
            }
        }



        public List<Item> ItemGet(int PageSize, int PageNumber)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.Items select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Item> ItemGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.Items select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<Item> ItemGetbyItemID(int ItemID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ItemID == ItemID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Item> ItemGetbyName(string Name, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Item> ItemGetbyItemType(int ItemType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ItemType == ItemType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Item> ItemGetbyPrice(decimal Price, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.Price == Price select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Item> ItemGetbyApplicationURL(string ApplicationURL, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ApplicationURL == ApplicationURL select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Item> ItemGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<Item> ItemGetbyItemID(int ItemID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ItemID == ItemID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Item> ItemGetbyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.Name == Name select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Item> ItemGetbyItemType(int ItemType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ItemType == ItemType select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Item> ItemGetbyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.Price == Price select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Item> ItemGetbyApplicationURL(string ApplicationURL)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ApplicationURL == ApplicationURL select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Item> ItemGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void ItemDeletebyItemID(int ItemID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ItemID == ItemID select p);
                db.Items.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ItemDeletebyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.Name == Name select p);
                db.Items.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ItemDeletebyItemType(int ItemType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ItemType == ItemType select p);
                db.Items.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ItemDeletebyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.Price == Price select p);
                db.Items.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ItemDeletebyApplicationURL(string ApplicationURL)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ApplicationURL == ApplicationURL select p);
                db.Items.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ItemDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Items where p.ModifiedDate == ModifiedDate select p);
                db.Items.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }



        public void ItemUpdateByItemID(int ItemID, string Name, int ItemType, decimal Price, string ApplicationURL, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                Item data = db.Items.Single(p => p.ItemID == ItemID);
                data.Name = Name;
                data.ItemType = ItemType;
                data.Price = Price;
                data.ApplicationURL = ApplicationURL;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomItem
        #endregion




    }
}
