﻿using System;
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

        public void ExamAdd(int ExamID, string ExamName, string SubjectName, int InstituteCourceID, int InstituteSubjectID, string Description, int LoginUserID, DateTime ModifiedDate, string ExamTime, bool IsActive, int RequirePecentage, DateTime StartDate, DateTime EndDate)
        {
            Exam ObjExam = new Exam();

            ObjExam.ExamID = ExamID;

            ObjExam.ExamName = ExamName;

            ObjExam.SubjectName = SubjectName;

            ObjExam.InstituteCourceID = InstituteCourceID;

            ObjExam.InstituteSubjectID = InstituteSubjectID;

            ObjExam.Description = Description;

            ObjExam.LoginUserID = LoginUserID;

            ObjExam.ModifiedDate = ModifiedDate;

            ObjExam.ExamTime = ExamTime;

            ObjExam.IsActive = IsActive;

            ObjExam.RequirePecentage = RequirePecentage;

            ObjExam.StartDate = StartDate;

            ObjExam.EndDate = EndDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Exams.InsertOnSubmit(ObjExam);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int ExamAdd(string ExamName, string SubjectName, int InstituteCourceID, int InstituteSubjectID, string Description, int LoginUserID, DateTime ModifiedDate, string ExamTime, bool IsActive, int RequirePecentage, DateTime StartDate, DateTime EndDate)
        {
            Exam ObjExam = new Exam();



            ObjExam.ExamName = ExamName;


            ObjExam.SubjectName = SubjectName;


            ObjExam.InstituteCourceID = InstituteCourceID;


            ObjExam.InstituteSubjectID = InstituteSubjectID;


            ObjExam.Description = Description;


            ObjExam.LoginUserID = LoginUserID;


            ObjExam.ModifiedDate = ModifiedDate;


            ObjExam.ExamTime = ExamTime;


            ObjExam.IsActive = IsActive;


            ObjExam.RequirePecentage = RequirePecentage;


            ObjExam.StartDate = StartDate;


            ObjExam.EndDate = EndDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Exams.InsertOnSubmit(ObjExam);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjExam.ExamID;
        }



        public List<Exam> ExamGet(int PageSize, int PageNumber)
        {
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
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
            db.DeferredLoadingEnabled = false;
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
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ExamID == ExamID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyExamName(string ExamName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ExamName == ExamName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbySubjectName(string SubjectName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.SubjectName == SubjectName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyInstituteCourceID(int InstituteCourceID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.InstituteCourceID == InstituteCourceID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyInstituteSubjectID(int InstituteSubjectID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.InstituteSubjectID == InstituteSubjectID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyExamTime(string ExamTime, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ExamTime == ExamTime select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyIsActive(bool IsActive, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.IsActive == IsActive select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyRequirePecentage(int RequirePecentage, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.RequirePecentage == RequirePecentage select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyStartDate(DateTime StartDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.StartDate == StartDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyEndDate(DateTime EndDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.EndDate == EndDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Exam> ExamGetbyExamID(int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ExamID == ExamID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyExamName(string ExamName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ExamName == ExamName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbySubjectName(string SubjectName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.SubjectName == SubjectName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyInstituteCourceID(int InstituteCourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.InstituteCourceID == InstituteCourceID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyInstituteSubjectID(int InstituteSubjectID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.InstituteSubjectID == InstituteSubjectID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyExamTime(string ExamTime)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ExamTime == ExamTime select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyIsActive(bool IsActive)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.IsActive == IsActive select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyRequirePecentage(int RequirePecentage)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.RequirePecentage == RequirePecentage select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyStartDate(DateTime StartDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.StartDate == StartDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Exam> ExamGetbyEndDate(DateTime EndDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.EndDate == EndDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void ExamDeletebyExamID(int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ExamID == ExamID select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyExamName(string ExamName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ExamName == ExamName select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebySubjectName(string SubjectName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.SubjectName == SubjectName select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyInstituteCourceID(int InstituteCourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.InstituteCourceID == InstituteCourceID select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyInstituteSubjectID(int InstituteSubjectID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.InstituteSubjectID == InstituteSubjectID select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.Description == Description select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.LoginUserID == LoginUserID select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ModifiedDate == ModifiedDate select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyExamTime(string ExamTime)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.ExamTime == ExamTime select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyIsActive(bool IsActive)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.IsActive == IsActive select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyRequirePecentage(int RequirePecentage)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.RequirePecentage == RequirePecentage select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyStartDate(DateTime StartDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.StartDate == StartDate select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void ExamDeletebyEndDate(DateTime EndDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Exams where p.EndDate == EndDate select p);
            db.Exams.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void ExamUpdateByExamID(int ExamID, string ExamName, string SubjectName, int InstituteCourceID, int InstituteSubjectID, string Description, int LoginUserID, DateTime ModifiedDate, string ExamTime, bool IsActive, int RequirePecentage, DateTime StartDate, DateTime EndDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            Exam data = db.Exams.Single(p => p.ExamID == ExamID);
            data.ExamName = ExamName;
            data.SubjectName = SubjectName;
            data.InstituteCourceID = InstituteCourceID;
            data.InstituteSubjectID = InstituteSubjectID;
            data.Description = Description;
            data.LoginUserID = LoginUserID;
            data.ModifiedDate = ModifiedDate;
            data.ExamTime = ExamTime;
            data.IsActive = IsActive;
            data.RequirePecentage = RequirePecentage;
            data.StartDate = StartDate;
            data.EndDate = EndDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomExam
        #endregion
	
	
        #region CustomExam
        public Decimal GetExamTotalmark(int ExamID)
        {

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return (Decimal)db.GetExamTotalmark(ExamID);

        }

        public int ExamAdd(string ExamName, string SubjectName, int LoginUserID, string Description, TimeSpan ExamTime, DateTime ModifiedDate, DateTime StartDate, DateTime EndDate, int Percentage)
        {
            Exam ObjExam = new Exam();

            ObjExam.Description = Description;

            ObjExam.ExamName = ExamName;
            ObjExam.RequirePecentage = Percentage;

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
        public void ExamUpdateByExamID(int ExamID, string ExamName, string SubjectName, int LoginUserID, string Description, TimeSpan ExamTime, DateTime ModifiedDate, DateTime StartDate, DateTime EndDate, int Percent)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            Exam data = db.Exams.Single(p => p.ExamID == ExamID);
            data.ExamName = ExamName;
            data.RequirePecentage = Percent;
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
        public int EXM_AnswerAdd(int EXM_QuestionID, string Answer, bool IsRight, decimal Marks, DateTime ModifiedDate)
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

        public void EXM_UserAnswerAdd(int EXM_UserAnswerID, int UserExamID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            EXM_UserAnswer ObjEXM_UserAnswer = new EXM_UserAnswer();

            ObjEXM_UserAnswer.EXM_UserAnswerID = EXM_UserAnswerID;

            ObjEXM_UserAnswer.UserExamID = UserExamID;

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
        }

        public int EXM_UserAnswerAdd(int UserExamID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            EXM_UserAnswer ObjEXM_UserAnswer = new EXM_UserAnswer();



            ObjEXM_UserAnswer.UserExamID = UserExamID;


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

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyUserExamID(int UserExamID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.UserExamID == UserExamID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
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

        public List<EXM_UserAnswer> EXM_UserAnswerGetbyUserExamID(int UserExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.UserExamID == UserExamID select p).ToList();
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

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_UserAnswerID == EXM_UserAnswerID select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_UserAnswerDeletebyUserExamID(int UserExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.UserExamID == UserExamID select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void EXM_UserAnswerDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

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

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.ModifiedDate == ModifiedDate select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void EXM_UserAnswerUpdateByEXM_UserAnswerID(int EXM_UserAnswerID, int UserExamID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            EXM_UserAnswer data = db.EXM_UserAnswers.Single(p => p.EXM_UserAnswerID == EXM_UserAnswerID);
            data.UserExamID = UserExamID;
            data.LoginUserID = LoginUserID;
            data.EXM_QuestionID = EXM_QuestionID;
            data.EXM_AnswerID = EXM_AnswerID;
            data.EXM_AnswerText = EXM_AnswerText;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void EXM_UserAnswerUpdateByLoginUserID(int EXM_UserAnswerID, int UserExamID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            EXM_UserAnswer data = db.EXM_UserAnswers.Single(p => p.LoginUserID == LoginUserID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }


        public void EXM_UserAnswerUpdateByEXM_AnswerID(int EXM_UserAnswerID, int UserExamID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
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
        public int EXM_UserAnswerAddwithMarkCalculation(int UserExamID, int LoginUserID, int EXM_QuestionID, int EXM_AnswerID, string EXM_AnswerText, DateTime ModifiedDate)
        {
            EXM_UserAnswer ObjEXM_UserAnswer = new EXM_UserAnswer();



            ObjEXM_UserAnswer.UserExamID = UserExamID;


            ObjEXM_UserAnswer.LoginUserID = LoginUserID;


            ObjEXM_UserAnswer.EXM_QuestionID = EXM_QuestionID;


            ObjEXM_UserAnswer.EXM_AnswerID = EXM_AnswerID;


            ObjEXM_UserAnswer.EXM_AnswerText = EXM_AnswerText;


            ObjEXM_UserAnswer.ModifiedDate = ModifiedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<EXM_Answer>(p => p.EXM_Question);
            db.LoadOptions = option;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_Answers where p.EXM_QuestionID == EXM_QuestionID && p.IsRight == true select p);
            decimal TempMark = 0;
            decimal questionMarks = 0;
            foreach (EXM_Answer rightAnswer in data)
            {
                questionMarks = (decimal)rightAnswer.EXM_Question.Marks;
                if (rightAnswer.EXM_AnswerID == EXM_AnswerID)
                {
                    TempMark = (decimal)questionMarks;

                }

            }
            if (TempMark > 0)
            {
                ObjEXM_UserAnswer.RecieveMark = (decimal)TempMark;
                ObjEXM_UserAnswer.IsRightMark = true;
            }
            else
            {
                ObjEXM_UserAnswer.RecieveMark = questionMarks * (-1);
                ObjEXM_UserAnswer.IsRightMark = false;
            }

            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.EXM_UserAnswers.InsertOnSubmit(ObjEXM_UserAnswer);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjEXM_UserAnswer.EXM_UserAnswerID;
        }
        public void EXM_UserAnswerUpdateByQuestionID(int QuestionID, int AnswerID, int LoginUserID, int UserExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_QuestionID == QuestionID && p.LoginUserID == LoginUserID && p.UserExamID == UserExamID select p).ToList();
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
                newAnswer.UserExamID = UserExamID;
                newAnswer.EXM_QuestionID = QuestionID;
                newAnswer.LoginUserID = LoginUserID;
                newAnswer.ModifiedDate = DateTime.Now;
                db.EXM_UserAnswers.InsertOnSubmit(newAnswer);
            }
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        public List<EXM_UserAnswer> EXM_UserAnswerGets(int EXM_QuestionID, int LoginUserID, int UserExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_QuestionID == EXM_QuestionID && p.LoginUserID == LoginUserID && p.UserExamID == UserExamID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public void EXM_UserAnswerDelete(int EXM_QuestionID, int LoginUserId, int UserExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.EXM_UserAnswers where p.EXM_QuestionID == EXM_QuestionID && p.LoginUserID == LoginUserId && p.UserExamID == UserExamID select p);
            db.EXM_UserAnswers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        #endregion





        #region UserExam

        public void UserExamAdd(int UserExamID, int LoginUserID, int ExamID, DateTime StartTime, DateTime EndDate, bool IsFinish, DateTime ModifiedDate)
        {
            UserExam ObjUserExam = new UserExam();

            ObjUserExam.UserExamID = UserExamID;

            ObjUserExam.LoginUserID = LoginUserID;

            ObjUserExam.ExamID = ExamID;

            ObjUserExam.StartTime = StartTime;

            ObjUserExam.EndDate = EndDate;

            ObjUserExam.IsFinish = IsFinish;

            ObjUserExam.ModifiedDate = ModifiedDate;

            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.UserExams.InsertOnSubmit(ObjUserExam);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int UserExamAdd(int LoginUserID, int ExamID, DateTime StartTime, DateTime EndDate, bool IsFinish, DateTime ModifiedDate)
        {
            UserExam ObjUserExam = new UserExam();



            ObjUserExam.LoginUserID = LoginUserID;


            ObjUserExam.ExamID = ExamID;


            ObjUserExam.StartTime = StartTime;


            ObjUserExam.EndDate = EndDate;


            ObjUserExam.IsFinish = IsFinish;


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

        public List<UserExam> UserExamGetbyIsFinish(bool IsFinish, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.IsFinish == IsFinish select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
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

        public List<UserExam> UserExamGetbyIsFinish(bool IsFinish)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.IsFinish == IsFinish select p).ToList();
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

        public void UserExamDeletebyIsFinish(bool IsFinish)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.UserExams where p.IsFinish == IsFinish select p);
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



        public void UserExamUpdateByUserExamID(int UserExamID, int LoginUserID, int ExamID, DateTime StartTime, DateTime EndDate, bool IsFinish, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            UserExam data = db.UserExams.Single(p => p.UserExamID == UserExamID);
            data.LoginUserID = LoginUserID;
            data.ExamID = ExamID;
            data.StartTime = StartTime;
            data.EndDate = EndDate;
            data.IsFinish = IsFinish;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }




        public void UserExamUpdateByLoginUserID(int UserExamID, int LoginUserID, int ExamID, DateTime StartTime, DateTime EndDate, bool IsFinish, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            UserExam data = db.UserExams.Single(p => p.LoginUserID == LoginUserID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }


        public void UserExamUpdateByExamID(int UserExamID, int LoginUserID, int ExamID, DateTime StartTime, DateTime EndDate, bool IsFinish, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            UserExam data = db.UserExams.Single(p => p.ExamID == ExamID);
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

        public void UserExamUpdate(int ExamID, int UserExamID, bool IsFinish)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            UserExam data = db.UserExams.Single(p => p.ExamID == ExamID && p.UserExamID == UserExamID);
            data.IsFinish = IsFinish;
            data.ModifiedDate = DateTime.Now;
            data.EndDate = DateTime.Now;
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        public List<UserExam> UserExamGetByLoginUserID(int LoginUserID, int ExamID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            OnlineExaminationDataContext db = new OnlineExaminationDataContext();
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.UserExams where p.LoginUserID == LoginUserID && p.ExamID == ExamID select p).ToList();
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
            db.DeferredLoadingEnabled = false;
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
        public void UpdateProfilePic(int LoginUserID, string FilePath)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            UserDataContext db = new UserDataContext();
            db.DeferredLoadingEnabled = false;
            User data = db.Users.Single(p => p.LoginUserID == LoginUserID);
            data.PhotoPath = FilePath;
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
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

            InstituteDataContext db = new InstituteDataContext();
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

            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Institutes.InsertOnSubmit(ObjInstitute);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjInstitute.InstituteID;
        }



        public List<Institute> InstituteGet(int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
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
            InstituteDataContext db = new InstituteDataContext();
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
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.InstituteID == InstituteID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Institute> InstituteGetbyName(string Name, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyAddress(string Address, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Address == Address select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCityName(string CityName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CityName == CityName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyStateName(string StateName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.StateName == StateName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCountryName(string CountryName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CountryName == CountryName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyTelePhone(string TelePhone, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.TelePhone == TelePhone select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyFax(string Fax, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Fax == Fax select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyEmail(string Email, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Email == Email select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyWebSite(string WebSite, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.WebSite == WebSite select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCollegeType(int CollegeType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CollegeType == CollegeType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyShortName(string ShortName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ShortName == ShortName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyIsDeleted(bool IsDeleted, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.IsDeleted == IsDeleted select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }





        public List<Institute> InstituteGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Name == Name select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyAddress(string Address)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Address == Address select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCityName(string CityName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CityName == CityName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyStateName(string StateName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.StateName == StateName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCountryName(string CountryName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CountryName == CountryName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyTelePhone(string TelePhone)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.TelePhone == TelePhone select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Fax == Fax select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyEmail(string Email)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Email == Email select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyWebSite(string WebSite)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.WebSite == WebSite select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyCollegeType(int CollegeType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CollegeType == CollegeType select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyShortName(string ShortName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ShortName == ShortName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Institute> InstituteGetbyIsDeleted(bool IsDeleted)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.IsDeleted == IsDeleted select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void InstituteDeletebyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.InstituteID == InstituteID select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.LoginUserID == LoginUserID select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Name == Name select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyAddress(string Address)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Address == Address select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyCityName(string CityName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CityName == CityName select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyStateName(string StateName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.StateName == StateName select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyCountryName(string CountryName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CountryName == CountryName select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyTelePhone(string TelePhone)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.TelePhone == TelePhone select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyFax(string Fax)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Fax == Fax select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyEmail(string Email)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Email == Email select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyWebSite(string WebSite)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.WebSite == WebSite select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyCollegeType(int CollegeType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.CollegeType == CollegeType select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyShortName(string ShortName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ShortName == ShortName select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.Description == Description select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.ModifiedDate == ModifiedDate select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteDeletebyIsDeleted(bool IsDeleted)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Institutes where p.IsDeleted == IsDeleted select p);
            db.Institutes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void InstituteUpdateByInstituteID(int InstituteID, int LoginUserID, string Name, string Address, string CityName, string StateName, string CountryName, string TelePhone, string Fax, string Email, string WebSite, int CollegeType, string ShortName, string Description, DateTime ModifiedDate, bool IsDeleted)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
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
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            Institute data = db.Institutes.Single(p => p.LoginUserID == LoginUserID);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        #endregion
        #region CustomInstitute
        public List<Institute> InstituteSearch(string Keyword, int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Institutes where p.Name.ToLower().Trim().Contains(Keyword.Trim().ToLower()) || p.ShortName.ToLower().Trim().Contains(Keyword.Trim().ToLower()) || p.ShortName.ToLower().Trim().Contains(Keyword.Trim().ToLower()) || p.CityName.ToLower().Trim().Contains(Keyword.Trim().ToLower()) select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        public List<Institute> InstituteSearch(string Keyword)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Institutes where p.Name.ToLower().Trim().Contains(Keyword.Trim().ToLower()) || p.ShortName.ToLower().Trim().Contains(Keyword.Trim().ToLower()) || p.ShortName.ToLower().Trim().Contains(Keyword.Trim().ToLower()) || p.CityName.ToLower().Trim().Contains(Keyword.Trim().ToLower()) select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        public List<Institute> InstituteGetbyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<InstituteCource>(p => p.Cource);
            option.LoadWith<Cource>(p => p.CourceCatagory);
            db.LoadOptions = option;
            var data = (from p in db.Institutes where p.InstituteID == InstituteID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        public List<Institute> InstituteGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<InstituteCource>(p => p.Institute);
            option.LoadWith<InstituteCource>(p => p.Cource);
            db.LoadOptions = option;
            var data = (from p in db.Institutes where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        public void InstituteUpdateByLoginUserID(int LoginUserID, string Name, string Address, string CityName, string StateName, string CountryName, string TelePhone, string Fax, string Email, string WebSite, int CollegeType, string ShortName, string Description, DateTime ModifiedDate, bool IsDeleted)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            Institute data = db.Institutes.Single(p => p.LoginUserID == LoginUserID);
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
        public int InstituteAdd(int LoginUserID, string Name, string Address, string CityName, string StateName, string CountryName, string TelePhone, string Fax, string Email, string WebSite, int CollegeType, string ShortName, string Description, DateTime ModifiedDate, bool IsDeleted, bool IsEdit)
        {
            InstituteDataContext db = new InstituteDataContext();
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



        #region CourceCatagory

        public void CourceCatagoryAdd(int CourceCatagoryID, string CatagoryName, int LoginUserID, string Description, int CatagoryType, DateTime ModifiedDate)
        {
            CourceCatagory ObjCourceCatagory = new CourceCatagory();

            ObjCourceCatagory.CourceCatagoryID = CourceCatagoryID;

            ObjCourceCatagory.CatagoryName = CatagoryName;

            ObjCourceCatagory.LoginUserID = LoginUserID;

            ObjCourceCatagory.Description = Description;

            ObjCourceCatagory.CatagoryType = CatagoryType;

            ObjCourceCatagory.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.CourceCatagories.InsertOnSubmit(ObjCourceCatagory);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int CourceCatagoryAdd(string CatagoryName, int LoginUserID, string Description, int CatagoryType, DateTime ModifiedDate)
        {
            CourceCatagory ObjCourceCatagory = new CourceCatagory();



            ObjCourceCatagory.CatagoryName = CatagoryName;


            ObjCourceCatagory.LoginUserID = LoginUserID;


            ObjCourceCatagory.Description = Description;


            ObjCourceCatagory.CatagoryType = CatagoryType;


            ObjCourceCatagory.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.CourceCatagories.InsertOnSubmit(ObjCourceCatagory);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjCourceCatagory.CourceCatagoryID;
        }



        public List<CourceCatagory> CourceCatagoryGet(int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.CourceCatagories select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.CourceCatagories select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<CourceCatagory> CourceCatagoryGetbyCourceCatagoryID(int CourceCatagoryID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.CourceCatagoryID == CourceCatagoryID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyCatagoryName(string CatagoryName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.CatagoryName == CatagoryName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyCatagoryType(int CatagoryType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.CatagoryType == CatagoryType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<CourceCatagory> CourceCatagoryGetbyCourceCatagoryID(int CourceCatagoryID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.CourceCatagoryID == CourceCatagoryID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyCatagoryName(string CatagoryName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.CatagoryName == CatagoryName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyCatagoryType(int CatagoryType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.CatagoryType == CatagoryType select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<CourceCatagory> CourceCatagoryGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void CourceCatagoryDeletebyCourceCatagoryID(int CourceCatagoryID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.CourceCatagoryID == CourceCatagoryID select p);
            db.CourceCatagories.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceCatagoryDeletebyCatagoryName(string CatagoryName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.CatagoryName == CatagoryName select p);
            db.CourceCatagories.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceCatagoryDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.LoginUserID == LoginUserID select p);
            db.CourceCatagories.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceCatagoryDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.Description == Description select p);
            db.CourceCatagories.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceCatagoryDeletebyCatagoryType(int CatagoryType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.CatagoryType == CatagoryType select p);
            db.CourceCatagories.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceCatagoryDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.CourceCatagories where p.ModifiedDate == ModifiedDate select p);
            db.CourceCatagories.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void CourceCatagoryUpdateByCourceCatagoryID(int CourceCatagoryID, string CatagoryName, int LoginUserID, string Description, int CatagoryType, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            CourceCatagory data = db.CourceCatagories.Single(p => p.CourceCatagoryID == CourceCatagoryID);
            data.CatagoryName = CatagoryName;
            data.LoginUserID = LoginUserID;
            data.Description = Description;
            data.CatagoryType = CatagoryType;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomCourceCatagory
        public void CourceCatagoryUpdateByLoginUserID(string CatagoryName, int LoginUserID, string Description, int CatagoryType, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            CourceCatagory data = db.CourceCatagories.Single(p => p.LoginUserID == LoginUserID);
            data.CatagoryName = CatagoryName;
            data.LoginUserID = LoginUserID;
            data.Description = Description;
            data.CatagoryType = CatagoryType;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        #endregion




        #region Cource

        public void CourceAdd(int CourceID, int CourceCatagoryID, string CourceName, string Description, int CourceType, DateTime Modifieddate)
        {
            Cource ObjCource = new Cource();

            ObjCource.CourceID = CourceID;

            ObjCource.CourceCatagoryID = CourceCatagoryID;

            ObjCource.CourceName = CourceName;

            ObjCource.Description = Description;

            ObjCource.CourceType = CourceType;

            ObjCource.Modifieddate = Modifieddate;

            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Cources.InsertOnSubmit(ObjCource);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int CourceAdd(int CourceCatagoryID, string CourceName, string Description, int CourceType, DateTime Modifieddate)
        {
            Cource ObjCource = new Cource();



            ObjCource.CourceCatagoryID = CourceCatagoryID;


            ObjCource.CourceName = CourceName;


            ObjCource.Description = Description;


            ObjCource.CourceType = CourceType;


            ObjCource.Modifieddate = Modifieddate;

            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Cources.InsertOnSubmit(ObjCource);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjCource.CourceID;
        }



        public List<Cource> CourceGet(int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Cources select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Cources select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Cource> CourceGetbyCourceID(int CourceID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceID == CourceID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyCourceCatagoryID(int CourceCatagoryID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceCatagoryID == CourceCatagoryID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyCourceName(string CourceName, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceName == CourceName select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyCourceType(int CourceType, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceType == CourceType select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyModifieddate(DateTime Modifieddate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.Modifieddate == Modifieddate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Cource> CourceGetbyCourceID(int CourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceID == CourceID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyCourceCatagoryID(int CourceCatagoryID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceCatagoryID == CourceCatagoryID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyCourceName(string CourceName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceName == CourceName select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyCourceType(int CourceType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceType == CourceType select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Cource> CourceGetbyModifieddate(DateTime Modifieddate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.Modifieddate == Modifieddate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void CourceDeletebyCourceID(int CourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceID == CourceID select p);
            db.Cources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceDeletebyCourceCatagoryID(int CourceCatagoryID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceCatagoryID == CourceCatagoryID select p);
            db.Cources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceDeletebyCourceName(string CourceName)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceName == CourceName select p);
            db.Cources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.Description == Description select p);
            db.Cources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceDeletebyCourceType(int CourceType)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.CourceType == CourceType select p);
            db.Cources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void CourceDeletebyModifieddate(DateTime Modifieddate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Cources where p.Modifieddate == Modifieddate select p);
            db.Cources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void CourceUpdateByCourceID(int CourceID, int CourceCatagoryID, string CourceName, string Description, int CourceType, DateTime Modifieddate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            Cource data = db.Cources.Single(p => p.CourceID == CourceID);
            data.CourceCatagoryID = CourceCatagoryID;
            data.CourceName = CourceName;
            data.Description = Description;
            data.CourceType = CourceType;
            data.Modifieddate = Modifieddate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomCource


        #endregion



        #region InstituteCource

        public void InstituteCourceAdd(int InstituteCourceID, int InstituteID, int CourceID, string MetaDescription, string MetaKeyword, DateTime StartDate, DateTime EndDate, bool IsPublished, bool HomeWorkEnable, bool AttendanceEnable, bool QuestionAnswerEnable, bool SelfRegistrationEnable, bool IsFree, decimal Price, DateTime Modifieddate)
        {
            InstituteCource ObjInstituteCource = new InstituteCource();

            ObjInstituteCource.InstituteCourceID = InstituteCourceID;

            ObjInstituteCource.InstituteID = InstituteID;

            ObjInstituteCource.CourceID = CourceID;

            ObjInstituteCource.MetaDescription = MetaDescription;

            ObjInstituteCource.MetaKeyword = MetaKeyword;

            ObjInstituteCource.StartDate = StartDate;

            ObjInstituteCource.EndDate = EndDate;

            ObjInstituteCource.IsPublished = IsPublished;

            ObjInstituteCource.HomeWorkEnable = HomeWorkEnable;

            ObjInstituteCource.AttendanceEnable = AttendanceEnable;

            ObjInstituteCource.QuestionAnswerEnable = QuestionAnswerEnable;

            ObjInstituteCource.SelfRegistrationEnable = SelfRegistrationEnable;

            ObjInstituteCource.IsFree = IsFree;

            ObjInstituteCource.Price = Price;

            ObjInstituteCource.Modifieddate = Modifieddate;

            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.InstituteCources.InsertOnSubmit(ObjInstituteCource);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int InstituteCourceAdd(int InstituteID, int CourceID, string MetaDescription, string MetaKeyword, DateTime StartDate, DateTime EndDate, bool IsPublished, bool HomeWorkEnable, bool AttendanceEnable, bool QuestionAnswerEnable, bool SelfRegistrationEnable, bool IsFree, decimal Price, DateTime Modifieddate)
        {
            InstituteCource ObjInstituteCource = new InstituteCource();



            ObjInstituteCource.InstituteID = InstituteID;


            ObjInstituteCource.CourceID = CourceID;


            ObjInstituteCource.MetaDescription = MetaDescription;


            ObjInstituteCource.MetaKeyword = MetaKeyword;


            ObjInstituteCource.StartDate = StartDate;


            ObjInstituteCource.EndDate = EndDate;


            ObjInstituteCource.IsPublished = IsPublished;


            ObjInstituteCource.HomeWorkEnable = HomeWorkEnable;


            ObjInstituteCource.AttendanceEnable = AttendanceEnable;


            ObjInstituteCource.QuestionAnswerEnable = QuestionAnswerEnable;


            ObjInstituteCource.SelfRegistrationEnable = SelfRegistrationEnable;


            ObjInstituteCource.IsFree = IsFree;


            ObjInstituteCource.Price = Price;


            ObjInstituteCource.Modifieddate = Modifieddate;

            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.InstituteCources.InsertOnSubmit(ObjInstituteCource);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjInstituteCource.InstituteCourceID;
        }



        public List<InstituteCource> InstituteCourceGet(int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.InstituteCources select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.InstituteCources select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<InstituteCource> InstituteCourceGetbyInstituteCourceID(int InstituteCourceID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.InstituteCourceID == InstituteCourceID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        
        public List<InstituteCource> InstituteCourceGetbyCourceID(int CourceID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.CourceID == CourceID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyMetaDescription(string MetaDescription, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.MetaDescription == MetaDescription select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyMetaKeyword(string MetaKeyword, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.MetaKeyword == MetaKeyword select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyStartDate(DateTime StartDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.StartDate == StartDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyEndDate(DateTime EndDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.EndDate == EndDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyIsPublished(bool IsPublished, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.IsPublished == IsPublished select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyHomeWorkEnable(bool HomeWorkEnable, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.HomeWorkEnable == HomeWorkEnable select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyAttendanceEnable(bool AttendanceEnable, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.AttendanceEnable == AttendanceEnable select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyQuestionAnswerEnable(bool QuestionAnswerEnable, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.QuestionAnswerEnable == QuestionAnswerEnable select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbySelfRegistrationEnable(bool SelfRegistrationEnable, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.SelfRegistrationEnable == SelfRegistrationEnable select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyIsFree(bool IsFree, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.IsFree == IsFree select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyPrice(decimal Price, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.Price == Price select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyModifieddate(DateTime Modifieddate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.Modifieddate == Modifieddate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<InstituteCource> InstituteCourceGetbyInstituteCourceID(int InstituteCourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.InstituteCourceID == InstituteCourceID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

       

        public List<InstituteCource> InstituteCourceGetbyCourceID(int CourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.CourceID == CourceID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyMetaDescription(string MetaDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.MetaDescription == MetaDescription select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyMetaKeyword(string MetaKeyword)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.MetaKeyword == MetaKeyword select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyStartDate(DateTime StartDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.StartDate == StartDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyEndDate(DateTime EndDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.EndDate == EndDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyIsPublished(bool IsPublished)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.IsPublished == IsPublished select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyHomeWorkEnable(bool HomeWorkEnable)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.HomeWorkEnable == HomeWorkEnable select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyAttendanceEnable(bool AttendanceEnable)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.AttendanceEnable == AttendanceEnable select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyQuestionAnswerEnable(bool QuestionAnswerEnable)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.QuestionAnswerEnable == QuestionAnswerEnable select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbySelfRegistrationEnable(bool SelfRegistrationEnable)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.SelfRegistrationEnable == SelfRegistrationEnable select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyIsFree(bool IsFree)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.IsFree == IsFree select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.Price == Price select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteCource> InstituteCourceGetbyModifieddate(DateTime Modifieddate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.Modifieddate == Modifieddate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void InstituteCourceDeletebyInstituteCourceID(int InstituteCourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.InstituteCourceID == InstituteCourceID select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.InstituteID == InstituteID select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyCourceID(int CourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.CourceID == CourceID select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyMetaDescription(string MetaDescription)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.MetaDescription == MetaDescription select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyMetaKeyword(string MetaKeyword)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.MetaKeyword == MetaKeyword select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyStartDate(DateTime StartDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.StartDate == StartDate select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyEndDate(DateTime EndDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.EndDate == EndDate select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyIsPublished(bool IsPublished)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.IsPublished == IsPublished select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyHomeWorkEnable(bool HomeWorkEnable)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.HomeWorkEnable == HomeWorkEnable select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyAttendanceEnable(bool AttendanceEnable)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.AttendanceEnable == AttendanceEnable select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyQuestionAnswerEnable(bool QuestionAnswerEnable)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.QuestionAnswerEnable == QuestionAnswerEnable select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebySelfRegistrationEnable(bool SelfRegistrationEnable)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.SelfRegistrationEnable == SelfRegistrationEnable select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyIsFree(bool IsFree)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.IsFree == IsFree select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyPrice(decimal Price)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.Price == Price select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteCourceDeletebyModifieddate(DateTime Modifieddate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.Modifieddate == Modifieddate select p);
            db.InstituteCources.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void InstituteCourceUpdateByInstituteCourceID(int InstituteCourceID, int InstituteID, int CourceID, string MetaDescription, string MetaKeyword, DateTime StartDate, DateTime EndDate, bool IsPublished, bool HomeWorkEnable, bool AttendanceEnable, bool QuestionAnswerEnable, bool SelfRegistrationEnable, bool IsFree, decimal Price, DateTime Modifieddate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            InstituteCource data = db.InstituteCources.Single(p => p.InstituteCourceID == InstituteCourceID);
            data.InstituteID = InstituteID;
            data.CourceID = CourceID;
            data.MetaDescription = MetaDescription;
            data.MetaKeyword = MetaKeyword;
            data.StartDate = StartDate;
            data.EndDate = EndDate;
            data.IsPublished = IsPublished;
            data.HomeWorkEnable = HomeWorkEnable;
            data.AttendanceEnable = AttendanceEnable;
            data.QuestionAnswerEnable = QuestionAnswerEnable;
            data.SelfRegistrationEnable = SelfRegistrationEnable;
            data.IsFree = IsFree;
            data.Price = Price;
            data.Modifieddate = Modifieddate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        
        #region CustomInstituteCource
        public List<InstituteCource> InstituteCourceGetbyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<InstituteCource>(p => p.Cource);
            option.LoadWith<Cource>(p => p.CourceCatagory);
            db.LoadOptions = option;
            var data = (from p in db.InstituteCources where p.InstituteID == InstituteID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        public List<InstituteCource> InstituteCourceGetbyInstituteID(int InstituteID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<InstituteCource>(p => p.Cource);
            option.LoadWith<Cource>(p => p.CourceCatagory);
            db.LoadOptions = option;
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteCources where p.InstituteID == InstituteID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        #endregion



        #region Tutorial

        public void TutorialAdd(int TutorialID, int LoginUserID, int TutorialTypeID, string Name, string Description, string FilePath, DateTime ModifiedDate)
        {
            Tutorial ObjTutorial = new Tutorial();

            ObjTutorial.TutorialID = TutorialID;

            ObjTutorial.LoginUserID = LoginUserID;

            ObjTutorial.TutorialTypeID = TutorialTypeID;

            ObjTutorial.Name = Name;

            ObjTutorial.Description = Description;

            ObjTutorial.FilePath = FilePath;

            ObjTutorial.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Tutorials.InsertOnSubmit(ObjTutorial);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int TutorialAdd(int LoginUserID, int TutorialTypeID, string Name, string Description, string FilePath, DateTime ModifiedDate)
        {
            Tutorial ObjTutorial = new Tutorial();



            ObjTutorial.LoginUserID = LoginUserID;


            ObjTutorial.TutorialTypeID = TutorialTypeID;


            ObjTutorial.Name = Name;


            ObjTutorial.Description = Description;


            ObjTutorial.FilePath = FilePath;


            ObjTutorial.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Tutorials.InsertOnSubmit(ObjTutorial);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjTutorial.TutorialID;
        }



        public List<Tutorial> TutorialGet(int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Tutorials select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Tutorials select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Tutorial> TutorialGetbyTutorialID(int TutorialID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.TutorialID == TutorialID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Tutorial> TutorialGetbyTutorialTypeID(int TutorialTypeID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.TutorialTypeID == TutorialTypeID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyName(string Name, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyFilePath(string FilePath, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.FilePath == FilePath select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Tutorial> TutorialGetbyTutorialID(int TutorialID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.TutorialID == TutorialID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyTutorialTypeID(int TutorialTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.TutorialTypeID == TutorialTypeID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.Name == Name select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyFilePath(string FilePath)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.FilePath == FilePath select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Tutorial> TutorialGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void TutorialDeletebyTutorialID(int TutorialID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.TutorialID == TutorialID select p);
            db.Tutorials.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void TutorialDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.LoginUserID == LoginUserID select p);
            db.Tutorials.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void TutorialDeletebyTutorialTypeID(int TutorialTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.TutorialTypeID == TutorialTypeID select p);
            db.Tutorials.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void TutorialDeletebyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.Name == Name select p);
            db.Tutorials.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void TutorialDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.Description == Description select p);
            db.Tutorials.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void TutorialDeletebyFilePath(string FilePath)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.FilePath == FilePath select p);
            db.Tutorials.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void TutorialDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.ModifiedDate == ModifiedDate select p);
            db.Tutorials.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void TutorialUpdateByTutorialID(int TutorialID, int LoginUserID, int TutorialTypeID, string Name, string Description, string FilePath, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            Tutorial data = db.Tutorials.Single(p => p.TutorialID == TutorialID);
            data.LoginUserID = LoginUserID;
            data.TutorialTypeID = TutorialTypeID;
            data.Name = Name;
            data.Description = Description;
            data.FilePath = FilePath;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomTutorial
        public List<GetTutorialResult> GetTutorial(string Keywork, int TutorialType)
        {

            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetTutorial(Keywork, TutorialType).ToList();

        }
        public List<GetTutorialResult> GetTutorial(string Keywork, int TutorialType, int PageSize, int PageNumber)
        {

            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetTutorial(Keywork, TutorialType).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }
        public List<Tutorial> TutorialGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<Tutorial>(p => p.TutorialType);
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Tutorials where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        #endregion


        #region TutorialType

        public void TutorialTypeAdd(int TutorialTypeID, string Name, int LoginUserID, DateTime ModifiedDate)
        {
            TutorialType ObjTutorialType = new TutorialType();

            ObjTutorialType.TutorialTypeID = TutorialTypeID;

            ObjTutorialType.Name = Name;

            ObjTutorialType.LoginUserID = LoginUserID;

            ObjTutorialType.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.TutorialTypes.InsertOnSubmit(ObjTutorialType);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int TutorialTypeAdd(string Name, int LoginUserID, DateTime ModifiedDate)
        {
            TutorialType ObjTutorialType = new TutorialType();



            ObjTutorialType.Name = Name;


            ObjTutorialType.LoginUserID = LoginUserID;


            ObjTutorialType.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.TutorialTypes.InsertOnSubmit(ObjTutorialType);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjTutorialType.TutorialTypeID;
        }



        public List<TutorialType> TutorialTypeGet(int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.TutorialTypes select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<TutorialType> TutorialTypeGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.TutorialTypes select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<TutorialType> TutorialTypeGetbyTutorialTypeID(int TutorialTypeID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.TutorialTypeID == TutorialTypeID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<TutorialType> TutorialTypeGetbyName(string Name, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<TutorialType> TutorialTypeGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<TutorialType> TutorialTypeGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<TutorialType> TutorialTypeGetbyTutorialTypeID(int TutorialTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.TutorialTypeID == TutorialTypeID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<TutorialType> TutorialTypeGetbyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.Name == Name select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<TutorialType> TutorialTypeGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<TutorialType> TutorialTypeGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void TutorialTypeDeletebyTutorialTypeID(int TutorialTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.TutorialTypeID == TutorialTypeID select p);
            db.TutorialTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void TutorialTypeDeletebyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.Name == Name select p);
            db.TutorialTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void TutorialTypeDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.LoginUserID == LoginUserID select p);
            db.TutorialTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void TutorialTypeDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.TutorialTypes where p.ModifiedDate == ModifiedDate select p);
            db.TutorialTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void TutorialTypeUpdateByTutorialTypeID(int TutorialTypeID, string Name, int LoginUserID, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            TutorialType data = db.TutorialTypes.Single(p => p.TutorialTypeID == TutorialTypeID);
            data.Name = Name;
            data.LoginUserID = LoginUserID;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomTutorialType
        #endregion



        #region Question

        public void QuestionAdd(Guid QuestionID, string QuestionText, string Description, int LoginUserID, int InstituteCourceID, string tag, int QuestionTypeID, int QuestionStatusID, DateTime ModifiedDate)
        {
            Question ObjQuestion = new Question();

            ObjQuestion.QuestionID = QuestionID;

            ObjQuestion.QuestionText = QuestionText;

            ObjQuestion.Description = Description;

            ObjQuestion.LoginUserID = LoginUserID;

            ObjQuestion.InstituteCourceID = InstituteCourceID;

            ObjQuestion.tag = tag;

            ObjQuestion.QuestionTypeID = QuestionTypeID;

            ObjQuestion.QuestionStatusID = QuestionStatusID;

            ObjQuestion.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Questions.InsertOnSubmit(ObjQuestion);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public Guid QuestionAdd(string QuestionText, string Description, int LoginUserID, int InstituteCourceID, string tag, int QuestionTypeID, int QuestionStatusID, DateTime ModifiedDate)
        {
            Question ObjQuestion = new Question();



            ObjQuestion.QuestionText = QuestionText;


            ObjQuestion.Description = Description;


            ObjQuestion.LoginUserID = LoginUserID;


            ObjQuestion.InstituteCourceID = InstituteCourceID;


            ObjQuestion.tag = tag;


            ObjQuestion.QuestionTypeID = QuestionTypeID;


            ObjQuestion.QuestionStatusID = QuestionStatusID;


            ObjQuestion.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Questions.InsertOnSubmit(ObjQuestion);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjQuestion.QuestionID;
        }



        public List<Question> QuestionGet(int PageSize, int PageNumber)
        {
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Questions select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Questions select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Question> QuestionGetbyQuestionID(Guid QuestionID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionID == QuestionID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyQuestionText(string QuestionText, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionText == QuestionText select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyInstituteCourceID(int InstituteCourceID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.InstituteCourceID == InstituteCourceID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbytag(string tag, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.tag == tag select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyQuestionTypeID(int QuestionTypeID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionTypeID == QuestionTypeID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyQuestionStatusID(int QuestionStatusID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionStatusID == QuestionStatusID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Question> QuestionGetbyQuestionID(Guid QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionID == QuestionID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyQuestionText(string QuestionText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionText == QuestionText select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyInstituteCourceID(int InstituteCourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.InstituteCourceID == InstituteCourceID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbytag(string tag)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.tag == tag select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyQuestionTypeID(int QuestionTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionTypeID == QuestionTypeID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyQuestionStatusID(int QuestionStatusID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionStatusID == QuestionStatusID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Question> QuestionGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void QuestionDeletebyQuestionID(Guid QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionID == QuestionID select p);
            db.Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionDeletebyQuestionText(string QuestionText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionText == QuestionText select p);
            db.Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.Description == Description select p);
            db.Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.LoginUserID == LoginUserID select p);
            db.Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionDeletebyInstituteCourceID(int InstituteCourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.InstituteCourceID == InstituteCourceID select p);
            db.Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionDeletebytag(string tag)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.tag == tag select p);
            db.Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionDeletebyQuestionTypeID(int QuestionTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionTypeID == QuestionTypeID select p);
            db.Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionDeletebyQuestionStatusID(int QuestionStatusID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.QuestionStatusID == QuestionStatusID select p);
            db.Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Questions where p.ModifiedDate == ModifiedDate select p);
            db.Questions.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void QuestionUpdateByQuestionID(Guid QuestionID, string QuestionText, string Description, int LoginUserID, int InstituteCourceID, string tag, int QuestionTypeID, int QuestionStatusID, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            Question data = db.Questions.Single(p => p.QuestionID == QuestionID);
            data.QuestionText = QuestionText;
            data.Description = Description;
            data.LoginUserID = LoginUserID;
            data.InstituteCourceID = InstituteCourceID;
            data.tag = tag;
            data.QuestionTypeID = QuestionTypeID;
            data.QuestionStatusID = QuestionStatusID;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        
	
        #region CustomQuestion
        public List<GetQuestionByLoginUserIDResult> GetQuestionByLoginUserID(int LoginUserID, int QuestionTypeID, int QuestionStatusID)
        {

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetQuestionByLoginUserID(LoginUserID, QuestionTypeID, QuestionStatusID).ToList();

        }
        public List<GetQuestionByLoginUserIDResult> GetQuestionByLoginUserID(int LoginUserID, int QuestionTypeID, int QuestionStatusID, int PageSize, int PageNumber)
        {

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetQuestionByLoginUserID(LoginUserID, QuestionTypeID, QuestionStatusID).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }
        public List<GetQuestionResult> GetQuestion(string Keyword, int QuestionTypeID, int QuestionStatusID)
        {

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetQuestion(Keyword, QuestionTypeID, QuestionStatusID).ToList();

        }
        public List<GetQuestionResult> GetQuestion(string Keyword, int QuestionTypeID, int QuestionStatusID, int PageSize, int PageNumber)
        {

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetQuestion(Keyword, QuestionTypeID, QuestionStatusID).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }
        public List<GetQuestionByQuestionIDResult> GetQuestionByQuestionID(Guid QuestionID, int QuestionTypeID, int QuestionStatusID)
        {

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetQuestionByQuestionID(QuestionID, QuestionTypeID, QuestionStatusID).ToList();

        }
        public List<GetQuestionByQuestionIDResult> GetQuestionByQuestionID(Guid QuestionID, int QuestionTypeID, int QuestionStatusID, int PageSize, int PageNumber)
        {

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetQuestionByQuestionID(QuestionID, QuestionTypeID, QuestionStatusID).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }
        
        public void QuestionAdd(Guid QuestionID, string QuestionText, int LoginUserID, int QuestionTypeID, DateTime ModifiedDate)
        {
            Question ObjQuestion = new Question();

            ObjQuestion.QuestionID = QuestionID;

            ObjQuestion.QuestionText = QuestionText;

            ObjQuestion.LoginUserID = LoginUserID;

            ObjQuestion.QuestionTypeID = QuestionTypeID;


            ObjQuestion.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Questions.InsertOnSubmit(ObjQuestion);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }
        #endregion



        #region QuestionStatus

        public void QuestionStatusAdd(int QuestionStatusID, string QuestionStatusText, int LoginUserID, DateTime ModifiedDate)
        {
            QuestionStatus ObjQuestionStatus = new QuestionStatus();

            ObjQuestionStatus.QuestionStatusID = QuestionStatusID;

            ObjQuestionStatus.QuestionStatusText = QuestionStatusText;

            ObjQuestionStatus.LoginUserID = LoginUserID;

            ObjQuestionStatus.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.QuestionStatus.InsertOnSubmit(ObjQuestionStatus);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int QuestionStatusAdd(string QuestionStatusText, int LoginUserID, DateTime ModifiedDate)
        {
            QuestionStatus ObjQuestionStatus = new QuestionStatus();



            ObjQuestionStatus.QuestionStatusText = QuestionStatusText;


            ObjQuestionStatus.LoginUserID = LoginUserID;


            ObjQuestionStatus.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.QuestionStatus.InsertOnSubmit(ObjQuestionStatus);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjQuestionStatus.QuestionStatusID;
        }



        public List<QuestionStatus> QuestionStatusGet(int PageSize, int PageNumber)
        {
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.QuestionStatus select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionStatus> QuestionStatusGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.QuestionStatus select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<QuestionStatus> QuestionStatusGetbyQuestionStatusID(int QuestionStatusID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.QuestionStatusID == QuestionStatusID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionStatus> QuestionStatusGetbyQuestionStatusText(string QuestionStatusText, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.QuestionStatusText == QuestionStatusText select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionStatus> QuestionStatusGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionStatus> QuestionStatusGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<QuestionStatus> QuestionStatusGetbyQuestionStatusID(int QuestionStatusID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.QuestionStatusID == QuestionStatusID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionStatus> QuestionStatusGetbyQuestionStatusText(string QuestionStatusText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.QuestionStatusText == QuestionStatusText select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionStatus> QuestionStatusGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionStatus> QuestionStatusGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void QuestionStatusDeletebyQuestionStatusID(int QuestionStatusID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.QuestionStatusID == QuestionStatusID select p);
            db.QuestionStatus.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionStatusDeletebyQuestionStatusText(string QuestionStatusText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.QuestionStatusText == QuestionStatusText select p);
            db.QuestionStatus.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionStatusDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.LoginUserID == LoginUserID select p);
            db.QuestionStatus.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionStatusDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionStatus where p.ModifiedDate == ModifiedDate select p);
            db.QuestionStatus.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void QuestionStatusUpdateByQuestionStatusID(int QuestionStatusID, string QuestionStatusText, int LoginUserID, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            QuestionStatus data = db.QuestionStatus.Single(p => p.QuestionStatusID == QuestionStatusID);
            data.QuestionStatusText = QuestionStatusText;
            data.LoginUserID = LoginUserID;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomQuestionStatus
        #endregion




        #region QuestionType

        public void QuestionTypeAdd(int QuestionTypeID, string QuestionTypeTnext, int LoginUserID, DateTime ModifiedDate)
        {
            QuestionType ObjQuestionType = new QuestionType();

            ObjQuestionType.QuestionTypeID = QuestionTypeID;

            ObjQuestionType.QuestionTypeTnext = QuestionTypeTnext;

            ObjQuestionType.LoginUserID = LoginUserID;

            ObjQuestionType.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.QuestionTypes.InsertOnSubmit(ObjQuestionType);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int QuestionTypeAdd(string QuestionTypeTnext, int LoginUserID, DateTime ModifiedDate)
        {
            QuestionType ObjQuestionType = new QuestionType();



            ObjQuestionType.QuestionTypeTnext = QuestionTypeTnext;


            ObjQuestionType.LoginUserID = LoginUserID;


            ObjQuestionType.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.QuestionTypes.InsertOnSubmit(ObjQuestionType);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjQuestionType.QuestionTypeID;
        }



        public List<QuestionType> QuestionTypeGet(int PageSize, int PageNumber)
        {
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.QuestionTypes select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionType> QuestionTypeGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.QuestionTypes select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<QuestionType> QuestionTypeGetbyQuestionTypeID(int QuestionTypeID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.QuestionTypeID == QuestionTypeID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionType> QuestionTypeGetbyQuestionTypeTnext(string QuestionTypeTnext, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.QuestionTypeTnext == QuestionTypeTnext select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionType> QuestionTypeGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionType> QuestionTypeGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<QuestionType> QuestionTypeGetbyQuestionTypeID(int QuestionTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.QuestionTypeID == QuestionTypeID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionType> QuestionTypeGetbyQuestionTypeTnext(string QuestionTypeTnext)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.QuestionTypeTnext == QuestionTypeTnext select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionType> QuestionTypeGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<QuestionType> QuestionTypeGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void QuestionTypeDeletebyQuestionTypeID(int QuestionTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.QuestionTypeID == QuestionTypeID select p);
            db.QuestionTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionTypeDeletebyQuestionTypeTnext(string QuestionTypeTnext)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.QuestionTypeTnext == QuestionTypeTnext select p);
            db.QuestionTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionTypeDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.LoginUserID == LoginUserID select p);
            db.QuestionTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void QuestionTypeDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.QuestionTypes where p.ModifiedDate == ModifiedDate select p);
            db.QuestionTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void QuestionTypeUpdateByQuestionTypeID(int QuestionTypeID, string QuestionTypeTnext, int LoginUserID, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            QuestionType data = db.QuestionTypes.Single(p => p.QuestionTypeID == QuestionTypeID);
            data.QuestionTypeTnext = QuestionTypeTnext;
            data.LoginUserID = LoginUserID;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomQuestionType
        #endregion




        #region Answer

        public void AnswerAdd(Guid AnswerID, string AnswerText, string Description, Guid QuestionID, int AnswerStateID, int LoginUserID, int AnswerRate, DateTime ModifiedDate)
        {
            Answer ObjAnswer = new Answer();

            ObjAnswer.AnswerID = AnswerID;

            ObjAnswer.AnswerText = AnswerText;

            ObjAnswer.Description = Description;

            ObjAnswer.QuestionID = QuestionID;

            ObjAnswer.AnswerStateID = AnswerStateID;

            ObjAnswer.LoginUserID = LoginUserID;

            ObjAnswer.AnswerRate = AnswerRate;

            ObjAnswer.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Answers.InsertOnSubmit(ObjAnswer);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public Guid AnswerAdd(string AnswerText, string Description, Guid QuestionID, int AnswerStateID, int LoginUserID, int AnswerRate, DateTime ModifiedDate)
        {
            Answer ObjAnswer = new Answer();



            ObjAnswer.AnswerText = AnswerText;


            ObjAnswer.Description = Description;


            ObjAnswer.QuestionID = QuestionID;


            ObjAnswer.AnswerStateID = AnswerStateID;


            ObjAnswer.LoginUserID = LoginUserID;


            ObjAnswer.AnswerRate = AnswerRate;


            ObjAnswer.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Answers.InsertOnSubmit(ObjAnswer);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjAnswer.AnswerID;
        }



        public List<Answer> AnswerGet(int PageSize, int PageNumber)
        {
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Answers select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Answers select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Answer> AnswerGetbyAnswerID(Guid AnswerID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerID == AnswerID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyAnswerText(string AnswerText, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerText == AnswerText select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyQuestionID(Guid QuestionID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.QuestionID == QuestionID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyAnswerStateID(int AnswerStateID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerStateID == AnswerStateID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyAnswerRate(int AnswerRate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerRate == AnswerRate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Answer> AnswerGetbyAnswerID(Guid AnswerID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerID == AnswerID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyAnswerText(string AnswerText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerText == AnswerText select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyQuestionID(Guid QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.QuestionID == QuestionID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyAnswerStateID(int AnswerStateID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerStateID == AnswerStateID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyAnswerRate(int AnswerRate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerRate == AnswerRate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Answer> AnswerGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void AnswerDeletebyAnswerID(Guid AnswerID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerID == AnswerID select p);
            db.Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerDeletebyAnswerText(string AnswerText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerText == AnswerText select p);
            db.Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.Description == Description select p);
            db.Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerDeletebyQuestionID(Guid QuestionID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.QuestionID == QuestionID select p);
            db.Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerDeletebyAnswerStateID(int AnswerStateID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerStateID == AnswerStateID select p);
            db.Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.LoginUserID == LoginUserID select p);
            db.Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerDeletebyAnswerRate(int AnswerRate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerRate == AnswerRate select p);
            db.Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.ModifiedDate == ModifiedDate select p);
            db.Answers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void AnswerUpdateByAnswerID(Guid AnswerID, string AnswerText, string Description, Guid QuestionID, int AnswerStateID, int LoginUserID, int AnswerRate, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            Answer data = db.Answers.Single(p => p.AnswerID == AnswerID);
            data.AnswerText = AnswerText;
            data.Description = Description;
            data.QuestionID = QuestionID;
            data.AnswerStateID = AnswerStateID;
            data.LoginUserID = LoginUserID;
            data.AnswerRate = AnswerRate;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion


        #region CustomAnswer
        public void UpdateAnswerStateByAnswerID(Guid AnswerID, int AnswerStatus)
        {
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Answers where p.AnswerID == AnswerID select p).ToList();
            if (data.Count > 0)
            {
                data[0].AnswerStateID = AnswerStatus;
                db.SubmitChanges();
            }

        }
        public List<GetAnswerByQuestionIDResult> GetAnswerByQuestionID(Guid QuestionID, int AnswerStateID)
        {

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetAnswerByQuestionID(QuestionID, AnswerStateID).ToList();

        }
        public List<GetAnswerByQuestionIDResult> GetAnswerByQuestionID(Guid QuestionID, int AnswerStateID, int PageSize, int PageNumber)
        {

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetAnswerByQuestionID(QuestionID, AnswerStateID).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }
        #endregion


        #region AnswerState

        public void AnswerStateAdd(int AnswerStateID, string AnswerStateText, int LoginUserID, DateTime ModifiedDate)
        {
            AnswerState ObjAnswerState = new AnswerState();

            ObjAnswerState.AnswerStateID = AnswerStateID;

            ObjAnswerState.AnswerStateText = AnswerStateText;

            ObjAnswerState.LoginUserID = LoginUserID;

            ObjAnswerState.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.AnswerStates.InsertOnSubmit(ObjAnswerState);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int AnswerStateAdd(string AnswerStateText, int LoginUserID, DateTime ModifiedDate)
        {
            AnswerState ObjAnswerState = new AnswerState();



            ObjAnswerState.AnswerStateText = AnswerStateText;


            ObjAnswerState.LoginUserID = LoginUserID;


            ObjAnswerState.ModifiedDate = ModifiedDate;

            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.AnswerStates.InsertOnSubmit(ObjAnswerState);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjAnswerState.AnswerStateID;
        }



        public List<AnswerState> AnswerStateGet(int PageSize, int PageNumber)
        {
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.AnswerStates select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<AnswerState> AnswerStateGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.AnswerStates select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<AnswerState> AnswerStateGetbyAnswerStateID(int AnswerStateID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.AnswerStateID == AnswerStateID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<AnswerState> AnswerStateGetbyAnswerStateText(string AnswerStateText, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.AnswerStateText == AnswerStateText select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<AnswerState> AnswerStateGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<AnswerState> AnswerStateGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<AnswerState> AnswerStateGetbyAnswerStateID(int AnswerStateID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.AnswerStateID == AnswerStateID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<AnswerState> AnswerStateGetbyAnswerStateText(string AnswerStateText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.AnswerStateText == AnswerStateText select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<AnswerState> AnswerStateGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<AnswerState> AnswerStateGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void AnswerStateDeletebyAnswerStateID(int AnswerStateID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.AnswerStateID == AnswerStateID select p);
            db.AnswerStates.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerStateDeletebyAnswerStateText(string AnswerStateText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.AnswerStateText == AnswerStateText select p);
            db.AnswerStates.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerStateDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.LoginUserID == LoginUserID select p);
            db.AnswerStates.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void AnswerStateDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.AnswerStates where p.ModifiedDate == ModifiedDate select p);
            db.AnswerStates.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void AnswerStateUpdateByAnswerStateID(int AnswerStateID, string AnswerStateText, int LoginUserID, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            QuestionAnswerDataContext db = new QuestionAnswerDataContext();
            db.DeferredLoadingEnabled = false;
            AnswerState data = db.AnswerStates.Single(p => p.AnswerStateID == AnswerStateID);
            data.AnswerStateText = AnswerStateText;
            data.LoginUserID = LoginUserID;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomAnswerState
        #endregion




        #region Message

        public void MessageAdd(Guid MessageID, string Subject, string MessageText, int ToLoginUserID, int FromLoginUserID, int ReplyID, DateTime ReadTime, bool IsReaded, bool DeleteFromTo, bool DeleteFromFrom, DateTime ModifiedDate)
        {
            Message ObjMessage = new Message();

            ObjMessage.MessageID = MessageID;

            ObjMessage.Subject = Subject;

            ObjMessage.MessageText = MessageText;

            ObjMessage.ToLoginUserID = ToLoginUserID;

            ObjMessage.FromLoginUserID = FromLoginUserID;

            ObjMessage.ReplyID = ReplyID;

            ObjMessage.ReadTime = ReadTime;

            ObjMessage.IsReaded = IsReaded;

            ObjMessage.DeleteFromTo = DeleteFromTo;

            ObjMessage.DeleteFromFrom = DeleteFromFrom;

            ObjMessage.ModifiedDate = ModifiedDate;

            MessageDataContext db = new MessageDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Messages.InsertOnSubmit(ObjMessage);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public Guid MessageAdd(string Subject, string MessageText, int ToLoginUserID, int FromLoginUserID, int ReplyID, DateTime ReadTime, bool IsReaded, bool DeleteFromTo, bool DeleteFromFrom, DateTime ModifiedDate)
        {
            Message ObjMessage = new Message();



            ObjMessage.Subject = Subject;


            ObjMessage.MessageText = MessageText;


            ObjMessage.ToLoginUserID = ToLoginUserID;


            ObjMessage.FromLoginUserID = FromLoginUserID;


            ObjMessage.ReplyID = ReplyID;


            ObjMessage.ReadTime = ReadTime;


            ObjMessage.IsReaded = IsReaded;


            ObjMessage.DeleteFromTo = DeleteFromTo;


            ObjMessage.DeleteFromFrom = DeleteFromFrom;


            ObjMessage.ModifiedDate = ModifiedDate;

            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Messages.InsertOnSubmit(ObjMessage);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjMessage.MessageID;
        }



        public List<Message> MessageGet(int PageSize, int PageNumber)
        {
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Messages select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.Messages select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<Message> MessageGetbyMessageID(Guid MessageID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.MessageID == MessageID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbySubject(string Subject, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.Subject == Subject select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyMessageText(string MessageText, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.MessageText == MessageText select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyToLoginUserID(int ToLoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ToLoginUserID == ToLoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyFromLoginUserID(int FromLoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.FromLoginUserID == FromLoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyReplyID(int ReplyID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ReplyID == ReplyID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyReadTime(DateTime ReadTime, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ReadTime == ReadTime select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyIsReaded(bool IsReaded, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.IsReaded == IsReaded select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyDeleteFromTo(bool DeleteFromTo, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.DeleteFromTo == DeleteFromTo select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyDeleteFromFrom(bool DeleteFromFrom, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.DeleteFromFrom == DeleteFromFrom select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<Message> MessageGetbyMessageID(Guid MessageID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.MessageID == MessageID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbySubject(string Subject)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.Subject == Subject select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyMessageText(string MessageText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.MessageText == MessageText select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyToLoginUserID(int ToLoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ToLoginUserID == ToLoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyFromLoginUserID(int FromLoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.FromLoginUserID == FromLoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyReplyID(int ReplyID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ReplyID == ReplyID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyReadTime(DateTime ReadTime)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ReadTime == ReadTime select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyIsReaded(bool IsReaded)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.IsReaded == IsReaded select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyDeleteFromTo(bool DeleteFromTo)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.DeleteFromTo == DeleteFromTo select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyDeleteFromFrom(bool DeleteFromFrom)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.DeleteFromFrom == DeleteFromFrom select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<Message> MessageGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void MessageDeletebyMessageID(Guid MessageID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.MessageID == MessageID select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebySubject(string Subject)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.Subject == Subject select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebyMessageText(string MessageText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.MessageText == MessageText select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebyToLoginUserID(int ToLoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ToLoginUserID == ToLoginUserID select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebyFromLoginUserID(int FromLoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.FromLoginUserID == FromLoginUserID select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebyReplyID(int ReplyID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ReplyID == ReplyID select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebyReadTime(DateTime ReadTime)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ReadTime == ReadTime select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebyIsReaded(bool IsReaded)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.IsReaded == IsReaded select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebyDeleteFromTo(bool DeleteFromTo)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.DeleteFromTo == DeleteFromTo select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebyDeleteFromFrom(bool DeleteFromFrom)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.DeleteFromFrom == DeleteFromFrom select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void MessageDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.Messages where p.ModifiedDate == ModifiedDate select p);
            db.Messages.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void MessageUpdateByMessageID(Guid MessageID, string Subject, string MessageText, int ToLoginUserID, int FromLoginUserID, int ReplyID, DateTime ReadTime, bool IsReaded, bool DeleteFromTo, bool DeleteFromFrom, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            MessageDataContext db = new MessageDataContext();
            db.DeferredLoadingEnabled = false;
            Message data = db.Messages.Single(p => p.MessageID == MessageID);
            data.Subject = Subject;
            data.MessageText = MessageText;
            data.ToLoginUserID = ToLoginUserID;
            data.FromLoginUserID = FromLoginUserID;
            data.ReplyID = ReplyID;
            data.ReadTime = ReadTime;
            data.IsReaded = IsReaded;
            data.DeleteFromTo = DeleteFromTo;
            data.DeleteFromFrom = DeleteFromFrom;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion


        #region CustomMessage
        public List<GetSentMessageResult> GetSentMessage(int LoginUserID)
        {

            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetSentMessage(LoginUserID).ToList();

        }
        public List<GetSentMessageResult> GetSentMessage(int LoginUserID, int PageSize, int PageNumber)
        {

            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetSentMessage(LoginUserID).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }
        public List<GetInboxMessageResult> GetInboxMessage(int LoginUserID)
        {

            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetInboxMessage(LoginUserID).ToList();

        }
        public List<GetInboxMessageResult> GetInboxMessage(int LoginUserID, int PageSize, int PageNumber)
        {

            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetInboxMessage(LoginUserID).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }
        public void MessageAdd(Guid MessageID, string Subject, string MessageText, int ToLoginUserID, int FromLoginUserID, DateTime ModifiedDate)
        {
            Message ObjMessage = new Message();

            ObjMessage.MessageID = MessageID;

            ObjMessage.Subject = Subject;

            ObjMessage.MessageText = MessageText;

            ObjMessage.ToLoginUserID = ToLoginUserID;

            ObjMessage.FromLoginUserID = FromLoginUserID;

            ObjMessage.IsReaded = false;

            ObjMessage.ModifiedDate = ModifiedDate;

            MessageDataContext db = new MessageDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.Messages.InsertOnSubmit(ObjMessage);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public List<GetFullMessageResult> GetFullMessage(Guid MessageID)
        {

            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetFullMessage(MessageID).ToList();

        }
        public List<GetFullMessageResult> GetFullMessage(Guid MessageID, int PageSize, int PageNumber)
        {

            MessageDataContext db = new MessageDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            return db.GetFullMessage(MessageID).Skip(PageNumber * PageSize).Take(PageSize).ToList();

        }
        #endregion




        #region InstituteUser

        public void InstituteUserAdd(int InstituteUserID, int InstituteID, int LoginUserID, string Description, DateTime ModifiedDate)
        {
            InstituteUser ObjInstituteUser = new InstituteUser();

            ObjInstituteUser.InstituteUserID = InstituteUserID;

            ObjInstituteUser.InstituteID = InstituteID;

            ObjInstituteUser.LoginUserID = LoginUserID;

            ObjInstituteUser.Description = Description;

            ObjInstituteUser.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.InstituteUsers.InsertOnSubmit(ObjInstituteUser);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int InstituteUserAdd(int InstituteID, int LoginUserID, string Description, DateTime ModifiedDate)
        {
            InstituteUser ObjInstituteUser = new InstituteUser();



            ObjInstituteUser.InstituteID = InstituteID;


            ObjInstituteUser.LoginUserID = LoginUserID;


            ObjInstituteUser.Description = Description;


            ObjInstituteUser.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.InstituteUsers.InsertOnSubmit(ObjInstituteUser);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjInstituteUser.InstituteUserID;
        }



        public List<InstituteUser> InstituteUserGet(int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.InstituteUsers select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUser> InstituteUserGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.InstituteUsers select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<InstituteUser> InstituteUserGetbyInstituteUserID(int InstituteUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.InstituteUserID == InstituteUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        

        public List<InstituteUser> InstituteUserGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUser> InstituteUserGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUser> InstituteUserGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<InstituteUser> InstituteUserGetbyInstituteUserID(int InstituteUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.InstituteUserID == InstituteUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUser> InstituteUserGetbyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.InstituteID == InstituteID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUser> InstituteUserGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUser> InstituteUserGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUser> InstituteUserGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void InstituteUserDeletebyInstituteUserID(int InstituteUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.InstituteUserID == InstituteUserID select p);
            db.InstituteUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteUserDeletebyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.InstituteID == InstituteID select p);
            db.InstituteUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteUserDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.LoginUserID == LoginUserID select p);
            db.InstituteUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteUserDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.Description == Description select p);
            db.InstituteUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteUserDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUsers where p.ModifiedDate == ModifiedDate select p);
            db.InstituteUsers.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void InstituteUserUpdateByInstituteUserID(int InstituteUserID, int InstituteID, int LoginUserID, string Description, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            InstituteUser data = db.InstituteUsers.Single(p => p.InstituteUserID == InstituteUserID);
            data.InstituteID = InstituteID;
            data.LoginUserID = LoginUserID;
            data.Description = Description;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
       
	
	
        #region CustomInstituteUser
        public List<InstituteUser> InstituteUserGetbyInstituteID(int InstituteID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<InstituteUser>(p => p.InstituteLoginUser);
           
            db.LoadOptions = option;
            var data = (from p in db.InstituteUsers where p.InstituteID == InstituteID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        public List<InstituteUser> InstituteUserSearch(string Keyword, int InstituteUserTypeID, int InstituteID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<InstituteUser>(p => p.InstituteLoginUser);
            
            db.LoadOptions = option;
            List<InstituteUser> data = new List<InstituteUser>();
            if (InstituteUserTypeID != -1)
            {
                data = (from p in db.InstituteUsers where  p.InstituteID == InstituteID && p.InstituteLoginUser.Username.ToLower().Contains(Keyword.Trim().ToLower()) select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            }
            else
            {
                data = (from p in db.InstituteUsers where p.InstituteID == InstituteID && p.InstituteLoginUser.Username.ToLower().Contains(Keyword.Trim().ToLower()) select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        public List<InstituteUser> InstituteUserSearch(string Keyword, int InstituteUserTypeID, int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            DataLoadOptions option = new DataLoadOptions();
            option.LoadWith<InstituteUser>(p => p.InstituteLoginUser);
            
            db.LoadOptions = option;
            List<InstituteUser> data = new List<InstituteUser>();
            if (InstituteUserTypeID != -1)
            {
                 data = (from p in db.InstituteUsers where  p.InstituteID == InstituteID && p.InstituteLoginUser.Username.ToLower().Contains(Keyword.Trim().ToLower()) select p).ToList();
            }
            else
            {
                 data = (from p in db.InstituteUsers where p.InstituteID == InstituteID && p.InstituteLoginUser.Username.ToLower().Contains(Keyword.Trim().ToLower()) select p).ToList();
            }
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }
        #endregion

        #region InstituteUserType

        public void InstituteUserTypeAdd(int InstituteUserTypeID, int LoginUserID, int InstituteID, string Name, string Description, DateTime ModifiedDate)
        {
            InstituteUserType ObjInstituteUserType = new InstituteUserType();

            ObjInstituteUserType.InstituteUserTypeID = InstituteUserTypeID;

            ObjInstituteUserType.LoginUserID = LoginUserID;

            ObjInstituteUserType.InstituteID = InstituteID;

            ObjInstituteUserType.Name = Name;

            ObjInstituteUserType.Description = Description;

            ObjInstituteUserType.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.InstituteUserTypes.InsertOnSubmit(ObjInstituteUserType);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int InstituteUserTypeAdd(int LoginUserID, int InstituteID, string Name, string Description, DateTime ModifiedDate)
        {
            InstituteUserType ObjInstituteUserType = new InstituteUserType();



            ObjInstituteUserType.LoginUserID = LoginUserID;


            ObjInstituteUserType.InstituteID = InstituteID;


            ObjInstituteUserType.Name = Name;


            ObjInstituteUserType.Description = Description;


            ObjInstituteUserType.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.InstituteUserTypes.InsertOnSubmit(ObjInstituteUserType);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjInstituteUserType.InstituteUserTypeID;
        }



        public List<InstituteUserType> InstituteUserTypeGet(int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.InstituteUserTypes select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.InstituteUserTypes select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<InstituteUserType> InstituteUserTypeGetbyInstituteUserTypeID(int InstituteUserTypeID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.InstituteUserTypeID == InstituteUserTypeID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyInstituteID(int InstituteID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.InstituteID == InstituteID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyName(string Name, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.Name == Name select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<InstituteUserType> InstituteUserTypeGetbyInstituteUserTypeID(int InstituteUserTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.InstituteUserTypeID == InstituteUserTypeID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.InstituteID == InstituteID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.Name == Name select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteUserType> InstituteUserTypeGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void InstituteUserTypeDeletebyInstituteUserTypeID(int InstituteUserTypeID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.InstituteUserTypeID == InstituteUserTypeID select p);
            db.InstituteUserTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteUserTypeDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.LoginUserID == LoginUserID select p);
            db.InstituteUserTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteUserTypeDeletebyInstituteID(int InstituteID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.InstituteID == InstituteID select p);
            db.InstituteUserTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteUserTypeDeletebyName(string Name)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.Name == Name select p);
            db.InstituteUserTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteUserTypeDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.Description == Description select p);
            db.InstituteUserTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteUserTypeDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteUserTypes where p.ModifiedDate == ModifiedDate select p);
            db.InstituteUserTypes.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void InstituteUserTypeUpdateByInstituteUserTypeID(int InstituteUserTypeID, int LoginUserID, int InstituteID, string Name, string Description, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            InstituteUserType data = db.InstituteUserTypes.Single(p => p.InstituteUserTypeID == InstituteUserTypeID);
            data.LoginUserID = LoginUserID;
            data.InstituteID = InstituteID;
            data.Name = Name;
            data.Description = Description;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomInstituteUserType
        #endregion


        #region InstituteSubject

        public void InstituteSubjectAdd(int InstituteSubjectID, int LoginUserID, string SubjectText, string Description, int InstituteCourceID, DateTime ModifiedDate)
        {
            InstituteSubject ObjInstituteSubject = new InstituteSubject();

            ObjInstituteSubject.InstituteSubjectID = InstituteSubjectID;

            ObjInstituteSubject.LoginUserID = LoginUserID;

            ObjInstituteSubject.SubjectText = SubjectText;

            ObjInstituteSubject.Description = Description;

            ObjInstituteSubject.InstituteCourceID = InstituteCourceID;

            ObjInstituteSubject.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.InstituteSubjects.InsertOnSubmit(ObjInstituteSubject);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public int InstituteSubjectAdd(int LoginUserID, string SubjectText, string Description, int InstituteCourceID, DateTime ModifiedDate)
        {
            InstituteSubject ObjInstituteSubject = new InstituteSubject();



            ObjInstituteSubject.LoginUserID = LoginUserID;


            ObjInstituteSubject.SubjectText = SubjectText;


            ObjInstituteSubject.Description = Description;


            ObjInstituteSubject.InstituteCourceID = InstituteCourceID;


            ObjInstituteSubject.ModifiedDate = ModifiedDate;

            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.InstituteSubjects.InsertOnSubmit(ObjInstituteSubject);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return ObjInstituteSubject.InstituteSubjectID;
        }



        public List<InstituteSubject> InstituteSubjectGet(int PageSize, int PageNumber)
        {
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.InstituteSubjects select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGet()
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            db.ObjectTrackingEnabled = false;
            var data = (from p in db.InstituteSubjects select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }


        public List<InstituteSubject> InstituteSubjectGetbyInstituteSubjectID(int InstituteSubjectID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.InstituteSubjectID == InstituteSubjectID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.LoginUserID == LoginUserID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbySubjectText(string SubjectText, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.SubjectText == SubjectText select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbyDescription(string Description, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.Description == Description select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbyInstituteCourceID(int InstituteCourceID, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.InstituteCourceID == InstituteCourceID select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.ModifiedDate == ModifiedDate select p).Skip(PageNumber * PageSize).Take(PageSize).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public List<InstituteSubject> InstituteSubjectGetbyInstituteSubjectID(int InstituteSubjectID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.InstituteSubjectID == InstituteSubjectID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.LoginUserID == LoginUserID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbySubjectText(string SubjectText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.SubjectText == SubjectText select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.Description == Description select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbyInstituteCourceID(int InstituteCourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.InstituteCourceID == InstituteCourceID select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }

        public List<InstituteSubject> InstituteSubjectGetbyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.ObjectTrackingEnabled = false;
            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.ModifiedDate == ModifiedDate select p).ToList();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
            return data;

        }



        public void InstituteSubjectDeletebyInstituteSubjectID(int InstituteSubjectID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.InstituteSubjectID == InstituteSubjectID select p);
            db.InstituteSubjects.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteSubjectDeletebyLoginUserID(int LoginUserID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.LoginUserID == LoginUserID select p);
            db.InstituteSubjects.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteSubjectDeletebySubjectText(string SubjectText)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.SubjectText == SubjectText select p);
            db.InstituteSubjects.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteSubjectDeletebyDescription(string Description)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.Description == Description select p);
            db.InstituteSubjects.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteSubjectDeletebyInstituteCourceID(int InstituteCourceID)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.InstituteCourceID == InstituteCourceID select p);
            db.InstituteSubjects.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }

        public void InstituteSubjectDeletebyModifiedDate(DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();

            db.DeferredLoadingEnabled = false;
            var data = (from p in db.InstituteSubjects where p.ModifiedDate == ModifiedDate select p);
            db.InstituteSubjects.DeleteAllOnSubmit(data);
            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }



        public void InstituteSubjectUpdateByInstituteSubjectID(int InstituteSubjectID, int LoginUserID, string SubjectText, string Description, int InstituteCourceID, DateTime ModifiedDate)
        {
            if (SettingProvider.IsLoggerEnable()) { StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber()); objLogger = new Logger.TimeLog(FunctionData); }
            InstituteDataContext db = new InstituteDataContext();
            db.DeferredLoadingEnabled = false;
            InstituteSubject data = db.InstituteSubjects.Single(p => p.InstituteSubjectID == InstituteSubjectID);
            data.LoginUserID = LoginUserID;
            data.SubjectText = SubjectText;
            data.Description = Description;
            data.InstituteCourceID = InstituteCourceID;
            data.ModifiedDate = ModifiedDate;

            db.SubmitChanges();
            if (SettingProvider.IsLoggerEnable()) { objLogger.StopTime(); }
        }





        #endregion
        #region CustomInstituteSubject
        #endregion
	
	






    }
}
