﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;
using DataAccess;
using System.Diagnostics;
using Logger;
using System.Web.Security;
using Common;
namespace BusinessLogic
{
    public class LoginUserController
    {
        #region AutoGenerated
        public List<LoginUser> GetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().LoginUserGetbyLoginUserID(LoginUserID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyUsername(string Username, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().LoginUserGetbyUsername(Username, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyPassword(string Password, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().LoginUserGetbyPassword(Password, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyUserType(int UserType, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().LoginUserGetbyUserType(UserType, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyUserId(Guid UserId, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().LoginUserGetbyUserId(UserId, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().LoginUserGetbyModifiedDate(ModifiedDate, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyCreatedDate(DateTime CreatedDate, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().LoginUserGetbyCreatedDate(CreatedDate, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyLoginUserID(int LoginUserID)
        {
            try
            {
                return new DataProvider().LoginUserGetbyLoginUserID(LoginUserID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyUsername(string Username)
        {
            try
            {
                return new DataProvider().LoginUserGetbyUsername(Username);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyPassword(string Password)
        {
            try
            {
                return new DataProvider().LoginUserGetbyPassword(Password);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyUserType(int UserType)
        {
            try
            {
                return new DataProvider().LoginUserGetbyUserType(UserType);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyUserId(Guid UserId)
        {
            try
            {
                return new DataProvider().LoginUserGetbyUserId(UserId);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyModifiedDate(DateTime ModifiedDate)
        {
            try
            {
                return new DataProvider().LoginUserGetbyModifiedDate(ModifiedDate);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> GetbyCreatedDate(DateTime CreatedDate)
        {
            try
            {
                return new DataProvider().LoginUserGetbyCreatedDate(CreatedDate);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> Get(int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().LoginUserGet(PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public List<LoginUser> Get()
        {
            try
            {
                return new DataProvider().LoginUserGet();
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<LoginUser>();
            }
        }
        public int Add(string Username, string Password, int UserType, Guid UserId, DateTime ModifiedDate, DateTime CreatedDate)
        {

            try
            {
                int ID = new DataProvider().LoginUserAdd(Username, Password, UserType, UserId, ModifiedDate, CreatedDate);
                return ID;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return 0;
            }
        }
        public bool DeletebyLoginUserID(int LoginUserID)
        {
            try
            {
                new DataProvider().LoginUserDeletebyLoginUserID(LoginUserID);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public bool DeletebyUsername(string Username)
        {
            try
            {
                new DataProvider().LoginUserDeletebyUsername(Username);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public bool DeletebyPassword(string Password)
        {
            try
            {
                new DataProvider().LoginUserDeletebyPassword(Password);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public bool DeletebyUserType(int UserType)
        {
            try
            {
                new DataProvider().LoginUserDeletebyUserType(UserType);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public bool DeletebyUserId(Guid UserId)
        {
            try
            {
                new DataProvider().LoginUserDeletebyUserId(UserId);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public bool DeletebyModifiedDate(DateTime ModifiedDate)
        {
            try
            {
                new DataProvider().LoginUserDeletebyModifiedDate(ModifiedDate);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public bool DeletebyCreatedDate(DateTime CreatedDate)
        {
            try
            {
                new DataProvider().LoginUserDeletebyCreatedDate(CreatedDate);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public bool UpdateByLoginUserID(int LoginUserID, string Username, string Password, int UserType, Guid UserId, DateTime ModifiedDate, DateTime CreatedDate)
        {

            try
            {
                new DataProvider().LoginUserUpdateByLoginUserID(LoginUserID, Username, Password, UserType, UserId, ModifiedDate, CreatedDate);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        #endregion
        #region LoginUser
        public bool CreateUser(string Username, string Password, string Email)
        {
            try
            {

                MembershipCreateStatus status;
                MembershipUser MemUser = Membership.CreateUser(Username, Password, Email, "No Question", "No Answer", true, out status);
                if (status == MembershipCreateStatus.Success)
                {
                    try
                    {
                        int LoginUserID = Add(Username, Password, (Int16)UserTypeEnum.Student, new Guid(MemUser.ProviderUserKey.ToString()), DateTime.Now, DateTime.Now);
                        if (LoginUserID == 0)
                        {
                            Membership.DeleteUser(MemUser.UserName);
                        }
                    }
                    catch
                    {
                        Membership.DeleteUser(MemUser.UserName);
                    }

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Dictionary<string,string> CreateUser(string Username, string Password, string Email, int UType)
        {
            Dictionary<string, string> StatusReturn = new Dictionary<string, string>();
            try
            {
                
                MembershipCreateStatus status;
                MembershipUser MemUser = Membership.CreateUser(Username, Password, Email, "No Question", "No Answer", true, out status);
                if (status == MembershipCreateStatus.Success)
                {
                    try
                    {
                        int LoginUserID = Add(Username, Password, UType, new Guid(MemUser.ProviderUserKey.ToString()), DateTime.Now, DateTime.Now);
                        if (LoginUserID == 0)
                        {
                            Membership.DeleteUser(MemUser.UserName);
                        }
                        StatusReturn.Add("loginuserid", LoginUserID.ToString());
                        StatusReturn.Add("status","success");
                    }
                    catch
                    {
                        Membership.DeleteUser(MemUser.UserName);
                        StatusReturn.Add("status", "error");
                    }

                }
                return StatusReturn;
            }
            catch
            {
                return StatusReturn;
            }
        }
        public Dictionary<string, string> CreateUser(string Username, string Password, string Email, int UType,int InstituteID,int InstituteCourceID)
        {
            Dictionary<string, string> StatusReturn = new Dictionary<string, string>();
            try
            {

                MembershipCreateStatus status;
                MembershipUser MemUser = Membership.CreateUser(Username, Password, Email, "No Question", "No Answer", true, out status);
                if (status == MembershipCreateStatus.Success)
                {
                    try
                    {
                        int LoginUserID = Add(Username, Password, UType, new Guid(MemUser.ProviderUserKey.ToString()), DateTime.Now, DateTime.Now);
                        new InstituteUserController().Add(InstituteID, LoginUserID, "", DateTime.Now);
                        new InstituteCourceUserController().Add(InstituteCourceID, LoginUserID, LoginUserID, (int)InstituteCourceUserEnum.Normal, DateTime.Now);
                        if (LoginUserID == 0)
                        {
                            Membership.DeleteUser(MemUser.UserName);
                        }
                        StatusReturn.Add("loginuserid", LoginUserID.ToString());
                        StatusReturn.Add("status", "success");
                    }
                    catch
                    {
                        Membership.DeleteUser(MemUser.UserName);
                        StatusReturn.Add("status", "error");
                    }

                }
                else if (status == MembershipCreateStatus.DuplicateUserName)
                {
                    StatusReturn.Add("status", "Please enter different Username");
                }
                else if (status == MembershipCreateStatus.DuplicateEmail)
                {
                    StatusReturn.Add("status", "Please select differnt Email");
                }
                return StatusReturn;
            }
            catch
            {
                return StatusReturn;
            }
        }
        public bool CreateUser(string Username, string Password, string Email, int UType, int InstituteUserType)
        {
            try
            {

                MembershipCreateStatus status;
                int LoginUserID=0;
                MembershipUser MemUser = Membership.CreateUser(Username, Password, Email, "No Question", "No Answer", true, out status);
                if (status == MembershipCreateStatus.Success)
                {
                    try
                    {
                         LoginUserID = Add(Username, Password, UType, new Guid(MemUser.ProviderUserKey.ToString()), DateTime.Now, DateTime.Now);
                        int id=new InstituteUserController().Add( new UserAuthontication().InstituteID,LoginUserID, "", DateTime.Now);
                        if (LoginUserID == 0)
                        {
                            Membership.DeleteUser(MemUser.UserName);
                            new InstituteUserController().DeletebyInstituteUserID(id);
                        }
                    }
                    catch
                    {
                        DeletebyLoginUserID(LoginUserID);
                        Membership.DeleteUser(MemUser.UserName);
                    }

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion





    }
    public enum UserTypeEnum
    {
        Student = 1,
        College = 2,
        Annoumus = 0
    }

}
