using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;
using DataAccess;
using System.Diagnostics;
using System.Web.UI.WebControls;
using System.Collections;

namespace BusinessLogic
{
    public class InstituteCourceController
    {


        #region InstituteCource
        public bool UpdateByInstituteCourceID(int InstituteCourceID, int CourceCategoryID, string CourceName, string MetaDescription, string MetaKeyword, DateTime Modifieddate)
        {

            try
            {
                new DataProvider().InstituteCourceUpdateByInstituteCourceID(InstituteCourceID, CourceCategoryID, CourceName, MetaDescription, MetaKeyword, Modifieddate);
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
        public string GetInstituteCourceName(int InstituteCourceID)
        {
            try
            {

                return new DataProvider().GetInstituteCourceName(InstituteCourceID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return "";
            }
        }
        public void BindInstituteCourceByLoginUserID(DropDownList dd, int InstituteID, int LoginUserID)
        {
            var data = GetByCourceLoginUserID(InstituteID, LoginUserID);

            dd.DataSource = data;
            dd.DataTextField = "CourceName";
            dd.DataValueField = "InstituteCourceID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
        }
        public void BindInstituteCource1(DropDownList dd, int InstituteID)
        {
            var data = GetCourceByInstituteID(InstituteID);

            dd.DataSource = data;
            dd.DataTextField = "CourceName";
            dd.DataValueField = "InstituteCourceID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
        }
        public void BindInstituteCource(DropDownList dd, int InstituteID, string SelectedValue)
        {
            var data = GetCourceByInstituteID(InstituteID);
            dd.DataSource = data;
            dd.DataTextField = "CourceName";
            dd.DataValueField = "InstituteCourceID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
            dd.SelectedValue = SelectedValue;
        }
        public List<GetCourceByInstituteIDResult> GetCourceByInstituteID(int InstituteID)
        {
            try
            {

                return new DataProvider().GetCourceByInstituteID(InstituteID);
            }
            catch
            {
                return new List<GetCourceByInstituteIDResult>();
            }
        }
        public List<GetCourceByInstituteIDResult> GetCourceByInstituteID(int InstituteID, int PageSize, int PageNumber)
        {
            try
            {

                return new DataProvider().GetCourceByInstituteID(InstituteID, PageSize, PageNumber);
            }
            catch
            {
                return new List<GetCourceByInstituteIDResult>();
            }
        }

        public List<InstituteCource> GetByCourceUserID(int InstituteID, int LoginUserID)
        {
            try
            {
                return new DataProvider().InstituteCourceGetByCourceUserID(InstituteID, LoginUserID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }
        public IEnumerable GetByCourceLoginUserID(int InstituteID, int LoginUserID)
        {
            try
            {
                return new DataProvider().InstituteCourceGetByLoginUserID(InstituteID, LoginUserID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" CreateControls: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public int Add(int InstituteID, int CourceCatagoryID, string CourceName, string MetaDescription, string MetaKeyword,  DateTime Modifieddate)
        {

            try
            {
                int ID = new DataProvider().InstituteCourceAdd(InstituteID, CourceCatagoryID, CourceName, MetaDescription, MetaKeyword,Modifieddate);
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
        #endregion
        #region AutoGenerated

        public List<InstituteCource> GetbyInstituteCourceID(int InstituteCourceID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyInstituteCourceID(InstituteCourceID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyInstituteID(int InstituteID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyInstituteID(InstituteID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyCourceID(int CourceID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyCourceID(CourceID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyMetaDescription(string MetaDescription, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyMetaDescription(MetaDescription, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyMetaKeyword(string MetaKeyword, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyMetaKeyword(MetaKeyword, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyModifieddate(DateTime Modifieddate, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyModifieddate(Modifieddate, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }



        public List<InstituteCource> GetbyInstituteCourceID(int InstituteCourceID)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyInstituteCourceID(InstituteCourceID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyInstituteID(int InstituteID)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyInstituteID(InstituteID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyCourceID(int CourceID)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyCourceID(CourceID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyMetaDescription(string MetaDescription)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyMetaDescription(MetaDescription);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyMetaKeyword(string MetaKeyword)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyMetaKeyword(MetaKeyword);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> GetbyModifieddate(DateTime Modifieddate)
        {
            try
            {
                return new DataProvider().InstituteCourceGetbyModifieddate(Modifieddate);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }

        public List<InstituteCource> Get(int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().InstituteCourceGet(PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }
        public List<InstituteCource> Get()
        {
            try
            {
                return new DataProvider().InstituteCourceGet();
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" Method: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<InstituteCource>();
            }
        }



        public bool Add(int InstituteCourceID, int InstituteID, int CourceID, string MetaDescription, string MetaKeyword, DateTime Modifieddate)
        {

            try
            {
                new DataProvider().InstituteCourceAdd(InstituteCourceID, InstituteID, CourceID, MetaDescription, MetaKeyword, Modifieddate);
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

        public int Add(int InstituteID, int CourceID, string MetaDescription, string MetaKeyword, DateTime Modifieddate)
        {

            try
            {
                int ID = new DataProvider().InstituteCourceAdd(InstituteID, CourceID, MetaDescription, MetaKeyword, Modifieddate);
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



        public bool DeletebyInstituteCourceID(int InstituteCourceID)
        {
            try
            {
                new DataProvider().InstituteCourceDeletebyInstituteCourceID(InstituteCourceID);
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


        public bool DeletebyInstituteID(int InstituteID)
        {
            try
            {
                new DataProvider().InstituteCourceDeletebyInstituteID(InstituteID);
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


        public bool DeletebyCourceID(int CourceID)
        {
            try
            {
                new DataProvider().InstituteCourceDeletebyCourceID(CourceID);
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


        public bool DeletebyMetaDescription(string MetaDescription)
        {
            try
            {
                new DataProvider().InstituteCourceDeletebyMetaDescription(MetaDescription);
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


        public bool DeletebyMetaKeyword(string MetaKeyword)
        {
            try
            {
                new DataProvider().InstituteCourceDeletebyMetaKeyword(MetaKeyword);
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


        public bool DeletebyModifieddate(DateTime Modifieddate)
        {
            try
            {
                new DataProvider().InstituteCourceDeletebyModifieddate(Modifieddate);
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




        public bool UpdateByInstituteCourceID(int InstituteCourceID, int InstituteID, int CourceID, string MetaDescription, string MetaKeyword, DateTime Modifieddate)
        {

            try
            {
                new DataProvider().InstituteCourceUpdateByInstituteCourceID(InstituteCourceID, InstituteID, CourceID, MetaDescription, MetaKeyword, Modifieddate);
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







        public void BindInstituteCource(DropDownList dd)
        {
            var data = Get();
            dd.DataSource = data;
            dd.DataTextField = "CatagoryName";
            dd.DataValueField = "InstituteCourceID";
            dd.DataBind();
            ListItem noneItem = new ListItem();
            noneItem.Text = "select";
            noneItem.Value = "0";
            dd.Items.Insert(0, noneItem);
        }
        public void BindInstituteCource(DropDownList dd, string SelectedValue)
        {
            var data = Get();
            dd.DataSource = data;
            dd.DataTextField = "CatagoryName";
            dd.DataValueField = "InstituteCourceID";
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
