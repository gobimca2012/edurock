﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Diagnostics;
using DataEntity;
using DataAccess;

namespace BusinessLogic
{
    public class ShareContent
    {
        public bool IsViewable
        {
            get;
            set;
        }
        public bool IsEditablable
        {
            get;
            set;
        }
    }
    public class ShareController
    {

        #region AutoGenerated

        public List<Share> GetbyShareID(Guid ShareID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().ShareGetbyShareID(ShareID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }

        public List<Share> GetbyObjectType(int ObjectType, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().ShareGetbyObjectType(ObjectType, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }

        public List<Share> GetbyObjectID(string ObjectID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().ShareGetbyObjectID(ObjectID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }

        public List<Share> GetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().ShareGetbyModifiedDate(ModifiedDate, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }



        public List<Share> GetbyShareID(Guid ShareID)
        {
            try
            {
                return new DataProvider().ShareGetbyShareID(ShareID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }

        public List<Share> GetbyObjectType(int ObjectType)
        {
            try
            {
                return new DataProvider().ShareGetbyObjectType(ObjectType);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }

        public List<Share> GetbyObjectID(string ObjectID)
        {
            try
            {
                return new DataProvider().ShareGetbyObjectID(ObjectID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }

        public List<Share> GetbyModifiedDate(DateTime ModifiedDate)
        {
            try
            {
                return new DataProvider().ShareGetbyModifiedDate(ModifiedDate);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }

        public List<Share> Get(int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().ShareGet(PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }
        public List<Share> Get()
        {
            try
            {
                return new DataProvider().ShareGet();
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }



        public bool Add(Guid ShareID, int ObjectType, string ObjectID, DateTime ModifiedDate)
        {

            try
            {
                new DataProvider().ShareAdd(ShareID, ObjectType, ObjectID, ModifiedDate);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }

        public Guid Add(int ObjectType, string ObjectID, DateTime ModifiedDate)
        {

            try
            {
                Guid ID = new DataProvider().ShareAdd(ObjectType, ObjectID, ModifiedDate);
                return ID;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return Guid.Empty;
            }
        }



        public bool DeletebyShareID(Guid ShareID)
        {
            try
            {
                new DataProvider().ShareDeletebyShareID(ShareID);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }


        public bool DeletebyObjectType(int ObjectType)
        {
            try
            {
                new DataProvider().ShareDeletebyObjectType(ObjectType);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }


        public bool DeletebyObjectID(string ObjectID)
        {
            try
            {
                new DataProvider().ShareDeletebyObjectID(ObjectID);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }


        public bool DeletebyModifiedDate(DateTime ModifiedDate)
        {
            try
            {
                new DataProvider().ShareDeletebyModifiedDate(ModifiedDate);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }




        public bool UpdateByShareID(Guid ShareID, int ObjectType, string ObjectID, DateTime ModifiedDate)
        {

            try
            {
                new DataProvider().ShareUpdateByShareID(ShareID, ObjectType, ObjectID, ModifiedDate);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }





        public void BindShare(DropDownList dd)
        {
            var data = Get();
            dd.DataSource = data;
            dd.DataTextField = "CatagoryName";
            dd.DataValueField = "ShareID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
        }
        public void BindShare(DropDownList dd, string SelectedValue)
        {
            var data = Get();
            dd.DataSource = data;
            dd.DataTextField = "CatagoryName";
            dd.DataValueField = "ShareID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
            dd.SelectedValue = SelectedValue;
        }
        #endregion
        #region Share
        public List<GetUserObjectAccessResult> GetUserObjectAccess(int LoginUserID, string ObjectID, int ObjectType)
        {
            try
            {

                return new DataProvider().GetUserObjectAccess(LoginUserID, ObjectID, ObjectType);
            }
            catch
            {
                return new List<GetUserObjectAccessResult>();
            }
        }
        public List<GetUserObjectAccessResult> GetUserObjectAccess(int LoginUserID, string ObjectID, int ObjectType, int PageSize, int PageNumber)
        {
            try
            {

                return new DataProvider().GetUserObjectAccess(LoginUserID, ObjectID, ObjectType, PageSize, PageNumber);
            }
            catch
            {
                return new List<GetUserObjectAccessResult>();
            }
        }
        public List<GetGroupObjectAccessResult> GetGroupObjectAccess(int LoginUserID, string ObjectID, int ObjectType)
        {
            try
            {

                return new DataProvider().GetGroupObjectAccess(LoginUserID, ObjectID, ObjectType);
            }
            catch
            {
                return new List<GetGroupObjectAccessResult>();
            }
        }
        public List<GetGroupObjectAccessResult> GetGroupObjectAccess(int LoginUserID, string ObjectID, int ObjectType, int PageSize, int PageNumber)
        {
            try
            {

                return new DataProvider().GetGroupObjectAccess(LoginUserID, ObjectID, ObjectType, PageSize, PageNumber);
            }
            catch
            {
                return new List<GetGroupObjectAccessResult>();
            }
        }
        public ShareContent GetAccess(string ObjectID, int ObjectType, int LoginUserID, int ObjectLoginUserID)
        {
            ShareContent objShareContent = new ShareContent();
            if (LoginUserID != ObjectLoginUserID)
            {

                objShareContent.IsViewable = false;
                objShareContent.IsEditablable = false;
                var dataShareData = new ShareController().Get(ObjectID, ObjectType);
                var dataShareUser = GetUserObjectAccess(LoginUserID, ObjectID, ObjectType);
                var dataGroupUser = GetGroupObjectAccess(LoginUserID, ObjectID, ObjectType);
                if (dataShareData.Count > 0 && (bool)dataShareData[0].EnableAllUseView)
                {
                    //if ()
                    {
                        objShareContent.IsViewable = true;
                    }
                }
                else if (dataGroupUser.Count > 0 && (bool)dataGroupUser[0].EnableView)
                {
                    //if ()
                    {
                        objShareContent.IsViewable = true;
                    }
                }
                else if (dataShareUser.Count > 0 && (bool)dataShareUser[0].EnableView)
                {
                    //if ()
                    {
                        objShareContent.IsViewable = true;
                    }
                }

                if (dataShareData.Count > 0 && (bool)dataShareData[0].EnableAllUserEdit)
                {

                    {
                        objShareContent.IsEditablable = true;
                    }
                }
                else if (dataGroupUser.Count > 0 && (bool)dataGroupUser[0].EnableEdit)
                {
                    //if ()
                    {
                        objShareContent.IsEditablable = true;
                    }
                }
                else if (dataShareUser.Count > 0 && (bool)dataShareUser[0].EnableEdit)
                {
                    //if ()
                    {
                        objShareContent.IsEditablable = true;
                    }
                }
            }
            else
            {
                objShareContent.IsEditablable = true;
                objShareContent.IsViewable = true;
            }
            return objShareContent;
        }
        public bool UpdateShareCommentAllUser(int ObjectType, string ObjectID, bool EnableAllUseComment)
        {
            try
            {
                new DataProvider().UpdateShareCommentAllUser(ObjectType, ObjectID, EnableAllUseComment);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public bool UpdateShareEditAllUser(int ObjectType, string ObjectID, bool EnableAllUseEdit)
        {
            try
            {
                new DataProvider().UpdateShareEditAllUser(ObjectType, ObjectID, EnableAllUseEdit);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public bool UpdateShareViewAllUser(int ObjectType, string ObjectID, bool EnableAllUseView)
        {
            try
            {
                new DataProvider().UpdateShareViewAllUser(ObjectType, ObjectID, EnableAllUseView);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public List<Share> Get(string ObjectID, int Type)
        {
            try
            {
                return new DataProvider().ShareGet(ObjectID, Type);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Share>();
            }
        }
        #endregion



    }
}
