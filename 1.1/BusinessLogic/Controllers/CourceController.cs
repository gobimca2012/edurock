﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;
using DataAccess;
using System.Diagnostics;
using System.Web.UI.WebControls;

namespace BusinessLogic
{
    public class CourceController
    {

        #region AutoGenerated

        public List<Cource> GetbyCourceID(int CourceID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().CourceGetbyCourceID(CourceID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyCourceCatagoryID(int CourceCatagoryID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().CourceGetbyCourceCatagoryID(CourceCatagoryID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyCourceName(string CourceName, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().CourceGetbyCourceName(CourceName, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyDescription(string Description, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().CourceGetbyDescription(Description, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyCourceType(int CourceType, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().CourceGetbyCourceType(CourceType, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyModifieddate(DateTime Modifieddate, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().CourceGetbyModifieddate(Modifieddate, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }



        public List<Cource> GetbyCourceID(int CourceID)
        {
            try
            {
                return new DataProvider().CourceGetbyCourceID(CourceID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyCourceCatagoryID(int CourceCatagoryID)
        {
            try
            {
                return new DataProvider().CourceGetbyCourceCatagoryID(CourceCatagoryID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyCourceName(string CourceName)
        {
            try
            {
                return new DataProvider().CourceGetbyCourceName(CourceName);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyDescription(string Description)
        {
            try
            {
                return new DataProvider().CourceGetbyDescription(Description);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyCourceType(int CourceType)
        {
            try
            {
                return new DataProvider().CourceGetbyCourceType(CourceType);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> GetbyModifieddate(DateTime Modifieddate)
        {
            try
            {
                return new DataProvider().CourceGetbyModifieddate(Modifieddate);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }

        public List<Cource> Get(int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().CourceGet(PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }
        public List<Cource> Get()
        {
            try
            {
                return new DataProvider().CourceGet();
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<Cource>();
            }
        }



        public bool Add(int CourceID, int CourceCatagoryID, string CourceName, string Description, int CourceType, DateTime Modifieddate)
        {

            try
            {
                new DataProvider().CourceAdd(CourceID, CourceCatagoryID, CourceName, Description, CourceType, Modifieddate);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }

        public int Add(int CourceCatagoryID, string CourceName, string Description, int CourceType, DateTime Modifieddate)
        {

            try
            {
                int ID = new DataProvider().CourceAdd(CourceCatagoryID, CourceName, Description, CourceType, Modifieddate);
                new DataProvider().InstituteCourceAdd(new UserAuthontication().InstituteID, ID, CourceName, "", DateTime.Now, DateTime.Now.AddYears(3), true, true, true, true, true, true, 0, DateTime.Now);
                return ID;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return 0;
            }
        }



        public bool DeletebyCourceID(int CourceID)
        {
            try
            {
                new DataProvider().CourceDeletebyCourceID(CourceID);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }


        public bool DeletebyCourceCatagoryID(int CourceCatagoryID)
        {
            try
            {
                new DataProvider().CourceDeletebyCourceCatagoryID(CourceCatagoryID);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }


        public bool DeletebyCourceName(string CourceName)
        {
            try
            {
                new DataProvider().CourceDeletebyCourceName(CourceName);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }


        public bool DeletebyDescription(string Description)
        {
            try
            {
                new DataProvider().CourceDeletebyDescription(Description);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }


        public bool DeletebyCourceType(int CourceType)
        {
            try
            {
                new DataProvider().CourceDeletebyCourceType(CourceType);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }


        public bool DeletebyModifieddate(DateTime Modifieddate)
        {
            try
            {
                new DataProvider().CourceDeletebyModifieddate(Modifieddate);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }




        public bool UpdateByCourceID(int CourceID, int CourceCatagoryID, string CourceName, string Description, int CourceType, DateTime Modifieddate)
        {

            try
            {
                new DataProvider().CourceUpdateByCourceID(CourceID, CourceCatagoryID, CourceName, Description, CourceType, Modifieddate);
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }







        #endregion
        #region Cource
        public void BindCource(DropDownList dd)
        {
            var data = Get();
            dd.DataSource = data;
            dd.DataTextField = "CourceName";
            dd.DataValueField = "CourceID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
        }
        public void BindCource(DropDownList dd, string SelectedValue)
        {
            var data = Get();
            dd.DataSource = data;
            dd.DataTextField = "CourceName";
            dd.DataValueField = "CourceID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
            dd.SelectedValue = SelectedValue;
        }
        #endregion
				
	
	
    }
}
