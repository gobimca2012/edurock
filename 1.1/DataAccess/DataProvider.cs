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

        public int ExamAdd(string ExamName, string SubjectName, int LoginUserID, string Description, TimeSpan ExamTime, DateTime ModifiedDate, DateTime StartDate, DateTime EndDate)
        {
            Exam ObjExam = new Exam();

            ObjExam.Description = Description;

            ObjExam.ExamName = ExamName;

            ObjExam.SubjectName = SubjectName;

            ObjExam.LoginUserID = LoginUserID;

            ObjExam.ModifiedDate = ModifiedDate;
            ObjExam.ExamTime = ExamTime.ToString();
            ObjExam.IsActive = false;
            ObjExam.StartDate = StartDate;
            ObjExam.EndDate = EndDate;
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



        public void ExamUpdateByExamID(int ExamID, string ExamName, string SubjectName, int LoginUserID, string Description, DateTime ModifiedDate)
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
        public void ExamUpdateByExamID(int ExamID, string ExamName, string SubjectName, int LoginUserID, string Description, TimeSpan ExamTime, DateTime ModifiedDate, DateTime StartDate, DateTime EndDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            Exam data = db.Exams.Single(p => p.ExamID == ExamID);
            data.ExamName = ExamName;
            data.Description = Description;
            data.SubjectName = SubjectName;
            data.LoginUserID = LoginUserID;
            data.ModifiedDate = ModifiedDate;
            data.ExamTime = ExamTime.ToString();
            data.StartDate = StartDate;
            data.EndDate = EndDate;
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
                    NextOrder = (int)data[0].Order++;
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
        public int EXM_AnswerAdd(int EXM_QuestionID, string Answer, bool IsRight,decimal Marks, DateTime ModifiedDate)
        {
            EXM_Answer ObjEXM_Answer = new EXM_Answer();


            ObjEXM_Answer.Marks = Marks;


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
        public void EXM_UserAnswerUpdateByQuestionID(int QuestionID, int AnswerID, int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_QuestionID == QuestionID && p.LoginUserID==LoginUserID select p).ToList();
            if (data.Count > 0)
            {
                EXM_UserAnswer exmData = data[0];
                exmData.EXM_AnswerID = AnswerID;

            }
            else
            {
                EXM_UserAnswer newAnswer = new EXM_UserAnswer();
                newAnswer.EXM_AnswerID = AnswerID;
                newAnswer.EXM_AnswerText = "";
                newAnswer.EXM_QuestionID = QuestionID;
                newAnswer.LoginUserID = LoginUserID;
                newAnswer.ModifiedDate = DateTime.Now;
                db.EXM_UserAnswers.InsertOnSubmit(newAnswer);
            }
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        public List<EXM_UserAnswer> EXM_UserAnswerGets(int EXM_QuestionID,int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_QuestionID == EXM_QuestionID && p.LoginUserID==LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public void EXM_UserAnswerDelete(int EXM_QuestionID,int LoginUserId)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_QuestionID == EXM_QuestionID && p.LoginUserID==LoginUserId select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        #endregion




        #region UserExam

        public void UserExamAdd(int UserExamID, int LoginUserID, int ExamID, DateTime StartTime, DateTime EndDate, DateTime ModifiedDate)
        {
            UserExam ObjUserExam = new UserExam();

            ObjUserExam.UserExamID = UserExamID;

            ObjUserExam.LoginUserID = LoginUserID;

            ObjUserExam.ExamID = ExamID;

            ObjUserExam.StartTime = StartTime;

            ObjUserExam.EndDate = EndDate;

            ObjUserExam.ModifiedDate = ModifiedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.UserExams.InsertOnSubmit(ObjUserExam);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int UserExamAdd(int LoginUserID, int ExamID, DateTime StartTime, DateTime EndDate, DateTime ModifiedDate)
        {
            UserExam ObjUserExam = new UserExam();



            ObjUserExam.LoginUserID = LoginUserID;


            ObjUserExam.ExamID = ExamID;


            ObjUserExam.StartTime = StartTime;


            ObjUserExam.EndDate = EndDate;


            ObjUserExam.ModifiedDate = ModifiedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.UserExams.InsertOnSubmit(ObjUserExam);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjUserExam.UserExamID;
        }



        public List<UserExam> UserExamGet(int PageSize, int PageNumber)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.UserExams select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.UserExams select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<UserExam> UserExamGetbyUserExamID(int UserExamID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.UserExamID == UserExamID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyExamID(int ExamID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.ExamID == ExamID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyStartTime(DateTime StartTime, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.StartTime == StartTime select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyEndDate(DateTime EndDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.EndDate == EndDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<UserExam> UserExamGetbyUserExamID(int UserExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.UserExamID == UserExamID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyExamID(int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.ExamID == ExamID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyStartTime(DateTime StartTime)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.StartTime == StartTime select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyEndDate(DateTime EndDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.EndDate == EndDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserExam> UserExamGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void UserExamDeletebyUserExamID(int UserExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.UserExamID == UserExamID select p);
            db.UserExams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserExamDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.LoginUserID == LoginUserID select p);
            db.UserExams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserExamDeletebyExamID(int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.ExamID == ExamID select p);
            db.UserExams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserExamDeletebyStartTime(DateTime StartTime)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.StartTime == StartTime select p);
            db.UserExams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserExamDeletebyEndDate(DateTime EndDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.EndDate == EndDate select p);
            db.UserExams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserExamDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.ModifiedDate == ModifiedDate select p);
            db.UserExams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void UserExamUpdateByUserExamID(int UserExamID, int LoginUserID, int ExamID, DateTime StartTime, DateTime EndDate, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            UserExam data = db.UserExams.Single(p => p.UserExamID == UserExamID);
            data.LoginUserID = LoginUserID;
            data.ExamID = ExamID;
            data.StartTime = StartTime;
            data.EndDate = EndDate;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void UserExamUpdateByLoginUserID(int UserExamID, int LoginUserID, int ExamID, DateTime StartTime, DateTime EndDate, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            UserExam data = db.UserExams.Single(p => p.LoginUserID == LoginUserID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        #endregion
        #region CustomUserExam
        public List<UserExam> UserExamGetbyExamID(int ExamID, int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.ExamID == ExamID && p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<ExamUserByExamIDResult> ExamUserByExamID(int ExamID)
        {

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.ExamUserByExamID(ExamID).ToList();

        }
        public List<ExamUserByExamIDResult> ExamUserByExamID(int ExamID, int PageSize, int PageNumber)
        {

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.ExamUserByExamID(ExamID).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }

        public void UserExamUpdate(int ExamID,int UserExamID,bool IsFinish)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            UserExam data = db.UserExams.Single(p => p.ExamID == ExamID && p.UserExamID==UserExamID);
            data.IsFinish = IsFinish;
            data.ModifiedDate = DateTime.Now;
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        public List<UserExam> UserExamGetByLoginUserID(int LoginUserID, int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();            
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.UserExams where p.LoginUserID==LoginUserID && p.ExamID==ExamID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        public List<GetExamResultByLoginUserIDResult> GetExamResultByLoginUserID(int LoginUserID, int ExamID)
        {

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();     
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetExamResultByLoginUserID(LoginUserID, ExamID).ToList();

        }
        public List<GetExamResultByLoginUserIDResult> GetExamResultByLoginUserID(int LoginUserID, int ExamID, int PageSize, int PageNumber)
        {

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();     
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetExamResultByLoginUserID(LoginUserID, ExamID).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }
        #endregion



        #region User

        public void UserAdd(int UserID, int LoginUserID, string FirstName, string LastName, string MiddleName, DateTime BirthDate, string Address1, string Address2, string City, string State, string Country, string WebSite, DateTime ModifiedDate)
        {
            User ObjUser = new User();

            ObjUser.UserID = UserID;

            ObjUser.LoginUserID = LoginUserID;

            ObjUser.FirstName = FirstName;

            ObjUser.LastName = LastName;

            ObjUser.MiddleName = MiddleName;

            ObjUser.BirthDate = BirthDate;

            ObjUser.Address1 = Address1;

            ObjUser.Address2 = Address2;

            ObjUser.City = City;

            ObjUser.State = State;

            ObjUser.Country = Country;

            ObjUser.WebSite = WebSite;

            ObjUser.ModifiedDate = ModifiedDate;

            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Users.InsertOnSubmit(ObjUser);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int UserAdd(int LoginUserID, string FirstName, string LastName, string MiddleName, DateTime BirthDate, string Address1, string Address2, string City, string State, string Country, string WebSite, DateTime ModifiedDate)
        {

            User ObjUser = new User();

            ObjUser.LoginUserID = LoginUserID;


            ObjUser.FirstName = FirstName;


            ObjUser.LastName = LastName;


            ObjUser.MiddleName = MiddleName;


            ObjUser.BirthDate = BirthDate;


            ObjUser.Address1 = Address1;


            ObjUser.Address2 = Address2;


            ObjUser.City = City;


            ObjUser.State = State;


            ObjUser.Country = Country;


            ObjUser.WebSite = WebSite;


            ObjUser.ModifiedDate = ModifiedDate;

            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Users.InsertOnSubmit(ObjUser);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjUser.UserID;
        }



        public List<User> UserGet(int PageSize, int PageNumber)
        {
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Users select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Users select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<User> UserGetbyUserID(int UserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.UserID == UserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyFirstName(string FirstName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.FirstName == FirstName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyLastName(string LastName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.LastName == LastName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyMiddleName(string MiddleName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.MiddleName == MiddleName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyBirthDate(DateTime BirthDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.BirthDate == BirthDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyAddress1(string Address1, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.Address1 == Address1 select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyAddress2(string Address2, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.Address2 == Address2 select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyCity(string City, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.City == City select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyState(string State, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.State == State select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyCountry(string Country, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.Country == Country select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyWebSite(string WebSite, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.WebSite == WebSite select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<User> UserGetbyUserID(int UserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.UserID == UserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyFirstName(string FirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.FirstName == FirstName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyLastName(string LastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.LastName == LastName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyMiddleName(string MiddleName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.MiddleName == MiddleName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyBirthDate(DateTime BirthDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.BirthDate == BirthDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyAddress1(string Address1)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.Address1 == Address1 select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyAddress2(string Address2)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.Address2 == Address2 select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyCity(string City)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.City == City select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyState(string State)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.State == State select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyCountry(string Country)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.Country == Country select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyWebSite(string WebSite)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.WebSite == WebSite select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<User> UserGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void UserDeletebyUserID(int UserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.UserID == UserID select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.LoginUserID == LoginUserID select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyFirstName(string FirstName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.FirstName == FirstName select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyLastName(string LastName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.LastName == LastName select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyMiddleName(string MiddleName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.MiddleName == MiddleName select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyBirthDate(DateTime BirthDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.BirthDate == BirthDate select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyAddress1(string Address1)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.Address1 == Address1 select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyAddress2(string Address2)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.Address2 == Address2 select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyCity(string City)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.City == City select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyState(string State)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.State == State select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyCountry(string Country)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.Country == Country select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyWebSite(string WebSite)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.WebSite == WebSite select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Users where p.ModifiedDate == ModifiedDate select p);
            db.Users.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void UserUpdateByUserID(int UserID, int LoginUserID, string FirstName, string LastName, string MiddleName, DateTime BirthDate, string Address1, string Address2, string City, string State, string Country, string WebSite, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            User data = db.Users.Single(p => p.UserID == UserID);
            data.LoginUserID = LoginUserID;
            data.FirstName = FirstName;
            data.LastName = LastName;
            data.MiddleName = MiddleName;
            data.BirthDate = BirthDate;
            data.Address1 = Address1;
            data.Address2 = Address2;
            data.City = City;
            data.State = State;
            data.Country = Country;
            data.WebSite = WebSite;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void UserUpdateByLoginUserID(int UserID, int LoginUserID, string FirstName, string LastName, string MiddleName, DateTime BirthDate, string Address1, string Address2, string City, string State, string Country, string WebSite, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            User data = db.Users.Single(p => p.LoginUserID == LoginUserID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        #endregion
        #region CustomUser
        public int UserAdd(int LoginUserID, string FirstName, string LastName, string MiddleName, DateTime BirthDate, string Address1, string Address2, string City, string State, string Country, string WebSite)
        {
            UserDataContext db = new UserDataContext();
            var data = (from p in db.Users where p.LoginUserID == LoginUserID select p).ToList();
            User ObjUser = new User();
            if (data.Count > 0)
            {
                ObjUser = data[0];
            }
            ObjUser.LoginUserID = LoginUserID;


            ObjUser.FirstName = FirstName;


            ObjUser.LastName = LastName;


            ObjUser.MiddleName = MiddleName;


            ObjUser.BirthDate = BirthDate;


            ObjUser.Address1 = Address1;


            ObjUser.Address2 = Address2;


            ObjUser.City = City;


            ObjUser.State = State;


            ObjUser.Country = Country;


            ObjUser.WebSite = WebSite;


            ObjUser.ModifiedDate = DateTime.Now;



            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            if (data.Count > 0)
            {
                ObjUser = data[0];
            }
            else
            {
                db.Users.InsertOnSubmit(ObjUser);
            }
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjUser.UserID;
        }
        #endregion


        #region UserEducation

        public void UserEducationAdd(int UserEducationID, int LoginUserID, string InstitueName, string SubjectName, string Year, DateTime ModifiedDate)
        {
            UserEducation ObjUserEducation = new UserEducation();

            ObjUserEducation.UserEducationID = UserEducationID;

            ObjUserEducation.LoginUserID = LoginUserID;

            ObjUserEducation.InstitueName = InstitueName;

            ObjUserEducation.SubjectName = SubjectName;

            ObjUserEducation.Year = Year;

            ObjUserEducation.ModifiedDate = ModifiedDate;

            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.UserEducations.InsertOnSubmit(ObjUserEducation);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int UserEducationAdd(int LoginUserID, string InstitueName, string SubjectName, string Year, DateTime ModifiedDate)
        {
            UserEducation ObjUserEducation = new UserEducation();



            ObjUserEducation.LoginUserID = LoginUserID;


            ObjUserEducation.InstitueName = InstitueName;


            ObjUserEducation.SubjectName = SubjectName;


            ObjUserEducation.Year = Year;


            ObjUserEducation.ModifiedDate = ModifiedDate;

            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.UserEducations.InsertOnSubmit(ObjUserEducation);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjUserEducation.UserEducationID;
        }



        public List<UserEducation> UserEducationGet(int PageSize, int PageNumber)
        {
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.UserEducations select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.UserEducations select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<UserEducation> UserEducationGetbyUserEducationID(int UserEducationID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.UserEducationID == UserEducationID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbyInstitueName(string InstitueName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.InstitueName == InstitueName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbySubjectName(string SubjectName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.SubjectName == SubjectName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbyYear(string Year, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.Year == Year select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<UserEducation> UserEducationGetbyUserEducationID(int UserEducationID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.UserEducationID == UserEducationID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbyInstitueName(string InstitueName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.InstitueName == InstitueName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbySubjectName(string SubjectName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.SubjectName == SubjectName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbyYear(string Year)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.Year == Year select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<UserEducation> UserEducationGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void UserEducationDeletebyUserEducationID(int UserEducationID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.UserEducationID == UserEducationID select p);
            db.UserEducations.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserEducationDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.LoginUserID == LoginUserID select p);
            db.UserEducations.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserEducationDeletebyInstitueName(string InstitueName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.InstitueName == InstitueName select p);
            db.UserEducations.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserEducationDeletebySubjectName(string SubjectName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.SubjectName == SubjectName select p);
            db.UserEducations.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserEducationDeletebyYear(string Year)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.Year == Year select p);
            db.UserEducations.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void UserEducationDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserEducations where p.ModifiedDate == ModifiedDate select p);
            db.UserEducations.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void UserEducationUpdateByUserEducationID(int UserEducationID, int LoginUserID, string InstitueName, string SubjectName, string Year, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            UserEducation data = db.UserEducations.Single(p => p.UserEducationID == UserEducationID);
            data.LoginUserID = LoginUserID;
            data.InstitueName = InstitueName;
            data.SubjectName = SubjectName;
            data.Year = Year;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void UserEducationUpdateByLoginUserID(int UserEducationID, int LoginUserID, string InstitueName, string SubjectName, string Year, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            UserEducation data = db.UserEducations.Single(p => p.LoginUserID == LoginUserID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        #endregion
        #region CustomUserEducation
        public int UserEducationAdd(int LoginUserID, string InstitueName, string SubjectName, string Year)
        {
            UserEducation ObjUserEducation = new UserEducation();
            var data = UserEducationGetbyLoginUserID(LoginUserID);
            if (data.Count > 0)
            {
                ObjUserEducation = data[0];
            }

            ObjUserEducation.LoginUserID = LoginUserID;


            ObjUserEducation.InstitueName = InstitueName;


            ObjUserEducation.SubjectName = SubjectName;


            ObjUserEducation.Year = Year;


            ObjUserEducation.ModifiedDate = DateTime.Now;

            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            if (data.Count == 0)
            {
                db.UserEducations.InsertOnSubmit(ObjUserEducation);
            }
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjUserEducation.UserEducationID;
        }
        #endregion



        #region Institute

        public void InstituteAdd(int InstituteID, int LoginUserID, string Name, string Address, string CityName, string StateName, string CountryName, string TelePhone, string Fax, string Email, string WebSite, int CollegeType, string ShortName, string Description, DateTime ModifiedDate, bool IsDeleted)
        {
            Institute ObjInstitute = new Institute();

            ObjInstitute.InstituteID = InstituteID;

            ObjInstitute.LoginUserID = LoginUserID;

            ObjInstitute.Name = Name;

            ObjInstitute.Address = Address;

            ObjInstitute.CityName = CityName;

            ObjInstitute.StateName = StateName;

            ObjInstitute.CountryName = CountryName;

            ObjInstitute.TelePhone = TelePhone;

            ObjInstitute.Fax = Fax;

            ObjInstitute.Email = Email;

            ObjInstitute.WebSite = WebSite;

            ObjInstitute.CollegeType = CollegeType;

            ObjInstitute.ShortName = ShortName;

            ObjInstitute.Description = Description;

            ObjInstitute.ModifiedDate = ModifiedDate;

            ObjInstitute.IsDeleted = IsDeleted;

            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Institutes.InsertOnSubmit(ObjInstitute);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int InstituteAdd(int LoginUserID, string Name, string Address, string CityName, string StateName, string CountryName, string TelePhone, string Fax, string Email, string WebSite, int CollegeType, string ShortName, string Description, DateTime ModifiedDate, bool IsDeleted)
        {
            Institute ObjInstitute = new Institute();

            ObjInstitute.LoginUserID = LoginUserID;


            ObjInstitute.Name = Name;


            ObjInstitute.Address = Address;


            ObjInstitute.CityName = CityName;


            ObjInstitute.StateName = StateName;


            ObjInstitute.CountryName = CountryName;


            ObjInstitute.TelePhone = TelePhone;


            ObjInstitute.Fax = Fax;


            ObjInstitute.Email = Email;


            ObjInstitute.WebSite = WebSite;


            ObjInstitute.CollegeType = CollegeType;


            ObjInstitute.ShortName = ShortName;


            ObjInstitute.Description = Description;


            ObjInstitute.ModifiedDate = ModifiedDate;


            ObjInstitute.IsDeleted = IsDeleted;

            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Institutes.InsertOnSubmit(ObjInstitute);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjInstitute.InstituteID;
        }



        public List<Institute> InstituteGet(int PageSize, int PageNumber)
        {
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Institutes select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Institutes select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Institute> InstituteGetbyInstituteID(int InstituteID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.InstituteID == InstituteID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyName(string Name, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyAddress(string Address, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Address == Address select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCityName(string CityName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CityName == CityName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyStateName(string StateName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.StateName == StateName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCountryName(string CountryName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CountryName == CountryName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyTelePhone(string TelePhone, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.TelePhone == TelePhone select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyFax(string Fax, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Fax == Fax select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyEmail(string Email, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Email == Email select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyWebSite(string WebSite, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.WebSite == WebSite select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCollegeType(int CollegeType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CollegeType == CollegeType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyShortName(string ShortName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ShortName == ShortName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyIsDeleted(bool IsDeleted, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.IsDeleted == IsDeleted select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Institute> InstituteGetbyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.InstituteID == InstituteID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Name == Name select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyAddress(string Address)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Address == Address select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCityName(string CityName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CityName == CityName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyStateName(string StateName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.StateName == StateName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCountryName(string CountryName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CountryName == CountryName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyTelePhone(string TelePhone)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.TelePhone == TelePhone select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Fax == Fax select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyEmail(string Email)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Email == Email select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyWebSite(string WebSite)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.WebSite == WebSite select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCollegeType(int CollegeType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CollegeType == CollegeType select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyShortName(string ShortName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ShortName == ShortName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyIsDeleted(bool IsDeleted)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.IsDeleted == IsDeleted select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void InstituteDeletebyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.InstituteID == InstituteID select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.LoginUserID == LoginUserID select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Name == Name select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyAddress(string Address)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Address == Address select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyCityName(string CityName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CityName == CityName select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyStateName(string StateName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.StateName == StateName select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyCountryName(string CountryName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CountryName == CountryName select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyTelePhone(string TelePhone)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.TelePhone == TelePhone select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Fax == Fax select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyEmail(string Email)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Email == Email select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyWebSite(string WebSite)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.WebSite == WebSite select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyCollegeType(int CollegeType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CollegeType == CollegeType select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyShortName(string ShortName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ShortName == ShortName select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Description == Description select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ModifiedDate == ModifiedDate select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyIsDeleted(bool IsDeleted)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.IsDeleted == IsDeleted select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void InstituteUpdateByInstituteID(int InstituteID, int LoginUserID, string Name, string Address, string CityName, string StateName, string CountryName, string TelePhone, string Fax, string Email, string WebSite, int CollegeType, string ShortName, string Description, DateTime ModifiedDate, bool IsDeleted)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            Institute data = db.Institutes.Single(p => p.InstituteID == InstituteID);
            data.LoginUserID = LoginUserID;
            data.Name = Name;
            data.Address = Address;
            data.CityName = CityName;
            data.StateName = StateName;
            data.CountryName = CountryName;
            data.TelePhone = TelePhone;
            data.Fax = Fax;
            data.Email = Email;
            data.WebSite = WebSite;
            data.CollegeType = CollegeType;
            data.ShortName = ShortName;
            data.Description = Description;
            data.ModifiedDate = ModifiedDate;
            data.IsDeleted = IsDeleted;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void InstituteUpdateByLoginUserID(int InstituteID, int LoginUserID, string Name, string Address, string CityName, string StateName, string CountryName, string TelePhone, string Fax, string Email, string WebSite, int CollegeType, string ShortName, string Description, DateTime ModifiedDate, bool IsDeleted)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            Institute data = db.Institutes.Single(p => p.LoginUserID == LoginUserID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        #endregion
        #region CustomInstitute

        public int InstituteAdd(int LoginUserID, string Name, string Address, string CityName, string StateName, string CountryName, string TelePhone, string Fax, string Email, string WebSite, int CollegeType, string ShortName, string Description, DateTime ModifiedDate, bool IsDeleted,bool IsEdit)
        {
            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            Institute ObjInstitute = new Institute();
            if (IsEdit)
            {
                var data = (from p in db.Institutes where p.LoginUserID == LoginUserID select p).ToList();
                ObjInstitute = data[0];
            }

            ObjInstitute.LoginUserID = LoginUserID;

            ObjInstitute.Name = Name;


            ObjInstitute.Address = Address;


            ObjInstitute.CityName = CityName;


            ObjInstitute.StateName = StateName;


            ObjInstitute.CountryName = CountryName;


            ObjInstitute.TelePhone = TelePhone;


            ObjInstitute.Fax = Fax;


            ObjInstitute.Email = Email;


            ObjInstitute.WebSite = WebSite;


            ObjInstitute.CollegeType = CollegeType;


            ObjInstitute.ShortName = ShortName;


            ObjInstitute.Description = Description;


            ObjInstitute.ModifiedDate = ModifiedDate;


            ObjInstitute.IsDeleted = IsDeleted;

            

            
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            if (!IsEdit)
            {
                db.Institutes.InsertOnSubmit(ObjInstitute);
            }
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjInstitute.InstituteID;
        }
        #endregion
	
	












    }
}
