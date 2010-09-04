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
	
	



    }
}
