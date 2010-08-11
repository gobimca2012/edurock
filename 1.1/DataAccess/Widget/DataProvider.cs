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
namespace DataAccess.WidgetProvider
{
    public class DataProvider
    {
        Logger.TimeLog objLogger;


        #region WidgetPage

        public void WidgetPageAdd(Guid PageID, int LoginUserID, int PageType, string Title, DateTime ModifiedDate)
        {
            WidgetPage ObjWidgetPage = new WidgetPage();

            ObjWidgetPage.PageID = PageID;

            ObjWidgetPage.LoginUserID = LoginUserID;

            ObjWidgetPage.PageType = PageType;

            ObjWidgetPage.Title = Title;

            ObjWidgetPage.ModifiedDate = ModifiedDate;

            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.WidgetPages.InsertOnSubmit(ObjWidgetPage);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public Guid WidgetPageAdd(int LoginUserID, int PageType, string Title, DateTime ModifiedDate)
        {
            WidgetPage ObjWidgetPage = new WidgetPage();



            ObjWidgetPage.LoginUserID = LoginUserID;


            ObjWidgetPage.PageType = PageType;


            ObjWidgetPage.Title = Title;


            ObjWidgetPage.ModifiedDate = ModifiedDate;

            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.WidgetPages.InsertOnSubmit(ObjWidgetPage);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjWidgetPage.PageID;
        }



        public List<WidgetPage> WidgetPageGet(int PageSize, int PageNumber)
        {
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.WidgetPages select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<WidgetPage> WidgetPageGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.WidgetPages select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<WidgetPage> WidgetPageGetbyPageID(Guid PageID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.PageID == PageID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<WidgetPage> WidgetPageGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<WidgetPage> WidgetPageGetbyPageType(int PageType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.PageType == PageType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<WidgetPage> WidgetPageGetbyTitle(string Title, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.Title == Title select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<WidgetPage> WidgetPageGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<WidgetPage> WidgetPageGetbyPageID(Guid PageID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.PageID == PageID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<WidgetPage> WidgetPageGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<WidgetPage> WidgetPageGetbyPageType(int PageType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.PageType == PageType select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<WidgetPage> WidgetPageGetbyTitle(string Title)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.Title == Title select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<WidgetPage> WidgetPageGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void WidgetPageDeletebyPageID(Guid PageID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.PageID == PageID select p);
            db.WidgetPages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetPageDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.LoginUserID == LoginUserID select p);
            db.WidgetPages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetPageDeletebyPageType(int PageType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.PageType == PageType select p);
            db.WidgetPages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetPageDeletebyTitle(string Title)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.Title == Title select p);
            db.WidgetPages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetPageDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.WidgetPages where p.ModifiedDate == ModifiedDate select p);
            db.WidgetPages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void WidgetPageUpdateByPageID(Guid PageID, int LoginUserID, int PageType, string Title, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            WidgetPage data = db.WidgetPages.Single(p => p.PageID == PageID);
            data.LoginUserID = LoginUserID;
            data.PageType = PageType;
            data.Title = Title;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomWidgetPage
        public List<WidgetPage> WidgetPageGetByLoginID(int LoginUserID, int PageType)
        {
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.WidgetPages where p.PageType == PageType && p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        #endregion





        #region Widget

        public void WidgetAdd(Guid WidgetID, Guid PageID, string Title, int ContentType, string ContentID, int WidgetOrder, int WidgetColumn, DateTime ModifiedDate)
        {
            Widget ObjWidget = new Widget();

            ObjWidget.WidgetID = WidgetID;

            ObjWidget.PageID = PageID;

            ObjWidget.Title = Title;

            ObjWidget.ContentType = ContentType;

            ObjWidget.ContentID = ContentID;

            ObjWidget.WidgetOrder = WidgetOrder;

            ObjWidget.WidgetColumn = WidgetColumn;

            ObjWidget.ModifiedDate = ModifiedDate;

            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Widgets.InsertOnSubmit(ObjWidget);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public Guid WidgetAdd(Guid PageID, string Title, int ContentType, string ContentID, int WidgetOrder, int WidgetColumn, DateTime ModifiedDate)
        {
            Widget ObjWidget = new Widget();



            ObjWidget.PageID = PageID;


            ObjWidget.Title = Title;


            ObjWidget.ContentType = ContentType;


            ObjWidget.ContentID = ContentID;


            ObjWidget.WidgetOrder = WidgetOrder;


            ObjWidget.WidgetColumn = WidgetColumn;


            ObjWidget.ModifiedDate = ModifiedDate;

            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Widgets.InsertOnSubmit(ObjWidget);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjWidget.WidgetID;
        }



        public List<Widget> WidgetGet(int PageSize, int PageNumber)
        {
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Widgets select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Widgets select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Widget> WidgetGetbyWidgetID(Guid WidgetID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.WidgetID == WidgetID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyPageID(Guid PageID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.PageID == PageID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyTitle(string Title, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.Title == Title select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyContentType(int ContentType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.ContentType == ContentType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyContentID(string ContentID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.ContentID == ContentID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyWidgetOrder(int WidgetOrder, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.WidgetOrder == WidgetOrder select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyWidgetColumn(int WidgetColumn, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.WidgetColumn == WidgetColumn select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Widget> WidgetGetbyWidgetID(Guid WidgetID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.WidgetID == WidgetID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyPageID(Guid PageID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.PageID == PageID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyTitle(string Title)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.Title == Title select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyContentType(int ContentType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.ContentType == ContentType select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyContentID(string ContentID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.ContentID == ContentID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyWidgetOrder(int WidgetOrder)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.WidgetOrder == WidgetOrder select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyWidgetColumn(int WidgetColumn)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.WidgetColumn == WidgetColumn select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Widget> WidgetGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void WidgetDeletebyWidgetID(Guid WidgetID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.WidgetID == WidgetID select p);
            db.Widgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetDeletebyPageID(Guid PageID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.PageID == PageID select p);
            db.Widgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetDeletebyTitle(string Title)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.Title == Title select p);
            db.Widgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetDeletebyContentType(int ContentType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.ContentType == ContentType select p);
            db.Widgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetDeletebyContentID(string ContentID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.ContentID == ContentID select p);
            db.Widgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetDeletebyWidgetOrder(int WidgetOrder)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.WidgetOrder == WidgetOrder select p);
            db.Widgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetDeletebyWidgetColumn(int WidgetColumn)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.WidgetColumn == WidgetColumn select p);
            db.Widgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void WidgetDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.ModifiedDate == ModifiedDate select p);
            db.Widgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void WidgetUpdateByWidgetID(Guid WidgetID, Guid PageID, string Title, int ContentType, string ContentID, int WidgetOrder, int WidgetColumn, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            Widget data = db.Widgets.Single(p => p.WidgetID == WidgetID);
            data.PageID = PageID;
            data.Title = Title;
            data.ContentType = ContentType;
            data.ContentID = ContentID;
            data.WidgetOrder = WidgetOrder;
            data.WidgetColumn = WidgetColumn;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion


        #region CustomWidget
        #endregion


        #region HTMLWidget

        public void HTMLWidgetAdd(Guid HTMLWidgetID, string HTMLDATA, DateTime ModifiedDate)
        {
            HTMLWidget ObjHTMLWidget = new HTMLWidget();

            ObjHTMLWidget.HTMLWidgetID = HTMLWidgetID;

            ObjHTMLWidget.HTMLDATA = HTMLDATA;

            ObjHTMLWidget.ModifiedDate = ModifiedDate;

            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.HTMLWidgets.InsertOnSubmit(ObjHTMLWidget);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public Guid HTMLWidgetAdd(string HTMLDATA, DateTime ModifiedDate)
        {
            HTMLWidget ObjHTMLWidget = new HTMLWidget();



            ObjHTMLWidget.HTMLDATA = HTMLDATA;


            ObjHTMLWidget.ModifiedDate = ModifiedDate;

            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.HTMLWidgets.InsertOnSubmit(ObjHTMLWidget);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjHTMLWidget.HTMLWidgetID;
        }



        public List<HTMLWidget> HTMLWidgetGet(int PageSize, int PageNumber)
        {
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.HTMLWidgets select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<HTMLWidget> HTMLWidgetGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.HTMLWidgets select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<HTMLWidget> HTMLWidgetGetbyHTMLWidgetID(Guid HTMLWidgetID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.HTMLWidgets where p.HTMLWidgetID == HTMLWidgetID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<HTMLWidget> HTMLWidgetGetbyHTMLDATA(string HTMLDATA, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.HTMLWidgets where p.HTMLDATA == HTMLDATA select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<HTMLWidget> HTMLWidgetGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.HTMLWidgets where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<HTMLWidget> HTMLWidgetGetbyHTMLWidgetID(Guid HTMLWidgetID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.HTMLWidgets where p.HTMLWidgetID == HTMLWidgetID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<HTMLWidget> HTMLWidgetGetbyHTMLDATA(string HTMLDATA)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.HTMLWidgets where p.HTMLDATA == HTMLDATA select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<HTMLWidget> HTMLWidgetGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.HTMLWidgets where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void HTMLWidgetDeletebyHTMLWidgetID(Guid HTMLWidgetID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.HTMLWidgets where p.HTMLWidgetID == HTMLWidgetID select p);
            db.HTMLWidgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void HTMLWidgetDeletebyHTMLDATA(string HTMLDATA)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.HTMLWidgets where p.HTMLDATA == HTMLDATA select p);
            db.HTMLWidgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void HTMLWidgetDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;


            db.DeferredLoadingEnabled = false;
            var data = (from p in db.HTMLWidgets where p.ModifiedDate == ModifiedDate select p);
            db.HTMLWidgets.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void HTMLWidgetUpdateByHTMLWidgetID(Guid HTMLWidgetID, string HTMLDATA, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.DeferredLoadingEnabled = false;
            HTMLWidget data = db.HTMLWidgets.Single(p => p.HTMLWidgetID == HTMLWidgetID);
            data.HTMLDATA = HTMLDATA;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomHTMLWidget
        public List<HTMLWidget> HTMLWidgetGetbyWidgetID(Guid WidgetID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var widgetData = (from p in db.Widgets where p.WidgetID == WidgetID select p).ToList();

            var data = (from p in db.HTMLWidgets where p.HTMLWidgetID == new Guid(widgetData[0].ContentID) select p).ToList();

            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public int WidgetOrderGetbyPageID(Guid PageID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            WidgetDataContext db = new WidgetDataContext();
            DataLoadOptions option = new DataLoadOptions();
            db.LoadOptions = option;

            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Widgets where p.PageID == PageID  orderby p.WidgetOrder  select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            if (data.Count > 0)
            {
                return data[data.Count - 1].WidgetOrder;
            }
            else
            {
                return 1;
            }
            
            

        }
        #endregion



    }
}
