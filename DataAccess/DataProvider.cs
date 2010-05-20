using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;
using System.Data.Linq;
using System.Diagnostics;
using Logger;
namespace DataAccess
{
    public class DataProvider
    {
        Logger.TimeLog objLogger;

        #region LoginUser

        public void LoginUserAdd(int LoginUserID, string Username, string Password, int UserType, Guid UserId, DateTime ModifiedDate, DateTime CreatedDate)
        {
            LoginUser ObjLoginUser = new LoginUser();

            ObjLoginUser.LoginUserID = LoginUserID;

            ObjLoginUser.Username = Username;

            ObjLoginUser.Password = Password;

            ObjLoginUser.UserType = UserType;

            ObjLoginUser.UserId = UserId;

            ObjLoginUser.ModifiedDate = ModifiedDate;

            ObjLoginUser.CreatedDate = CreatedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.LoginUsers.InsertOnSubmit(ObjLoginUser);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public List<LoginUser> LoginUserGet(int PageSize, int PageNumber)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<LoginUser> LoginUserGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyUsername(string Username, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.Username == Username select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyPassword(string Password, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.Password == Password select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyUserType(int UserType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.UserType == UserType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyUserId(Guid UserId, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.UserId == UserId select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyCreatedDate(DateTime CreatedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.CreatedDate == CreatedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<LoginUser> LoginUserGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyUsername(string Username)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.Username == Username select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyPassword(string Password)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.Password == Password select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyUserType(int UserType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.UserType == UserType select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyUserId(Guid UserId)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.UserId == UserId select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<LoginUser> LoginUserGetbyCreatedDate(DateTime CreatedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.LoginUsers where p.CreatedDate == CreatedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void LoginUserDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.LoginUsers where p.LoginUserID == LoginUserID select p);
            db.LoginUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void LoginUserDeletebyUsername(string Username)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.LoginUsers where p.Username == Username select p);
            db.LoginUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void LoginUserDeletebyPassword(string Password)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.LoginUsers where p.Password == Password select p);
            db.LoginUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void LoginUserDeletebyUserType(int UserType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.LoginUsers where p.UserType == UserType select p);
            db.LoginUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void LoginUserDeletebyUserId(Guid UserId)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.LoginUsers where p.UserId == UserId select p);
            db.LoginUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void LoginUserDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.LoginUsers where p.ModifiedDate == ModifiedDate select p);
            db.LoginUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void LoginUserDeletebyCreatedDate(DateTime CreatedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.LoginUsers where p.CreatedDate == CreatedDate select p);
            db.LoginUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void LoginUserUpdateByLoginUserID(int LoginUserID, string Username, string Password, int UserType, Guid UserId, DateTime ModifiedDate, DateTime CreatedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            LoginUser data = db.LoginUsers.Single(p => p.LoginUserID == LoginUserID);
            data.Username = Username;
            data.Password = Password;
            data.UserType = UserType;
            data.UserId = UserId;
            data.ModifiedDate = ModifiedDate;
            data.CreatedDate = CreatedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void LoginUserUpdateByUserId(int LoginUserID, string Username, string Password, int UserType, Guid UserId, DateTime ModifiedDate, DateTime CreatedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            LoginUser data = db.LoginUsers.Single(p => p.UserId == UserId);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        #endregion
        #region CustomLoginUser
        #endregion




    }
}
