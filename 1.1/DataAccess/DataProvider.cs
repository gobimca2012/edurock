using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;
using System.Data.Linq;
using System.Diagnostics;
using Logger;
using System.Data;
namespace DataAccess
{
    public class DataProvider
    {
        Logger.TimeLog objLogger;

        #region LoginUser

        public int LoginUserAdd(string Username, string Password, int UserType, Guid UserId, DateTime ModifiedDate, DateTime CreatedDate)
        {
            LoginUser ObjLoginUser = new LoginUser();



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
            return ObjLoginUser.LoginUserID;
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


        #region Exam

        public int ExamAdd(string ExamName, string SubjectName, int LoginUserID,string Description, DateTime ModifiedDate)
        {
            Exam ObjExam = new Exam();

            ObjExam.Description = Description;

            ObjExam.ExamName = ExamName;

            ObjExam.SubjectName = SubjectName;

            ObjExam.LoginUserID = LoginUserID;

            ObjExam.ModifiedDate = ModifiedDate;
            ObjExam.IsActive = false;
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Exams.InsertOnSubmit(ObjExam);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjExam.ExamID;
        }

        public List<Exam> ExamGet(int PageSize, int PageNumber)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Exam> ExamGetbyExamID(int ExamID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.ExamID == ExamID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyExamName(string ExamName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.ExamName == ExamName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbySubjectName(string SubjectName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.SubjectName == SubjectName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Exam> ExamGetbyExamID(int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.ExamID == ExamID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyExamName(string ExamName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.ExamName == ExamName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbySubjectName(string SubjectName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.SubjectName == SubjectName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Exams where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void ExamDeletebyExamID(int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.Exams where p.ExamID == ExamID select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyExamName(string ExamName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.Exams where p.ExamName == ExamName select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebySubjectName(string SubjectName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.Exams where p.SubjectName == SubjectName select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.Exams where p.LoginUserID == LoginUserID select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.Exams where p.ModifiedDate == ModifiedDate select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void ExamUpdateByExamID(int ExamID, string ExamName, string SubjectName, int LoginUserID,string Description, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            Exam data = db.Exams.Single(p => p.ExamID == ExamID);
            data.ExamName = ExamName;
            data.Description = Description;
            data.SubjectName = SubjectName;
            data.LoginUserID = LoginUserID;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void ExamUpdateByLoginUserID(int ExamID, string ExamName, string SubjectName, int LoginUserID, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            Exam data = db.Exams.Single(p => p.LoginUserID == LoginUserID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomExam
        public void ExamUpdateByExamID(int ExamID, string ExamName, string SubjectName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            Exam data = db.Exams.Single(p => p.ExamID == ExamID);
            data.ExamName = ExamName;
            data.SubjectName = SubjectName;
            data.ModifiedDate = DateTime.Now;
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        public void UpdateExamByExamID(int ExamID, bool IsActive)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            Exam data = db.Exams.Single(p => p.ExamID == ExamID);
            data.IsActive = IsActive;
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        #endregion


        #region EXM_Question

        public void EXM_QuestionAdd(int EXM_QuestionID, string Question, int LoginUserID, int ExamID, int Q_Type, string Description, DateTime ModifiedDate)
        {
            EXM_Question ObjEXM_Question = new EXM_Question();

            ObjEXM_Question.EXM_QuestionID = EXM_QuestionID;

            ObjEXM_Question.Question = Question;

            ObjEXM_Question.LoginUserID = LoginUserID;

            ObjEXM_Question.ExamID = ExamID;

            ObjEXM_Question.Q_Type = Q_Type;

            ObjEXM_Question.Description = Description;

            ObjEXM_Question.ModifiedDate = ModifiedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.EXM_Questions.InsertOnSubmit(ObjEXM_Question);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }


        public List<EXM_Question> EXM_QuestionGet(int PageSize, int PageNumber)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<EXM_Question> EXM_QuestionGetbyEXM_QuestionID(int EXM_QuestionID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.EXM_QuestionID == EXM_QuestionID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyQuestion(string Question, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.Question == Question select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyExamID(int ExamID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.ExamID == ExamID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyQ_Type(int Q_Type, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.Q_Type == Q_Type select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<EXM_Question> EXM_QuestionGetbyEXM_QuestionID(int EXM_QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.EXM_QuestionID == EXM_QuestionID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyQuestion(string Question)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.Question == Question select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyExamID(int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            //LoadOption option = new LoadOption();
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<EXM_Question>(p => p.EXM_Answers);
            db.LoadOptions = option;
            var data = (from p in db.EXM_Questions where p.ExamID == ExamID orderby p.Order select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyQ_Type(int Q_Type)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.Q_Type == Q_Type select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Question> EXM_QuestionGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Questions where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void EXM_QuestionDeletebyEXM_QuestionID(int EXM_QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Questions where p.EXM_QuestionID == EXM_QuestionID select p);
            db.EXM_Answers.DeleteAllOnSubmit((from p in db.EXM_Answers where p.EXM_QuestionID == EXM_QuestionID select p));
            db.EXM_Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_QuestionDeletebyQuestion(string Question)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Questions where p.Question == Question select p);
            db.EXM_Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_QuestionDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Questions where p.LoginUserID == LoginUserID select p);
            db.EXM_Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_QuestionDeletebyExamID(int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Questions where p.ExamID == ExamID select p);
            db.EXM_Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_QuestionDeletebyQ_Type(int Q_Type)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Questions where p.Q_Type == Q_Type select p);
            db.EXM_Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_QuestionDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Questions where p.Description == Description select p);
            db.EXM_Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_QuestionDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Questions where p.ModifiedDate == ModifiedDate select p);
            db.EXM_Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void EXM_QuestionUpdateByEXM_QuestionID(int EXM_QuestionID, string Question, int LoginUserID, int ExamID, int Marks, int Q_Type, string Description, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            EXM_Question data = db.EXM_Questions.Single(p => p.EXM_QuestionID == EXM_QuestionID);
            data.Question = Question;
            data.LoginUserID = LoginUserID;
            data.ExamID = ExamID;
            data.Marks = Marks;
            data.Q_Type = Q_Type;
            data.Description = Description;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void EXM_QuestionUpdateByExamID(int EXM_QuestionID, string Question, int LoginUserID, int ExamID, int Q_Type, string Description, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            EXM_Question data = db.EXM_Questions.Single(p => p.ExamID == ExamID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        #endregion
        #region CustomEXM_Question
        public int EXM_QuestionAdd(string Question, int LoginUserID, int ExamID, int Q_Type, string Description, int Marks, DateTime ModifiedDate)
        {
            EXM_Question ObjEXM_Question = new EXM_Question();
            ObjEXM_Question.Marks = Marks;


            ObjEXM_Question.Question = Question;

            ObjEXM_Question.LoginUserID = LoginUserID;

            ObjEXM_Question.ExamID = ExamID;

            ObjEXM_Question.Q_Type = Q_Type;

            ObjEXM_Question.Description = Description;

            ObjEXM_Question.ModifiedDate = ModifiedDate;

            ObjEXM_Question.IsActive = false;

            
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.EXM_Questions.InsertOnSubmit(ObjEXM_Question);
            var data = (from p in db.EXM_Questions where p.ExamID == ExamID orderby p.Order descending select p).ToList();
            int NextOrder = 1;
            if (data.Count > 0)
            {
                if (data[0].Order != null)
                {
                    NextOrder =(int) data[0].Order++;
                }
            }
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjEXM_Question.EXM_QuestionID;
        }
        public void UpdateQuestionByQuestionID(int QuestionID, bool IsActive)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            EXM_Question data = db.EXM_Questions.Single(p => p.EXM_QuestionID == QuestionID);
            data.IsActive = IsActive;
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        public void QuestionUpdateByQuestionID(int QuestionID, int Order)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            
            db.DeferredLoadingEnabled = false;
            EXM_Question data = db.EXM_Questions.Single(p => p.EXM_QuestionID == QuestionID);
            data.Order = Order;
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        #endregion



        #region EXM_Answer

        public void EXM_AnswerAdd(int EXM_AnswerID, int EXM_QuestionID, string Answer, bool IsRight, DateTime ModifiedDate)
        {
            EXM_Answer ObjEXM_Answer = new EXM_Answer();

            ObjEXM_Answer.EXM_AnswerID = EXM_AnswerID;

            ObjEXM_Answer.EXM_QuestionID = EXM_QuestionID;

            ObjEXM_Answer.Answer = Answer;

            ObjEXM_Answer.IsRight = IsRight;

            ObjEXM_Answer.ModifiedDate = ModifiedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.EXM_Answers.InsertOnSubmit(ObjEXM_Answer);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int EXM_AnswerAdd(int EXM_QuestionID, string Answer, bool IsRight, DateTime ModifiedDate)
        {
            EXM_Answer ObjEXM_Answer = new EXM_Answer();





            ObjEXM_Answer.EXM_QuestionID = EXM_QuestionID;


            ObjEXM_Answer.Answer = Answer;


            ObjEXM_Answer.IsRight = IsRight;


            ObjEXM_Answer.ModifiedDate = ModifiedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.EXM_Answers.InsertOnSubmit(ObjEXM_Answer);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjEXM_Answer.EXM_AnswerID;
        }



        public List<EXM_Answer> EXM_AnswerGet(int PageSize, int PageNumber)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Answer> EXM_AnswerGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<EXM_Answer> EXM_AnswerGetbyEXM_AnswerID(int EXM_AnswerID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.EXM_AnswerID == EXM_AnswerID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Answer> EXM_AnswerGetbyEXM_QuestionID(int EXM_QuestionID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.EXM_QuestionID == EXM_QuestionID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Answer> EXM_AnswerGetbyAnswer(string Answer, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.Answer == Answer select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Answer> EXM_AnswerGetbyIsRight(bool IsRight, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.IsRight == IsRight select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Answer> EXM_AnswerGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<EXM_Answer> EXM_AnswerGetbyEXM_AnswerID(int EXM_AnswerID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.EXM_AnswerID == EXM_AnswerID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Answer> EXM_AnswerGetbyEXM_QuestionID(int EXM_QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.EXM_QuestionID == EXM_QuestionID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Answer> EXM_AnswerGetbyAnswer(string Answer)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.Answer == Answer select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Answer> EXM_AnswerGetbyIsRight(bool IsRight)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.IsRight == IsRight select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_Answer> EXM_AnswerGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_Answers where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void EXM_AnswerDeletebyEXM_AnswerID(int EXM_AnswerID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Answers where p.EXM_AnswerID == EXM_AnswerID select p);
            db.EXM_Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_AnswerDeletebyEXM_QuestionID(int EXM_QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Answers where p.EXM_QuestionID == EXM_QuestionID select p);
            db.EXM_Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_AnswerDeletebyAnswer(string Answer)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Answers where p.Answer == Answer select p);
            db.EXM_Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_AnswerDeletebyIsRight(bool IsRight)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Answers where p.IsRight == IsRight select p);
            db.EXM_Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_AnswerDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Answers where p.ModifiedDate == ModifiedDate select p);
            db.EXM_Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void EXM_AnswerUpdateByEXM_AnswerID(int EXM_AnswerID, int EXM_QuestionID, string Answer, bool IsRight, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            EXM_Answer data = db.EXM_Answers.Single(p => p.EXM_AnswerID == EXM_AnswerID);
            data.EXM_QuestionID = EXM_QuestionID;
            data.Answer = Answer;
            data.IsRight = IsRight;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void EXM_AnswerUpdateByEXM_QuestionID(int EXM_AnswerID, int EXM_QuestionID, string Answer, bool IsRight, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            EXM_Answer data = db.EXM_Answers.Single(p => p.EXM_QuestionID == EXM_QuestionID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        #endregion
        #region CustomEXM_Answer
        public bool IsRightAnswerAdded(int QuestionID)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            var data = (from p in db.EXM_Answers where p.EXM_QuestionID == QuestionID && p.IsRight == true select p).ToList();
            var dataQuestion = (from p in db.EXM_Questions where p.EXM_QuestionID == QuestionID select p).ToList();
            if (dataQuestion[0].Q_Type == 1 || dataQuestion[0].Q_Type == 3)
            {
                if (data.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (dataQuestion[0].Q_Type == 2 || dataQuestion[0].Q_Type == 4)
            {
                if (data.Count > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        #endregion




        #region EXM_UserAnswer

        public void EXM_UserAnswerAdd(int EXM_UserAnswerID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            EXM_UserAnswer ObjEXM_UserAnswer = new EXM_UserAnswer();

            ObjEXM_UserAnswer.EXM_UserAnswerID = EXM_UserAnswerID;

            ObjEXM_UserAnswer.LoginUserID = LoginUserID;

            ObjEXM_UserAnswer.EXM_QuestionID = EXM_QuestionID;

            ObjEXM_UserAnswer.EXM_AnswerID = EXM_AnswerID;

            ObjEXM_UserAnswer.EXM_AnswerText = EXM_AnswerText;

            ObjEXM_UserAnswer.ModifiedDate = ModifiedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.EXM_UserAnswers.InsertOnSubmit(ObjEXM_UserAnswer);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int EXM_UserAnswerAdd(int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            EXM_UserAnswer ObjEXM_UserAnswer = new EXM_UserAnswer();



            ObjEXM_UserAnswer.LoginUserID = LoginUserID;


            ObjEXM_UserAnswer.EXM_QuestionID = EXM_QuestionID;


            ObjEXM_UserAnswer.EXM_AnswerID = EXM_AnswerID;


            ObjEXM_UserAnswer.EXM_AnswerText = EXM_AnswerText;


            ObjEXM_UserAnswer.ModifiedDate = ModifiedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.EXM_UserAnswers.InsertOnSubmit(ObjEXM_UserAnswer);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjEXM_UserAnswer.EXM_UserAnswerID;
        }



        public List<EXM_UserAnswer> EXM_UserAnswerGet(int PageSize, int PageNumber)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_UserAnswers select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.EXM_UserAnswers select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<EXM_UserAnswer> EXM_UserAnswerGetbyEXM_UserAnswerID(int EXM_UserAnswerID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_UserAnswerID == EXM_UserAnswerID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyEXM_QuestionID(int EXM_QuestionID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_QuestionID == EXM_QuestionID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyEXM_AnswerID(int EXM_AnswerID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_AnswerID == EXM_AnswerID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyEXM_AnswerText(string EXM_AnswerText, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_AnswerText == EXM_AnswerText select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<EXM_UserAnswer> EXM_UserAnswerGetbyEXM_UserAnswerID(int EXM_UserAnswerID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_UserAnswerID == EXM_UserAnswerID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyEXM_QuestionID(int EXM_QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_QuestionID == EXM_QuestionID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyEXM_AnswerID(int EXM_AnswerID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_AnswerID == EXM_AnswerID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyEXM_AnswerText(string EXM_AnswerText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_AnswerText == EXM_AnswerText select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void EXM_UserAnswerDeletebyEXM_UserAnswerID(int EXM_UserAnswerID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_UserAnswerID == EXM_UserAnswerID select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_UserAnswerDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.LoginUserID == LoginUserID select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_UserAnswerDeletebyEXM_QuestionID(int EXM_QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_QuestionID == EXM_QuestionID select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_UserAnswerDeletebyEXM_AnswerID(int EXM_AnswerID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_AnswerID == EXM_AnswerID select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_UserAnswerDeletebyEXM_AnswerText(string EXM_AnswerText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_AnswerText == EXM_AnswerText select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_UserAnswerDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.ModifiedDate == ModifiedDate select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void EXM_UserAnswerUpdateByEXM_UserAnswerID(int EXM_UserAnswerID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            EXM_UserAnswer data = db.EXM_UserAnswers.Single(p => p.EXM_UserAnswerID == EXM_UserAnswerID);
            data.LoginUserID = LoginUserID;
            data.EXM_QuestionID = EXM_QuestionID;
            data.EXM_AnswerID = EXM_AnswerID;
            data.EXM_AnswerText = EXM_AnswerText;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void EXM_UserAnswerUpdateByLoginUserID(int EXM_UserAnswerID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            EXM_UserAnswer data = db.EXM_UserAnswers.Single(p => p.LoginUserID == LoginUserID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }


        public void EXM_UserAnswerUpdateByEXM_AnswerID(int EXM_UserAnswerID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            EXM_UserAnswer data = db.EXM_UserAnswers.Single(p => p.EXM_AnswerID == EXM_AnswerID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        #endregion
        #region CustomEXM_UserAnswer
        #endregion
	
	
	
	






    }
}
