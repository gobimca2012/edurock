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



        #region Product

        public void ProductAdd(int ProductID, string Name, int ItemType, decimal Price, string QuantityText, string ApplicationURL, string Description, string MetaDescription, DateTime ModifiedDate)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                Product ObjProduct = new Product();

                ObjProduct.ProductID = ProductID;

                ObjProduct.Name = Name;

                ObjProduct.ItemType = ItemType;

                ObjProduct.Price = Price;

                ObjProduct.QuantityText = QuantityText;

                ObjProduct.ApplicationURL = ApplicationURL;

                ObjProduct.Description = Description;

                ObjProduct.MetaDescription = MetaDescription;

                ObjProduct.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.Products.InsertOnSubmit(ObjProduct);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public int ProductAdd(string Name, int ItemType, decimal Price, string QuantityText, string ApplicationURL, string Description, string MetaDescription, DateTime ModifiedDate)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                Product ObjProduct = new Product();



                ObjProduct.Name = Name;


                ObjProduct.ItemType = ItemType;


                ObjProduct.Price = Price;


                ObjProduct.QuantityText = QuantityText;


                ObjProduct.ApplicationURL = ApplicationURL;


                ObjProduct.Description = Description;


                ObjProduct.MetaDescription = MetaDescription;


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
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
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
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.Products select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<Product> ProductGetbyProductID(int ProductID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
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
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyItemType(int ItemType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ItemType == ItemType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyPrice(decimal Price, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Price == Price select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyQuantityText(string QuantityText, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.QuantityText == QuantityText select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyApplicationURL(string ApplicationURL, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ApplicationURL == ApplicationURL select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyMetaDescription(string MetaDescription, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.MetaDescription == MetaDescription select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<Product> ProductGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<Product> ProductGetbyProductID(int ProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
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
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Name == Name select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyItemType(int ItemType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ItemType == ItemType select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Price == Price select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyQuantityText(string QuantityText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.QuantityText == QuantityText select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyApplicationURL(string ApplicationURL)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ApplicationURL == ApplicationURL select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Description == Description select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyMetaDescription(string MetaDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.MetaDescription == MetaDescription select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<Product> ProductGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void ProductDeletebyProductID(int ProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
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
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Name == Name select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyItemType(int ItemType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ItemType == ItemType select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Price == Price select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyQuantityText(string QuantityText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.QuantityText == QuantityText select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyApplicationURL(string ApplicationURL)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ApplicationURL == ApplicationURL select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.Description == Description select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyMetaDescription(string MetaDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.MetaDescription == MetaDescription select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void ProductDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.Products where p.ModifiedDate == ModifiedDate select p);
                db.Products.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }



        public void ProductUpdateByProductID(int ProductID, string Name, int ItemType, decimal Price, string QuantityText, string ApplicationURL, string Description, string MetaDescription, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                Product data = db.Products.Single(p => p.ProductID == ProductID);
                data.Name = Name;
                data.ItemType = ItemType;
                data.Price = Price;
                data.QuantityText = QuantityText;
                data.ApplicationURL = ApplicationURL;
                data.Description = Description;
                data.MetaDescription = MetaDescription;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomProduct
       
        #endregion


        #region CustomerProduct

        public void CustomerProductAdd(Guid CustomerProductID, int ProductID, string UserID, decimal PricePerItem, decimal TotalPrice, int Quantity, DateTime ExpireDate, DateTime BroughtDate, DateTime ModifiedDate)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                CustomerProduct ObjCustomerProduct = new CustomerProduct();

                ObjCustomerProduct.CustomerProductID = CustomerProductID;

                ObjCustomerProduct.ProductID = ProductID;

                ObjCustomerProduct.UserID = UserID;

                ObjCustomerProduct.PricePerItem = PricePerItem;

                ObjCustomerProduct.TotalPrice = TotalPrice;

                ObjCustomerProduct.Quantity = Quantity;

                ObjCustomerProduct.ExpireDate = ExpireDate;

                ObjCustomerProduct.BroughtDate = BroughtDate;

                ObjCustomerProduct.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.CustomerProducts.InsertOnSubmit(ObjCustomerProduct);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public Guid CustomerProductAdd(int ProductID, string UserID, decimal PricePerItem, decimal TotalPrice, int Quantity, DateTime ExpireDate, DateTime BroughtDate, DateTime ModifiedDate)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                CustomerProduct ObjCustomerProduct = new CustomerProduct();



                ObjCustomerProduct.ProductID = ProductID;


                ObjCustomerProduct.UserID = UserID;


                ObjCustomerProduct.PricePerItem = PricePerItem;


                ObjCustomerProduct.TotalPrice = TotalPrice;


                ObjCustomerProduct.Quantity = Quantity;


                ObjCustomerProduct.ExpireDate = ExpireDate;


                ObjCustomerProduct.BroughtDate = BroughtDate;


                ObjCustomerProduct.ModifiedDate = ModifiedDate;



                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.CustomerProducts.InsertOnSubmit(ObjCustomerProduct);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return ObjCustomerProduct.CustomerProductID;
            }
        }



        public List<CustomerProduct> CustomerProductGet(int PageSize, int PageNumber)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.CustomerProducts select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerProduct> CustomerProductGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.CustomerProducts select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<CustomerProduct> CustomerProductGetbyCustomerProductID(Guid CustomerProductID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.CustomerProductID == CustomerProductID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerProduct> CustomerProductGetbyProductID(int ProductID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.ProductID == ProductID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerProduct> CustomerProductGetbyUserID(string UserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.UserID == UserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerProduct> CustomerProductGetbyPricePerItem(decimal PricePerItem, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.PricePerItem == PricePerItem select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerProduct> CustomerProductGetbyTotalPrice(decimal TotalPrice, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.TotalPrice == TotalPrice select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerProduct> CustomerProductGetbyQuantity(int Quantity, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.Quantity == Quantity select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerProduct> CustomerProductGetbyExpireDate(DateTime ExpireDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.ExpireDate == ExpireDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerProduct> CustomerProductGetbyBroughtDate(DateTime BroughtDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.BroughtDate == BroughtDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerProduct> CustomerProductGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<CustomerProduct> CustomerProductGetbyCustomerProductID(Guid CustomerProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.CustomerProductID == CustomerProductID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerProduct> CustomerProductGetbyProductID(int ProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.ProductID == ProductID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerProduct> CustomerProductGetbyUserID(string UserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.UserID == UserID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerProduct> CustomerProductGetbyPricePerItem(decimal PricePerItem)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.PricePerItem == PricePerItem select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerProduct> CustomerProductGetbyTotalPrice(decimal TotalPrice)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.TotalPrice == TotalPrice select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerProduct> CustomerProductGetbyQuantity(int Quantity)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.Quantity == Quantity select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerProduct> CustomerProductGetbyExpireDate(DateTime ExpireDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.ExpireDate == ExpireDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerProduct> CustomerProductGetbyBroughtDate(DateTime BroughtDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.BroughtDate == BroughtDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerProduct> CustomerProductGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void CustomerProductDeletebyCustomerProductID(Guid CustomerProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.CustomerProductID == CustomerProductID select p);
                db.CustomerProducts.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerProductDeletebyProductID(int ProductID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.ProductID == ProductID select p);
                db.CustomerProducts.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerProductDeletebyUserID(string UserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.UserID == UserID select p);
                db.CustomerProducts.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerProductDeletebyPricePerItem(decimal PricePerItem)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.PricePerItem == PricePerItem select p);
                db.CustomerProducts.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerProductDeletebyTotalPrice(decimal TotalPrice)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.TotalPrice == TotalPrice select p);
                db.CustomerProducts.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerProductDeletebyQuantity(int Quantity)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.Quantity == Quantity select p);
                db.CustomerProducts.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerProductDeletebyExpireDate(DateTime ExpireDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.ExpireDate == ExpireDate select p);
                db.CustomerProducts.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerProductDeletebyBroughtDate(DateTime BroughtDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.BroughtDate == BroughtDate select p);
                db.CustomerProducts.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerProductDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerProducts where p.ModifiedDate == ModifiedDate select p);
                db.CustomerProducts.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }



        public void CustomerProductUpdateByCustomerProductID(Guid CustomerProductID, int ProductID, string UserID, decimal PricePerItem, decimal TotalPrice, int Quantity, DateTime ExpireDate, DateTime BroughtDate, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                CustomerProduct data = db.CustomerProducts.Single(p => p.CustomerProductID == CustomerProductID);
                data.ProductID = ProductID;
                data.UserID = UserID;
                data.PricePerItem = PricePerItem;
                data.TotalPrice = TotalPrice;
                data.Quantity = Quantity;
                data.ExpireDate = ExpireDate;
                data.BroughtDate = BroughtDate;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }







        #endregion
        #region CustomCustomerProduct
        #endregion


        #region CustomerInfo

        public void CustomerInfoAdd(Guid CustomerInfoID, string UserID, string FirstName, string LastName, string MobileNumber, string OfficeNumber, string Fax, string businessEmail, int CurrencyCode, string BillingFirstName, string BillingLastName, string BillingAddress1, string BillingAddress2, string BillingCity, string billingStateProvince, string billingCountry, string BillingEmail, DateTime ModifiedDate)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;

                CustomerInfo ObjCustomerInfo = new CustomerInfo();

                ObjCustomerInfo.CustomerInfoID = CustomerInfoID;

                ObjCustomerInfo.UserID = UserID;

                ObjCustomerInfo.FirstName = FirstName;

                ObjCustomerInfo.LastName = LastName;

                ObjCustomerInfo.MobileNumber = MobileNumber;

                ObjCustomerInfo.OfficeNumber = OfficeNumber;

                ObjCustomerInfo.Fax = Fax;

                ObjCustomerInfo.businessEmail = businessEmail;

                ObjCustomerInfo.CurrencyCode = CurrencyCode;

                ObjCustomerInfo.BillingFirstName = BillingFirstName;

                ObjCustomerInfo.BillingLastName = BillingLastName;

                ObjCustomerInfo.BillingAddress1 = BillingAddress1;

                ObjCustomerInfo.BillingAddress2 = BillingAddress2;

                ObjCustomerInfo.BillingCity = BillingCity;

                ObjCustomerInfo.billingStateProvince = billingStateProvince;

                ObjCustomerInfo.billingCountry = billingCountry;

                ObjCustomerInfo.BillingEmail = BillingEmail;

                ObjCustomerInfo.ModifiedDate = ModifiedDate;


                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.CustomerInfos.InsertOnSubmit(ObjCustomerInfo);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public Guid CustomerInfoAdd(string UserID, string FirstName, string LastName, string MobileNumber, string OfficeNumber, string Fax, string businessEmail, int CurrencyCode, string BillingFirstName, string BillingLastName, string BillingAddress1, string BillingAddress2, string BillingCity, string billingStateProvince, string billingCountry, string BillingEmail, DateTime ModifiedDate)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {

                DataLoadOptions option = new DataLoadOptions();
                db.LoadOptions = option;
                CustomerInfo ObjCustomerInfo = new CustomerInfo();


                ObjCustomerInfo.UserID = UserID;


                ObjCustomerInfo.FirstName = FirstName;


                ObjCustomerInfo.LastName = LastName;


                ObjCustomerInfo.MobileNumber = MobileNumber;


                ObjCustomerInfo.OfficeNumber = OfficeNumber;


                ObjCustomerInfo.Fax = Fax;


                ObjCustomerInfo.businessEmail = businessEmail;


                ObjCustomerInfo.CurrencyCode = CurrencyCode;


                ObjCustomerInfo.BillingFirstName = BillingFirstName;


                ObjCustomerInfo.BillingLastName = BillingLastName;


                ObjCustomerInfo.BillingAddress1 = BillingAddress1;


                ObjCustomerInfo.BillingAddress2 = BillingAddress2;


                ObjCustomerInfo.BillingCity = BillingCity;


                ObjCustomerInfo.billingStateProvince = billingStateProvince;


                ObjCustomerInfo.billingCountry = billingCountry;


                ObjCustomerInfo.BillingEmail = BillingEmail;


                ObjCustomerInfo.ModifiedDate = ModifiedDate;



                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.CustomerInfos.InsertOnSubmit(ObjCustomerInfo);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return ObjCustomerInfo.CustomerInfoID;
            }
        }



        public List<CustomerInfo> CustomerInfoGet(int PageSize, int PageNumber)
        {
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.CustomerInfos select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                db.ObjectTrackingEnabled = false;
                var data = (from p in db.CustomerInfos select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }


        public List<CustomerInfo> CustomerInfoGetbyCustomerInfoID(Guid CustomerInfoID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.CustomerInfoID == CustomerInfoID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyUserID(string UserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.UserID == UserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyFirstName(string FirstName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.FirstName == FirstName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyLastName(string LastName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.LastName == LastName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyMobileNumber(string MobileNumber, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.MobileNumber == MobileNumber select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyOfficeNumber(string OfficeNumber, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.OfficeNumber == OfficeNumber select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyFax(string Fax, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.Fax == Fax select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbybusinessEmail(string businessEmail, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.businessEmail == businessEmail select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyCurrencyCode(int CurrencyCode, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.CurrencyCode == CurrencyCode select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyBillingFirstName(string BillingFirstName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingFirstName == BillingFirstName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyBillingLastName(string BillingLastName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingLastName == BillingLastName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyBillingAddress1(string BillingAddress1, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingAddress1 == BillingAddress1 select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyBillingAddress2(string BillingAddress2, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingAddress2 == BillingAddress2 select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyBillingCity(string BillingCity, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingCity == BillingCity select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbybillingStateProvince(string billingStateProvince, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.billingStateProvince == billingStateProvince select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbybillingCountry(string billingCountry, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.billingCountry == billingCountry select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyBillingEmail(string BillingEmail, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingEmail == BillingEmail select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }

        public List<CustomerInfo> CustomerInfoGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }

        }



        public List<CustomerInfo> CustomerInfoGetbyCustomerInfoID(Guid CustomerInfoID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.CustomerInfoID == CustomerInfoID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyUserID(string UserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.UserID == UserID select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyFirstName(string FirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.FirstName == FirstName select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyLastName(string LastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.LastName == LastName select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyMobileNumber(string MobileNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.MobileNumber == MobileNumber select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyOfficeNumber(string OfficeNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.OfficeNumber == OfficeNumber select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.Fax == Fax select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbybusinessEmail(string businessEmail)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.businessEmail == businessEmail select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyCurrencyCode(int CurrencyCode)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.CurrencyCode == CurrencyCode select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyBillingFirstName(string BillingFirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingFirstName == BillingFirstName select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyBillingLastName(string BillingLastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingLastName == BillingLastName select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyBillingAddress1(string BillingAddress1)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingAddress1 == BillingAddress1 select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyBillingAddress2(string BillingAddress2)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingAddress2 == BillingAddress2 select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyBillingCity(string BillingCity)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingCity == BillingCity select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbybillingStateProvince(string billingStateProvince)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.billingStateProvince == billingStateProvince select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbybillingCountry(string billingCountry)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.billingCountry == billingCountry select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyBillingEmail(string BillingEmail)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingEmail == BillingEmail select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }

        public List<CustomerInfo> CustomerInfoGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.ObjectTrackingEnabled = false;
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.ModifiedDate == ModifiedDate select p).ToList();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
                return data;
            }
        }



        public void CustomerInfoDeletebyCustomerInfoID(Guid CustomerInfoID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.CustomerInfoID == CustomerInfoID select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyUserID(string UserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.UserID == UserID select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyFirstName(string FirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.FirstName == FirstName select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyLastName(string LastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.LastName == LastName select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyMobileNumber(string MobileNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.MobileNumber == MobileNumber select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyOfficeNumber(string OfficeNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.OfficeNumber == OfficeNumber select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.Fax == Fax select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebybusinessEmail(string businessEmail)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.businessEmail == businessEmail select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyCurrencyCode(int CurrencyCode)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.CurrencyCode == CurrencyCode select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyBillingFirstName(string BillingFirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingFirstName == BillingFirstName select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyBillingLastName(string BillingLastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingLastName == BillingLastName select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyBillingAddress1(string BillingAddress1)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingAddress1 == BillingAddress1 select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyBillingAddress2(string BillingAddress2)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingAddress2 == BillingAddress2 select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyBillingCity(string BillingCity)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingCity == BillingCity select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebybillingStateProvince(string billingStateProvince)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.billingStateProvince == billingStateProvince select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebybillingCountry(string billingCountry)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.billingCountry == billingCountry select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyBillingEmail(string BillingEmail)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.BillingEmail == BillingEmail select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }

        public void CustomerInfoDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                var data = (from p in db.CustomerInfos where p.ModifiedDate == ModifiedDate select p);
                db.CustomerInfos.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            }
        }



        public void CustomerInfoUpdateByCustomerInfoID(Guid CustomerInfoID, string UserID, string FirstName, string LastName, string MobileNumber, string OfficeNumber, string Fax, string businessEmail, int CurrencyCode, string BillingFirstName, string BillingLastName, string BillingAddress1, string BillingAddress2, string BillingCity, string billingStateProvince, string billingCountry, string BillingEmail, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            using (ShoppingCartDataContext db = new ShoppingCartDataContext())
            {
                db.DeferredLoadingEnabled = false;
                CustomerInfo data = db.CustomerInfos.Single(p => p.CustomerInfoID == CustomerInfoID);
                data.UserID = UserID;
                data.FirstName = FirstName;
                data.LastName = LastName;
                data.MobileNumber = MobileNumber;
                data.OfficeNumber = OfficeNumber;
                data.Fax = Fax;
                data.businessEmail = businessEmail;
                data.CurrencyCode = CurrencyCode;
                data.BillingFirstName = BillingFirstName;
                data.BillingLastName = BillingLastName;
                data.BillingAddress1 = BillingAddress1;
                data.BillingAddress2 = BillingAddress2;
                data.BillingCity = BillingCity;
                data.billingStateProvince = billingStateProvince;
                data.billingCountry = billingCountry;
                data.BillingEmail = BillingEmail;
                data.ModifiedDate = ModifiedDate;

                db.SubmitChanges();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }







        #endregion
        #region CustomCustomerInfo
        #endregion
	
	



    }
}
