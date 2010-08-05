﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;
using DataAccess;
using System.Diagnostics;
using System.Web.UI.WebControls;
using System.Web;
using System.Configuration;
using System.IO;

namespace BusinessLogic
{
    public class TutorialController
    {


        #region AutoGenerated

        public List<Tutorial> GetbyTutorialID(int TutorialID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().TutorialGetbyTutorialID(TutorialID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyLoginUserID(int LoginUserID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().TutorialGetbyLoginUserID(LoginUserID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyTutorialTypeID(int TutorialTypeID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().TutorialGetbyTutorialTypeID(TutorialTypeID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyName(string Name, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().TutorialGetbyName(Name, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyDescription(string Description, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().TutorialGetbyDescription(Description, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyFilePath(string FilePath, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().TutorialGetbyFilePath(FilePath, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().TutorialGetbyModifiedDate(ModifiedDate, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }



        public List<Tutorial> GetbyTutorialID(int TutorialID)
        {
            try
            {
                return new DataProvider().TutorialGetbyTutorialID(TutorialID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyLoginUserID(int LoginUserID)
        {
            try
            {
                return new DataProvider().TutorialGetbyLoginUserID(LoginUserID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyTutorialTypeID(int TutorialTypeID)
        {
            try
            {
                return new DataProvider().TutorialGetbyTutorialTypeID(TutorialTypeID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyName(string Name)
        {
            try
            {
                return new DataProvider().TutorialGetbyName(Name);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyDescription(string Description)
        {
            try
            {
                return new DataProvider().TutorialGetbyDescription(Description);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyFilePath(string FilePath)
        {
            try
            {
                return new DataProvider().TutorialGetbyFilePath(FilePath);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> GetbyModifiedDate(DateTime ModifiedDate)
        {
            try
            {
                return new DataProvider().TutorialGetbyModifiedDate(ModifiedDate);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }

        public List<Tutorial> Get(int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().TutorialGet(PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }
        public List<Tutorial> Get()
        {
            try
            {
                return new DataProvider().TutorialGet();
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Tutorial>();
            }
        }



        public bool Add(int TutorialID, int LoginUserID, int TutorialTypeID, string Name, string Description, string FilePath, DateTime ModifiedDate)
        {

            try
            {
                new DataProvider().TutorialAdd(TutorialID, LoginUserID, TutorialTypeID, Name, Description, FilePath, ModifiedDate);
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

        public int Add(int LoginUserID, int TutorialTypeID, string Name, string Description, string FilePath, DateTime ModifiedDate)
        {

            try
            {
                int ID = new DataProvider().TutorialAdd(LoginUserID, TutorialTypeID, Name, Description, FilePath, ModifiedDate);
                return ID;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return 0;
            }
        }



        public bool DeletebyTutorialID(int TutorialID)
        {
            try
            {
                new DataProvider().TutorialDeletebyTutorialID(TutorialID);
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


        public bool DeletebyLoginUserID(int LoginUserID)
        {
            try
            {
                new DataProvider().TutorialDeletebyLoginUserID(LoginUserID);
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


        public bool DeletebyTutorialTypeID(int TutorialTypeID)
        {
            try
            {
                new DataProvider().TutorialDeletebyTutorialTypeID(TutorialTypeID);
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


        public bool DeletebyName(string Name)
        {
            try
            {
                new DataProvider().TutorialDeletebyName(Name);
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


        public bool DeletebyDescription(string Description)
        {
            try
            {
                new DataProvider().TutorialDeletebyDescription(Description);
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


        public bool DeletebyFilePath(string FilePath)
        {
            try
            {
                new DataProvider().TutorialDeletebyFilePath(FilePath);
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
                new DataProvider().TutorialDeletebyModifiedDate(ModifiedDate);
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




        public bool UpdateByTutorialID(int TutorialID, int LoginUserID, int TutorialTypeID, string Name, string Description, string FilePath, DateTime ModifiedDate)
        {

            try
            {
                new DataProvider().TutorialUpdateByTutorialID(TutorialID, LoginUserID, TutorialTypeID, Name, Description, FilePath, ModifiedDate);
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








        public void BindTutorial(DropDownList dd)
        {
            var data = Get();
            dd.DataSource = data;
            dd.DataTextField = "CatagoryName";
            dd.DataValueField = "TutorialID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
        }
        public void BindTutorial(DropDownList dd, string SelectedValue)
        {
            var data = Get();
            dd.DataSource = data;
            dd.DataTextField = "CatagoryName";
            dd.DataValueField = "TutorialID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
            dd.SelectedValue = SelectedValue;
        }
        #endregion
        #region Tutorial
        public List<GetTutorialResult> GetTutorial(string Keywork, int TutorialType)
        {
            try
            {

                return new DataProvider().GetTutorial(Keywork, TutorialType);
            }
            catch
            {
                return new List<GetTutorialResult>();
            }
        }
        public List<GetTutorialResult> GetTutorial(string Keywork, int TutorialType, int PageSize, int PageNumber)
        {
            try
            {

                return new DataProvider().GetTutorial(Keywork, TutorialType, PageSize, PageNumber);
            }
            catch
            {
                return new List<GetTutorialResult>();
            }
        }
        public string UploadTutorial(FileUpload fl)
        {
            string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["TutorialPath"]);
            FolderPath += new UserAuthontication().LoggedInUserName+"/";
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string FilePath = FolderPath + "/" + fl.FileName;
            fl.SaveAs(FilePath);
            return FilePath;
        }
        #endregion
				
	
	
				
	
	
    }

    public enum TutorialEnum
    {
        ExamPaper=1,
        Books=2
    }
}